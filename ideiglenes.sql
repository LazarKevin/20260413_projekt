
DROP DATABASE IF EXISTS eventdb;
CREATE DATABASE eventdb;
USE eventdb;


CREATE TABLE User (
    Id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    EventId INT,
    ImgUrl VARCHAR(600)
);


CREATE TABLE Regist (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    Email VARCHAR(150) UNIQUE,
    Status ENUM('pending','approved','rejected') DEFAULT 'pending'
);


CREATE TABLE Login (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100),
    Password VARCHAR(255),
    Email VARCHAR(150)
);


CREATE TABLE Event (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100),
    Descr VARCHAR(255),
    Dates DATETIME,
    Datetol DATETIME,
    Dateig DATETIME,
    Categ VARCHAR(50),
    Important BOOLEAN,
    Wheres VARCHAR(100)
);


ALTER TABLE User
ADD CONSTRAINT fk_user_event
FOREIGN KEY (EventId) REFERENCES Event(Id);

INSERT INTO User (Id, Name, Password, EventId,ImgUrl)
VALUES (0, 'admin', 'admin123', NULL,adminKépe);

-- =========================
-- TRIGGER: CSAK ADMIN FOGADHAT EL
-- =========================
DELIMITER $$

CREATE TRIGGER before_regist_update
BEFORE UPDATE ON Regist
FOR EACH ROW
BEGIN
    -- ha approved-ra akarják állítani
    IF NEW.Status = 'approved' THEN
        
        -- ellenőrizzük: létezik-e admin (Id = 0)
        IF NOT EXISTS (SELECT 1 FROM User WHERE Id = 0) THEN
            SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'Nincs admin user!';
        END IF;

    END IF;
END$$

DELIMITER ;

-- =========================
-- ELJÁRÁS: REGISZTRÁCIÓ JÓVÁHAGYÁS
-- CSAK ADMIN (Id = 0) HASZNÁLHATJA
-- =========================
DELIMITER $$

CREATE PROCEDURE ApproveUser(
    IN p_regist_id INT,
    IN p_admin_id INT
)
BEGIN
    DECLARE v_name VARCHAR(100);
    DECLARE v_password VARCHAR(255);

    -- ellenőrizzük admin-e
    IF p_admin_id != 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Csak admin hagyhat jóvá!';
    END IF;

    -- lekérjük a regisztrációt
    SELECT Name, Password
    INTO v_name, v_password
    FROM Regist
    WHERE Id = p_regist_id AND Status = 'pending';

    -- ha nincs ilyen
    IF v_name IS NULL THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Nincs ilyen pending user!';
    END IF;

    -- új user beszúrás (ID auto generálás kézzel)
    INSERT INTO User (Id, Name, Password, EventId)
    SELECT IFNULL(MAX(Id),0)+1, v_name, v_password, NULL FROM User;

    -- státusz frissítés
    UPDATE Regist
    SET Status = 'approved'
    WHERE Id = p_regist_id;

END$$

DELIMITER ;

-- =========================
-- ELJÁRÁS: ELUTASÍTÁS
-- =========================
DELIMITER $$

CREATE PROCEDURE RejectUser(
    IN p_regist_id INT,
    IN p_admin_id INT
)
BEGIN
    IF p_admin_id != 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Csak admin utasíthat el!';
    END IF;

    UPDATE Regist
    SET Status = 'rejected'
    WHERE Id = p_regist_id;
END$$

DELIMITER ;

-- =========================
-- TESZT ADAT
-- =========================
INSERT INTO Regist (Name, Password, Email)
VALUES ('Teszt Elek', 'pw123', 'teszt@mail.com');

-- =========================
-- HASZNÁLAT
-- =========================

-- pending lista
-- SELECT * FROM Regist WHERE Status='pending';

-- jóváhagyás (admin = 0)
-- CALL ApproveUser(1, 0);

-- elutasítás
-- CALL RejectUser(1, 0);

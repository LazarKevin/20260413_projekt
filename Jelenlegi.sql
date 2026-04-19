CREATE DATABASE IF NOT EXISTS ISKOLA;

USE ISKOLA;

CREATE TABLE Eventt (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Descr TEXT,
    Datetol DATETIME,
    Dateig DATETIME,
    Categ VARCHAR(100),
    Important BOOLEAN DEFAULT FALSE,
    Wheres VARCHAR(255)
);


CREATE TABLE Users (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    Osztaly VARCHAR(50),
    EventId INT,
    ImgNumber VARCHAR(255),
    Email VARCHAR(255),
    FOREIGN KEY (EventId) REFERENCES Eventt(Id)
);


CREATE TABLE Regist (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255),
    Password VARCHAR(255),
    Email VARCHAR(255)
);


INSERT INTO Users (Name, Password, Email, EventId, ImgNumber) 
VALUES ('Admin', 'biztonsagos_jelszo_123', 'admin@example.com', NULL, '1.png');

INSERT INTO Eventt (Name, Descr, Datetol, Dateig, Categ, Important, Wheres)
VALUES ('Iskolai kirándulás', 'Kirándulás a közeli erdőbe', '2026-09-15 08:00:00', '2026-09-15 18:00:00', 'Kültéri', TRUE, 'Erdő');
VALUES ('Tudományos előadás', 'Előadás a fizika világáról', '2026-10-01 14:00:00', '2026-10-01 16:00:00', 'Beltéri', FALSE, 'Aula');
VALUES ('Sportnap', 'Egész napos sportesemény a pályán', '2026-11-20 09:00:00', '2026-11-20 17:00:00', 'Kültéri', TRUE, 'Sportpálya');

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
    EventId INT,
    ImgNumber VARCHAR(255),
    Email VARCHAR(255),
    AdminE BOOLEAN
    FOREIGN KEY (EventId) REFERENCES Eventt(Id)
);


CREATE TABLE Regist (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255),
    Password VARCHAR(255),
    Email VARCHAR(255),
    imgNumber VARCHAR(255),
    AdminE BOOLEAN
);


INSERT INTO Users (Name, Password, Email, EventId, ImgNumber, AdmineE) 
VALUES ('ADMIN', '$2a$12$/nUdlJaob1i0nGh/DdSpFuRdg2EuTCGwVO/zesIFhgcnqHoyxD.AS', '@@@@@', NULL, '1.png', True);

INSERT INTO Eventt (Name, Descr, Datetol, Dateig, Categ, Important, Wheres)
VALUES
    ('Iskolai kirándulás', 'Kirándulás a közeli erdőbe', '2026-09-15 08:00:00', '2026-09-15 18:00:00', 'Kültéri', TRUE, 'Erdő'),
    ('Tudományos előadás', 'Előadás a fizika világáról', '2026-10-01 14:00:00', '2026-10-01 16:00:00', 'Beltéri', FALSE, 'Aula'),
    ('Sportnap', 'Egész napos sportesemény a pályán', '2026-11-20 09:00:00', '2026-11-20 17:00:00', 'Kültéri', TRUE, 'Sportpálya'),
    ('Karácsonyi műsor', 'Ünnepi fellépések és versek', '2026-12-18 10:00:00', '2026-12-18 13:00:00', 'Beltéri', TRUE, 'Tornaterem'),
    ('Matematikaverseny', 'Iskolai szintű matematikaverseny', '2026-10-22 08:00:00', '2026-10-22 12:00:00', 'Beltéri', FALSE, 'Könyvtár'),
    ('Szülői értekezlet', 'Évközi szülői értekezlet minden osztálynak', '2026-11-05 17:00:00', '2026-11-05 19:00:00', 'Beltéri', TRUE, 'Aula'),
    ('Tavaszi takarítónap', 'Közös iskolaudvar-rendezés', '2026-04-22 09:00:00', '2026-04-22 13:00:00', 'Kültéri', FALSE, 'Iskolaudvar'),
    ('Egészségnap', 'Egészséges életmóddal kapcsolatos programok', '2026-05-10 08:00:00', '2026-05-10 16:00:00', 'Beltéri', FALSE, 'Tornaterem');

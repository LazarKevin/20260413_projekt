
CREATE TABLE Eventt (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Descr TEXT,
    Dates DATETIME,
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
    ImgUrl VARCHAR(255),
    Email VARCHAR(255),
    FOREIGN KEY (EventId) REFERENCES Eventt(Id)
);


CREATE TABLE Regist (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255),
    Password VARCHAR(255),
    Email VARCHAR(255)
);


INSERT INTO Users (Name, Password, Email, EventId, ImgUrl) 
VALUES ('Admin', 'biztonsagos_jelszo_123', 'admin@example.com', NULL, 'admin_avatar.png');

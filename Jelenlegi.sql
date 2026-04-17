
CREATE TABLE Event (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Descr TEXT,
    Dates DATETIME,
    Datetol DATETIME,
    Dateig DATETIME,
    Categ VARCHAR(100),
    Important BOOLEAN DEFAULT FALSE,
    Wheres VARCHAR(255)
);


CREATE TABLE User (
    Id INTEGER PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    EventId INTEGER,
    ImgUrl VARCHAR(255),
    Email VARCHAR(255),
    FOREIGN KEY (EventId) REFERENCES Event(Id)
);


CREATE TABLE Regist (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(255),
    Password VARCHAR(255),
    Email VARCHAR(255)
);



INSERT INTO User (Id, Name, Password, Email, EventId, ImgUrl) 
VALUES (0, 'Admin', 'biztonsagos_jelszo_123', 'admin@example.com', NULL, 'admin_avatar.png');


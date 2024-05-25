CREATE DATABASE ParkingSystemDatabase;
USE ParkingSystemDatabase;

CREATE TABLE users (
    userId INT PRIMARY KEY IDENTITY,
    firstName NVARCHAR(50),
    lastName NVARCHAR(50),
    userName NVARCHAR(50) UNIQUE,
    password NVARCHAR(100)
);

CREATE TABLE userLogs (
    logId INT NOT NULL PRIMARY KEY IDENTITY,
    userId INT,
    logDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (userId) REFERENCES users(userId)
);

CREATE TABLE vehicles
(
    vehicleId INT PRIMARY KEY IDENTITY,
    plateNumber NVARCHAR(50) UNIQUE,
    vehicleType NVARCHAR (50),
    vehicleBrand NVARCHAR(50),
);

CREATE TABLE floors
(
    floorId INT PRIMARY KEY IDENTITY
);

CREATE TABLE transactions
(
    transactionId INT PRIMARY KEY IDENTITY,
    vehicleId INT,
    parkedBy INT,
    parkInTime DATETIME DEFAULT GETDATE(),
    parkOutTime DATETIME DEFAULT null,
    duration INT DEFAULT null,
    flagdown INT,
    parkingFee INT DEFAULT NULL,
    FOREIGN KEY (vehicleId) REFERENCES vehicles(vehicleId),
    FOREIGN KEY (parkedBy) REFERENCES users (userId),
)

CREATE TABLE parkingSlot
(
    floorId INT,
    parkingSlotID INT PRIMARY KEY IDENTITY,
    transactionId INT DEFAULT NULL,
    isAvailable INT default 1,
    FOREIGN KEY (floorId) REFERENCES floors(floorId),
    FOREIGN KEY (transactionId) REFERENCES transactions(transactionId)
);

CREATE TABLE transactionHistory
(
    id INT PRIMARY KEY IDENTITY,
    parkedBy NVARCHAR (100),
    plateNumber NVARCHAR(50), 
    parkInTime DATETIME,
    parkOutTime DATETIME,
    ParkingFee INT,
)





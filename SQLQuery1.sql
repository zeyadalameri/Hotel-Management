IF DB_ID('Hotel') IS NULL
BEGIN
    CREATE DATABASE Hotel;
END
GO

USE Hotel;
GO

IF OBJECT_ID('dbo.customer', 'U') IS NOT NULL DROP TABLE dbo.customer;
IF OBJECT_ID('dbo.rooms', 'U') IS NOT NULL DROP TABLE dbo.rooms;
IF OBJECT_ID('dbo.employee', 'U') IS NOT NULL DROP TABLE dbo.employee;
GO

CREATE TABLE dbo.rooms
(
    roomid INT IDENTITY(1,1) PRIMARY KEY,
    roomnum INT UNIQUE,
    roomtype VARCHAR(20) NOT NULL,
    bed VARCHAR(20) NOT NULL,
    price BIGINT NOT NULL,
    booked VARCHAR(50) DEFAULT 'NO'
);

CREATE TABLE dbo.customer
(
    cid INT IDENTITY(1,1) PRIMARY KEY,
    cname VARCHAR(100) NOT NULL,
    mobile BIGINT NOT NULL,
    nationality VARCHAR(70) NOT NULL,
    gender VARCHAR(7) NOT NULL,
    dob VARCHAR(100) NOT NULL,
    idproof VARCHAR(100) NOT NULL,
    address VARCHAR(100) NOT NULL,
    checkin VARCHAR(100) NOT NULL,
    checkout VARCHAR(100),
    chekout VARCHAR(100) NOT NULL DEFAULT 'NO',
    roomid INT NOT NULL REFERENCES dbo.rooms(roomid)
);

CREATE TABLE dbo.employee
(
    eid INT IDENTITY(1,1) PRIMARY KEY,
    ename VARCHAR(100) NOT NULL,
    mobile BIGINT NOT NULL,
    gender VARCHAR(10) NOT NULL,
    emailid VARCHAR(100) NOT NULL,
    username VARCHAR(50) NOT NULL UNIQUE,
    pass VARCHAR(50) NOT NULL,
    admin VARCHAR(10) NOT NULL DEFAULT 'user'
);

INSERT INTO dbo.employee (ename, mobile, gender, emailid, username, pass, admin)
VALUES ('Zeyad Admin', 500000000, 'Male', 'admin@example.com', 'zeyad', '1234', 'admin');

INSERT INTO dbo.rooms (roomnum, roomtype, bed, price, booked)
VALUES
(101, 'Ac', 'Single', 100, 'NO'),
(102, 'Ac', 'Double', 180, 'NO'),
(201, 'Non-Ac', 'Single', 70, 'NO'),
(202, 'Non-Ac', 'Double', 130, 'NO');

SELECT * FROM dbo.rooms;
SELECT * FROM dbo.employee;

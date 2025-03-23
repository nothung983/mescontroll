CREATE DATABASE mediaz_db;
USE mediaz_db;
DROP DATABASE mediaz_db;

-- USERS TABLE
CREATE TABLE Users(
    UserID INT PRIMARY KEY IDENTITY(1,1),
    User_fullname NVARCHAR(255) NOT NULL,
    User_Pass NVARCHAR(100) NOT NULL,
    User_Phone_Num VARCHAR(10) NOT NULL,
    User_Email NVARCHAR(255) UNIQUE NOT NULL,
    User_Role NVARCHAR(50) DEFAULT 'User' CHECK (User_Role IN ('User', 'Admin')) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);
ALter table users Add User_Image NVARCHAR(500) NULL;

-- BRANDS TABLE
CREATE TABLE Brands(
    BrandID INT PRIMARY KEY IDENTITY(1,1),
    Brand_Name VARCHAR(50) UNIQUE NOT NULL
);

-- CAMERAS TABLE
CREATE TABLE Cameras (
    CameraID INT PRIMARY KEY IDENTITY(1,1),
    Camera_Name NVARCHAR(255) NOT NULL,
    Camera_Brand INT FOREIGN KEY REFERENCES Brands(BrandID) ON DELETE SET NULL,
    Camera_SensorType NVARCHAR(50),  
    OwnerID INT FOREIGN KEY REFERENCES Users(UserID) ON DELETE SET NULL,
    Booking_Status NVARCHAR(50) CHECK (Booking_Status IN ('Available', 'Booked', 'Under Maintenance')) DEFAULT 'Available',
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- LENSES TABLE
CREATE TABLE Lenses (
    LensID INT PRIMARY KEY IDENTITY(1,1),
    Lenses_Name NVARCHAR(255) NOT NULL,
    Lenses_Brand INT FOREIGN KEY REFERENCES Brands(BrandID) ON DELETE SET NULL,
    Lenses_FocalLengthMin INT NOT NULL,  
    Lenses_FocalLengthMax INT NOT NULL,  
    Lenses_Aperture FLOAT,
    OwnerID INT FOREIGN KEY REFERENCES Users(UserID) ON DELETE SET NULL,
    Booking_Status NVARCHAR(50) CHECK (Booking_Status IN ('Available', 'Booked', 'Under Maintenance')) DEFAULT 'Available',
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- ACCESSORIES TABLE
CREATE TABLE Accessories (
    AccessoryID INT PRIMARY KEY IDENTITY(1,1),
    Accessory_Name NVARCHAR(255) NOT NULL,
    Accessory_Brand INT FOREIGN KEY REFERENCES Brands(BrandID) ON DELETE SET NULL,
    Accessory_Type NVARCHAR(50),  
    OwnerID INT FOREIGN KEY REFERENCES Users(UserID) ON DELETE SET NULL,
    Booking_Status NVARCHAR(50) CHECK (Booking_Status IN ('Available', 'Booked', 'Under Maintenance')) DEFAULT 'Available',
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- BOOKINGS TABLE
CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(UserID), 
    CameraID INT NULL FOREIGN KEY REFERENCES Cameras(CameraID),
    LensID INT NULL FOREIGN KEY REFERENCES Lenses(LensID),
    AccessoryID INT NULL FOREIGN KEY REFERENCES Accessories(AccessoryID),
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,
    Booking_Status NVARCHAR(50) CHECK (Booking_Status IN ('Pending', 'Approved', 'Rejected', 'Returned')) DEFAULT 'Pending',
    AdminApprovalID INT NULL FOREIGN KEY REFERENCES Users(UserID), 
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- REQUESTS TABLE
CREATE TABLE Requests (
    RequestID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    DeviceType NVARCHAR(50) CHECK (DeviceType IN ('Camera', 'Lens', 'Accessory')) NOT NULL,
    Request_content NVARCHAR(255) NOT NULL,
    Booking_Status NVARCHAR(50) CHECK (Booking_Status IN ('Pending', 'Approved', 'Rejected')) DEFAULT 'Pending',
    AdminApprovalID INT FOREIGN KEY REFERENCES Users(UserID) NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);


-- Insert Users
INSERT INTO Users (User_fullname, User_Pass, User_Phone_Num, User_Email, User_Role, User_Image) VALUES
('Alice Johnson', 'password123', '1234567890', 'alice@example.com', 'User', '1.png'),
('Bob Smith', 'securePass1', '0987654321', 'bob@example.com', 'User', '2.png'),
('Charlie Brown', 'pass456', '1122334455', 'charlie@example.com', 'Admin', '3.png'),
('David Miller', 'testPass4', '2233445566', 'david@example.com', 'User', '4.png'),
('Emma Wilson', 'helloWorld', '3344556677', 'emma@example.com', 'User', '5.png'),
('Frank Thomas', 'secureMe', '4455667788', 'frank@example.com', 'User', '6.png'),
('Grace Hall', 'pass789', '5566778899', 'grace@example.com', 'Admin', '7.png'),
('Hannah Scott', 'strongPass', '6677889900', 'hannah@example.com', 'User', '8.png'),
('Ian Adams', 'pass101', '7788990011', 'ian@example.com', 'User', '9.png'),
('Jessica Lopez', 'test1234', '8899001122', 'jessica@example.com', 'User', '10.png');

-- Insert Brands
INSERT INTO Brands (Brand_Name) VALUES
('Canon'),
('Sony'),
('Fujifilm'),
('Nikon'),
('Tamron'),
('Sigma'),
('DJI');

-- Insert Cameras
INSERT INTO Cameras (Camera_Name, Camera_Brand, Camera_SensorType, OwnerID, Booking_Status) VALUES
('Canon EOS R5', 1, 'Full Frame', 1, 'Available'),
('Nikon Z6 II', 4, 'Full Frame', 2, 'Booked'),
('Sony A7 III', 2, 'Full Frame', 3, 'Available'),
('Fujifilm X-T4', 3, 'APS-C', 4, 'Available'),
('Canon EOS R6 II', 1, 'Full Frame', 5, 'Booked'),
('Sony FX30', 2, 'APS-C', 6, 'Available'),
('Nikon D850', 4, 'Full Frame', 7, 'Available'),
('Sony A6500', 2, 'APS-C', 8, 'Booked'),
('Sony A7R III', 2, 'Full Frame', 9, 'Available'),
('Sony A7C', 2, 'Full Frame', 10, 'Available');

-- Insert Lenses
INSERT INTO Lenses (Lenses_Name, Lenses_Brand, Lenses_FocalLengthMin, Lenses_FocalLengthMax, Lenses_Aperture, OwnerID, Booking_Status) VALUES
('Canon RF 50mm f/1.2L', 1, 50, 50, 1.2, 1, 'Available'),
('Nikon Z 24-70mm f/2.8 S', 4, 24, 70, 2.8, 2, 'Booked'),
('Sony FE 85mm f/1.4 GM', 2, 85, 85, 1.4, 3, 'Under Maintenance'),
('Fujifilm XF 35mm f/1.4', 3, 35, 35, 1.4, 4, 'Available'),
('Tamron 70-200mm f/2.8', 5, 70, 200, 2.8, 5, 'Available'),
('Sigma 18-35mm f/1.8', 6, 18, 35, 1.8, 6, 'Booked'),
('DJI DL 35mm f/2.8', 7, 35, 35, 2.8, 7, 'Available'),
('Canon RF 85mm f/1.2L', 1, 85, 85, 1.2, 8, 'Booked'),
('Sony FE 35mm f/1.8', 2, 35, 35, 1.8, 9, 'Available'),
('Nikon Z 50mm f/1.8 S', 4, 50, 50, 1.8, 10, 'Available');

-- Insert Accessories
INSERT INTO Accessories (Accessory_Name, Accessory_Brand, Accessory_Type, OwnerID, Booking_Status) VALUES
('SanDisk 128GB SD Card', 1, 'Memory Card', 1, 'Available'),
('Manfrotto Tripod', 2, 'Tripod', 2, 'Booked'),
('Godox V1 Flash', 3, 'Flash', 3, 'Available');

-- Insert Bookings
INSERT INTO Bookings (UserID, CameraID, LensID, AccessoryID, StartDate, EndDate, Booking_Status, AdminApprovalID) VALUES
(1, 2, 2, 2, '2025-03-01', '2025-03-07', 'Approved', 3),
(2, 3, NULL, 1, '2025-03-05', '2025-03-10', 'Pending', NULL);


INSERT INTO Bookings (UserID, CameraID, LensID, AccessoryID, StartDate, EndDate, Booking_Status, AdminApprovalID) VALUES
(3, 5, 2, 3, '2025-03-16', '2025-03-17', 'Approved', 7),
(3, 2, 4, 2, '2025-03-14', '2025-03-15', 'Approved', 7),
(3, 1, 2, 3, '2025-03-12', '2025-03-13', 'Approved', 7);


INSERT INTO Bookings (UserID, CameraID, LensID, AccessoryID, StartDate, EndDate, Booking_Status, AdminApprovalID) VALUES
(1, 5, 2, 3, '2025-04-16', '2025-04-17', 'Pending', NULL),
(1, 2, NULL, 3, '2025-04-11', '2025-04-18', 'Pending', NULL),
(1, NULL, 2, 2, '2025-04-18', '2025-04-19', 'Pending', NULL),
(1, 6, 4, 2, '2025-04-14', '2025-04-15', 'Pending', NULL);

-- Insert Requests
INSERT INTO Requests (UserID, DeviceType, Request_content, Booking_Status, AdminApprovalID) VALUES
(1, 'Camera', 'Requesting a Canon EOS R5 for a school event shoot.', 'Pending', NULL),
(2, 'Lens', 'Need a Sony 85mm lens for portrait photography.', 'Approved', 3);


select * from Lenses where OwnerID = 3;


Select BookingID, StartDate, EndDate, Accessory_Name, Camera_Name, Lenses_name
from Bookings B


select * from users;
select * from lenses;

select U.User_fullname AS Request_from, R.DeviceType AS Devices From Requests R JOIN Users U ON R.UserID = U.UserID;

SELECT TOP 10  r.RequestID, u.User_fullname, r.DeviceType, r.Request_content, r.CreatedAt 
                                    FROM Requests r JOIN Users u ON r.UserID = u.UserID ORDER BY r.CreatedAt DESC;

desc Users;

SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Users' AND COLUMN_NAME = 'User_Phone_Num';

ALTER TABLE Users ALTER COLUMN User_Phone_Num VARCHAR(15);


select * from Requests;
select * from Bookings;


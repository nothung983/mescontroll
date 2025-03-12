CREATE DATABASE mediaz_db;
USE mediaz_db;

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
INSERT INTO Users (User_fullname, User_Pass, User_Phone_Num, User_Email, User_Role) VALUES
('Alice Johnson', 'password123', '1234567890', 'alice@example.com', 'User'),
('Bob Smith', 'securePass1', '0987654321', 'bob@example.com', 'User'),
('Charlie Brown', 'pass456', '1122334455', 'charlie@example.com', 'Admin'),
('David Miller', 'testPass4', '2233445566', 'david@example.com', 'User'),
('Emma Wilson', 'helloWorld', '3344556677', 'emma@example.com', 'User'),
('Frank Thomas', 'secureMe', '4455667788', 'frank@example.com', 'User'),
('Grace Hall', 'pass789', '5566778899', 'grace@example.com', 'Admin'),
('Hannah Scott', 'strongPass', '6677889900', 'hannah@example.com', 'User'),
('Ian Adams', 'pass101', '7788990011', 'ian@example.com', 'User'),
('Jessica Lopez', 'test1234', '8899001122', 'jessica@example.com', 'User');

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

-- Insert Requests
INSERT INTO Requests (UserID, DeviceType, Request_content, Booking_Status, AdminApprovalID) VALUES
(1, 'Camera', 'Requesting a Canon EOS R5 for a school event shoot.', 'Pending', NULL),
(2, 'Lens', 'Need a Sony 85mm lens for portrait photography.', 'Approved', 3);

ALter table users Add User_Image NVARCHAR(500) NULL;

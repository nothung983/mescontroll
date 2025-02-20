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

-- EVENTS TABLE
CREATE TABLE Events (
    EventID INT PRIMARY KEY IDENTITY(1,1),
    Event_Name NVARCHAR(255) NOT NULL,
    Event_Date DATETIME NOT NULL,
    CreatedBy INT FOREIGN KEY REFERENCES Users(UserID) ON DELETE SET NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- EVENT DEVICES TABLE
CREATE TABLE EventDevices (
    EventDeviceID INT PRIMARY KEY IDENTITY(1,1),
    EventID INT FOREIGN KEY REFERENCES Events(EventID) ON DELETE CASCADE,
    CameraID INT NULL FOREIGN KEY REFERENCES Cameras(CameraID),
    LensID INT NULL FOREIGN KEY REFERENCES Lenses(LensID),
    AccessoryID INT NULL FOREIGN KEY REFERENCES Accessories(AccessoryID)
);

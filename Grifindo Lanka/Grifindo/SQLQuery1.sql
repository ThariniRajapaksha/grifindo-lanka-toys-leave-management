/*Database create*/
/*CREATE DATABASE Grifindo;*/

/*Use create database*/
use Grifindo;

/*Create User Registration Table*/
/*CREATE TABLE User_Register (
    UserID int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(255),
    Contact int,
    EmployeeID int,
    Password varchar(255)
);
INSERT INTO User_Register (Name, Contact, EmployeeID, Password)
VALUES ('Tharini Rajapaksha', '0771740070', '12345', 'Tharini.123');
select * from User_Register;*/

/*Create Admin Registration Table*/
/*CREATE TABLE Admin_Register (
    RegID int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(255),
    Contact int,
    AdminID int,
    Password varchar(255)
);
INSERT INTO Admin_Register (Name, Contact, AdminID, Password)
VALUES ('Rehansa Vipulasena', '0779970602', '111', 'Rehansa.123');
select * from Admin_Register;*/

/*
/* Alter the User_Register table to make EmployeeID unique */
ALTER TABLE User_Register
ADD CONSTRAINT UQ_EmployeeID UNIQUE (EmployeeID);
/* Alter the User_Register table to make UserID unique */
ALTER TABLE User_Register
ADD CONSTRAINT UQ_UserID UNIQUE (UserID);
/* Alter the User_Register table to make Password unique */
ALTER TABLE User_Register
ADD CONSTRAINT UQ_Password UNIQUE (Password);
*/

/*
/* Alter the Admin_Register table to make RegID unique */
ALTER TABLE Admin_Register
ADD CONSTRAINT UQ_RegID UNIQUE (RegID);

/* Alter the Admin_Register table to make AdminID unique */
ALTER TABLE Admin_Register
ADD CONSTRAINT UQ_AdminID UNIQUE (AdminID);

/* Alter the Admin_Register table to make Password unique */
ALTER TABLE Admin_Register
ADD CONSTRAINT UQ_Passwords UNIQUE (Password);
*/

/*Create User Login Table*/
/*CREATE TABLE UserLogin (
    LoginID int IDENTITY(1,1) PRIMARY KEY,
	UserID int,
    EmployeeID int,
    Password varchar(255),
    CONSTRAINT FK_UserID FOREIGN KEY (UserID) REFERENCES User_Register(UserID),
    CONSTRAINT FK_EmployeeID FOREIGN KEY (EmployeeID) REFERENCES User_Register(EmployeeID),
	CONSTRAINT FK_Password FOREIGN KEY (Password) REFERENCES User_Register(Password)
);
select * from UserLogin;*/


/*Create Admin Login Table*/
/*CREATE TABLE AdminLogin (
    AdminLoginID int IDENTITY(1,1) PRIMARY KEY,
	RegID int,
    AdminID int,
    Password varchar(255),
    CONSTRAINT FK_RegID FOREIGN KEY (RegID) REFERENCES Admin_Register(RegID),
    CONSTRAINT FK_AdminID FOREIGN KEY (AdminID) REFERENCES Admin_Register(AdminID),
	CONSTRAINT FK_Passwords FOREIGN KEY (Password) REFERENCES Admin_Register(Password)
);
select * from AdminLogin;
*/

/*Create Employees leave applications Table*/
/*CREATE TABLE LeaveApplication (
    ApplicationID int IDENTITY(1,1) PRIMARY KEY,
	EmployeeID int NOT NULL UNIQUE,
    Name varchar(255),
	Contact int,
    Email varchar(255),
	LeaveType varchar(255) NOT NULL UNIQUE,
	StartDate DATE NOT NULL UNIQUE,
	EndDate DATE NOT NULL UNIQUE,
	Reason varchar(255),
    CONSTRAINT FK_EmployeeIDs FOREIGN KEY (EmployeeID) REFERENCES User_Register(EmployeeID)
);
select * from LeaveApplication;
*/

/*Create History of leave application Table*/
/*CREATE TABLE HistoryOfLeave (
    QueNum int IDENTITY(1,1) PRIMARY KEY,
	EmployeeID int,
    LeaveType varchar(255),
    StartDate DATE,
	EndDate DATE,
	Status varchar(255),
    CONSTRAINT FK_EmpID FOREIGN KEY (EmployeeID) REFERENCES User_Register(EmployeeID),
    CONSTRAINT FK_LeaveType FOREIGN KEY (LeaveType) REFERENCES LeaveApplication(LeaveType),
	CONSTRAINT FK_StartDate FOREIGN KEY (StartDate) REFERENCES LeaveApplication(StartDate),
	CONSTRAINT FK_EndDate FOREIGN KEY (EndDate) REFERENCES LeaveApplication(EndDate)
);
select * from HistoryOfLeave;
*/

/*Create Employee Management Table*/
/*CREATE TABLE EmployeeManagement (
    RegNum int IDENTITY(1,1) PRIMARY KEY,
	FistName varchar(255),
    LastName varchar(255),
    DateOfBirth DATE,
	Gender varchar(255),
	Email varchar(255),
	Phone int,
	Address varchar(255),
	EmployeeID int,
	NIC int,
	Position varchar(255),
	Department varchar(255),
	StartDate DATE,
	EmployeementType varchar(255),
	Anual int,
	Casual int,
	Short int
);
select * from EmployeeManagement;
*/

/*
/* Create RosterManagement Table */
CREATE TABLE RosterManagement (
    RosterID int IDENTITY(1,1) PRIMARY KEY,
    EmployeeID int,
    MondayStartTime time,
    MondayEndTime time,
    TuesdayStartTime time,
    TuesdayEndTime time,
    WednesdayStartTime time,
    WednesdayEndTime time,
    ThursdayStartTime time,
    ThursdayEndTime time,
    FridayStartTime time,
    FridayEndTime time,
    SaturdayStartTime time,
    SaturdayEndTime time,
    SundayStartTime time,
    SundayEndTime time,
    
    CONSTRAINT FK_Emp FOREIGN KEY (EmployeeID) REFERENCES User_Register(EmployeeID)
);
INSERT INTO RosterManagement (EmployeeID, MondayStartTime, MondayEndTime, TuesdayStartTime, TuesdayEndTime, WednesdayStartTime, WednesdayEndTime, ThursdayStartTime, ThursdayEndTime, FridayStartTime, FridayEndTime)
VALUES (12345, '09:00', '17:00', '09:00', '17:00', '09:00', '17:00', '09:00', '17:00', '09:00', '17:00');

SELECT * FROM RosterManagement;
*/
/*ALTER TABLE UserLogin DROP CONSTRAINT FK_UserID
select * from UserLogin;*/
/*ALTER TABLE UserLogin
DROP COLUMN UserID;*/
/*ALTER TABLE AdminLogin DROP CONSTRAINT FK_RegID
select * from AdminLogin;*/
/*ALTER TABLE AdminLogin
DROP COLUMN RegID;
select * from AdminLogin;*/
/*INSERT INTO AdminLogin (AdminID, Password)
VALUES ('111', 'Rehansa.123');
select * from AdminLogin;*/
/*
-- Approve leave application
-- Declare the variable
DECLARE @QueNum INT;

-- Set the value for testing (replace with an actual Queue Number)
SET @QueNum = 123; 

-- Approve leave application
UPDATE HistoryOfLeave
SET Status = 'Approved'
WHERE QueNum = @QueNum;

-- Reject leave application
UPDATE HistoryOfLeave
SET Status = 'Rejected'
WHERE QueNum = @QueNum;


/*EXEC sp_rename 'EmployeeManagement.Anual', 'Annual', 'COLUMN';*/
INSERT INTO User_Register (Name, Contact, EmployeeID, Password)
VALUES ('Alena Watson', '0779970602', '12399', 'Alena.123');*/
/*
-- Drop the unique constraint on LeaveType
ALTER TABLE LeaveApplication
DROP CONSTRAINT IF EXISTS UQ_LeaveType; 
-- Drop the unique constraint on StartDate
ALTER TABLE LeaveApplication
DROP CONSTRAINT IF EXISTS UQ_StartDate; 
-- Drop the unique constraint on EndDate
ALTER TABLE LeaveApplication
DROP CONSTRAINT IF EXISTS UQ_EndDate; 
*//*
ALTER TABLE HistoryOfLeave
DROP CONSTRAINT FK_LeaveType;
*//*
ALTER TABLE LeaveApplication
DROP CONSTRAINT UQ__LeaveApp__B4450593A693F5DF;
*/
/*ALTER TABLE LeaveApplication
DROP CONSTRAINT IF EXISTS UQ_LeaveApp;*/

/*ALTER TABLE LeaveApplication
DROP CONSTRAINT UQ__LeaveApp__7AD04FF04AEC75E7;*/

SELECT * FROM LeaveApplication;
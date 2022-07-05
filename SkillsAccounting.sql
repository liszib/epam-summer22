CREATE DATABASE SkillsAccounting
COLLATE Cyrillic_General_CI_AS
GO
USE SkillsAccounting

GO
CREATE TABLE Skills(
	[ID] int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Skills PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL
)

GO
CREATE TABLE Users(
	[ID] int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Users PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [DateOfBirth] DATETIME NOT NULL
)

GO
CREATE TABLE SkillsList(
	[userID] int NOT NULL, 
    [skillID] int NOT NULL,
	CONSTRAINT FK_SkillsList_Skills FOREIGN KEY (userID) REFERENCES Skills (ID),
	CONSTRAINT FK_SkillsList_Users FOREIGN KEY (userID) REFERENCES Users (ID)
)

GO

CREATE TABLE InfoUser(
	[userID] int NOT NULL, 
    [Login] NVARCHAR(50) NOT NULL,
	[Password] NVARCHAR(50) NOT NULL,
	[Role] NVARCHAR(50) NOT NULL,
	CONSTRAINT FK_InfoUser_Users FOREIGN KEY (userID) REFERENCES Users (ID)
)

GO

CREATE PROCEDURE Authorization
	@Login NVARCHAR(50) ,
    @Password NVARCHAR(50),
AS
SELECT * FROM InfoUser
WHERE Login_ = @Login and Password_ = @Password

GO

CREATE PROCEDURE AddUser
	@ID int,
    @Name VARCHAR(50),
	@DateOfBirth DATETIME
AS
INSERT INTO Users
VALUES(@Name, @DateOfBirth)
GO

CREATE PROCEDURE AddSkill
	@ID int,
    @Name VARCHAR(50)
AS
INSERT INTO Skills
VALUES(@Name)
GO

CREATE PROCEDURE AddInfoUser
	@userID int, 
    @Login NVARCHAR(50) NOT NULL,
	@Password NVARCHAR(50) NOT NULL,
	@Role NVARCHAR(50)
AS
INSERT INTO InfoUser([Login], [Password], [Role]) 
VALUES(@Login, @Password, @Role);
GO

CREATE PROCEDURE RemoveUser
@ID int
AS
BEGIN
    DELETE from Users
    WHERE ID=@ID
END
GO

CREATE PROCEDURE RemoveSkill
@ID INT
as
BEGIN
    DELETE from Skills
    WHERE ID=@ID
END
GO

CREATE PROCEDURE RemoveInfoUser
@userID INT
as
BEGIN
    DELETE from InfoUser
    WHERE userID=@userID 
END
GO

CREATE PROCEDURE ModifyUser
@ID int,
@Name VARCHAR(50),
@DateOfBirth DATETIME
as
BEGIN
    UPDATE Users SET Name = @Name, DateOfBirth = @DateOfBirth
    WHERE ID=@ID
END
GO

CREATE PROCEDURE ModifySkill
@ID int,
@Name VARCHAR(50)
as
BEGIN
    UPDATE Skills SET Name = @Name
    WHERE ID=@ID
END
GO

CREATE PROCEDURE ModifyInfoUser
	@userID int, 
    @Login NVARCHAR(50) NOT NULL,
	@Password NVARCHAR(50) NOT NULL,
	@Role NVARCHAR(50)
as
BEGIN
    UPDATE InfoUser SET Login = @Login, Password = @Password, Role = @Role
    WHERE userID=@userID
END
GO
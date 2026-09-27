CREATE TABLE Devices
(
DeviceID INT IDENTITY(1,1) PRIMARY KEY,
 
AssetTag VARCHAR(50),
 
DeviceName VARCHAR(100),
 
DeviceType VARCHAR(50),
 
Status VARCHAR(50),
 
AssignedTo VARCHAR(100),
 
SerialNumber VARCHAR(100),
 
ModelYear INT
);
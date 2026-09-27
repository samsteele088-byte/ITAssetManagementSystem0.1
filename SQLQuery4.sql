CREATE TABLE Maintenance
(
    MaintenanceID INT IDENTITY(1,1) PRIMARY KEY,

    DeviceID INT,

    Note VARCHAR(500),

    DateAdded DATETIME
);
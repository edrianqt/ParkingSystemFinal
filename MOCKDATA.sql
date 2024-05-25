use ParkingSystemDatabase;

/* ADMIN */

INSERT INTO admin(firstName, lastName, userName, password)
VALUES('christian', 'nunez', '123123', 'nunez123')

select * from users

SELECT * FROM users WHERE userName = 'hikari' AND password = 'nunez123'

select * from admin

DBCC checkident('admin', reseed, 0)

/* ADMIN ENDS */

/* ADMINLOGS */

DBCC checkident('adminLogs', reseed, 7)

INSERT INTO adminLogs(adminId, logDate)
VALUES(1, GETDATE())

SELECT userLogs.logId, users.firstName, users.lastName, users.userName, userLogs.logDate
FROM userLogs
INNER JOIN users ON userLogs.userId = users.userId
WHERE adminLogs.logDate = '2024-05-21';

SELECT adminLogs.logId, admin.firstName, admin.lastName, admin.userName, adminLogs.logDate
                   FROM adminLogs
                   INNER JOIN admin ON adminLogs.adminId = admin.adminId
                   WHERE admin.firstName = 'panda';


/* ADMINLOGS ENDS */

/* VEHICLE */

INSERT INTO vehicles(plateNumber, vehicleType, vehicleBrand)
VALUES('ABC-126', 'SUV', 'TOYOTA')

SELECT * from vehicles

DBCC checkident('vehicles', reseed, 1)

/* VEHICLE ENDS */

select * from floors


/* Transaction */

INSERT INTO transactions(vehicleId, parkedBy, parkInTime)
VALUES(1, 1, GETDATE());

select * from transactions WHERE TRANSACTIONID = 1;

INSERT INTO transactions(vehicleId, parkedBy, parkInTime)
VALUES(1, 1, GETDATE());

SELECT * FROM TRANSACTIONS;

DELETE FROM vehicles WHERE vehicleId = 1;

UPDATE transactions
SET parkOutTime = GETDATE(),
    duration = DATEDIFF(minute, parkInTime, GETDATE())
WHERE transactionId = 6

/* TRANSACTION */

/* Parking Slot */

INSERT INTO parkingSlot(floorId)
VALUES(1)

select * FROM parkingSlot WHERE floorId = 1

UPDATE parkingSlot
SET transactionId = 1,
   IsAvailable = 0
WHERE parkingSlotId = 1

SELECT 
    ps.parkingSlotID,
    ps.floorId,
    ps.isAvailable,
    t.transactionId,
    t.vehicleId,
    v.plateNumber,
    v.vehicleType,
    v.vehicleBrand,
    t.parkedBy,
    a.firstName AS adminFirstName,
    a.lastName AS adminLastName,
    t.parkInTime,
    t.parkOutTime
FROM 
    parkingSlot ps
LEFT JOIN 
    transactions t ON ps.transactionId = t.transactionId
LEFT JOIN
    vehicles v ON t.vehicleId = v.vehicleId
LEFT JOIN
    admin a ON t.parkedBy = a.adminId;

SELECT 
            ps.transactionId AS transcation_id,
            t.parkInTime,
            t.parkOutTime,
            v.plateNumber AS VehiclePlateNumber,
            v.vehicleType,
            v.vehicleBrand,
            CONCAT(a.firstName, ' ', a.lastName) AS parkedBy
        FROM 
            parkingSlot ps
        INNER JOIN 
            transactions t ON ps.transactionId = t.transactionId
        INNER JOIN 
            vehicles v ON t.vehicleId = v.vehicleId
        INNER JOIN 
            admin a ON t.parkedBy = a.adminId
        WHERE 
            ps.FloorId = 1;


/* PARKING SLOT */

SELECT 
                t.transactionId,
                t.duration,
                t.parkInTime,
                t.parkOutTime,
                v.plateNumber,
                v.vehicleType,
                v.vehicleBrand,
                CONCAT(a.firstName, ' ', a.lastName) AS parkedBy
            FROM 
                transactions t
            INNER JOIN 
                vehicles v ON t.vehicleId = v.vehicleId
            INNER JOIN 
                admin a ON t.parkedBy = a.adminId
            WHERE 
                t.transactionId = 1


DELETE FROM vehicles WHERE plateNumber = ABC-1234;

select * from transactionHistory

select * from userLogs WHERE userLogs.logDate = '22-05-2024'

SELECT userLogs.logId, users.firstName, users.lastName, users.userName, userLogs.logDate
                   FROM userLogs
                   INNER JOIN users ON userLogs.userId = users.userId
                   WHERE userLogs.logDate = '22-05-2024'

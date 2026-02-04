
--DDL – Data Definition Language

-- SYNTAX:
-- CREATE TABLE table_name (column_name datatype, column_name datatype, ...);

--CREATE TABLE StaffDetails (
--    StaffID INT PRIMARY KEY,
--    StaffName VARCHAR(50),
--    Team VARCHAR(50),
--    MonthlySalary INT
--);


-- SYNTAX:
-- ALTER TABLE table_name ADD column_name datatype;

--ALTER TABLE StaffDetails
--ADD ContactEmail VARCHAR(100);



-- SYNTAX:
-- DROP TABLE table_name;

--DROP TABLE StaffDetails;


-- SYNTAX:
-- TRUNCATE TABLE table_name;

--TRUNCATE TABLE StaffDetails;



--DML – Data Manipulation Language


-- SYNTAX:
-- INSERT INTO table_name VALUES (value1, value2, value3, ...);

--INSERT INTO StaffDetails VALUES (101, 'Aman', 'Operations', 32000, 'aman@gmail.com');
--INSERT INTO StaffDetails VALUES (102, 'Riya', 'Development', 45000, 'riya@gmail.com');


-- SYNTAX:
-- UPDATE table_name SET column_name = value WHERE condition;

--UPDATE StaffDetails
--SET MonthlySalary = 48000
--WHERE StaffID = 102;


-- SYNTAX:
-- DELETE FROM table_name WHERE condition;

--DELETE FROM StaffDetails
--WHERE StaffID = 101;



--DQL – Data Query Language

-- SYNTAX:
-- SELECT column_name FROM table_name;

--SELECT *
--FROM StaffDetails;



--DCL – Data Control Language

-- SYNTAX:
-- GRANT permission ON object TO user;

--GRANT SELECT
--ON StaffDetails
--TO TraineeUser;



-- SYNTAX:
-- REVOKE permission ON object FROM user;

--REVOKE SELECT
--ON StaffDetails
--FROM TraineeUser;



--TCL – Transaction Control Language

-- SYNTAX:
-- COMMIT;

--BEGIN TRANSACTION;

--INSERT INTO StaffDetails
--VALUES (103, 'Neeraj', 'Accounts', 52000, 'neeraj@gmail.com');

--COMMIT;



-- SYNTAX:
-- ROLLBACK;

--BEGIN TRANSACTION;

--DELETE FROM StaffDetails
--WHERE StaffID = 102;

--ROLLBACK;


-- SYNTAX:
-- SAVE TRANSACTION savepoint_name;

--BEGIN TRANSACTION;

--INSERT INTO StaffDetails
--VALUES (104, 'Pooja', 'Marketing', 36000, 'pooja@gmail.com');

--SAVE TRANSACTION SavePoint_A;

--DELETE FROM StaffDetails
--WHERE StaffID = 104;

--ROLLBACK TRANSACTION SavePoint_A;

--COMMIT;


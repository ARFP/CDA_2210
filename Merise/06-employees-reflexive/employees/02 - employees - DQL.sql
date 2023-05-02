-- use employees

/* 1. Sélectionner le nom, prénom et salaire de tous les employés 
	triés par date d’embauche de la plus ancienne à la plus récente.*/

SELECT emp_lastname, emp_firstname, emp_salary, emp_hiredate FROM employees 
ORDER BY emp_hiredate ASC;


/* 2. Sélectionner le nom, salaire, date d’embauche de tous les employés 
	triés par identifiant de manager (croissant) 
	puis par nom (ordre alphabétique). */

SELECT emp_lastname, emp_salary, emp_hiredate, emp_manager_id FROM employees 
ORDER BY emp_manager_id ASC, emp_lastname ASC;


/* 3. Sélectionner le nom, prénom, salaire, date d’embauche, 
	nom et prénom du manager de tous les employés. 
	Trier la liste par nom de manager (ordre croissant) 
	puis par date d’embauche de la plus récente à la plus ancienne. */

SELECT 
E0.emp_lastname,
E0.emp_firstname,
E0.emp_salary,
E0.emp_hiredate,
E0.emp_manager_id,
E1.emp_id AS 'Manager id',
E1.emp_lastname AS 'Manager Last name',
E1.emp_firstname AS 'Manager First name'
FROM employees AS E0
LEFT JOIN employees AS E1 ON E0.emp_manager_id = E1.emp_id
ORDER BY E1.emp_lastname ASC,E0.emp_hiredate DESC;


/* 4. Sélectionner les employés sans manager.*/

SELECT * FROM employees WHERE emp_manager_id IS NULL;


/* 5. Sélectionner le prénom et nom de tous les managers avec, pour chacun, 
	le nombre de leur subordonnés. 
	Les managers avec le moins de subordonnés apparaissent en 1er */

SELECT 
MAN1.emp_lastname,
MAN1.emp_firstname,
count(EMP1.emp_id) as 'manager_count'
from employees as MAN1
join employees as EMP1 on MAN1.emp_id = EMP1.emp_manager_id
group by
MAN1.emp_lastname,
MAN1.emp_firstname
order by
manager_count asc;

/* This instruction verify if there's exactly 5 employees managed by ID 5
select count (*) from employees where employees.emp_manager_id = 5;
*/

-- Version avec utilisation d'une sous requette.
SELECT 
MAN1.emp_lastname,
MAN1.emp_firstname,
count(EMP1.emp_id) as 'manager_count',
(SELECT count (*) from employees EMP2 where EMP2.emp_manager_id = EMP1.emp_manager_id) as 'toto'
from employees as MAN1
join employees as EMP1 on MAN1.emp_id = EMP1.emp_manager_id
group by
MAN1.emp_lastname,
MAN1.emp_firstname,
EMP1.emp_manager_id
order by
manager_count asc;



/* 6. Sélectionner le nom de tous les managers avec, pour chacun, 
	la moyenne des salaires de leur subordonnés. 
	Trier le résultat selon la valeur de la moyenne par ordre décroissant. */

SELECT 
MAN1.emp_lastname,
avg(EMP1.emp_salary) as 'salary_average',
(SELECT avg (EMP2.emp_salary) from employees EMP2 where EMP2.emp_manager_id = MAN1.emp_id) as 'tata'
from employees as MAN1
join employees as EMP1 on MAN1.emp_id = EMP1.emp_manager_id
group by
MAN1.emp_lastname,
MAN1.emp_id
order by
salary_average desc;

INSERT INTO employees
(emp_manager_id,emp_lastname,emp_firstname,emp_salary,emp_hiredate)
VALUES
(NULL,'Toto', 'Johnny', 100000, '2010-01-09');

-- johnny
SELECT DISTINCT 
D.emp_id , D.emp_lastname,  D.emp_firstname, D.emp_salary, 
COUNT(E.emp_id) AS 'Number of Employees',
SUM(E.emp_salary) AS 'Total Salary',
AVG(E.emp_salary) AS 'Average Salary' 
FROM employees AS D , 
employees AS E
WHERE D.emp_manager_id IS NULL 
AND E.emp_manager_id IS NOT NULL
GROUP BY D.emp_id , D.emp_lastname,  D.emp_firstname, D.emp_salary

-- rodolphe V1
SELECT 
boss.emp_id,boss.emp_firstname,boss.emp_lastname,boss.emp_salary,boss.emp_hiredate,
COUNT(employees.emp_id) as 'Nomber of employees',
SUM(employees.emp_salary) as 'Total salary',
AVG(employees.emp_salary) as 'Average salary' 
FROM employees AS boss
INNER JOIN employees ON employees.emp_id <> boss.emp_id AND employees.emp_manager_id IS NOT NULL
WHERE boss.emp_manager_id IS NULL  
GROUP BY boss.emp_id,boss.emp_firstname,boss.emp_lastname,boss.emp_salary,boss.emp_hiredate;

-- Rodolphe V2
SELECT 
boss.emp_id,boss.emp_firstname,boss.emp_lastname,boss.emp_salary,boss.emp_hiredate,
COUNT(employees.emp_id) as 'Number of employees',
SUM(employees.emp_salary) as 'Total salary',
AVG(employees.emp_salary) as 'Average salary'FROM employees AS boss
INNER JOIN employees ON employees.emp_id <> boss.emp_id AND employees.emp_manager_id IS NOT NULL 
WHERE boss.emp_manager_id IS NULL 
GROUP BY boss.emp_id,boss.emp_firstname,boss.emp_lastname,boss.emp_salary,boss.emp_hiredate;

-- gerard

SELECT
Boss.emp_id 'Employee Id',
Boss.emp_lastname AS 'Lastname',
Boss.emp_firstname AS 'Firstname',
Boss.emp_salary AS 'Salary',
Boss.emp_hiredate AS 'Hiredate',
COUNT(All_emp.emp_id) AS 'Number of Employees',
SUM (All_emp.emp_salary) AS 'Total Salary',
AVG(All_emp.emp_salary) AS 'Average Salary'
FROM employees AS Boss 
JOIN employees AS All_emp ON Boss.emp_id <> All_emp.emp_id
WHERE Boss.emp_manager_id IS NULL AND All_emp.emp_manager_id IS NOT NULL
GROUP BY Boss.emp_id, Boss.emp_lastname,Boss.emp_firstname, Boss.emp_salary, Boss.emp_hiredate 

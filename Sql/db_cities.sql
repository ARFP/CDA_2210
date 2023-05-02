-- USE cities;


-- afficher les villes et le nom du pays

SELECT city_name, country_name 
FROM cities, countries 
WHERE countries.country_code = cities.country_code 
AND cities.country_code = 'FR';


SELECT city_name, country_name 
FROM cities 
JOIN countries 
ON countries.country_code = cities.country_code
WHERE cities.country_code = 'FR';



SELECT city_name, country_name 
FROM cities 
JOIN countries 
ON countries.country_code = cities.country_code 
WHERE countries.country_name LIKE 'F%';

-- afficher les éléments uniquement si le pays contient plus de 4 villes
SELECT cities.city_name, country_name
FROM cities 
JOIN countries ON countries.country_code = cities.country_code 
JOIN cities C ON C.country_code = countries.country_code
GROUP BY C.city_name, country_name
HAVING count(C.city_id) >= 4;


SELECT country_name, count(city_id) 
FROM cities JOIN countries 
ON countries.country_code = cities.country_code 
GROUP BY country_name
HAVING count(city_id) >= 4;


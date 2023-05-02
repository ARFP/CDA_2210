-- use cities;

-- DDL = CREATE, DROP, ALTER
-- DML = INSERT, UPDATE, DELETE 
-- DQL = SELECT, CALL

DROP TABLE IF EXISTS cities;
DROP TABLE IF EXISTS countries;

CREATE TABLE countries
(
	country_code CHAR(2),
	country_name VARCHAR(100) NOT NULL,
	PRIMARY KEY (country_code)
);

CREATE TABLE cities 
(
	city_id INT IDENTITY,
	city_name VARCHAR(100) NOT NULL,
	country_code CHAR(2) NOT NULL,
	PRIMARY KEY (city_id)
);


ALTER TABLE cities 
	ADD CONSTRAINT FK_cities FOREIGN KEY (country_code)
		REFERENCES countries(country_code);

		
INSERT INTO countries
(country_code,country_name)
VALUES
('FR','France')
,('RU','Russian Federation') 
,('US','United States'); 

INSERT INTO cities
(city_name,country_code)
VALUES
('Paris','FR')
,('Lyon','FR')
,('Toulouse','FR')
,('Marseille','FR')
,('Mulhouse','FR')
,('Boston','US')
,('Los Angeles','US')
,('Washington','US')
,('New York','US')
,('Moscou','RU')
,('Saint-Pétersbourg','RU');


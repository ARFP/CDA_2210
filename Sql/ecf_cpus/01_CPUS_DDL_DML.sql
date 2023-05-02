-- use ecf_sql_cpus;

DROP TABLE IF EXISTS production_done; 
DROP TABLE IF EXISTS production_lines; 
DROP TABLE IF EXISTS products;


CREATE TABLE products
(
	product_id INT PRIMARY KEY,
	product_name VARCHAR(128) NOT NULL,
	product_value INT NOT NULL,
);

CREATE TABLE production_lines
(
	line_id CHAR(3) PRIMARY KEY,
	line_label VARCHAR(50),
	product_id INT NOT NULL,
);

CREATE TABLE production_done
(
	forge_id INT PRIMARY KEY,
	forge_date DATE NOT NULL,
	forge_quantity INT NOT NULL, 
	line_id CHAR(3) NOT NULL,
	product_id INT NOT NULL,
);

ALTER TABLE production_lines 
	ADD CONSTRAINT FK_prods_lines FOREIGN KEY (product_id) REFERENCES products(product_id);

	
ALTER TABLE production_lines 
	ADD 
		CONSTRAINT FK_done_prods FOREIGN KEY (product_id) REFERENCES products(product_id),
		CONSTRAINT FK_done_lines FOREIGN KEY (line_id) REFERENCES production_lines(line_id);



INSERT INTO products 
(product_id, product_name, product_value) 
VALUES 
(1, 'Ryzen 3 3200G', 124),
(2, 'Ryzen 3 4100', 133),
(3, 'Ryzen 5 PRO', 219),
(4, 'Ryzen 5 5600', 289),
(5, 'Ryzen 7 5700X', 369),
(6, 'Ryzen 7 5800', 579),
(7, 'Ryzen 9 5950X', 759);


INSERT INTO production_lines
(line_id, line_label, product_id) 
VALUES 
('R3A', 'Ryzen LEGACY', 1),
('R3B', 'Ryzen MID', 2),
('R5A', 'Ryzen PRO', 3),
('R5B', 'Ryzen PRISM', 4),
('R7A', 'Ryzen XCOM', 5),
('R7B', 'Ryzen XD3', 6),
('R9Z', 'Ryzen LATEST', 7);


INSERT INTO production_done 
(forge_id, product_id, line_id, forge_date, forge_quantity) 
VALUES 
(3142, 1, 'R3A', '2022-04-29', 27),
(3143, 3, 'R5A', '2022-04-29', 31),
(3144, 3, 'R5A', '2022-05-02', 34),
(3145, 4, 'R5B', '2022-05-02', 16);


SELECT * FROM products;
SELECT * FROM production_lines;
SELECT * FROM production_done;
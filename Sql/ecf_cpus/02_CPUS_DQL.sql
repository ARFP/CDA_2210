-- use ecf_sql_cpus;

 

-- 1 Sélectionner tous les micro-processeurs triés par valeur commerciale (product_value). 

SELECT product_id, product_name, product_value FROM products ORDER BY product_value;

 

-- 2 Sélectionner les CPUs dont le nom se termine par la lettre « X ». 

SELECT product_id, product_name, product_value FROM products WHERE product_name LIKE '%X';
 


-- 3 Sélectionner les lignes de production dont le libellé contient la chaine « PR » 

SELECT line_id, line_label, product_id FROM production_lines WHERE line_label LIKE '%PR%';



-- 4 Sélectionnez le nom, le prix de tous les microprocesseurs. Pour chaque CPU listé, on doit connaitre le libellé de la ligne de production associée. 

SELECT product_name, product_value, line_label 
FROM products P JOIN production_lines PL ON P.product_id = PL.product_id;
 

-- 5 Sélectionner les productions terminées dont le nombre de CPU produits dépasse 20. 
-- La requête doit retourner le nom du CPU, son prix, le libellé de la ligne de production et le nombre d’unités produites.  

SELECT product_name, product_value, line_label, forge_quantity 
FROM production_done PD
JOIN production_lines PL ON PD.line_id = PL.line_id 
JOIN products P ON PD.product_id = P.product_id 
WHERE forge_quantity > 20;
 


-- 6 Sélectionner toutes les lignes de productions (identifiant, libellé) avec le nombre TOTAL d’unités produites par ligne de production 
-- ainsi que l’identifiant du CPU associé.  

SELECT PL.line_id, PL.line_label, SUM(forge_quantity) as forge_total, PL.product_id 
FROM production_lines PL
LEFT JOIN production_done PD ON PL.line_id = PD.line_id
GROUP BY PL.line_id, PL.line_label, PL.product_id ; 
 


-- 7 Même requête que la précédente mais en ne sélectionnant que les lignes de production qui ont produit au moins 1 unité. 

SELECT PL.line_id, PL.line_label, SUM(forge_quantity) as forge_total, PL.product_id 
FROM production_lines PL
JOIN production_done PD ON PL.line_id = PD.line_id
GROUP BY PL.line_id, PL.line_label, PL.product_id 
HAVING SUM(forge_quantity) > 0; 
 


-- 8 Afficher la valeur totale des CPUs produits avec le nom du CPU ayant rapporté le plus, toutes productions confondues. 

SELECT SUM(P.product_value * PD.forge_quantity) as 'PRODS_TOTAL_VALUE', P.product_name AS 'MOST_PROFITABLE_ITEM'
FROM production_done PD
JOIN products P ON PD.product_id = P.product_id 
GROUP BY P.product_name
ORDER BY 'PRODS_TOTAL_VALUE' DESC; 


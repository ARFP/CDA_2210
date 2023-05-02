USE bibli2210;

/*
  DQL :  Data Query Language
	SELECT
*/

-- Sélectionne toutes les lignes et toutes les colonnes
SELECT * FROM etats_livres; 

SELECT * FROM etats_livres WHERE etat_livre_id = 6;

SELECT * FROM etats_livres WHERE etat_livre_id < 6 AND etat_livre_id > 3;

SELECT * FROM etats_livres WHERE etat_livre_id BETWEEN 1 AND 4;

SELECT * FROM etats_livres WHERE etat_livre_id <> 5;

SELECT * FROM etats_livres WHERE etat_livre_id = 1 OR etat_livre_id = 2 OR etat_livre_id = 5;

SELECT * FROM etats_livres WHERE etat_livre_id IN(1,2,5); 

SELECT * FROM etats_livres WHERE etat_livre_id NOT IN(1,2,5);

SELECT * FROM etats_livres WHERE etat_livre_nom LIKE '%b%'; -- LIKE '%b%' = qui contient la lettre b 

SELECT * FROM etats_livres WHERE etat_livre_nom LIKE '%at'; -- LIKE '%at' = qui se termine par at 

SELECT * FROM etats_livres WHERE etat_livre_nom LIKE 'n%'; -- LIKE 'n%' = qui commence par n 

-- SELECT * FROM etats_livres WHERE etat_livre_nom LIKE '%[A-Za-z]%'; -- LIKE 'n%' = qui commence par n 





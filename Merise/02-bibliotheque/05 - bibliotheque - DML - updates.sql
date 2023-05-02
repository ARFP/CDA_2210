USE bibli2210;

-- Mettre à jour un enregistrement 

UPDATE auteurs 
SET auteur_nom='Bouchard' 
WHERE auteur_id = 2;

UPDATE auteurs 
SET auteur_nom='DEV', auteur_prenom='Toto'  
WHERE auteur_id = 1;

SELECT * FROM editeurs;
SELECT * FROM auteurs;
SELECT * FROM livres;
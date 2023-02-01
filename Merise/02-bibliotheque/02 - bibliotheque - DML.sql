USE bibli2210;

/*
  DML : Data Modeling Language
	INSERT : ins�rer des donn�es dans une table
	UPDATE : modifier des donn�es existantes dans une table
	DELETE : supprimer des donn�es d'une table 
	TRUNCATE : Vider une table et r�initialiser les compteurs (auto incr�ment) 
*/
-- vider une table et r�initialiser les compteurs
-- TRUNCATE TABLE editeurs;
-- TRUNCATE TABLE auteurs;

-- Supprimer les donn�es d'une table
-- les 2 isntructions suivantes remplacent le TRUNCATE (uniquement SQLSERVER)
DELETE FROM editeurs; -- supprimer toutes les donn�es de la table
DBCC CHECKIDENT('editeurs', RESEED, 0); -- r�initialise la colonne auto incr�ment�e

INSERT INTO editeurs 
(editeur_nom)
VALUES 
('toto'),
('titi'),
('tata');

DELETE FROM auteurs; -- supprimer toutes les donn�es de la table
DBCC CHECKIDENT('auteurs', RESEED, 0); 

INSERT INTO auteurs 
(auteur_prenom, auteur_nom)
VALUES 
('Mike', 'Devold�re'),
('G�rard', 'Rogne');

-- INSERT INTO auteurs VALUES ('Devold�re', 'Mike');

-- Mettre � jour un enregistrement 
UPDATE auteurs 
SET auteur_nom='Bouchard' 
WHERE auteur_id = 2;

UPDATE auteurs 
SET auteur_nom='DEV', auteur_prenom='Toto'  
WHERE auteur_id = 1;

SELECT * FROM editeurs;
SELECT * FROM auteurs;

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
DELETE FROM livres; -- supprimer toutes les donn�es de la table
DBCC CHECKIDENT('livres', RESEED, 0);  -- r�initialise la colonne auto incr�ment�e

DELETE FROM etats_livres; 
DBCC CHECKIDENT('etats_livres', RESEED, 0); 

DELETE FROM editeurs; 
DBCC CHECKIDENT('editeurs', RESEED, 0);

DELETE FROM auteurs; 
DBCC CHECKIDENT('auteurs', RESEED, 0);


INSERT INTO editeurs 
(editeur_nom)
VALUES 
('Les �ditions du plat pays'),
('Eyrolles'),
('Alsace Power');


INSERT INTO auteurs 
(auteur_prenom, auteur_nom)
VALUES 
('Pierre', 'Kiroul'),
('Paul', 'Hissage'),
('Jack', 'Adit');

-- INSERT INTO auteurs VALUES ('Devold�re', 'Mike');


INSERT INTO etats_livres 
(etat_livre_nom) 
VALUES 
('neuf'), -- etat_livre_id = 1
('tr�s bon �tat'),
('bon �tat'),
('bof'),
('ab�m�'),
('tr�s ab�m�'); -- etat_livre_id = 6


INSERT INTO livres 
(livre_isbn, livre_titre, livre_date_achat, etat_livre_id, editeur_id)
VALUES 
('479-1', 'SQL pour les nuls', '2022-01-31', 4, 3),
('478-2', 'Le cheval vert', '2022-05-17', 3, 1),
('478-3', 'Les avantures de Toto', '2022-05-21', 1, 2),
('479-4', 'Tintin chez les D�veloppeurs', '2022-06-03', 2, 3),
('479-5', 'A song of ice and fire', '2023-01-11', 2, 3);

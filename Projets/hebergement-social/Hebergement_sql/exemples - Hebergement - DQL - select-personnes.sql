-- use hebergement;

-- Sélectionner toutes les colonnes (*) et toutes les lignes de la table 'Personnes'
SELECT * FROM Personnes;

-- Sélectionner l'identifiant, le prénom et l nom de toutes les lignes de la table 'Personnes'
SELECT personne_id, personne_prenom, personne_nom FROM Personnes;


-- Identique à la requête précédente avec utilisation des alias 
-- (renommage des colonnes au moment de la restitution du résultat)
SELECT 
personne_id AS 'Identifiant', 
personne_prenom AS 'Prénom', 
personne_nom AS 'Son nom'
FROM Personnes; 

-- Sélectionner toutes les personnes et trier les résultats par prénom et par ordre croissant. 
SELECT * FROM Personnes 
ORDER BY personne_prenom ASC;

-- Sélectionner toutes les personnes dont la date de naissance est comprise entre A et B
SELECT * FROM Personnes 
WHERE personne_ddn >= '2000-01-01' AND personne_ddn <= '2005-12-31';

-- Sélectionner toutes les personnes dont la date de naissance est comprise entre A et B
SELECT * FROM Personnes 
WHERE personne_ddn BETWEEN '2000-01-01' AND '2005-12-31';

-- Sélectionner toutes les personnes dont le mois de naissance est égal à 11
SELECT * FROM Personnes 
WHERE personne_ddn LIKE '%-11-%';

-- Sélectionner toutes les personnes dont le mois de naissance est égal à 11
SELECT * FROM Personnes 
WHERE MONTH(personne_ddn) = '11';

-- Sélectionner identifiant, nom, (prenom, date de naissance) 
-- des personnes dont l'identifiant est supérieur à 5 
SELECT TOP (2)
personne_id AS 'id',
personne_prenom AS 'Prénom',
CONCAT(personne_nom, ' ', personne_ddn) AS 'nom et date de naissance'
FROM personnes 
WHERE personne_id > 5 
ORDER BY personne_nom DESC;

-- Ne faites pas ça !
SELECT * FROM Personnes, Roles 
ORDER BY personne_id;

-- Séléctionne lepersonnes en joignant les informations de leurs rôles respecteifs
SELECT * FROM Personnes 
INNER JOIN Roles ON Personnes.role_id = Roles.role_id
WHERE personne_id = 4;

/*
SELECT * FROM Personnes 
NATURAL JOIN Roles 
WHERE personne_id = 4;
*/
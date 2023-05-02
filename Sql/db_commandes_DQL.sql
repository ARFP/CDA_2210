/*
SELECT 'toto';

SELECT HASHBYTES('SHA1', 'toto');
*/

UPDATE 
commande_ligne
SET 
prix_total = 3, prix_unitaire = '1'
WHERE id = 1;

UPDATE 
commande_ligne
SET 
prix_total = quantite + prix_unitaire;


UPDATE 
commande 
SET 
cache_prix_total = 
	(
		SELECT SUM(prix_total) as toto 
		FROM commande_ligne 
		WHERE commande_ligne.commande_id = commande.id
	)
;


UPDATE 
commande 
SET 
cache_prix_total = 
	(
		SELECT SUM(quantite * prix_unitaire) as toto 
		FROM commande_ligne 
		WHERE commande_ligne.commande_id = commande.id
	)
;


select distinct T1.nom, string_agg(T1.commande_id, ', ') 
from commande_ligne as T1
join commande_ligne as T2
on T1.commande_id <> T2.commande_id and T1.nom=T2.nom
group by T1.nom;



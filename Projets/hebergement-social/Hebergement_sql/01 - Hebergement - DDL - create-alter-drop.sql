-- use hebergement;

DROP TABLE IF EXISTS Personnes_Activites;
DROP TABLE IF EXISTS Activites;
DROP TABLE IF EXISTS Type_Activites;
DROP TABLE IF EXISTS Residents;
DROP TABLE IF EXISTS Residents_Activites;
DROP TABLE IF EXISTS Etats;
DROP TABLE IF EXISTS Personnes;
DROP TABLE IF EXISTS Roles;

CREATE TABLE Roles
(
	role_id INT IDENTITY(1,1) PRIMARY KEY,
	role_nom VARCHAR(25) NOT NULL UNIQUE
	-- UNIQUE(role_nom)
);

CREATE TABLE Personnes 
(
	personne_id INT IDENTITY(1,1),
	personne_nom VARCHAR(50) NOT NULL,
	personne_prenom VARCHAR(50) NOT NULL,
	personne_ddn DATE NOT NULL,
	role_id INT NOT NULL,
	PRIMARY KEY (personne_id)
);

CREATE TABLE Etats 
(
	etat_id INT IDENTITY(1,1),
	etat_intitule VARCHAR(25),
	PRIMARY KEY (etat_id)
);

CREATE TABLE Type_Activites 
(
	type_activite_id INT IDENTITY,
	type_activite_nom VARCHAR(50) NOT NULL
	PRIMARY KEY (type_activite_id)
);

CREATE TABLE Activites
(
	activite_id INT IDENTITY(1,1),
	activite_intitule VARCHAR(100) NOT NULL,
	activite_debut DATETIME2 NOT NULL ,
	activite_fin DATETIME2 NOT NULL, -- CHECK(activite_fin > activite_debut),
	type_activite_id INT NOT NULL,
	etat_id INT NOT NULL,
	PRIMARY KEY (activite_id),
	FOREIGN KEY (type_activite_id) REFERENCES Type_Activites(type_activite_id),
	FOREIGN KEY (etat_id) REFERENCES Etats(etat_id)
);

CREATE TABLE Residents(
   resident_id INT IDENTITY,
   resident_date_arrivee DATETIME2 NOT NULL,
   resident_date_depart DATETIME2,
   resident_num_chambre SMALLINT NOT NULL,
   resident_date_visite_med DATETIME2 NOT NULL,
   resident_besoins_medicaux VARCHAR(max),
   medecin_id INT NULL, -- médecin qui assure le suivi (facultatif)
   medecin_consultation INT NOT NULL, -- médecin qui a consulté le résident à son arrivée
   personne_id INT NOT NULL -- etat civil du résident,
   PRIMARY KEY(resident_id),
   UNIQUE(personne_id),
   FOREIGN KEY(medecin_id) REFERENCES Personnes(personne_id),
   FOREIGN KEY(medecin_consultation) REFERENCES Personnes(personne_id),
   FOREIGN KEY(personne_id) REFERENCES Personnes(personne_id)
);


CREATE TABLE Residents_Activites 
(
	resident_id INT,
	activite_id INT,
	PRIMARY KEY (resident_id, activite_id)
);

CREATE TABLE Personnes_Activites(
   personne_id INT,
   activite_id INT,
   PRIMARY KEY(personne_id, activite_id),
   FOREIGN KEY(personne_id) REFERENCES Personnes(personne_id),
   FOREIGN KEY(activite_id) REFERENCES Activites(activite_id)
);


-- ALTER TABLE Residents_Activites 
-- 	ADD PRIMARY KEY (resident_id, activite_id);






ALTER TABLE Personnes 
	ADD FOREIGN KEY (role_id) REFERENCES Roles(role_id);




-- ALTER TABLE etats ADD PRIMARY KEY (etat_id);
-- ALTER TABLE etats ADD CONSTRAINT PK_etats PRIMARY KEY (etat_id);
-- ALTER TABLE etats DROP CONSTRAINT PK_etats;


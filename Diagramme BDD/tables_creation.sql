CREATE TABLE Pizza(
   id INT,
   nom VARCHAR(50),
   prix DECIMAL(15,2),
   PRIMARY KEY(id)
);

CREATE TABLE Client(
   id INT,
   nom VARCHAR(50),
   prenom VARCHAR(50),
   telephone INT,
   adresse VARCHAR(50),
   code_postal VARCHAR(50),
   ville VARCHAR(50),
   PRIMARY KEY(id)
);

CREATE TABLE Commande(
   num_commande INT,
   date_ DATE,
   emporter binary,
   id INT NOT NULL,
   id_1 INT NOT NULL,
   PRIMARY KEY(num_commande),
   UNIQUE(id),
   FOREIGN KEY(id) REFERENCES Client(id),
   FOREIGN KEY(id_1) REFERENCES Pizza(id)
);


-- Pizza = (id INT, nom VARCHAR(50), prix DECIMAL(15,2));
-- Client = (id INT, nom VARCHAR(50), prenom VARCHAR(50), telephone INT, adresse VARCHAR(50), code_postal VARCHAR(50), ville VARCHAR(50));
-- Commande = (num_commande INT, date_ DATE, emporter binary, #id, #id_1);

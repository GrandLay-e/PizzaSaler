CREATE TABLE Pizza (
   id_pizza INT IDENTITY(1,1) PRIMARY KEY,  
   nom VARCHAR(50),
   prix DECIMAL(15,2)
);

CREATE TABLE Client (
   id_client INT IDENTITY(1,1) PRIMARY KEY, 
   nom VARCHAR(50),
   prenom VARCHAR(50),
   telephone VARCHAR(50),
   adresse VARCHAR(50),
   code_postal VARCHAR(10),  
   ville VARCHAR(50)
);

CREATE TABLE Commande (
   num_commande INT IDENTITY(1,1) PRIMARY KEY,  
   date_ DATE,
   emporter BIT,
   id_client INT NOT NULL,
   FOREIGN KEY(id_client) REFERENCES Client(id_client)
);

CREATE TABLE Gestion (
   id_pizza INT,
   num_commande INT,
   quantite INT,
   PRIMARY KEY(id_pizza, num_commande),
   FOREIGN KEY(id_pizza) REFERENCES Pizza(id_pizza),
   FOREIGN KEY(num_commande) REFERENCES Commande(num_commande)
);


CREATE INDEX idx_id_pizza ON Gestion(id_pizza);
CREATE INDEX idx_num_commande ON Gestion(num_commande);
CREATE INDEX idx_id_client ON Commande(id_client);


-- Pizza = (id_pizza INT, nom VARCHAR(50), prix DECIMAL(15,2));
-- Client = (id_client INT, nom VARCHAR(50), prenom VARCHAR(50), telephone VARCHAR(50), adresse VARCHAR(50), code_postal VARCHAR(50), ville VARCHAR(50));
-- Commande = (num_commande INT, date_ DATE, emporter BOOLEAN, #id_client);
-- Gestion = (#id_pizza, #num_commande, quantite INT);


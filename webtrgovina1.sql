--create database webtrgovina1;
--go
--drop database webtrgovina1;

use webtrgovina1;


create table kupci(
kupacID INT PRIMARY KEY,
ime VARCHAR(100),
Email VARCHAR(100),
adresa VARCHAR(255)
);


create table proizvodi (
proizvodID int primary key,
ime VARCHAR(100),
vrste varchar(50),
cijena DECIMAL(10, 2),
opis TEXT
);

create table narudzbe (
narudzbaID INT PRIMARY KEY,
kupacID INT,
datumnarudzbe DATE,
FOREIGN KEY (kupacID) REFERENCES kupci(kupacID)   
);

create table detaljinarudzbe (
detaljinarudzbeID INT PRIMARY KEY,
narudzbaID INT,
proizvodID INT,
kolicina INT
FOREIGN KEY (narudzbaID) REFERENCES narudzbe(narudzbaID),
FOREIGN KEY (proizvodID) REFERENCES proizvodi(proizvodID)
);




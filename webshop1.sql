--drop database if exists webshop1;
--go

--create database webshop1;
--go

--use webshop1;

--create table narudzba(
--sifra int not null primary key identity(1,1),
--kupac int not null,
--datumnarudzbe datetime,
--datumdostave datetime,
--placanje varchar(50) not null,
--ukupaniznos decimal(18,2)
--);

--create table detaljinarudzbe(
--sifra int not null primary key identity,
--narudzba int,
--proizvod int not null,
--kolicina varchar(999), 
--cijena decimal(18,2)
--);

--create table kupac(
--sifra int not null primary key identity,
--ime varchar(50) not null,
--prezime varchar(50) not null,
--email varchar(100) not null,
--adresa varchar(100) not null,
--telefon varchar(20) 
--);

--create table proizvod(
--sifra int not null primary key identity,
--naziv varchar(50) not null,
--vrsta varchar(50) not null,
--cijena decimal(18,2)
--);

--alter table narudzba add foreign key (kupac) references kupac(sifra);
--alter table detaljinarudzbe add foreign key (narudzba) references narudzba(sifra);
--alter table detaljinarudzbe add foreign key (proizvod) references proizvod(sifra);



use BDW56_424q

drop table FilmsActeurs
drop table FilmsSupplements
drop table FilmsLangues
drop table FilmsSousTitres
drop table Acteurs
drop table Supplements
drop table Langues
drop table SousTitres
drop table Films
drop table EmpruntsFilms
drop table Exemplaires
drop table UtilisateursPreferences
drop table Utilisateurs
drop table ValeursPreferences
drop table TypesUtilisateurs
drop table Preferences
drop table Categories
drop table Formats
drop table Realisateurs
drop table Producteurs

create table Acteurs(
	NoActeur int Primary key identity,
	Nom nvarchar(50),
	Sexe nchar(1)
)

create table Supplements(
	NoSupplement int primary key identity,
	Description nvarchar(50)
)

create table Langues(
	NoLangue int primary key identity,
	Langue nvarchar(10)
)

create table SousTitres(
	NoSousTitre int primary key identity,
	LangueSousTitre nvarchar(10)
)

create table Categories(
	NoCategorie int primary key identity,
	Description nvarchar(50)
)

create table Formats(
	NoFormat int primary key identity,
	Description nvarchar(50)
)

create table Realisateurs(
	NoRealisateur int primary key identity,
	Nom nvarchar(50)
)

create table Producteurs(
	NoProducteur int primary key identity,
	Nom nvarchar(50)
)

create table TypesUtilisateurs(
	TypeUtilisateur nchar(1) primary key,
	Description nvarchar(25)
)

create table Utilisateurs(
	NoUtilisateur int primary key identity,
	NomUtilisateur nvarchar(10),
	Courriel nvarchar(50),
	MotPasse int,
	TypeUtilisateur nchar(1),
	foreign key(TypeUtilisateur) references TypesUtilisateurs(TypeUtilisateur)
)

create table Films(
	NoFilm int primary key identity,
	AnneeSortie int,
	Categorie int,
	Format int,
	DataMAJ datetime,
	NoUtilisateurMAJ int,
	Resume nvarchar(500),
	DureeMinutes int,
	FilmOriginal bit,
	ImagePochette nvarchar(50),
	NbDisques int,
	TitreFrancais nvarchar(50),
	TitreOriginal nvarchar(50),
	VersionEtendue bit,
	NoRealisateur int,
	NoProducteur int,
	Xtra nvarchar(255),
	foreign key(Categorie) references Categories(NoCategorie),
	foreign key(Format) references Formats(NoFormat),
	foreign key(NoProducteur) references Producteurs(NoProducteur),
	foreign key(NoRealisateur) references Realisateurs(NoRealisateur),
	foreign key(NoUtilisateurMAJ) references Utilisateurs(NoUtilisateur)
)

create table FilmsActeurs(
	NoFilm int,
	NoActeur int,
	Primary key(NoFilm, NoActeur),
	foreign key(NoActeur) references Acteurs(NoActeur),
	foreign key(NoFilm) references Films(NoFilm)
)

create table FilmsLangues(
	NoFilm int,
	NoLangue int,
	primary key(NoFilm, NoLangue),
	foreign key (NoLangue) references Langues(NoLangue),
	foreign key(NoFilm) references Films(NoFilm)
)

create table FilmsSousTitres(
	NoFilm int,
	NoSousTitre int,
	primary key(NoFilm, NoSousTitre),
	foreign key (NoSousTitre) references SousTitres(NoSousTitre),
	foreign key(NoFilm) references Films(NoFilm)
)
create table FilmsSupplements(
	NoFilm int ,
	NoSupplement int,
	primary key (NoFilm, NoSupplement),
	foreign key(NoSupplement) references Supplements(NoSupplement),
	foreign key(NoFilm) references Films(NoFilm)
)

create table Exemplaires(
	NoExemplaire int primary key identity,
	NoUtilisateurProprietaire int,
	foreign key (NoUtilisateurProprietaire) references Utilisateurs(NoUtilisateur)
)

create table EmpruntsFilms(
	NoExemplaire int primary key identity,
	NoUtilisateur int,
	DateEmprunt datetime,
	foreign key (NoExemplaire) references Exemplaires(NoExemplaire),
	foreign key (NoUtilisateur) references Utilisateurs(NoUtilisateur)
)

create table Preferences(
	NoPreference int primary key identity,
	Description nvarchar(50)
)

create table UtilisateursPreferences(
	NoUtilisateur int,
	NoPreference int,
	primary key(NoUtilisateur,NoPreference),
	foreign key (NoPreference) references Preferences(NoPreference),
	foreign key (NoUtilisateur) references Utilisateurs(NoUtilisateur)
)

create table ValeursPreferences(
	NoUtilisateur int,
	NoPreference int,
	Valeur nvarchar(50),
	primary key (NoUtilisateur, NoPreference),
)
alter table ValeursPreferences add foreign key (NoUtilisateur, NoPreference) references UtilisateursPreferences(NoUtilisateur, NoPreference)


insert into TypesUtilisateurs (TypeUtilisateur, Description) values ('A','Administrateur')
insert into TypesUtilisateurs (TypeUtilisateur, Description) values ('S','Super utilisateur')
insert into TypesUtilisateurs (TypeUtilisateur, Description) values ('U','Utilisateur')

insert into Utilisateurs (NomUtilisateur,Courriel,MotPasse,TypeUtilisateur) values ('admin','fasanterre@hotmail.com',99999,'A')
insert into Utilisateurs (NomUtilisateur,Courriel,MotPasse,TypeUtilisateur) values ('SuperFelix','fasanterre@hotmail.com',11111,'S')
insert into Utilisateurs (NomUtilisateur,Courriel,MotPasse,TypeUtilisateur) values ('Felix','fasanterre@hotmail.com',22222,'U')
--------------------------INSERT QUERY MAGAZYN--------------------------------
USE Baza_szwalnia
INSERT INTO 
	Polki_rozmiary (Wysokosc,Szerokosc,Glebokosc)
VALUES
	(100,100,100),
	(200,200,200),
	(200,300,100),
	(100,300,100),
	(500,500,100)
INSERT INTO 
Elementy_Typy (Typ)
VALUES
	('Czesci maszyn'),
	('Tkanina'),
	('Nici'),
	('Guziki'),
	('Opakowania')
INSERT INTO 
	Elementy_Jednostki (Jednostka)
VALUES
	('mm'),
	('cm'),
	('m'),
	('m2'),
	('mb'),
	('cal'),
	('kg'),
	('szt')
INSERT INTO 
	Elementy_Cechy_Slownik (Cecha)
VALUES
	('Grubosc'),
	('Dlugosc'),
	('Szerokosc'),
	('Srednica'),
	('Waga'),
	('Kolor'),
	('Org. oznaczenie'),
	('Material'),
	('Splot')
INSERT INTO 
	Polki (ID_Rozmiar_Polki)
VALUES
	(1),
	(1),
	(1),
	(1),
	(2),
	(3),
	(3),
	(4),
	(5),
	(5),
	(5),
INSERT INTO 
	Dostawcy_Zaopatrzenie (Nazwa,Telefon_1,Telefon_2,Email)
VALUES
	('Janex',555222999,789456123,'janexhandel@janex.pl'),
	('PolMat',888666444,159753864,'polmat@wp.pl')
INSERT INTO 
	Dostawcy_Zaopatrzenie (Nazwa,Telefon_1,Email)
VALUES
	('MaterialX',999666333,'materialy@mat.pl'),
	('GuzikProd',777444111,'guzpro@guzpro.pl'),
	('HurtMat',000555444,'zamow@hurtmat.pl')
INSERT INTO 
	Kurierzy (Nazwa,Telefon_1,Telefon_2,Email)
VALUES
	('PoczteX',545656022,987111222,'barbara@poczta.pl'),
	('DHL',764985132,733433133,'wysylka@dhl.pl'),
	('JanuszPrzesylki',111111111,1111111112,'janusz@onion.pl')
INSERT INTO 
	Kurierzy (Nazwa,Telefon_1,Email)
VALUES
	('DPD',505015145,'darbur@dpd.pl'),
	('SpeedeX',964746852,'truespeed@lan.pl')
INSERT INTO 
	Miejsca (Nazwa)
VALUES
	('Magazyn'),
	('Produkcja'),
	('Utrzymanie ruchu'),
	('Biuro'),
	('Dzial finansow')
INSERT INTO
	Elementy (
	ID_Element_Typ,Element_Nazwa,
	Okres_Przydatnosci_Miesiace,Element_Ilosc_W_Paczce,ID_Jednostka)
VALUES
	(1,'£o¿ysko',24,1,2),
	(2,'Bawe³na',48,100,1),
	(3,'Bawe³na',48,1000,4),
	(4,'Guzik',0,100,5),
	(5,'Tektura falista',0,100,2),
	(1,'Sruba',0,10,3),
	(1,'Bêbenek',48,1,2),
	(1,'Igla do dzianin',0,10,2),
	(1,'Kolo pasowe',0,5,2)
INSERT INTO 
	Elementy_Cechy (ID_Element,ID_Cecha,Wartosc_Cechy_Liczbowa,ID_Jednostka,Wartosc_Cechy_Slowna)
VALUES
	(1,4,17,1,null),
	(2,3,120,2,null),
	(3,6,null,null,'660033'),
	(4,4,12,1,null),
	(5,1,3,1,null),
	(6,2,39,1,null),
	(7,1,null,'RS/003-11'),
	(8,6,null,'Zloty'),
	(9,7,null,'07/28061')
INSERT INTO 
	Umowy_Kurierzy (ID_Kurier,Data_Zawarcia,Czas_Dostawy,Koszt_Km,Koszt_Staly)
VALUES
	(1,'2020-04-08',48,1.8,20),
	(2,'2020-04-01',72,1,0),
	(3,'2020-04-05',24,0,50),
	(4,'2020-03-15',12,5,10),
	(5,'2020-03-25',24,1.05,0)
INSERT INTO
	Oferta (ID_Element,Element_Oznaczenie,ID_Dostawcy,Cena_Jedn,Data_Oferty,Ilosc_Minimalna,Ilosc_Maksymalna,Ilosc_W_Opakowaniu_Zbiorczym)
	--zastanawiam siê, czy iloœæ w opakowaniu zbiorczym jest konieczna? Wprowadza niepewnoœæ - iloœæ minimalna to ilosc paczek? Iloœæ paczek w paczkach? To nie czteropak coli
VALUES
	(1,HDK321122,2,2.2,'2020-03-08',10,1000,5),
	(1,PL2403,4,3.15,'2020-03-12',2,500,2),
	(1,L09P9,5,2.05,'2020-04-08',12,1800,5),
	(2,Bw7441,2,18.30,'2020-03-19',2,40,2),
	(2,Egyp321,22.30,'2020-05-09',1,1000,2),
	(2,Ctt234,2,2.2,'2020-04-30',10,1000,2)

/*sample code
INSERT INTO 
	Polki (ID_Rozmiar_Polki)
VALUES
	(''),
	(''),
	(''),
	(''),
	('')
*/
/*sample code
USE Baza_szwalnia
SELECT * FROM 


*/
USE Master
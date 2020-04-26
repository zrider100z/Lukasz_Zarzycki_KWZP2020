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
	('Opakowania'),
	('Gumka')
INSERT INTO 
	Elementy_Jednostki (Jednostka)
VALUES
	('m2'),
	('mb'),
	('kg'),
	('m'),
	('szt'),
	('cal')
INSERT INTO 
	Elementy_Cechy_Slownik (Cecha)
VALUES
	('Grubosc'),
	('Dlugosc'),
	('Waga'),
	('Kolor'),
	('Szerokosc'),
	('Org. oznaczenie'),
	('Material'),
	('Splot'),
	('Wysokosc')
INSERT INTO 
	Polki (ID_Rozmiar_Polki)
VALUES
	(1),
	(2),
	(3),
	(4),
	(5)
INSERT INTO 
	Dostawcy_Zaopatrzenie (Nazwa,Telefon_1,Telefon_2,Email)
VALUES
	('Janex',555222999,789456123,'janexhandel@janex.pl'),
	('PolMat',888666444,159753864,'polmat@wp.pl'),
	('JanuszeDostawy', 455719998, 500687214, 'januszwalczuk@wp.pl'),
	('PolHurt', 987619423, 598277243, 'dostawcy@polhurt.pl'),
	('BestMaks', 600869875, 533987137,'m.korbka@bestmaks-dostawcy.pl'),
	('AlleLogistics', 997644654, 498755653, 'allekontakt@gmail.com'),
	('Tanio&Bezpiecznie', 666997420, 4206998654, 'kontakt@taniocha.pl')
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
	('JanuszPrzesylki',111111111,1111111112,'janusz@onion.pl'),
	('TNT', 444888354, 789343190, 'krzysztof.zalewski@tntpaczki.com'),
	('Paczka w RUCHu', 500333505, 155987515, 'pomoc@paczki.ruch.pl'),
	('Inpost', 714800800, 567787333, 'twojkurier@inpost.com')
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
	(1,'£o¿ysko',24,1,5),
	(2,'Bawe³na',48,100,1),
	(3,'Bawe³na',48,1000,4),
	(4,'Okr¹g³e',0,100,5),
	(5,'Tektura falista',0,100,2),
	(1,'Sruba',0,10,3),
	(1,'Bêbenek',48,1,5),
	(1,'Igla do dzianin',0,10,5),
	(1,'Kolo pasowe',0,5,5),
	(5,'Karton klapowy',0,100,5),
	(5,'Foliopaki',48,100,5)
INSERT INTO 
	Elementy_Cechy (ID_Element,ID_Cecha,Wartosc_Cechy_Liczbowa,Wartosc_Cechy_Slowna)
VALUES
	(1,3,0.2,null),
	(2,5,1.6,null),
	(3,4,null,'660033'),
	(4,1,2,null),
	(5,1,3,null),
	(6,2,6.5,null),
	(7,6,null,'RS/003-11'),
	(8,7,null,'Zloty'),
	(9,6,null,'07/28061'),
	(10,9,100),
	(10,2,100),
	(10,5,100),
	(11,2,40),
	(11,5,40)
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
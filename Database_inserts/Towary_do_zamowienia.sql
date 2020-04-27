--towary ktore trzeba zamowic i ilosci
--towary, których stan magazynowy jest mniejszy ni¿ minimalna iloœæ zamówienia
SELECT Stan_magazynu.ID_Element, Zapotrzebowanie_zamowien.Suma_potrzebnych-Stan_magazynu.Ilosc_calkowita AS Brak_ilosc 
FROM
	(
	SELECT Elementy.ID_Element, Element_Nazwa, Ilosc_paczek_total, Ilosc_paczek_total*Element_Ilosc_W_Paczce AS Ilosc_calkowita, Jednostka 
		FROM 
		(
			SELECT Elementy.ID_Element, SUM( Ilosc_Paczek) AS Ilosc_paczek_total  
			FROM Zawartosc 
			INNER JOIN Elementy 
			ON Zawartosc.ID_Element=Elementy.ID_Element 
			GROUP BY Elementy.ID_Element
		) Stan 
			INNER JOIN Elementy 
			ON Stan.ID_Element=Elementy.ID_Element 
			INNER JOIN Elementy_Jednostki 
			ON Elementy.ID_Jednostka=Elementy_Jednostki.ID_jednostka 
	) Stan_magazynu 
	INNER JOIN (SELECT ID_element, SUM(Liczba) AS Suma_potrzebnych 
				FROM 
				(
				SELECT ID_zamowienia, Elementy_Proces.ID_element, Liczba 
				FROM Zamowienie_Produkt
				INNER JOIN Proces_Zamowienie
				ON Zamowienie_Produkt.ID = Proces_Zamowienie.ID_Zamowienie_Produkty
				INNER JOIN Elementy_proces
				ON Proces_Zamowienie.ID_Proces_Technologiczny = Elementy_Proces.ID_Proces_Technologiczny				
				) Lista_zapotrzebowania
				GROUP BY ID_element) Zapotrzebowanie_zamowien 
	ON Stan_magazynu.ID_Element=Zapotrzebowanie_zamowien.ID_element
WHERE Stan_magazynu.Ilosc_calkowita < Zapotrzebowanie_zamowien.Suma_potrzebnych
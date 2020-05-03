--najtañszy dostawca WG produktu
SELECT Nazwa, Oferta.ID_dostawcy, Ranking.ID_element, Ranking.Cena AS Cena_jednostkowa FROM(
		SELECT ID_Element, MIN(Cena_Jedn) FROM Oferta GROUP BY ID_Element
		) Ranking (ID_element, Cena) 
		INNER JOIN 
			Oferta ON Oferta.ID_Element = Ranking.ID_element AND Ranking.Cena = Oferta.Cena_Jedn
		INNER JOIN 
			Dostawcy_Zaopatrzenie ON Dostawcy_Zaopatrzenie.ID_Dostawcy = Oferta.ID_Dostawcy
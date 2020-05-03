--procent zajecia polek
DECLARE @ilosc_polek real = (SELECT COUNT(ID_Polka) FROM Polki)
DECLARE @ilosc_polek_zajetych real = (SELECT Count(ID_Polka) FROM Zawartosc)
DECLARE @procent_zajetych decimal(4,2) = (@ilosc_polek_zajetych*100/@ilosc_polek)
PRINT @procent_zajetych
DECLARE @ilosc_polek_wolnych int = @ilosc_polek - @ilosc_polek_zajetych
PRINT @ilosc_polek_wolnych
--wolne polki
SELECT ID_Polka AS Nr_wolnej_polki, Wysokosc, Szerokosc, Glebokosc FROM Polki
RIGHT JOIN Polki_Rozmiary ON Polki_Rozmiary.ID_Rozmiar_Polki=Polki.ID_Rozmiar_Polki
WHERE ID_polka NOT IN (SELECT ID_Polka FROM Zawartosc)
--procent zajecia polek
DECLARE @ilosc_polek real = (SELECT COUNT(ID_Polka) FROM Polki)
DECLARE @ilosc_polek_zajetych real = (SELECT Count(ID_Polka) FROM Zawartosc)
DECLARE @procent_zajetych decimal(4,2) = (@ilosc_polek_zajetych*100/@ilosc_polek)
PRINT @procent_zajetych
--wolne polki
SELECT ID_Polka FROM Polki WHERE ID_polka NOT IN (SELECT ID_Polka FROM Zawartosc) 
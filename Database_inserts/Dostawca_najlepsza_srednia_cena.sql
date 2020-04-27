--------------dostawca z najlepsza srednia cena ---------------------
--Temporary ranking table
CREATE TABLE #Ranking_sredni (
ID_ranking int IDENTITY(1,1) PRIMARY KEY,
ID_element int,
ID_dostawcy int,
Mark real
)
--Counter for while loop declared
DECLARE @counter INT = 0
--Teomporary amount of offers table created to work as a yardstick
CREATE TABLE #Ilosc_ofert (
ID_ilosc_ofert int IDENTITY(1,1) PRIMARY KEY,
ID_element int,
Ilosc int
)
--Table inserted with amount of offers for each item
INSERT INTO #Ilosc_ofert (ID_element, Ilosc)
SELECT ID_element, COUNT(ID_Dostawcy)
FROM Oferta
GROUP BY ID_Element
--While loop to make a coherent ranking
WHILE @counter < (SELECT MAX(ID_element) FROM Oferta)
BEGIN
	set @counter = @counter+1
	--Insert into ranking
	INSERT INTO #Ranking_sredni (ID_element, ID_Dostawcy, Mark)
	--element ID as counter, supplier ID, scaled rank
	SELECT @counter, Ranking.ID_Dostawcy, RANK() OVER (ORDER BY Cena_Jedn DESC)*100/(SELECT Ilosc FROM #Ilosc_ofert WHERE ID_element = @counter)    --ROW_NUMBER() OVER (ORDER BY ID_oferta) AS Mark 
	FROM (
		SELECT ID_oferta, ID_Dostawcy, Cena_Jedn FROM Oferta WHERE ID_element = @counter --ORDER BY Cena_Jedn
	) Ranking
END;
--This select returns the final ranking
SELECT Nazwa, MidSelect.ID_dostawcy AS ID_dostawcy, Score 
	FROM (
		SELECT ID_Dostawcy, SUM(Mark) AS Score 
			FROM #Ranking_sredni 
			GROUP BY ID_dostawcy 
	) MidSelect INNER JOIN Dostawcy_Zaopatrzenie 
	ON Dostawcy_Zaopatrzenie.ID_Dostawcy = MidSelect.ID_dostawcy 
	ORDER BY Score DESC
DROP TABLE #Ranking_sredni
DROP TABLE #Ilosc_ofert 
GO
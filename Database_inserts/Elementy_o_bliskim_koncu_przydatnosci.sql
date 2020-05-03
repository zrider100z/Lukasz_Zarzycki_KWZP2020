-- wybieranie tych elementow ktorych okres przydatnosci < 2 miesiace
SELECT Element_Nazwa, Okres_Przydatnosci_Miesiace, Data_Dostawy_Rzeczywista 
FROM Elementy INNER JOIN (SELECT ID_Element, Data_Dostawy_Rzeczywista 
FROM Dostawy_Zawartosc INNER JOIN Zamowienia_Dostawy
ON Dostawy_Zawartosc.ID_Dostawy=Zamowienia_Dostawy.ID_Dostawy) AS x
ON Elementy.ID_Element=x.ID_Element
WHERE DATEDIFF(MONTH,GETDATE(), DATEADD(MONTH, Okres_Przydatnosci_Miesiace, Data_Dostawy_Rzeczywista))<2 
AND Okres_Przydatnosci_Miesiace>0;
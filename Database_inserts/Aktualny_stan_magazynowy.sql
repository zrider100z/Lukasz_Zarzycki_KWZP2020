--aktualny stan magazynowy
SELECT Elementy.ID_Element, Element_Nazwa, Ilosc_paczek_total, Ilosc_paczek_total*Element_Ilosc_W_Paczce AS Ilosc_calkowita, Jednostka FROM (
SELECT Elementy.ID_Element, SUM( Ilosc_Paczek) AS Ilosc_paczek_total  From Zawartosc INNER JOIN Elementy ON Zawartosc.ID_Element=Elementy.ID_Element GROUP BY Elementy.ID_Element
) Stan INNER JOIN Elementy ON Stan.ID_Element=Elementy.ID_Element INNER JOIN Elementy_Jednostki ON Elementy.ID_Jednostka=Elementy_Jednostki.ID_jednostka
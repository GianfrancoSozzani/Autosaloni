ALTER PROCEDURE [dbo].[MARCHE_SelectAll]
AS
BEGIN
select K_Marca, Marca
from MARCHE
order by Marca
END
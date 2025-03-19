ALTER PROCEDURE [dbo].[MARCHE_CheckRedundantRecords]
(
	@chiave int,
	@marca nvarchar(50)
)
AS
BEGIN
	select K_Marca, Marca
	from MARCHE
	where K_Marca != @chiave and Marca = @Marca
END
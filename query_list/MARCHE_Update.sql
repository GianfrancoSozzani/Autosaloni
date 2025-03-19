ALTER procedure [dbo].[MARCHE_Update]
(
	@chiave int,
	@marca nvarchar(50)
)
AS 
BEGIN
	update MARCHE
		set
			Marca = @marca
		where K_Marca = @chiave
END
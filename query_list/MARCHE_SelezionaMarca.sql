ALTER procedure [dbo].[MARCHE_SelezionaMarca]
(
	@marca nvarchar(50)
)
AS
BEGIN
	select Marca
	from MARCHE
	where Marca = @marca
END
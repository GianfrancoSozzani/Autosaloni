ALTER PROCEDURE [dbo].[MODELLI_SelezionaModello]
(
	@marca int,
	@modello nvarchar(50)
)
AS
BEGIN
	select Modello, K_Marca
	from MODELLI
	where Modello = @modello and K_Marca = @marca
END
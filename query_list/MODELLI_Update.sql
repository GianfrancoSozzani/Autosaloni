ALTER procedure [dbo].[MODELLI_Update]
(
	@chiave int,
	@marca int,
	@modello nvarchar(50)
)
AS
BEGIN
	update MODELLI 
	set K_Marca = @marca, 
		Modello = @modello
	where K_Modello = @chiave
END
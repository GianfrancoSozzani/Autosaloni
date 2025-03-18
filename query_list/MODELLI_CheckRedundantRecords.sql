ALTER PROCEDURE [dbo].[MODELLI_CheckRedundantRecords]
(
	@chiave int,
	@modello nvarchar(50),
	@marca int
)
AS
BEGIN
	select Modello, K_Marca 
	from MODELLI
	where K_Modello = @chiave and K_Marca = @marca and Modello = @modello
END
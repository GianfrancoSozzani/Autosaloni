ALTER PROCEDURE [dbo].[MODELLI_Inserimento]
(
	@marca int,
	@modello nvarchar(50)
)
AS
BEGIN
	insert into MODELLI
	(Modello, K_Marca)
	values 
		(@modello, @marca)
END
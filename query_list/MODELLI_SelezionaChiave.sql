ALTER procedure [dbo].[MODELLI_SelezionaChiave]
(
	@chiave int
)
AS
BEGIN
	select K_Modello, Modello, K_Marca
	from MODELLI
	where K_Modello = @chiave
END
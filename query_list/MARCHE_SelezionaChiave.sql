ALTER procedure [dbo].[MARCHE_SelezionaChiave]
(
	@chiave int
)
AS
BEGIN
	select K_Marca, Marca
	from MARCHE
	where K_Marca = @chiave
END
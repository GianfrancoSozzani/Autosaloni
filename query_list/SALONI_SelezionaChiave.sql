ALTER procedure [dbo].[SALONI_SelezionaChiave]
(
	@chiave int
)
as
begin 
	select Nome_Salone,
		Indirizzo,
		CAP,
		Citta,
		Provincia
	from SALONI
	where K_Salone = @chiave
end
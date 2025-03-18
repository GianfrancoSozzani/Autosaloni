ALTER PROCEDURE [dbo].[CLIENTI_SelezionaChiave]
(
	@chiave int
)
AS
BEGIN
	select
		Cognome,
		Nome,
		Codice_Fiscale,
		Citta,
		Provincia,
		Indirizzo,
		CAP,
		Codice_Patente,
		Data_di_Nascita
	from CLIENTI
	where K_Cliente = @chiave
END
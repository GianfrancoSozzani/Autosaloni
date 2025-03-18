ALTER PROCEDURE [dbo].[CLIENTI_SelectAll]
AS
BEGIN
	select K_Cliente,
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
	order by Citta, Cognome
END
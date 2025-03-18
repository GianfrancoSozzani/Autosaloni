ALTER PROCEDURE [dbo].[CLIENTI_CheckRedundantLicenses]
(
	@codice_fiscale char(16),
	@codice_patente nchar(10),
	@cognome nvarchar(50)
)
AS
BEGIN
	select count (Codice_Fiscale) as [QUANTI]
	from 
		CLIENTI
	where
		Codice_Patente = @codice_patente and
		Codice_Fiscale = @codice_fiscale and
		Cognome = @cognome
END
ALTER PROCEDURE [dbo].[CLIENTI_CheckRedundantRecords]
(
	@cognome nvarchar(50),
	@nome nvarchar(50),
	@codice_fiscale char(16),
	@citta nvarchar(50),
	@provincia char(2),
	@indirizzo nvarchar(50),
	@data_nascita date
)
AS
BEGIN
	select count (Codice_Fiscale) as [QUANTI]
	from 
		CLIENTI
	where
		Cognome = @cognome and
		Nome = @nome and
		Codice_Fiscale = @codice_fiscale and
		Citta = @citta and
		Provincia = @provincia and
		Indirizzo = @indirizzo and
		Data_di_Nascita = @data_nascita


END
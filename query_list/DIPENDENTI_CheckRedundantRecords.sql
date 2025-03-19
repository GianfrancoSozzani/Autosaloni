ALTER PROCEDURE [dbo].[DIPENDENTI_CheckRedundantRecords]
(
	@cognome nvarchar(50),
	@codice_fiscale char(16),
	@salone int,
	@ruolo char(1)
)
AS
BEGIN
	select count(Codice_Fiscale) as [QUANTI]
	from DIPENDENTI
	where
		Cognome = @cognome and
		Codice_Fiscale = @codice_fiscale and
		Ruolo = @ruolo and
		K_Salone = @salone

END
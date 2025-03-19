ALTER PROCEDURE [dbo].[DIPENDENTI_Update]
	(
		@chiave int,
		@cognome nvarchar(50),
		@nome nvarchar(50),
		@ruolo char(1),
		@salone int,
		@codice_fiscale char(16)
	)
AS
BEGIN
	update DIPENDENTI set
		Cognome = @cognome,
		Nome = @nome,
		Ruolo = @ruolo,
		K_Salone = @salone,
		Codice_Fiscale = @codice_fiscale
	where
		K_Dipendente = @chiave
END
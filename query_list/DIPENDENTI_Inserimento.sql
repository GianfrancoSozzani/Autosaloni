ALTER PROCEDURE [dbo].[DIPENDENTI_Inserimento]
(
	@cognome nvarchar(50),
	@nome nvarchar(50),
	@ruolo char(1),
	@salone int,
	@codice_fiscale char(16)
)
AS
BEGIN
	insert into DIPENDENTI
	(Cognome, Nome, Ruolo, K_Salone, Codice_Fiscale)
	values
	(@cognome, @nome, @ruolo, @salone, @codice_fiscale)
END
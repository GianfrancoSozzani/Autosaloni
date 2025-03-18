ALTER PROCEDURE [dbo].[CLIENTI_Update]
(
	@chiave int,
	@cognome nvarchar(50),
	@nome nvarchar(50),
	@codice_fiscale char(16),
	@citta nvarchar(50),
	@provincia char(2),
	@indirizzo nvarchar(50),
	@cap char(5),
	@codice_patente nchar(10),
	@data_nascita date
)
AS
BEGIN
	update 
		CLIENTI
	set 
		Cognome = @cognome,
		Nome = @nome,
		Codice_Fiscale = @codice_fiscale,
		Citta = @citta,
		Provincia = @provincia,
		Indirizzo = @indirizzo,
		CAP = @cap,
		Codice_Patente = @codice_patente,
		Data_di_Nascita = @data_nascita
	where 
		K_Cliente = @chiave
END
ALTER PROCEDURE [dbo].[CLIENTI_Inserimento]
(
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
	insert into CLIENTI
		(Cognome, Nome, Codice_Fiscale, Citta, Provincia, Indirizzo, CAP, Codice_Patente, Data_di_Nascita)
	values
		(@cognome, @nome, @codice_fiscale, @citta, @provincia, @indirizzo, @cap, @codice_patente, @data_nascita)
END
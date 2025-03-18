ALTER PROCEDURE [dbo].[SALONI_Inserimento]
(
	@nome_salone nvarchar(50),
	@indirizzo nvarchar(50),
	@cap char(5),
	@citta nvarchar(50),
	@provincia char(2)
)
AS
BEGIN
	insert into SALONI
	(Nome_Salone, Indirizzo, CAP, Citta, Provincia)
	values
	(@nome_salone, @indirizzo, @cap, @citta, @provincia)
END
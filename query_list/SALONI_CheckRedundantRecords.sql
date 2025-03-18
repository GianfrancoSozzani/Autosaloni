	ALTER PROCEDURE [dbo].[SALONI_CheckRedundantRecords]
	(
		@chiave int,
		@nome_salone nvarchar(50),
		@indirizzo nvarchar(50),
		@cap char(5),
		@citta nvarchar(50),
		@provincia char(2)
	)
	AS
	BEGIN
		select Nome_Salone,
		Indirizzo,
		CAP,
		Citta,
		Provincia
		from SALONI
		where K_Salone != @chiave and Nome_Salone = @nome_salone
	END
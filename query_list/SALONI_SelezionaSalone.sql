	ALTER PROCEDURE [dbo].[SALONI_SelezionaSalone]
	(
		@nome_salone nvarchar(50)
	)
	AS
	BEGIN
		select Nome_Salone, 
			Indirizzo,
			CAP, 
			Citta, 
			Provincia
		from SALONI
		where Nome_Salone = @nome_salone
	END
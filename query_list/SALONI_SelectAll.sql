ALTER procedure [dbo].[SALONI_SelectAll]
AS
BEGIN
	select K_Salone,
		Nome_Salone,
		Indirizzo,
		CAP,
		Citta,
		Provincia
	from SALONI
	order by Citta, Nome_Salone
END
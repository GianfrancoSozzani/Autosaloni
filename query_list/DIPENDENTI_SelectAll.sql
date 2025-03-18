ALTER PROCEDURE [dbo].[DIPENDENTI_SelectAll]
AS
BEGIN
	select DIP.K_Dipendente,
		DIP.K_Salone,
		DIP.Cognome,
		DIP.Nome,
		DIP.Ruolo,
		SAL.Nome_Salone,
		DIP.Codice_Fiscale
	from 
		DIPENDENTI as DIP
	inner join
		SALONI as SAL
		on DIP.K_Salone = SAL.K_Salone
	order by
		Nome_Salone, Cognome, Nome
END
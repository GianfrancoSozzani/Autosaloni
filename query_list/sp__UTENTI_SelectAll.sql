ALTER procedure [dbo].[sp__UTENTI_SelectAll]
as
begin
	select 
		USR,
		PWD,
		COGNOME,
		NOME,
		CITTA
	from UTENTI
end
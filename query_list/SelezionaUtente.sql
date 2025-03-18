ALTER procedure [dbo].[SelezionaUtente]
(
	@USR nvarchar(50)
)
AS
BEGIN
	Select USR,
			PWD,
			COGNOME,
			NOME,
			CITTA
	
	from UTENTI 
	where USR = @USR
END
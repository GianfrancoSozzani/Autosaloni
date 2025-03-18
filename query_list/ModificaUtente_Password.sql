ALTER procedure [dbo].[ModificaUtente_Password]
(
	@PWD nvarchar(50),
	@COGNOME nvarchar(50),
	@NOME nvarchar(50),
	@CITTA nvarchar(50),
	@USR nvarchar(50)
)
AS
BEGIN
	update UTENTI 
	set PWD =  @PWD,COGNOME = @COGNOME, NOME = @NOME, CITTA = @CITTA 
	where USR = @USR
	
END
ALTER procedure [dbo].[InserimentoUtenti]
(
	@USR nvarchar(50),
	@PWD nvarchar(50),
	@COGNOME nvarchar(50),
	@NOME nvarchar(50),
	@CITTA nvarchar(50)
)
AS
BEGIN
insert into UTENTI values (@USR, @PWD, @COGNOME, @NOME, @CITTA)
END
ALTER procedure [dbo].[RecuperaPassword]
(
	@USR nvarchar(50)
)
as
begin
	SELECT PWD 
	FROM UTENTI 
	WHERE USR = @USR
end
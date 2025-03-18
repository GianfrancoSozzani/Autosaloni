ALTER procedure [dbo].[LoginAutosaloni]
(
	@USR nvarchar(50),
	@PWD nvarchar(50)
)
as
begin
	select count(*) as QUANTI
	from UTENTI
	where USR = @usr and PWD = @pwd
end 
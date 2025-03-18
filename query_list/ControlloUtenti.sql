ALTER procedure [dbo].[ControlloUtenti]
(
	@USR nvarchar(50)
)
as
begin
	Select count(*) as [QUANTI] 
	from UTENTI 
	where USR= @USR
end
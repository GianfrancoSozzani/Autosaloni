ALTER procedure [dbo].[AUTOMOBILI_ControlloDuplicati]
(
	@vin char(17)
)
as
begin
	select 
		count (Telaio) as [QUANTI]
	from 
		AUTOMOBILI
	where 
		Telaio = @vin
end
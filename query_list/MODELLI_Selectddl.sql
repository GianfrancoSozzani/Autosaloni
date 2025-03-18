ALTER procedure [dbo].[MODELLI_Selectddl]
(
	@marca int
)
as
begin
select 
	MO.K_Modello,
	MO.Modello 
	from MODELLI as MO
	inner join MARCHE as MA
	on MO.K_Marca = MA.K_Marca 
	where MO.K_Marca = @marca
	order by Modello
end
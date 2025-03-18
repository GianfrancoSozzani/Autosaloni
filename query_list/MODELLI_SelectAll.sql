ALTER procedure [dbo].[MODELLI_SelectAll]
AS
BEGIN
	select 
		MO.K_Modello,
		MO.K_Marca,
		MA.Marca,
		MO.Modello 
	from MODELLI as MO
	inner join MARCHE as MA
	on MO.K_Marca = MA.K_Marca 
	order by Marca, Modello
END
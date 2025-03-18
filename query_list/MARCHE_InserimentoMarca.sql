ALTER procedure [dbo].[MARCHE_InserimentoMarca]
(
	@marca nvarchar(50)
)
as
begin
insert into MARCHE (Marca) values(@marca)
end
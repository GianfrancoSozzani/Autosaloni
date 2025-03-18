ALTER procedure [dbo].[SALONI_Update]
(
	@chiave int,
	@nome_salone nvarchar(50),
	@indirizzo nvarchar(50),
	@cap char(5),
	@citta nvarchar(50),
	@provincia char(2)
)
as
begin
	update SALONI
	set
		Nome_Salone = @nome_salone,
		Indirizzo = @indirizzo,
		CAP = @cap,
		Citta = @citta,
		Provincia = @provincia
	where
		K_Salone = @chiave
end
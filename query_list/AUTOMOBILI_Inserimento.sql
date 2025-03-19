ALTER procedure [dbo].[AUTOMOBILI_Inserimento]

(
	@modello int,
	@stato char(1),
	@data_acquisto date,
	@cliente_acquisto int,
	@prezzo_acquisto decimal(10,2),
	@salone int,
	@responsabile int,
	@venditore int,
	@alimentazione nvarchar(20),
	@colore nvarchar(50),
	@km int,
	@cambio nvarchar(20),
	@targa nvarchar(20),
	@telaio char(17),
	@condizione nvarchar(300),
	@optional nvarchar(300)
)
as
begin
	insert into AUTOMOBILI
	(K_Modello,Stato,Data_Acquisto,K_Cliente_Acquisto,Prezzo_Acquisto,K_Salone,K_Responsabile,K_Venditore,Alimentazione,Colore,KM,Cambio,Targa,Telaio,Condizione,Optional)
	values
		(@modello,@stato,@data_acquisto,@cliente_acquisto,@prezzo_acquisto,@salone,@responsabile,@venditore,@alimentazione,@colore,@km,@cambio,@targa,@telaio,@condizione,@optional)
end
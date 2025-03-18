ALTER procedure [dbo].[AUTOMOBILI_SelectAll]
as
begin
	select 
		A.K_Auto,
		MO.Modello,
		A.Stato,
        A.Data_Acquisto,
		CL.Cognome as Cognome_Cliente_Acquisto,
		CL.Nome as Nome_Cliente_Acquisto,
		A.Prezzo_Acquisto,
		SA.Nome_Salone,
		D.Cognome as Cognome_Venditore,
		D.Nome as Nome_Venditore,
		A.Alimentazione,
		A.Colore,
		A.KM,
		A.Cambio,
		A.Targa,
		A.Telaio,
		A.Condizione,
		A.Optional,
		A.Prezzo_Offerto,
		A.Prezzo_Vendita,
		A.Data_Vendita,
		D2.Cognome as Cognome_Responsabile,
		D2.Nome as Nome_Responsabile,
		CL2.Cognome as Cognome_Cliente_Vendita,
		CL2.Nome as Nome_Cliente_Vendita
	from AUTOMOBILI as A
	inner join MODELLI as MO on A.K_Modello = MO.K_Modello
	inner join CLIENTI as CL on A.K_Cliente_Acquisto = CL.K_Cliente
	inner join SALONI as SA on A.K_Salone = SA.K_Salone
	inner join DIPENDENTI as D on A.K_Venditore = D.K_Dipendente
	inner join DIPENDENTI as D2 on A.K_RESPONSABILE = D2.K_DIPENDENTE
	left join CLIENTI as CL2 on A.K_CLIENTE_VENDITA = CL2.K_CLIENTE
	order by A.Data_Acquisto
end
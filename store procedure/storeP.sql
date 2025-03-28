USE [AUTOSALONI]
GO
/****** Object:  StoredProcedure [dbo].[SPESE_AUTO_Update]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SPESE_AUTO_Update]
GO
/****** Object:  StoredProcedure [dbo].[SPESE_AUTO_SelezionaSpesa]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SPESE_AUTO_SelezionaSpesa]
GO
/****** Object:  StoredProcedure [dbo].[SPESE_AUTO_SelezionaDatiAutomobile]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SPESE_AUTO_SelezionaDatiAutomobile]
GO
/****** Object:  StoredProcedure [dbo].[SPESE_AUTO_SelezionaAutomobile]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SPESE_AUTO_SelezionaAutomobile]
GO
/****** Object:  StoredProcedure [dbo].[SPESE_AUTO_Inserimento]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SPESE_AUTO_Inserimento]
GO
/****** Object:  StoredProcedure [dbo].[SPESE_AUTO_DatiCliente]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SPESE_AUTO_DatiCliente]
GO
/****** Object:  StoredProcedure [dbo].[sp__UTENTI_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp__UTENTI_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[SelezionaUtente]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SelezionaUtente]
GO
/****** Object:  StoredProcedure [dbo].[SALONI_Update]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SALONI_Update]
GO
/****** Object:  StoredProcedure [dbo].[SALONI_SelezionaSalone]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SALONI_SelezionaSalone]
GO
/****** Object:  StoredProcedure [dbo].[SALONI_SelezionaChiave]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SALONI_SelezionaChiave]
GO
/****** Object:  StoredProcedure [dbo].[SALONI_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SALONI_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[SALONI_Inserimento]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SALONI_Inserimento]
GO
/****** Object:  StoredProcedure [dbo].[SALONI_CheckRedundantRecords]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[SALONI_CheckRedundantRecords]
GO
/****** Object:  StoredProcedure [dbo].[RecuperaPassword]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[RecuperaPassword]
GO
/****** Object:  StoredProcedure [dbo].[ModificaUtente_Password]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[ModificaUtente_Password]
GO
/****** Object:  StoredProcedure [dbo].[ModificaUtente_NoPassword]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[ModificaUtente_NoPassword]
GO
/****** Object:  StoredProcedure [dbo].[MODELLI_Update]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[MODELLI_Update]
GO
/****** Object:  StoredProcedure [dbo].[MODELLI_SelezionaModello]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[MODELLI_SelezionaModello]
GO
/****** Object:  StoredProcedure [dbo].[MODELLI_SelezionaChiave]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[MODELLI_SelezionaChiave]
GO
/****** Object:  StoredProcedure [dbo].[MODELLI_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[MODELLI_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[MODELLI_Inserimento]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[MODELLI_Inserimento]
GO
/****** Object:  StoredProcedure [dbo].[MODELLI_CheckRedundantRecords]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[MODELLI_CheckRedundantRecords]
GO
/****** Object:  StoredProcedure [dbo].[MARCHE_Update]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[MARCHE_Update]
GO
/****** Object:  StoredProcedure [dbo].[MARCHE_SelezionaMarca]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[MARCHE_SelezionaMarca]
GO
/****** Object:  StoredProcedure [dbo].[MARCHE_SelezionaChiave]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[MARCHE_SelezionaChiave]
GO
/****** Object:  StoredProcedure [dbo].[MARCHE_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[MARCHE_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[MARCHE_InserimentoMarca]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[MARCHE_InserimentoMarca]
GO
/****** Object:  StoredProcedure [dbo].[MARCHE_CheckRedundantRecords]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[MARCHE_CheckRedundantRecords]
GO
/****** Object:  StoredProcedure [dbo].[LoginAutosaloni]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[LoginAutosaloni]
GO
/****** Object:  StoredProcedure [dbo].[LOG_EVENTI_Insert]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[LOG_EVENTI_Insert]
GO
/****** Object:  StoredProcedure [dbo].[LOG_ERRORI_Insert]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[LOG_ERRORI_Insert]
GO
/****** Object:  StoredProcedure [dbo].[InserimentoUtenti]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[InserimentoUtenti]
GO
/****** Object:  StoredProcedure [dbo].[DIPENDENTI_Update]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[DIPENDENTI_Update]
GO
/****** Object:  StoredProcedure [dbo].[DIPENDENTI_SelezionaDipendente]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[DIPENDENTI_SelezionaDipendente]
GO
/****** Object:  StoredProcedure [dbo].[DIPENDENTI_SelezionaChiave]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[DIPENDENTI_SelezionaChiave]
GO
/****** Object:  StoredProcedure [dbo].[DIPENDENTI_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[DIPENDENTI_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[DIPENDENTI_Inserimento]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[DIPENDENTI_Inserimento]
GO
/****** Object:  StoredProcedure [dbo].[DIPENDENTI_CheckRedundantRecords]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[DIPENDENTI_CheckRedundantRecords]
GO
/****** Object:  StoredProcedure [dbo].[ControlloUtenti]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[ControlloUtenti]
GO
/****** Object:  StoredProcedure [dbo].[CLIENTI_Update]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[CLIENTI_Update]
GO
/****** Object:  StoredProcedure [dbo].[CLIENTI_SelezionaCliente]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[CLIENTI_SelezionaCliente]
GO
/****** Object:  StoredProcedure [dbo].[CLIENTI_SelezionaChiave]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[CLIENTI_SelezionaChiave]
GO
/****** Object:  StoredProcedure [dbo].[CLIENTI_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[CLIENTI_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[CLIENTI_Inserimento]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[CLIENTI_Inserimento]
GO
/****** Object:  StoredProcedure [dbo].[CLIENTI_CheckRedundantRecords]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[CLIENTI_CheckRedundantRecords]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_Update]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_Update]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_StatisticheAutomobile2025]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_StatisticheAutomobile2025]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_StatisticheAutomobile2024]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_StatisticheAutomobile2024]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_SelezionaMarcaAutomobile]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_SelezionaMarcaAutomobile]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_SelezionaDatiAutomobile]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_SelezionaDatiAutomobile]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_SelezionaChiave]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_SelezionaChiave]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_SelezionaAutomobileVendita]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_SelezionaAutomobileVendita]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_SelezionaAutomobile]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_SelezionaAutomobile]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_Saldo_Totale_2025]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_Saldo_Totale_2025]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_Saldo_Totale_2024]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_Saldo_Totale_2024]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_RiempimentoDatiVendita]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_RiempimentoDatiVendita]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_Inserimento]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_Inserimento]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlVenditoriSalone]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_ddlVenditoriSalone]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlVenditoriModifica]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_ddlVenditoriModifica]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlResponsabiliSalone]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_ddlResponsabiliSalone]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlResponsabiliModifica]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_ddlResponsabiliModifica]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlModelli]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_ddlModelli]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlClienti]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_ddlClienti]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlClienteVenditaModifica]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_ddlClienteVenditaModifica]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlClienteAcquistoModifica]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_ddlClienteAcquistoModifica]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlAutomobiliVendita]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_ddlAutomobiliVendita]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_DatiClienteVendita]    Script Date: 27/03/2025 18:22:58 ******/
DROP PROCEDURE IF EXISTS [dbo].[AUTOMOBILI_DatiClienteVendita]
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_DatiClienteVendita]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AUTOMOBILI_DatiClienteVendita]
(
	@cliente int
)
as
begin
	select
		Cognome,
		Nome,
		Codice_Fiscale,
		Citta,
		Indirizzo,
		CAP,
		Provincia,
		Codice_Patente,
		Data_di_Nascita
	from CLIENTI
	where K_Cliente = @cliente
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlAutomobiliVendita]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_ddlAutomobiliVendita]
as
begin
	select 
		A.K_Auto,
		MA.Marca + ' ' + MO.Modello as MarcaModello
	from MODELLI MO
	inner join MARCHE MA on MO.K_Marca = MA.K_Marca
	inner join AUTOMOBILI A on A.K_Modello = MO.K_Modello
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlClienteAcquistoModifica]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AUTOMOBILI_ddlClienteAcquistoModifica]
(
	@chiave int
)
as
begin
	select
		C.K_Cliente
	from
		CLIENTI as C
	inner join AUTOMOBILI as A on A.K_Cliente_Acquisto = C.K_Cliente
	where
		A.K_Auto = @chiave
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlClienteVenditaModifica]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_ddlClienteVenditaModifica]
(
	@chiave int
)
as
begin
	select
		C.K_Cliente
	from
		CLIENTI as C
	right join AUTOMOBILI as A on A.K_Cliente_Vendita = C.K_Cliente
	where
		A.K_Auto = @chiave
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlClienti]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AUTOMOBILI_ddlClienti]
as
begin
	select K_Cliente, Cognome + ' ' + Nome as NomeCognome
	from CLIENTI
	order by Cognome, Nome
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlModelli]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_ddlModelli]
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
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlResponsabiliModifica]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_ddlResponsabiliModifica]
(
	@chiave int
)
as
begin
	select
		D.K_Dipendente
	from
		DIPENDENTI as D
	inner join AUTOMOBILI as A on A.K_Responsabile = D.K_Dipendente
	where
		A.K_Auto = @chiave and D.K_Salone = A.K_Salone and D.Ruolo = 'R'
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlResponsabiliSalone]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_ddlResponsabiliSalone]
(
	 @salone int
)
as
begin
	select D.K_Dipendente, D.Cognome + ' ' + D.Nome as NomeCognome
	from DIPENDENTI as D
	inner join SALONI as S
	on D.K_Salone = S.K_Salone
	where D.K_Salone = @salone and Ruolo = 'R'
	order by Cognome, Nome
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlVenditoriModifica]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[AUTOMOBILI_ddlVenditoriModifica]
(
	@chiave int
)
as
begin
	select
		D.K_Dipendente
	from
		DIPENDENTI as D
	inner join AUTOMOBILI as A on A.K_Responsabile = D.K_Dipendente
	where
		A.K_Auto = @chiave and D.K_Salone = A.K_Salone
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_ddlVenditoriSalone]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_ddlVenditoriSalone]
(
	 @salone int
)
as
begin
	select D.K_Dipendente, D.Cognome + ' ' + D.Nome as NomeCognome
	from DIPENDENTI as D
	inner join SALONI as S
	on D.K_Salone = S.K_Salone
	where D.K_Salone = @salone
	order by Cognome, Nome
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_Inserimento]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_Inserimento]

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
	@vin char(17),
	@condizione nvarchar(300),
	@optional nvarchar(300)
)
as
begin
	insert into AUTOMOBILI
	(K_Modello,Stato,Data_Acquisto,K_Cliente_Acquisto,Prezzo_Acquisto,K_Salone,K_Responsabile,K_Venditore,Alimentazione,Colore,KM,Cambio,Targa,Telaio,Condizione,Optional)
	values
		(@modello,@stato,@data_acquisto,@cliente_acquisto,@prezzo_acquisto,@salone,@responsabile,@venditore,@alimentazione,@colore,@km,@cambio,@targa,@vin,@condizione,@optional)
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_RiempimentoDatiVendita]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AUTOMOBILI_RiempimentoDatiVendita]
(
	@prezzo_offerto decimal(10,2),
	@prezzo_vendita decimal(10,2),
	@data_vendita date,
	@cliente int,
	@chiave int
)
as
begin
	update AUTOMOBILI set
		Prezzo_Offerto = @prezzo_offerto,
		Prezzo_Vendita = @prezzo_vendita,
		Data_Vendita = @data_vendita,
		K_Cliente_Vendita = @cliente
	where
		K_Auto = @chiave	
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_Saldo_Totale_2024]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AUTOMOBILI_Saldo_Totale_2024]
as
select
    sum(Totale_Speso) as Costi,
    sum(Totale_Incassato) as Ricavi,
    sum(Totale_Incassato) - sum(Totale_Speso) as SaldoTotale
from v_StatisticheAutomobili
where YEAR(Data_Vendita) = 2024
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_Saldo_Totale_2025]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AUTOMOBILI_Saldo_Totale_2025]
as
select
    sum(Totale_Speso) as Costi,
    sum(Totale_Incassato) as Ricavi,
    sum(Totale_Incassato) - sum(Totale_Speso) as SaldoTotale
from v_StatisticheAutomobili
where YEAR(Data_Vendita) = 2025
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_SelectAll]
as
begin
	select 
		A.K_Auto,
		MA.Marca,
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
	inner join MARCHE as MA on MO.K_Marca = MA.K_Marca
	inner join CLIENTI as CL on A.K_Cliente_Acquisto = CL.K_Cliente
	inner join SALONI as SA on A.K_Salone = SA.K_Salone
	inner join DIPENDENTI as D on A.K_Venditore = D.K_Dipendente
	inner join DIPENDENTI as D2 on A.K_RESPONSABILE = D2.K_DIPENDENTE
	left join CLIENTI as CL2 on A.K_CLIENTE_VENDITA = CL2.K_CLIENTE
	order by A.Data_Acquisto
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_SelezionaAutomobile]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_SelezionaAutomobile]
(
	@vin char(17)
)
as
begin
	select Telaio	 
	from 
		AUTOMOBILI
	where 
		Telaio = @vin
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_SelezionaAutomobileVendita]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_SelezionaAutomobileVendita]
(
	@chiave int
)
as
begin
	select 
		A.K_Auto,
		MA.Marca,
		MO.Modello,
		A.Stato,
        A.Data_Acquisto,
		CL.Cognome as Cognome_Cliente_Acquisto,
		CL.Nome as Nome_Cliente_Acquisto,
		A.Prezzo_Acquisto,
		SA.Nome_Salone,
		D.Cognome as Cognome_Venditore,
		D.Nome as Nome_Venditore,
		D2.Cognome as Cognome_Responsabile,
		D2.Nome as Nome_Responsabile,
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
	inner join MARCHE as MA on MO.K_Marca = MA.K_Marca
	inner join CLIENTI as CL on A.K_Cliente_Acquisto = CL.K_Cliente
	inner join SALONI as SA on A.K_Salone = SA.K_Salone
	inner join DIPENDENTI as D on A.K_Venditore = D.K_Dipendente
	inner join DIPENDENTI as D2 on A.K_RESPONSABILE = D2.K_DIPENDENTE
	left join CLIENTI as CL2 on A.K_CLIENTE_VENDITA = CL2.K_CLIENTE
	where K_Auto = @chiave
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_SelezionaChiave]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_SelezionaChiave]
(
	@chiave int
)
as
begin
	select Telaio	 
	from 
		AUTOMOBILI
	where 
		K_Auto != @chiave
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_SelezionaDatiAutomobile]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_SelezionaDatiAutomobile]
(
	@chiave int
)
as
begin
	select 
		K_Modello,
		Stato,
        Data_Acquisto,
		Prezzo_Acquisto,
		K_Salone,
		Alimentazione,
		Colore,
		KM,
		Cambio,
		Targa,
		Telaio,
		Condizione,
		Optional,
		Prezzo_Offerto,
		Prezzo_Vendita,
		Data_Vendita

	from
		AUTOMOBILI
	where
		K_Auto = @chiave
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_SelezionaMarcaAutomobile]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_SelezionaMarcaAutomobile]
(
	@chiave int
)
as
begin
	select 
		M.K_Marca
	from
		MARCHE as M
	inner join MODELLI as MO on M.K_Marca = MO.K_Marca
	inner join AUTOMOBILI as A on A.K_Modello = MO.K_Modello
	where
		A.K_Auto = @chiave
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_StatisticheAutomobile2024]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AUTOMOBILI_StatisticheAutomobile2024]
as
begin
	select * from v_StatisticheAutomobili
	where YEAR(Data_Vendita) = 2024
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_StatisticheAutomobile2025]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--somma di tutto quello che abbiamo speso nell'acquisto di auto
--e somma di tutto quello che abbiamo incassato nella vendita di auto
--e saldo totale
CREATE procedure [dbo].[AUTOMOBILI_StatisticheAutomobile2025]
as
begin
	select * from v_StatisticheAutomobili
	where YEAR(Data_Vendita) = 2025
end
GO
/****** Object:  StoredProcedure [dbo].[AUTOMOBILI_Update]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AUTOMOBILI_Update]
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
	@vin char(17),
	@condizione nvarchar(300),
	@optional nvarchar(300),
	@prezzo_offerto decimal(10,2),
	@prezzo_vendita decimal(10,2),
	@data_vendita date,
	@cliente_vendita int,
	@chiave int 
)
as
begin
	update 
		AUTOMOBILI
	set 
		K_Modello = @modello,
		Stato = @stato,
		Data_Acquisto = @data_acquisto,
		K_Cliente_Acquisto = @cliente_acquisto,
		Prezzo_Acquisto = @prezzo_acquisto,
		K_Salone = @salone,
		K_Responsabile = @responsabile,
		K_Venditore = @venditore,
		Alimentazione = @alimentazione,
		Colore = @colore,
		KM = @km,
		Cambio = @cambio,
		Targa = @targa,
		Telaio = @vin,
		Condizione = @condizione,
		Optional = @optional,
		Prezzo_Offerto = @prezzo_offerto,
		Prezzo_Vendita = @prezzo_vendita,
		Data_Vendita = @data_vendita,
		K_Cliente_Vendita = @cliente_vendita
	where
		K_Auto = @chiave
end
GO
/****** Object:  StoredProcedure [dbo].[CLIENTI_CheckRedundantRecords]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CLIENTI_CheckRedundantRecords]
(
	@chiave int,
	@codice_fiscale char(16),
	@codice_patente nchar(10)
	
)
AS
BEGIN
	select 
			Codice_Fiscale,
			Codice_Patente
	from 
		CLIENTI
	where
		K_Cliente != @chiave and (
		Codice_Fiscale = @codice_fiscale or
		Codice_Patente = @codice_patente)
END
GO
/****** Object:  StoredProcedure [dbo].[CLIENTI_Inserimento]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CLIENTI_Inserimento]
(
	@cognome nvarchar(50),
	@nome nvarchar(50),
	@codice_fiscale char(16),
	@citta nvarchar(50),
	@provincia char(2),
	@indirizzo nvarchar(50),
	@cap char(5),
	@codice_patente nchar(10),
	@data_nascita date
)
AS
BEGIN
	insert into CLIENTI
		(Cognome, Nome, Codice_Fiscale, Citta, Provincia, Indirizzo, CAP, Codice_Patente, Data_di_Nascita)
	values
		(@cognome, @nome, @codice_fiscale, @citta, @provincia, @indirizzo, @cap, @codice_patente, @data_nascita)
END
GO
/****** Object:  StoredProcedure [dbo].[CLIENTI_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CLIENTI_SelectAll]
AS
BEGIN
	select K_Cliente,
		Cognome,
		Nome,
		Codice_Fiscale,
		Citta,
		Provincia,
		Indirizzo,
		CAP,
		Codice_Patente,
		Data_di_Nascita
	from CLIENTI
	order by Citta, Cognome, Nome
END
GO
/****** Object:  StoredProcedure [dbo].[CLIENTI_SelezionaChiave]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CLIENTI_SelezionaChiave]
(
	@chiave int
)
AS
BEGIN
	select
		Cognome,
		Nome,
		Codice_Fiscale,
		Citta,
		Provincia,
		Indirizzo,
		CAP,
		Codice_Patente,
		Data_di_Nascita
	from CLIENTI
	where K_Cliente = @chiave
END
GO
/****** Object:  StoredProcedure [dbo].[CLIENTI_SelezionaCliente]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[CLIENTI_SelezionaCliente]
(
	@codice_fiscale char(16),
	@codice_patente nchar(10)
)
AS
BEGIN
	select Cognome, Nome, Citta, Codice_Fiscale, Indirizzo, CAP, Provincia, Codice_Patente, Data_di_Nascita 
	from 
		CLIENTI
	where
		Codice_Fiscale = @codice_fiscale and
		Codice_Patente = @codice_patente
END
GO
/****** Object:  StoredProcedure [dbo].[CLIENTI_Update]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CLIENTI_Update]
(
	@chiave int,
	@cognome nvarchar(50),
	@nome nvarchar(50),
	@codice_fiscale char(16),
	@citta nvarchar(50),
	@provincia char(2),
	@indirizzo nvarchar(50),
	@cap char(5),
	@codice_patente nchar(10),
	@data_nascita date
)
AS
BEGIN
	update 
		CLIENTI
	set 
		Cognome = @cognome,
		Nome = @nome,
		Codice_Fiscale = @codice_fiscale,
		Citta = @citta,
		Provincia = @provincia,
		Indirizzo = @indirizzo,
		CAP = @cap,
		Codice_Patente = @codice_patente,
		Data_di_Nascita = @data_nascita
	where 
		K_Cliente = @chiave
END
GO
/****** Object:  StoredProcedure [dbo].[ControlloUtenti]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ControlloUtenti]
(
	@USR nvarchar(50)
)
as
begin
	Select count(*) as [QUANTI] 
	from UTENTI 
	where USR= @USR
end
GO
/****** Object:  StoredProcedure [dbo].[DIPENDENTI_CheckRedundantRecords]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DIPENDENTI_CheckRedundantRecords]
(
	@chiave int,
	@codice_fiscale char(16)
)
AS
BEGIN
	select Cognome, Nome, Ruolo, K_Salone, Codice_Fiscale
	from DIPENDENTI
	where
		K_Dipendente != @chiave and 
		Codice_Fiscale = @codice_fiscale 
END
GO
/****** Object:  StoredProcedure [dbo].[DIPENDENTI_Inserimento]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DIPENDENTI_Inserimento]
(
	@cognome nvarchar(50),
	@nome nvarchar(50),
	@ruolo char(1),
	@salone int,
	@codice_fiscale char(16)
)
AS
BEGIN
	insert into DIPENDENTI
	(Cognome, Nome, Ruolo, K_Salone, Codice_Fiscale)
	values
	(@cognome, @nome, @ruolo, @salone, @codice_fiscale)
END
GO
/****** Object:  StoredProcedure [dbo].[DIPENDENTI_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DIPENDENTI_SelectAll]
AS
BEGIN
	select DIP.K_Dipendente,
		DIP.K_Salone,
		DIP.Cognome,
		DIP.Nome,
		DIP.Ruolo,
		SAL.Nome_Salone,
		DIP.Codice_Fiscale
	from 
		DIPENDENTI as DIP
	inner join
		SALONI as SAL
		on DIP.K_Salone = SAL.K_Salone
	order by
		Nome_Salone, Cognome, Nome
END
GO
/****** Object:  StoredProcedure [dbo].[DIPENDENTI_SelezionaChiave]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DIPENDENTI_SelezionaChiave]
(
	@chiave int
)
AS
BEGIN
select K_Dipendente,
	Cognome,
	Nome,
	Ruolo,
	K_Salone,
	Codice_Fiscale
from DIPENDENTI
where K_Dipendente = @chiave
END
GO
/****** Object:  StoredProcedure [dbo].[DIPENDENTI_SelezionaDipendente]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DIPENDENTI_SelezionaDipendente]
(
	@codice_fiscale char(16)
)
AS
BEGIN
	select Codice_Fiscale, Cognome, Nome, Ruolo, K_Salone 
	from DIPENDENTI
	where
		Codice_Fiscale = @codice_fiscale 
END
GO
/****** Object:  StoredProcedure [dbo].[DIPENDENTI_Update]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DIPENDENTI_Update]
	(
		@chiave int,
		@cognome nvarchar(50),
		@nome nvarchar(50),
		@ruolo char(1),
		@salone int,
		@codice_fiscale char(16)
	)
AS
BEGIN
	update DIPENDENTI set
		Cognome = @cognome,
		Nome = @nome,
		Ruolo = @ruolo,
		K_Salone = @salone,
		Codice_Fiscale = @codice_fiscale
	where
		K_Dipendente = @chiave
END
GO
/****** Object:  StoredProcedure [dbo].[InserimentoUtenti]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InserimentoUtenti]
(
	@USR nvarchar(50),
	@PWD nvarchar(50),
	@COGNOME nvarchar(50),
	@NOME nvarchar(50),
	@CITTA nvarchar(50)
)
AS
BEGIN
insert into UTENTI values (@USR, @PWD, @COGNOME, @NOME, @CITTA)
END
GO
/****** Object:  StoredProcedure [dbo].[LOG_ERRORI_Insert]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LOG_ERRORI_Insert]
(
	@ip nvarchar(15),
	@er nvarchar(300)
)
as
begin
	insert into LOG_ERRORI
	values (GETDATE(), @ip, @er)
end
GO
/****** Object:  StoredProcedure [dbo].[LOG_EVENTI_Insert]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[LOG_EVENTI_Insert]
(
	@usr nvarchar(50),
	@form nvarchar(50),
	@evento nvarchar(300)
)
as
begin 
	insert into LOG_EVENTI
	values (GETDATE(), @usr, @form, @evento)
end
GO
/****** Object:  StoredProcedure [dbo].[LoginAutosaloni]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LoginAutosaloni]
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
GO
/****** Object:  StoredProcedure [dbo].[MARCHE_CheckRedundantRecords]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MARCHE_CheckRedundantRecords]
(
	@chiave int,
	@marca nvarchar(50)
)
AS
BEGIN
	select K_Marca, Marca
	from MARCHE
	where K_Marca != @chiave and Marca = @Marca
END
GO
/****** Object:  StoredProcedure [dbo].[MARCHE_InserimentoMarca]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MARCHE_InserimentoMarca]
(
	@marca nvarchar(50)
)
as
begin
insert into MARCHE (Marca) values(@marca)
end
GO
/****** Object:  StoredProcedure [dbo].[MARCHE_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MARCHE_SelectAll]
AS
BEGIN
select K_Marca, Marca
from MARCHE
order by Marca
END
GO
/****** Object:  StoredProcedure [dbo].[MARCHE_SelezionaChiave]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MARCHE_SelezionaChiave]
(
	@chiave int
)
AS
BEGIN
	select K_Marca, Marca
	from MARCHE
	where K_Marca = @chiave
END
GO
/****** Object:  StoredProcedure [dbo].[MARCHE_SelezionaMarca]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MARCHE_SelezionaMarca]
(
	@marca nvarchar(50)
)
AS
BEGIN
	select Marca
	from MARCHE
	where Marca = @marca
END
GO
/****** Object:  StoredProcedure [dbo].[MARCHE_Update]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MARCHE_Update]
(
	@chiave int,
	@marca nvarchar(50)
)
AS 
BEGIN
	update MARCHE
		set
			Marca = @marca
		where K_Marca = @chiave
END
GO
/****** Object:  StoredProcedure [dbo].[MODELLI_CheckRedundantRecords]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MODELLI_CheckRedundantRecords]
(
	@chiave int,
	@modello nvarchar(50),
	@marca int
)
AS
BEGIN
	select Modello, K_Marca 
	from MODELLI
	where K_Modello = @chiave and K_Marca = @marca and Modello = @modello
END
GO
/****** Object:  StoredProcedure [dbo].[MODELLI_Inserimento]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MODELLI_Inserimento]
(
	@marca int,
	@modello nvarchar(50)
)
AS
BEGIN
	insert into MODELLI
	(Modello, K_Marca)
	values 
		(@modello, @marca)
END
GO
/****** Object:  StoredProcedure [dbo].[MODELLI_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MODELLI_SelectAll]
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
GO
/****** Object:  StoredProcedure [dbo].[MODELLI_SelezionaChiave]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MODELLI_SelezionaChiave]
(
	@chiave int
)
AS
BEGIN
	select K_Modello, Modello, K_Marca
	from MODELLI
	where K_Modello = @chiave
END
GO
/****** Object:  StoredProcedure [dbo].[MODELLI_SelezionaModello]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MODELLI_SelezionaModello]
(
	@marca int,
	@modello nvarchar(50)
)
AS
BEGIN
	select Modello, K_Marca
	from MODELLI
	where Modello = @modello and K_Marca = @marca
END
GO
/****** Object:  StoredProcedure [dbo].[MODELLI_Update]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MODELLI_Update]
(
	@chiave int,
	@marca int,
	@modello nvarchar(50)
)
AS
BEGIN
	update MODELLI 
	set K_Marca = @marca, 
		Modello = @modello
	where K_Modello = @chiave
END
GO
/****** Object:  StoredProcedure [dbo].[ModificaUtente_NoPassword]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificaUtente_NoPassword]
(
	
	@COGNOME nvarchar(50),
	@NOME nvarchar(50),
	@CITTA nvarchar(50),
	@USR nvarchar(50)
)
AS
BEGIN
	update UTENTI 
	set COGNOME = @COGNOME, NOME = @NOME, CITTA = @CITTA 
	where USR = @USR
	
END
GO
/****** Object:  StoredProcedure [dbo].[ModificaUtente_Password]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificaUtente_Password]
(
	@PWD nvarchar(50),
	@COGNOME nvarchar(50),
	@NOME nvarchar(50),
	@CITTA nvarchar(50),
	@USR nvarchar(50)
)
AS
BEGIN
	update UTENTI 
	set PWD =  @PWD,COGNOME = @COGNOME, NOME = @NOME, CITTA = @CITTA 
	where USR = @USR
	
END
GO
/****** Object:  StoredProcedure [dbo].[RecuperaPassword]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[RecuperaPassword]
(
	@USR nvarchar(50)
)
as
begin
	SELECT PWD 
	FROM UTENTI 
	WHERE USR = @USR
end
GO
/****** Object:  StoredProcedure [dbo].[SALONI_CheckRedundantRecords]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[SALONI_CheckRedundantRecords]
	(
		@chiave int,
		@nome_salone nvarchar(50),
		@indirizzo nvarchar(50),
		@cap char(5),
		@citta nvarchar(50),
		@provincia char(2)
	)
	AS
	BEGIN
		select Nome_Salone,
		Indirizzo,
		CAP,
		Citta,
		Provincia
		from SALONI
		where K_Salone != @chiave and Nome_Salone = @nome_salone
	END
GO
/****** Object:  StoredProcedure [dbo].[SALONI_Inserimento]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SALONI_Inserimento]
(
	@nome_salone nvarchar(50),
	@indirizzo nvarchar(50),
	@cap char(5),
	@citta nvarchar(50),
	@provincia char(2)
)
AS
BEGIN
	insert into SALONI
	(Nome_Salone, Indirizzo, CAP, Citta, Provincia)
	values
	(@nome_salone, @indirizzo, @cap, @citta, @provincia)
END
GO
/****** Object:  StoredProcedure [dbo].[SALONI_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SALONI_SelectAll]
AS
BEGIN
	select K_Salone,
		Nome_Salone,
		Indirizzo,
		CAP,
		Citta,
		Provincia
	from SALONI
	order by Citta, Nome_Salone
END
GO
/****** Object:  StoredProcedure [dbo].[SALONI_SelezionaChiave]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SALONI_SelezionaChiave]
(
	@chiave int
)
as
begin 
	select Nome_Salone,
		Indirizzo,
		CAP,
		Citta,
		Provincia
	from SALONI
	where K_Salone = @chiave
end
GO
/****** Object:  StoredProcedure [dbo].[SALONI_SelezionaSalone]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create PROCEDURE [dbo].[SALONI_SelezionaSalone]
	(
		@nome_salone nvarchar(50)
	)
	AS
	BEGIN
		select Nome_Salone, 
			Indirizzo,
			CAP, 
			Citta, 
			Provincia
		from SALONI
		where Nome_Salone = @nome_salone
	END
GO
/****** Object:  StoredProcedure [dbo].[SALONI_Update]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SALONI_Update]
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
GO
/****** Object:  StoredProcedure [dbo].[SelezionaUtente]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelezionaUtente]
(
	@USR nvarchar(50)
)
AS
BEGIN
	Select USR,
			PWD,
			COGNOME,
			NOME,
			CITTA
	
	from UTENTI 
	where USR = @USR
END
GO
/****** Object:  StoredProcedure [dbo].[sp__UTENTI_SelectAll]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp__UTENTI_SelectAll]
as
begin
	select 
		USR,
		PWD,
		COGNOME,
		NOME,
		CITTA
	from UTENTI
end
GO
/****** Object:  StoredProcedure [dbo].[SPESE_AUTO_DatiCliente]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPESE_AUTO_DatiCliente]
(
	@chiave int
)
as
begin
	select * from v_ClientiAutomobili
	where K_Auto = @chiave
end
GO
/****** Object:  StoredProcedure [dbo].[SPESE_AUTO_Inserimento]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPESE_AUTO_Inserimento]
(
	@chiave int,
	@spesa nvarchar(50),
	@importo decimal(9,2)
)
as
begin
	insert into SPESE_AUTO (K_Auto, Spesa, Importo)
	values
		(@chiave, @spesa, @importo)
end 
GO
/****** Object:  StoredProcedure [dbo].[SPESE_AUTO_SelezionaAutomobile]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPESE_AUTO_SelezionaAutomobile]
(
	@chiave int
)
as
begin
	select
		K_Spesa,
		Spesa,
		Importo
	from SPESE_AUTO
	where K_Auto = @chiave
end
GO
/****** Object:  StoredProcedure [dbo].[SPESE_AUTO_SelezionaDatiAutomobile]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPESE_AUTO_SelezionaDatiAutomobile]
(
	@chiave int
)
as
begin
	select 
		A.K_Auto,
		MA.Marca,
		MO.Modello,
		A.Stato,
        A.Data_Acquisto,
		A.Prezzo_Acquisto,
		SA.Nome_Salone,
		D.Cognome as Cognome_Venditore,
		D.Nome as Nome_Venditore,
		D2.Cognome as Cognome_Responsabile,
		D2.Nome as Nome_Responsabile,
		A.Alimentazione,
		A.Colore,
		A.KM,
		A.Cambio,
		A.Targa,
		A.Telaio,
		A.Condizione,
		A.Optional
	from AUTOMOBILI as A
	inner join MODELLI as MO on A.K_Modello = MO.K_Modello
	inner join MARCHE as MA on MO.K_Marca = MA.K_Marca
	inner join CLIENTI as CL on A.K_Cliente_Acquisto = CL.K_Cliente
	inner join SALONI as SA on A.K_Salone = SA.K_Salone
	inner join DIPENDENTI as D on A.K_Venditore = D.K_Dipendente
	inner join DIPENDENTI as D2 on A.K_RESPONSABILE = D2.K_DIPENDENTE
	where 
		A.K_Auto = @chiave
end
GO
/****** Object:  StoredProcedure [dbo].[SPESE_AUTO_SelezionaSpesa]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPESE_AUTO_SelezionaSpesa]
(
	@chiave int
)
as
begin
	select * from v_Spesa
	where
		K_Spesa = @chiave
end
GO
/****** Object:  StoredProcedure [dbo].[SPESE_AUTO_Update]    Script Date: 27/03/2025 18:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPESE_AUTO_Update]
(
	@chiave int,
	@spesa nvarchar(50),
	@importo decimal(9,2)
)
as
begin
	update 
		SPESE_AUTO
	set
		Spesa = @spesa,
		Importo = @importo
	where
		K_Spesa = @chiave
end
GO

ALTER procedure [dbo].[CLIENTI_DatiAnagraficiClienteAcquisto]
as
begin
	select K_Cliente, Cognome + ' ' + Nome as NomeCognome
	from CLIENTI
	order by Cognome, Nome
end
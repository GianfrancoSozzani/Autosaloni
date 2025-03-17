create procedure DIPENDENTI_VenditoriSalone
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
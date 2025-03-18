ALTER PROCEDURE [dbo].[DIPENDENTI_SelezionaChiave]
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
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Automobili_Spese.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-spese">

        <div class="dati">
            <div class="forms">
                <div class="dati cliente">
                    <div class="form-container">
                        <div class="title">
                            <p>Dati cliente</p>
                        </div>
                        <span>&nbsp;</span>
                        <div class="form-group">
                            <asp:Label ID="lblCognome" runat="server" Text="Cognome: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtCognome" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblNome" runat="server" Text="Nome: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtNome" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCodiceFiscale" runat="server" Text="Codice Fiscale: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtCodiceFiscale" runat="server" CssClass="form-input Upper" MaxLength="16" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCitta" runat="server" Text="Città: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtCitta" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblIndirizzo" runat="server" Text="Indirizzo: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtIndirizzo" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCAP" runat="server" Text="CAP: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtCAP" runat="server" CssClass="form-input" MaxLength="5" Width="45px" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblProvincia" runat="server" Text="Provincia: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtProvincia" runat="server" CssClass="form-input Upper" MaxLength="2" Width="30px" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblPatente" runat="server" Text="Codice Patente:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtPatente" runat="server" CssClass="form-input Upper" MaxLength="10" Width="150px" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="Data di Nascità: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtDataNascita" runat="server" CssClass="form-input" MaxLength="10" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="dati">
            <div id="autochart">
                <div class="title">
                    <p>Dati Automobile</p>
                </div>
                <span>&nbsp;</span>
                <div class="contenitore-dati">
                    <div class="part1">
                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Marca: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtMarca" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Modello: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtModello" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <div class="form-group">
                            <asp:Label ID="Label6" runat="server" Text="Stato " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtStato" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" Text="Data di Acquisto " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtData_Acquisto" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <div class="form-group">
                            <asp:Label ID="Label8" runat="server" Text="Prezzo d'Acquisto: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtPrezzoAcquisto" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                    </div>
                    <div class="part2">
                        <div class="form-group">
                            <asp:Label ID="Label9" runat="server" Text="Salone: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtNomeSalone" runat="server" CssClass="form-input" MaxLength="5" Width="45px" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <div class="form-group">
                            <asp:Label ID="Label10" runat="server" Text="Cognome Venditore: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtCognomeVenditore" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Nome Venditore: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtNomeVenditore" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="Cognome Responsabile: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtCognomeResponsabile" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <div class="form-group">
                            <asp:Label ID="Label11" runat="server" Text="Nome Responsabile: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtNomeResponsabile" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>

                    </div>
                    <div class="part3">
                        <div class="form-group">
                            <asp:Label ID="Label17" runat="server" Text="Alimentazione:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtAlimentazione" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <div class="form-group">
                            <asp:Label ID="Label12" runat="server" Text="Colore:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtColori" runat="server" AutoPostBack="true" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <div class="form-group">
                            <asp:Label ID="Label13" runat="server" Text="KM:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtKM" runat="server" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <div class="form-group">
                            <asp:Label ID="Label14" runat="server" Text="Cambio:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtCambio" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <div class="form-group">
                            <asp:Label ID="Label15" runat="server" Text="Targa:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtTarga" runat="server" ForeColor="#236BB3" MaxLength="20" CssClass="Upper" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                    </div>
                    <div class="part4">
                        <div class="form-group">
                            <asp:Label ID="Label16" runat="server" Text="Telaio:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtTelaio" runat="server" ForeColor="#236BB3" MaxLength="17" CssClass="Upper" Enabled="False"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label18" runat="server" Text="Condizioni:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtCondizioni" runat="server" TextMode="MultiLine" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <div class="form-group">
                            <asp:Label ID="Label19" runat="server" Text="Optionals:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                            <asp:TextBox ID="txtOptional" runat="server" TextMode="MultiLine" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="griglia-spese">
                <div class="title">
                    <p>Griglia Spese</p>
                </div>
                <asp:GridView ID="griglia_spese" runat="server" DataKeyNames="K_Spesa" CssClass="grid" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#1495db" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
            </div>
        </div>
        <div class="dati spesa">
            <div class="title">
                <p>Dati Spesa</p>
            </div>
            <span>&nbsp;</span>
            <div class="spese">
                <div class="form-group">
                    <asp:Label ID="Label20" runat="server" Text="Spesa: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                    <asp:TextBox ID="txtSpesa" runat="server" CssClass="form-input" MaxLength="10" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label21" runat="server" Text="Importo: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-input" MaxLength="10" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                </div>
                <span>&nbsp;</span>
                <div class="form-group">
                    <asp:Button ID="txtInserisci" runat="server" Text="inserisci" ForeColor="#236BB3" />
                </div>
            </div>
        </div>

    </div>
</asp:Content>


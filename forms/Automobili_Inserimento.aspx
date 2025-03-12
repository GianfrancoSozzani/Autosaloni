<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Automobili_Inserimento.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content-optimized">

        <div class="title">
            <p>Inserire una nuova Automobile</p>
        </div>

        <div class="griglia-optimized2">
            <asp:GridView ID="griglia" runat="server" DataKeyNames="K_Auto" CssClass="grid" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowDataBound="griglia_RowDataBound">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#1495db" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />

                <Columns>
                    <asp:TemplateField HeaderText="Cognome_Responsabile">
                        <ItemTemplate>
                            <asp:Label ID="lblCognomeResp"
                                Text=""
                                runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nome_Responsabile">
                        <ItemTemplate>
                            <asp:Label ID="lblNomeResp"
                                Text=""
                                runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cognome_Cliente_Vendita">
                        <ItemTemplate>
                            <asp:Label ID="lblCognomeVendita"
                                Text=""
                                runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nome_Cliente_Vendita">
                        <ItemTemplate>
                            <asp:Label ID="lblNomeVendita"
                                Text=""
                                runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div class="inserimento">
            <div class="form-container">
                <div class="form-group">
                    <asp:Label ID="Label15" runat="server" Text="Marca: " CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlMarche" runat="server" OnSelectedIndexChanged="ddlMarche_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div>&nbsp;</div>
                <div id="modelli" class="form-group">
                    <asp:Label ID="lblModello" runat="server" Text="Modello: " CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlModelli" runat="server" AutoPostBack="true"></asp:DropDownList >
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Stato: " CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlStato" runat="server" AutoPostBack="true"></asp:DropDownList >
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Data di acquisto: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtDataAcquisto" runat="server" TextMode="Date"></asp:TextBox>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Cliente Acquisto: " CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlClientiAcquisto" runat="server" AutoPostBack="true"></asp:DropDownList>
                    &nbsp;
                    <a href="Clienti_Inserimento.aspx">Nuovo Cliente </a>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Prezzo di Acquisto: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtPrezzoAcquisto" runat="server"></asp:TextBox>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="Salone: " CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlSaloni" runat="server" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label6" runat="server" Text="Responsabile: " CssClass="form-label"></asp:Label>
                    <%--qui compaiono solo i responsabili--%>
                    <asp:DropDownList ID="ddlResponsabile" runat="server" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label7" runat="server" Text="Venditore:" CssClass="form-label"></asp:Label>
                    <%--qui compaiono tutti i dipendenti  usare chiave per distingure ononimi--%>
                    <asp:DropDownList ID="ddlVenditore" runat="server" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label8" runat="server" Text="Alimentazione:" CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlAlimentazione" runat="server" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label9" runat="server" Text="Colore:" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtColori" runat="server" AutoPostBack="true"></asp:TextBox>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label10" runat="server" Text="KM:" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtKM" runat="server"></asp:TextBox>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label11" runat="server" Text="Cambio:" CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlCambio" runat="server" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label12" runat="server" Text="Targa:" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtTarga" runat="server"></asp:TextBox>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label13" runat="server" Text="Condizioni:" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtCondizioni" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <asp:Label ID="Label14" runat="server" Text="Optionals:" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtOptional" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div>&nbsp;</div>
                <div class="form-group">
                    <p>&nbsp;</p>
                    <asp:Button ID="btnInserimento" runat="server" Text="Inserimento" OnClick="btnInserimento_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>


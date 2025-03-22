<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Automobili_Vendita.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content-optimized">
        <div class="title">
            <p>Inserire i dati di vendita dell'automobile</p>
        </div>
        <div class="container-vendita">
            <div class="dati cliente">
                <div class="form-container">
                    <div class="form-group">
                        <asp:Label ID="Label4" runat="server" Text="Cliente: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:DropDownList ID="ddlClienti" runat="server" AutoPostBack="true" ForeColor="#236BB3"></asp:DropDownList>
                        <span>&nbsp;</span>
                        <a href="Clienti_Inserimento.aspx">Nuovo Cliente</a>
                    </div>
                    <span>&nbsp;</span>
                    <hr style="border: 1px solid #236BB3;" />
                    <span>&nbsp;</span>
                    <div class="title">
                        <p>Dati cliente</p>
                    </div>
                    <span>&nbsp;</span>
                    <div class="form-group">
                        <asp:Label ID="lblCognome" runat="server" Text="Cognome: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:TextBox ID="txtCognome" runat="server" CssClass="form-input" ForeColor="#236BB3"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblNome" runat="server" Text="Nome: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:TextBox ID="txtNome" runat="server" CssClass="form-input" ForeColor="#236BB3"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCodiceFiscale" runat="server" Text="Codice Fiscale: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:TextBox ID="txtCodiceFiscale" runat="server" CssClass="form-input Upper" MaxLength="16" ForeColor="#236BB3"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCitta" runat="server" Text="Città: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:TextBox ID="txtCitta" runat="server" CssClass="form-input"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblIndirizzo" runat="server" Text="Indirizzo: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:TextBox ID="txtIndirizzo" runat="server" CssClass="form-input" ForeColor="#236BB3"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblProvincia" runat="server" Text="Provincia: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:TextBox ID="txtProvincia" runat="server" CssClass="form-input Upper" MaxLength="2" Width="30px" ForeColor="#236BB3"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCAP" runat="server" Text="CAP: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:TextBox ID="txtCAP" runat="server" CssClass="form-input" MaxLength="5" Width="45px" ForeColor="#236BB3"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblPatente" runat="server" Text="Codice Patente:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:TextBox ID="txtPatente" runat="server" CssClass="form-input Upper" MaxLength="10" Width="150px" ForeColor="#236BB3"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Data di Nascità: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:TextBox ID="txtDataNascita" runat="server" CssClass="form-input" MaxLength="10" ForeColor="#236BB3"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="operazioni-automobile">
                <div id="griglie">
                    <div class="griglia">
                        <div class="title">
                            <p>Dati relativi alle spese sostenute per l'automobile</p>
                        </div>
                        <span>&nbsp;</span>
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
                    <div class="title">
                        <p>Dati dell'automobile</p>
                    </div>
                    <div class="griglia-optimized2">
                        <span>&nbsp;</span>
                        <asp:GridView ID="griglia_automobili" runat="server" DataKeyNames="K_Auto" CssClass="grid" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
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
                <div id="dati-vendita">
                    <div class="title">
                        <p>Dati di Vendita</p>
                    </div>
                    <span>&nbsp;</span>
                    <div class="form-group">
                        <asp:Label ID="Label12" runat="server" Text="Prezzo Offerto: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:TextBox ID="txtPrezzoOfferto" runat="server" CssClass="form-input" ForeColor="#236BB3"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Prezzo di Vendita: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-input" ForeColor="#236BB3"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Data di Vendita: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-input" ForeColor="#236BB3" TextMode="Date"></asp:TextBox>
                    </div>
                    <span>&nbsp;</span>
                    <div class="form-group">
                        <asp:Button ID="btnInserimentoDtai" runat="server" Text="Inserimento dati" ForeColor="#236BB3" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


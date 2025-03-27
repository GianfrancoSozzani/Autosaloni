<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Statistiche_Auto.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-statistiche">


        <div class="2025">
            <div class="title">
                <p>Statistiche 2025</p>
            </div>
            <div class="griglia">
                <asp:GridView ID="griglia_2025" runat="server" DataKeyNames="K_Auto" CssClass="grid" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowDataBound="griglia_2025_RowDataBound">
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
            <div>
                <asp:Label ID="Label1" runat="server" Text="Costi:"></asp:Label>
                <asp:TextBox ID="txtCosti2025" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                <span>&nbsp;</span>
                <asp:Label ID="Label2" runat="server" Text="Ricavi:"></asp:Label>
                <asp:TextBox ID="txtRicavi2025" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                <span>&nbsp;</span>
                <asp:Label ID="Label3" runat="server" Text="Saldo totale:"></asp:Label>
                <asp:TextBox ID="txtSaldoTotale2025" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
            </div>
        </div>
        <div class="2024">
            <div class="title">
                <p>Statistiche 2024</p>
            </div>
            <div class="griglia">
                <asp:GridView ID="griglia_2024" runat="server" DataKeyNames="K_Auto" CssClass="grid" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowDataBound="griglia_2024_RowDataBound">
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
            <div>
                <asp:Label ID="Label4" runat="server" Text="Costi:"></asp:Label>
                <asp:TextBox ID="txtCosti2024" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                <span>&nbsp;</span>
                <asp:Label ID="Label5" runat="server" Text="Ricavi:"></asp:Label>
                <asp:TextBox ID="txtRicavi2024" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
                <span>&nbsp;</span>
                <asp:Label ID="Label6" runat="server" Text="Saldo totale:"></asp:Label>
                <asp:TextBox ID="txtSaldoTotale2024" runat="server" CssClass="form-input" ForeColor="#236BB3" Enabled="False"></asp:TextBox>
            </div>
        </div>
    </div>
</asp:Content>


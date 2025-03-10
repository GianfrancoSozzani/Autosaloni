<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="MarcaModifica.aspx.cs" Inherits="Forms_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="headtitle">
        <h1>Modifica Marca</h1>
    </div>
    <div id="container">
        <div class="inserimento">
            <div class="table">
                <asp:GridView ID="griglia" runat="server" DataKeyNames="K_Marca" OnSelectedIndexChanged="griglia_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ButtonType="Button" HeaderText="Seleziona" ShowHeader="True" ShowSelectButton="True" />
                    </Columns>
                    <SelectedRowStyle BackColor="LightYellow" />
                    <%-- Aggiungi questa riga --%>
                </asp:GridView>
            </div>
        </div>
        <div class="inserimento">
            <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
            <div id="divmodifica" class="inserimento" runat="server" visible="false">
                <p>
                    <asp:TextBox ID="txtMarca" runat="server" CssClass="form-input"></asp:TextBox></p>
                <p>
                    <asp:Button ID="btnSalva" runat="server" Text="Salva" OnClick="btnSalva_Click" />
                </p>
            </div>
        </div>
    </div>
</asp:Content>


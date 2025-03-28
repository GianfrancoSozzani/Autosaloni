﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Automobili_Modifica2.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="compilazione">
        <div id="parte1">
            <div class="form-group">
                <asp:Label ID="Label15" runat="server" Text="Marca: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:DropDownList ID="ddlMarche" runat="server" AutoPostBack="true" ForeColor="#236BB3" OnSelectedIndexChanged="ddlMarche_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div>&nbsp;</div>
            <div id="modelli" class="form-group">
                <asp:Label ID="lblModello" runat="server" Text="Modello: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:DropDownList ID="ddlModelli" runat="server" AutoPostBack="true" ForeColor="#236BB3"></asp:DropDownList>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Stato: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:DropDownList ID="ddlStato" runat="server" AutoPostBack="true" ForeColor="#236BB3"></asp:DropDownList>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Data di acquisto: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:TextBox ID="txtDataAcquisto" runat="server" ForeColor="#236BB3"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Cliente Acquisto: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:DropDownList ID="ddlClientiAcquisto" runat="server" AutoPostBack="true" ForeColor="#236BB3"></asp:DropDownList>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Prezzo di Acquisto: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:TextBox ID="txtPrezzoAcquisto" runat="server" ForeColor="#236BB3"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Salone: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:DropDownList ID="ddlSaloni" runat="server" AutoPostBack="true" ForeColor="#236BB3" OnSelectedIndexChanged="ddlSaloni_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Responsabile: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>

                <asp:DropDownList ID="ddlResponsabile" runat="server" AutoPostBack="true" ForeColor="#236BB3"></asp:DropDownList>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Venditore:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>

                <asp:DropDownList ID="ddlVenditore" runat="server" AutoPostBack="true" ForeColor="#236BB3"></asp:DropDownList>
            </div>
        </div>
        <div id="parte2">
            <div class="form-group">
                <asp:Label ID="Label17" runat="server" Text="Alimentazione:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:DropDownList ID="ddlAlimentazione" runat="server" AutoPostBack="true" ForeColor="#236BB3"></asp:DropDownList>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="Colore:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:TextBox ID="txtColori" runat="server" AutoPostBack="true" ForeColor="#236BB3"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="KM:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:TextBox ID="txtKM" runat="server" ForeColor="#236BB3"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label11" runat="server" Text="Cambio:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:DropDownList ID="ddlCambio" runat="server" AutoPostBack="true" ForeColor="#236BB3"></asp:DropDownList>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label12" runat="server" Text="Targa:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:TextBox ID="txtTarga" runat="server" ForeColor="#236BB3" MaxLength="20" CssClass="Upper"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label16" runat="server" Text="Telaio:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:TextBox ID="txtTelaio" runat="server" ForeColor="#236BB3" MaxLength="17" CssClass="Upper"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label13" runat="server" Text="Condizioni:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:TextBox ID="txtCondizioni" runat="server" TextMode="MultiLine" ForeColor="#236BB3"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <asp:Label ID="Label14" runat="server" Text="Optionals:" CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:TextBox ID="txtOptional" runat="server" TextMode="MultiLine" ForeColor="#236BB3"></asp:TextBox>
            </div>
        </div>
        <div id="parte3">
            <div class="title">
                <p>Dati di Vendita</p>
            </div>
            <span>&nbsp;</span>
            <div class="form-group">
                <asp:Label ID="Label20" runat="server" Text="Cliente Vendita: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:DropDownList ID="ddlClientiVendita" runat="server" AutoPostBack="true" ForeColor="#236BB3"></asp:DropDownList>
            </div>
            <span>&nbsp;</span>
            <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="Prezzo Offerto: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:TextBox ID="txtPrezzoOfferto" runat="server" CssClass="form-input" ForeColor="#236BB3"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label18" runat="server" Text="Prezzo di Vendita: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:TextBox ID="txtPrezzoVendita" runat="server" CssClass="form-input" ForeColor="#236BB3"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label19" runat="server" Text="Data di Vendita: " CssClass="form-label" ForeColor="#236BB3"></asp:Label>
                <asp:TextBox ID="txtDataVendita" runat="server" CssClass="form-input" ForeColor="#236BB3"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div class="form-group">
                <a href="Clienti_Inserimento.aspx">Nuovo Cliente </a>
                <p>&nbsp;</p>
                <asp:Button ID="btnModifica" runat="server" Text="Modifica" ForeColor="#236BB3" OnClick="btnModifica_Click" />
            </div>
        </div>
    </div>
</asp:Content>


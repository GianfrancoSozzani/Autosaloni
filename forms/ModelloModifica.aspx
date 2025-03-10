﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="ModelloModifica.aspx.cs" Inherits="Forms_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="headtitle">
        <h1>Modifica Modello</h1>
    </div>
    <div id="container">
        <div class="inserimento">
            <div class="table">
                <asp:GridView ID="griglia" runat="server" DataKeyNames="K_Modello" OnSelectedIndexChanged="griglia_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ButtonType="Button" HeaderText="Seleziona" ShowHeader="True" ShowSelectButton="True" />
                    </Columns>
                    <SelectedRowStyle BackColor="LightYellow" />
                </asp:GridView>
            </div>
        </div>
        <div class="inserimento">
            <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />

            <div id="divmodifica" class="inserimento" runat="server" visible="false">
                <div class="form-group">
                    <asp:Label ID="lblSelezionaMarca" runat="server" Text="Seleziona Marca" CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlMarche" runat="server"></asp:DropDownList>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblModello" runat="server" Text="Modello" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtModello" runat="server" CssClass="form-input"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnSalva" runat="server" Text="Salva" OnClick="btnSalva_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>


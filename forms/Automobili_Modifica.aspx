﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Automobili_Modifica.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content">
        <div class="title">
            <p>Modifica un Automobile già registrata</p>
        </div>
        <div class="griglia-optimized2">
            <asp:GridView ID="griglia" runat="server" DataKeyNames="K_Auto" CssClass="grid" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowDataBound="griglia_RowDataBound">
                <Columns>
                    <asp:CommandField ButtonType="Button" HeaderText="Seleziona" ShowSelectButton="true" ShowHeader="true" />
                </Columns>
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
        <div>&nbsp;</div>
        <div>
            <asp:Button ID="btnModifica" runat="server" Text="Modifica" ForeColor="#236BB3" OnClick="btnModifica_Click" />
        </div>
    </div>
</asp:Content>


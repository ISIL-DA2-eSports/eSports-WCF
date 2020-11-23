<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebRankingJugador.aspx.cs" Inherits="WebWCF_eSports.Jugador.WebRankingJugador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 22px;
    }
    .auto-style3 {
        width: 273px;
    }
    .auto-style4 {
        height: 22px;
        width: 273px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-family: Verdana; color: rgb(0, 0, 0); font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(243, 244, 238); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;">
    Test Web Jugador Ranking</p>
<br />
<table class="auto-style1">
    <tr>
        <td class="auto-style3">Seleccione top:</td>
        <td>
            <asp:DropDownList ID="dplTop" runat="server">
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem Value="10">10</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
        </td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style2">
            <asp:Button ID="btnSiguiente" runat="server" OnClick="btnSiguiente_Click" Text="Siguiente" />
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="grvDatos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="982px" AutoGenerateColumns="False">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Nickname" HeaderText="Nickname">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="NomHeroe" HeaderText="Hero">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Round" HeaderText="Match">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TotalKills" HeaderText="Kills">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TotalDeaths" HeaderText="Deaths">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TotalAssists" HeaderText="Assists">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>

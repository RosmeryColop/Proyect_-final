<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="Ej_15.Reporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: x-large">
        &nbsp;&nbsp;&nbsp;&nbsp; Reporte de Datos</p>
    <p style="font-size: x-large">
        &nbsp;</p>
    <p style="font-size: large">
        Enfermedades mas comunes:</p>
    <p style="font-size: large">
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </p>
    <p style="font-size: large">
        Edad Promedio:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p style="font-size: large">
        Medicamentos Recetados:</p>
    <p style="font-size: large">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p style="font-size: large">
        Dinero Total:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p style="font-size: large">
        Del&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" TextMode="Date"></asp:TextBox>
&nbsp;al&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" TextMode="Date"></asp:TextBox>
    </p>
    <p style="font-size: large">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Calcular" />
    </p>
</asp:Content>

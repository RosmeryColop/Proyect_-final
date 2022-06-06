<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarSintoma.aspx.cs" Inherits="Ej_15.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: x-large">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Editar Sintoma</p>
<p style="font-size: x-large">
    &nbsp;</p>
<p style="font-size: large">
    Codigo Sintoma:&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p style="font-size: large">
    Sintoma:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p style="font-size: large">
    &nbsp;</p>
<p style="font-size: x-large">
&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Buscar Sintoma" OnClick="Button1_Click" />
&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Editar Sintoma" OnClick="Button2_Click" />
</p>
</asp:Content>

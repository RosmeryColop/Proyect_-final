<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Form Historial Paciente.aspx.cs" Inherits="Ej_15.Form_Historial_Paciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>HISTORIAL DEL PACIENTE</h1>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Buscar por Código del Paciente:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="130px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="150px" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

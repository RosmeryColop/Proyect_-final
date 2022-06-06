<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sintomas.aspx.cs" Inherits="Ej_15.Sintomas1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: x-large">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Agregar Sintoma&nbsp;</p>
    <p style="font-size: x-large">
    &nbsp;</p>
<p style="font-size: large">
    Cod Sintoma:&nbsp;
    <asp:TextBox ID="txt_Enfermedad" runat="server"></asp:TextBox>
</p>
<p style="font-size: large">
    Sintomas:&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_sintomas" runat="server"></asp:TextBox>
&nbsp;&nbsp;
</p>
    <p style="font-size: large">
        &nbsp;</p>
    <p style="font-size: large">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Agregar Sintoma" />
&nbsp;&nbsp;
        </p>
</asp:Content>

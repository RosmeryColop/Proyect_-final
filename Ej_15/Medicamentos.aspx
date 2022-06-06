<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Medicamentos.aspx.cs" Inherits="Ej_15.Medicamentos1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Medicamentos</h1>
    <h3>Codigo<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </h3>
    <h3>Ingredientes
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </h3>
    <h3>Laboratorio
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </h3>
    <h3>Enfermedades<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </h3>
    <h3>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar Datos" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Agregar Enfermedad" />
    </h3>
    <p>
        &nbsp;</p>
</asp:Content>

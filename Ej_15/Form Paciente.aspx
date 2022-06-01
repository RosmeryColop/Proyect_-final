<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Form Paciente.aspx.cs" Inherits="Ej_15.Form_Paciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Pacientes</h1>
    <p>
        &nbsp;</p>
    <h3>Ingreso de nuevos pacientes:</h3>
    <p>
        &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp; Nombre:&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPacienteNombre" runat="server" Width="300px"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp; Apellido:&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPacienteApellido" runat="server" Width="299px"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp; Dirección:&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPacienteDireccion" runat="server" Width="350px"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp; Fecha de Nacimiento:
        <asp:TextBox ID="TextBoxPacienteNacimiento" runat="server" Width="250px"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp; NIT:&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPacienteNIT" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp; Teléfono:&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPacienteTelefono" runat="server" Width="170px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonINGRESAR" runat="server" Height="50px" OnClick="Button1_Click" style="font-weight: 700; font-size: medium; font-style: italic" Text="Ingresar NUEVO Paciente" Width="250px" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

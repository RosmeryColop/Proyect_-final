<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cita.aspx.cs" Inherits="Ej_15.Cita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    NIT&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxNIT" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar_SelectionChanged" Width="350px">
        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
        <TodayDayStyle BackColor="#CCCCCC" />
    </asp:Calendar>
</p>
<p>
    Hora disponible&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownListHora" runat="server">
    </asp:DropDownList>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="ButtonAgregarCita" runat="server" OnClick="ButtonAgregarCita_Click" Text="Agregar Cita" />
</p>
</asp:Content>

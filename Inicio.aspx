<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="MPsito4.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Bienvenido</h1>

    <asp:TextBox ID="txtNombreCliente" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvNombreCliente" runat="server"
    ControlToValidate="txtNombreCliente"
    Display="Dynamic"
    InitialValue=""
    ErrorMessage="El nombre es obligatorio."
    ForeColor="Red"
    ValidationGroup="vgCrearTicket"
    MinimumLength="5">
</asp:RequiredFieldValidator>

<asp:TextBox ID="txtRutCliente" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="revRutCliente" runat="server"
    ControlToValidate="txtRutCliente"
    Display="Dynamic"
    InitialValue=""
    ErrorMessage="El rut es obligatorio y debe tener el formato 12345678-9."
    ForeColor="Red"
    ValidationGroup="vgCrearTicket"
    ValidationExpression="^\d{7,8}-[\dkK]$">
</asp:RegularExpressionValidator>

<asp:TextBox ID="txtTelefonoCliente" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvTelefonoCliente" runat="server"
    ControlToValidate="txtTelefonoCliente"
    Display="Dynamic"
    InitialValue=""
    ErrorMessage="El número telefónico es obligatorio."
    ForeColor="Red"
    ValidationGroup="vgCrearTicket">
</asp:RequiredFieldValidator>

<asp:TextBox ID="txtEmailCliente" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="revEmailCliente" runat="server"
    ControlToValidate="txtEmailCliente"
    Display="Dynamic"
    InitialValue=""
    ErrorMessage="El email es obligatorio y debe tener un formato válido."
    ForeColor="Red"
    ValidationGroup="vgCrearTicket"
    ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$">
</asp:RegularExpressionValidator>

<asp:DropDownList ID="ddlTipoCliente" runat="server">
    <asp:ListItem Text="Seleccionar" Value="" />
    <asp:ListItem Text="Cliente Tipo A" Value="A" />
    <asp:ListItem Text="Cliente Tipo B" Value="B" />
</asp:DropDownList>
<asp:CustomValidator ID="cvTipoCliente" runat="server"
    ControlToValidate="ddlTipoCliente"
    Display="Dynamic"
    ErrorMessage="Seleccione un tipo de cliente válido."
    ForeColor="Red"
    OnServerValidate="cvTipoCliente_ServerValidate"
    ValidationGroup="vgCrearTicket">
</asp:CustomValidator>

<asp:TextBox ID="txtNombreProducto" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvNombreProducto" runat="server"
    ControlToValidate="txtNombreProducto"
    Display="Dynamic"
    InitialValue=""
    ErrorMessage="El nombre del producto es obligatorio."
    ForeColor="Red"
    ValidationGroup="vgCrearTicket"
    MinimumLength="10">
</asp:RequiredFieldValidator>

<asp:TextBox ID="txtDescripcionProducto" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvDescripcionProducto" runat="server"
    ControlToValidate="txtDescripcionProducto"
    Display="Dynamic"
    InitialValue=""
    ErrorMessage="La descripción del producto es obligatoria."
    ForeColor="Red"
    ValidationGroup="vgCrearTicket"
    MinimumLength="10">
</asp:RequiredFieldValidator>

<asp:ValidationSummary ID="vsCrearTicket" runat="server" ValidationGroup="vgCrearTicket" />

<asp:Button ID="btnCrearTicket" runat="server" Text="Crear Ticket" OnClick="btnCrearTicket_Click" ValidationGroup="vgCrearTicket" />

</asp:Content>

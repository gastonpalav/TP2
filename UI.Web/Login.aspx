<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <header >Bienvenido al sistema academia</header>
    <br />
    <div class="form-group">
        <asp:Panel ID="formPanel" Visible="true" runat="server">
            <asp:Label ID="usuarioLabel" runat="server" Text="usuario: "></asp:Label>
        <asp:TextBox ID="usuarioTextBox" class="form-control" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="usuarioRequerido" runat="server" ForeColor="Red" ErrorMessage="Requerido" ControlToValidate="usuarioTextBox" ValidationGroup="vg" >*</asp:RequiredFieldValidator>
            <br />
        <asp:Label ID="passLabel" runat="server" Text="Contraseña: "></asp:Label>
        <asp:TextBox ID="passTextBox" TextMode="Password" class="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordRequerido" runat="server" ForeColor="Red" ErrorMessage="Requerido" ControlToValidate="passTextBox" ValidationGroup="vg" >*</asp:RequiredFieldValidator>
            <br />
        <asp:CustomValidator ID="loginValidator" ForeColor="Red" runat="server" ErrorMessage="Usuario o contraseña incorrectos" ValidationGroup="vg"></asp:CustomValidator>
    </asp:Panel>
    </div>
    <asp:Panel ID="formActionPanel" Visible="true" runat="server">
        <asp:LinkButton ID="loginLinkButton" class="btn btn-success" runat="server" ValidationGroup="vg" OnClick="loginLinkButton_Click">Login</asp:LinkButton>
        <br />
        <asp:Label ID="mensajeLabel" runat="server" ForeColor="Red" Text=""></asp:Label>
    </asp:Panel>
     <asp:Panel ID="ValidationActionPanel" runat="server">
        <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" ValidationGroup="vg" />
    </asp:Panel>
</asp:Content>

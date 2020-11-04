<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profesores.aspx.cs" Inherits="UI.Web.Profesores" %>

<asp:Content ID="Content" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridViewProfesores" runat="server" AutogenerateColumns="false" SelectedRowStyle-color="Black" DataKeyNames="ID" OnSelectedIndexChanged="gridViewProfesores_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="Email" DataField="Email" />
                <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
                <asp:BoundField HeaderText="Fecha de nacimiento" DataField="FechaNacimiento" />
                <asp:BoundField HeaderText="Legajo" DataField="Legajo" />
                <asp:BoundField HeaderText="Plan" DataField="PlanDescripcion" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="nombreLabel" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="nombreRequerido" runat="server" ForeColor="Red" ErrorMessage="Requerido" ControlToValidate="nombreTextBox" ValidationGroup="vg"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="apellidoRequerido" runat="server" ForeColor="Red" ErrorMessage="Requerido" ControlToValidate="apellidoTextBox" ValidationGroup="vg"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="emailLabel" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="emailRequerido" runat="server" ForeColor="Red" ErrorMessage="Requerido" ControlToValidate="emailTextBox" ValidationGroup="vg" ></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="emailValidator" runat="server"  ForeColor="Red" ControlToValidate="emailTextBox" ErrorMessage="Incorrecto" ValidationExpression="^[^@]+@[^@]+\.[a-zA-Z]{2,}$" ValidationGroup="vg"></asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="direccionLabel" runat="server" Text="Direccion: "></asp:Label>
        <asp:TextBox ID="direccionTextBox" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="direccionRequerido" runat="server" ForeColor="Red" ControlToValidate="direccionTextBox" ValidationGroup="vg" ErrorMessage="Requerido"></asp:RequiredFieldValidator>

        <br />
        <asp:Label ID="telefonoLabel" runat="server" Text="Telefono: "></asp:Label>
        <asp:TextBox ID="telefonoTextBox" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="telefonoRequerido" runat="server" ForeColor="Red" ControlToValidate="telefonoTextBox" ValidationGroup="vg" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="fechaNacimientoLabel" runat="server" Text="FechaNacimiento: "></asp:Label>
        <asp:TextBox ID="fechaNacimientoTextBox" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="fechaNacimientorRequerida" ValidationGroup="vg" ControlToValidate="fechaNacimientoTextBox" ForeColor="Red" runat="server" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
         <asp:CompareValidator id="cvlFecha" runat="server" ControlToValidate="fechaNacimientoTextBox" Type="Date" Operator="DataTypeCheck" ForeColor="Red" ErrorMessage="Ingrese una fecha válida." ValidationGroup="vg"> </asp:CompareValidator>
        <br />
        <asp:Label ID="legajoLabel" runat="server" Text="Legajo: "></asp:Label>
        <asp:TextBox ID="legajoTextBox" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="legajoRequerido" runat="server" ForeColor="Red" ControlToValidate="legajoTextBox" ValidationGroup="vg" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
         <asp:RangeValidator ID="rngLegajo" runat="server" ControlToValidate="legajoTextBox" Type="Integer" MinimumValue="1" MaximumValue="10000" ErrorMessage="Ingrese un legajo valido." ForeColor="Red" ToolTip="Ingrese un legajo valido." ValidationGroup="vg"/>

        <br />
        <asp:Label ID="planLabel" runat="server" Text="Plan: "></asp:Label>
        <asp:DropDownList ID="planDropDown" runat="server" AppendDataBoundItems="True">
            <asp:ListItem Value="0" Text="--Seleccione una opción--" Enabled="True"></asp:ListItem>
        </asp:DropDownList>
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server" >
        <asp:LinkButton ID="editarlinkButton" runat="server" OnClick="editarlinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="formActionPanel" Visible="false" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click" ValidationGroup="vg">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButtom" runat="server" OnClick="cancelarLinkButtom_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="ValidationActionPanel" runat="server">
        <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" ValidationGroup="vg" />
    </asp:Panel>

</asp:Content>

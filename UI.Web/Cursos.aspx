<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server" >
        <asp:gridView ID="gridView" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
             <Columns>  
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="Año Calendario" DataField="AnioCalendario" />
                 <asp:BoundField HeaderText="Cupo" DataField="Cupo" />
                <asp:BoundField HeaderText="Comision" DataField="ComisionDescripcion" />
                 <asp:BoundField HeaderText="Materia" DataField="MateriaDescripcion" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:gridView>
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="descripcionTextBox" ErrorMessage="La descripcion no puede estar vacía" ForeColor="Red" ToolTip="La descripcion no puede estar vacía" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="anioCalendarioLabel" runat="server" Text="Año calendario: "></asp:Label>
        <asp:TextBox ID="anioCalendarioTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfanioCalendario" runat="server" ControlToValidate="anioCalendarioTextBox"  ErrorMessage="El Año calendario no puede estar vacío" ForeColor="Red" ToolTip="El Año calendario no puede estar vacío" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="cupoLabel" runat="server" Text="Cupo: "></asp:Label>
        <asp:TextBox ID="cupoTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCupo" runat="server" ControlToValidate="CupoTextBox"  ErrorMessage="El cupo no puede estar vacio" ForeColor="Red" ToolTip="El cupo no puede estar vacio" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="MateriaLabel" runat="server" Text="Materia: "></asp:Label>
        <asp:DropDownList ID="MateriaDropDown" runat="server" AppendDataBoundItems="True">
            <asp:ListItem Value="0" Text="--Seleccione una opción--" Enabled="True"></asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvMateria" runat="server" ControlToValidate="MateriaDropDown" ErrorMessage="Seleccione una materia" ForeColor="Red" ToolTip="No seleccionó una materia" InitialValue="0" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />
         <asp:Label ID="ComisionLabel" runat="server" Text="Comision: "></asp:Label>
        <asp:DropDownList ID="ComisionDropDown" runat="server" AppendDataBoundItems="True">
            <asp:ListItem Value="0" Text="--Seleccione una opción--" Enabled="True"></asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvComision" runat="server" ControlToValidate="ComisionDropDown" ErrorMessage="Seleccione una comision" ForeColor="Red" ToolTip="No seleccionó una comision" InitialValue="0" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />
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

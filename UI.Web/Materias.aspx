<%@ Page Title="Materias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>  
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="HS Semanales" DataField="HSSemanales" />
                <asp:BoundField HeaderText="HS Totales" DataField="HSTotales" />
                <asp:BoundField HeaderText="Plan" DataField="PlanDescripcion" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="descripcionTextBox" ErrorMessage="La descripcion no puede estar vacía" ForeColor="Red" ToolTip="La descripcion no puede estar vacía" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="hssemLabel" runat="server" Text="Hs Semanales: "></asp:Label>
        <asp:TextBox ID="hssemTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvHssem" runat="server" ControlToValidate="hssemTextBox" ErrorMessage="Las horas semanales de la materia no pueden estar vacías" ForeColor="Red" ToolTip="Las horas semanales de la materia no pueden estar vacías" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="hstotLabel" runat="server" Text="Hs Totales: "></asp:Label>
        <asp:TextBox ID="hstotTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="revHstot" runat="server" ControlToValidate="hstotTextBox" ErrorMessage="Las horas totales de la materia no pueden estar vacías" ForeColor="Red" ToolTip="Las horas totales de la materia no pueden estar vacías"  ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />

        <asp:Label ID="planLabel" runat="server" Text="Plan: "></asp:Label>
        <asp:DropDownList ID="planDropDown" runat="server" AppendDataBoundItems="True">
            <asp:ListItem Value="0" Text="--Seleccione una opción--" Enabled="True"></asp:ListItem>
        </asp:DropDownList>
        <br />
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server" >
        <asp:LinkButton ID="editarlinkButton" runat="server" OnClick="editarlinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="formActionPanel" Visible="false" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButtom" runat="server" OnClick="cancelarLinkButtom_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="ValidationActionPanel" runat="server">
        <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" ValidationGroup="vg" />
    </asp:Panel>

</asp:Content>

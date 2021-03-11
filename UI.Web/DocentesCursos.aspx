<%@ Page Title="DocentesCursos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DocentesCursos.aspx.cs" Inherits="UI.Web.DocentesCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server" >
        <asp:gridView ID="gridView" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" CssClass="table table-responsive-lg">
             <Columns>  
                <asp:BoundField HeaderText="Curso" DataField="CursoDescripcion" />
                 <asp:BoundField HeaderText="Docente" DataField="LegajoDocente" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:gridView>
    </asp:Panel>
    <div class="form-group">
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        
        <br />
        <asp:Label ID="DocenteLabel" runat="server" Text="Docente: "></asp:Label>
        <asp:DropDownList ID="DocenteDropDown" class="form-control" runat="server" AppendDataBoundItems="True">
            <asp:ListItem Value="0" Text="--Seleccione una opción--" Enabled="True"></asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvDocente" runat="server" ControlToValidate="DocenteDropDown" ErrorMessage="Seleccione un docente" ForeColor="Red" ToolTip="No seleccionó un docente" InitialValue="0" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />
         <asp:Label ID="CursoLabel" runat="server" Text="Curso: "></asp:Label>
        <asp:DropDownList ID="CursoDropDown" class="form-control" runat="server" AppendDataBoundItems="True">
            <asp:ListItem Value="0" Text="--Seleccione una opción--" Enabled="True"></asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvCurso" runat="server" ControlToValidate="CursoDropDown" ErrorMessage="Seleccione un curso" ForeColor="Red" ToolTip="No seleccionó un curso" InitialValue="0" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />

    </asp:Panel>
    </div>
    <asp:Panel ID="gridActionsPanel" runat="server" class="btn-group">
        <asp:LinkButton ID="editarlinkButton" class="btn btn-secondary" runat="server" OnClick="editarlinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" class="btn btn-secondary" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" class="btn btn-secondary" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="formActionPanel" Visible="false" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" class="btn btn-success" runat="server" OnClick="aceptarLinkButton_Click" ValidationGroup="vg">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButtom" class="btn btn-danger" runat="server" OnClick="cancelarLinkButtom_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="ValidationActionPanel" runat="server">
        <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" ValidationGroup="vg" />
    </asp:Panel>
</asp:Content>
<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CondicionesAlumnos.aspx.cs" Inherits="UI.Web.RegistroCondicionesAlumnos" %>


<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
     <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black" 
            SelectedRowStyle-ForeColor="White" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" CssClass="table table-responsive-lg">
            <Columns>
                <asp:BoundField HeaderText="Legajo Alumno" DataField="LegajoAlumno" />
                <asp:BoundField HeaderText="Materia" DataField="CursoDescripcion" />
                <asp:BoundField HeaderText="Condicion" DataField="AlumnoCondicion" />
                <asp:BoundField HeaderText="Nota" DataField="AlumnoNota" />
                <asp:BoundField HeaderText="CargoDocente" DataField="Cargo" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
     </asp:Panel>
    
    <div class="form-group">
    <asp:Panel ID="formPanel" Visible="false" runat="server" >
        <asp:Label ID="LegajoLabel" runat="server" Text="Legajo Alumno: "></asp:Label>
        <asp:TextBox ID="LegajoTextBox" class="form-control" runat="server" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="LegajoRequerido" runat="server" ForeColor="Red" ErrorMessage="Requerido" ControlToValidate="LegajoTextBox" ValidationGroup="vg"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="MateriaLabel" runat="server" Text="Materia: "></asp:Label>
        <asp:TextBox ID="MateriaTextBox" class="form-control" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="MateriaRequerido" runat="server" ForeColor="Red" ErrorMessage="Requerido" ControlToValidate="MateriaTextBox" ValidationGroup="vg"></asp:RequiredFieldValidator>
        <br />
   
        <asp:Label ID="NotaLabel" runat="server" Text="Nota: "></asp:Label>
        <asp:TextBox ID="NotaTextBox" class="form-control" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="NotaRequerido" runat="server" ForeColor="Red" ControlToValidate="NotaTextBox" ValidationGroup="vg" ErrorMessage="Requerido"></asp:RequiredFieldValidator>

        <br />
        <asp:Label ID="CargoLabel" runat="server" Text="Cargo "></asp:Label>
        <asp:TextBox ID="CargoTextBox" class="form-control" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="CargoRequerido" runat="server" ForeColor="Red" ControlToValidate="CargoTextBox" ValidationGroup="vg" ErrorMessage="Requerido"></asp:RequiredFieldValidator>
        <br />
         <asp:Label ID="CondicionLabel" runat="server" Text="Condicion: "></asp:Label>
          <asp:DropDownList ID="CondicionDropDown" class="form-control" runat="server" AppendDataBoundItems="True">
            <asp:ListItem Value="0" Text="--Seleccione una opción--" Enabled="True"></asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="revCondicion" runat="server" ControlToValidate="CondicionDropDown" ErrorMessage="Seleccione una condicion" ForeColor="Red" ToolTip="No seleccionó una condicion" InitialValue="0" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />
    </asp:Panel>
    </div>

    <asp:Panel ID="gridActionsPanel" runat="server" class="btn-group">
        <asp:LinkButton ID="editarlinkButton" class="btn btn-secondary" runat="server" OnClick="editarlinkButton_Click">Editar</asp:LinkButton>
 
        <br />
    </asp:Panel>
    
    <asp:Panel ID="formActionPanel" Visible="false" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" class="btn btn-success" runat="server" OnClick="aceptarLinkButton_Click" ValidationGroup="vg">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButtom" class="btn btn-danger" runat="server" OnClick="cancelarLinkButtom_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="ValidationActionPanel" runat="server">
        <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" ValidationGroup="vg" />
    </asp:Panel>
</asp:Content>

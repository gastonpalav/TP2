<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstadoAcademico.aspx.cs" Inherits="UI.Web.EstadoAcademico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <h1>Estado Academico</h1>
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"   DataKeyNames="ID"  CssClass="table table-responsive-lg">
            <Columns>
                <asp:BoundField HeaderText="Materia" DataField="MateriaDescripcion" />
                <asp:BoundField HeaderText="Comision" DataField="ComisionDescripcion" />
                <asp:BoundField HeaderText="Plan" DataField="PlanDescripcion" />
                <asp:BoundField HeaderText="Especialidad" DataField="EspecialidadDescripcion" />
                <asp:BoundField HeaderText="condicion" DataField="condicion" />
                <asp:BoundField HeaderText="Nota" DataField="nota" />
            </Columns>
        </asp:GridView>
     </asp:Panel>
</asp:Content>

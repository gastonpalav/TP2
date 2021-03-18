<%@ Page Language="C#" enableSessionState="true"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteAlumnosComisiones.aspx.cs" Inherits="UI.Web.ReporteAlumnosComisiones" %>
 
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>


<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

   <asp:Button class="btn btn-secondary" runat="server" Text="Generar Reporte" OnClick="GenerarReporte_Click" Width="201px"/>


</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuDocentes.aspx.cs" Inherits="UI.Web.MenuDocentes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <style>
        .mainMenu{
            background-color:black;
            text-align:center;
            font-size:20px;
            color:white;
            padding:20px;
            margin-left:30px
        }

        .div1{
            background-color:black;
            height:auto;
            width:auto;
            border-radius:5px;
        }

        

    </style>
    <div class="div1">
    <asp:Menu ID="Menu"  Orientation="Horizontal" runat="server" DynamicMenuItemStyle-Font-Bold="true" StaticSubMenuIndent="10px" OnMenuItemDataBound="Menu_MenuItemDataBound">
        <LevelMenuItemStyles>
            <asp:MenuItemStyle CssClass="mainMenu" />
                <asp:MenuItemStyle CssClass="subMenu" />
       
      </LevelMenuItemStyles>
        <Items>
            <asp:MenuItem NavigateUrl="~/DatosPersonales.aspx" Text="Datos personales" Value="1"/>
        </Items>
</asp:Menu>
        </div>
</asp:Content>


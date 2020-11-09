using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class MenuAdministrador : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //string userID = (string)Session["UsuarioID"];
            //if(!IsPostBack)
            //{
            //    if(userID=="" || userID==null)
            //    {
            //        Response.Redirect("~/Login.aspx");
            //    }
            //}
        }

        protected void Menu_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            if(SiteMap.CurrentNode !=null)
            {
                if(e.Item.Text == SiteMap.CurrentNode.Title)
                {
                    if(e.Item.Parent!=null)
                    {
                        e.Item.Parent.Selected = true;
                    }
                    else
                    {
                        e.Item.Selected = true;
                        
                    }
                }
            }
        }

        protected void Menu_MenuItemDataBound1(object sender, MenuEventArgs e)
        {

        }
    }
}
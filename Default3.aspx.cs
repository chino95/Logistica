using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    Cls_Conexion con = new Cls_Conexion();
    protected void contacto(object sender, EventArgs e)
    {
        int a = 0;
        string nom = String.Format("{0}", Request.Form["Name"]);
        string correo = String.Format("{0}", Request.Form["Email"]);
        string  nume = String.Format("{0}", Request.Form["Phone"]);
        string mensa = String.Format("{0}", Request.Form["Message"]);
        con.contacto(nom, correo, nume, mensa);
    }
}
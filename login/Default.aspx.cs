using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {        
    }
    protected void Registrar()
    {
      
    }
    Cls_Conexion con = new Cls_Conexion();

    protected void boton(object sender,EventArgs e)
    {
        string usu = String.Format("{0}", Request.Form["correo"]);
        string pass = String.Format("{0}", Request.Form["psw"]);
        con.sesion(usu,pass);

    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class usuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["pan"] = (Panel)Panel1;
        }
    }

    protected void Btn_agregar_Click(object sender, EventArgs e)
    {
        DataTable dt1 = new DataTable();
        dt1.Columns.Add("Nombre");
        dt1.Columns.Add("Apellido Paterno");
        dt1.Columns.Add("Apellido Materno");
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            DataRow dr1 = dt1.NewRow();
            dr1[0] = GridView1.Rows[i].Cells[1].Text;
            dr1[1] = GridView1.Rows[i].Cells[2].Text;
            dr1[2] = GridView1.Rows[i].Cells[3].Text;
            dt1.Rows.Add(dr1);
        }
        DataRow dr = dt1.NewRow();
        dr[0] = txt_nombre.Value.ToString();
        dr[1] = txt_apep.Value.ToString();
        dr[2] = txt_apem.Value.ToString();
        dt1.Rows.Add(dr);
        GridView1.DataSource = dt1;
        GridView1.DataBind();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string a = e.CommandArgument.ToString();
        DataTable dt1 = new DataTable();
        dt1.Columns.Add("Nombre");
        dt1.Columns.Add("Apellido Paterno");
        dt1.Columns.Add("Apellido Materno");
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            if (a != i.ToString())
            {
                DataRow dr1 = dt1.NewRow();
                dr1[0] = GridView1.Rows[i].Cells[1].Text;
                dr1[1] = GridView1.Rows[i].Cells[2].Text;
                dr1[2] = GridView1.Rows[i].Cells[3].Text;
                dt1.Rows.Add(dr1);
            }
        }    
        GridView1.DataSource = dt1;
        GridView1.DataBind();
    }

    protected void Btn_panel_Click(object sender, EventArgs e)
    {
        
        TextBox MyTextBox = new TextBox();        
        MyTextBox.CssClass = "text";
        MyTextBox.Attributes.Add("placeholder","Nombre");
        TextBox MyTextBox2 = new TextBox();
        MyTextBox2.CssClass = "text";
        MyTextBox2.Attributes.Add("placeholder", "Apellido Paterno");
        TextBox MyTextBox3 = new TextBox();
        MyTextBox3.CssClass = "text";
        MyTextBox3.Attributes.Add("placeholder", "Apellido Materno");
        Button btn = new Button();
        btn.CssClass = "btn";
        btn.Text = "Agregar";
        Panel p =(Panel)Session["pan"];
        
        p.Controls.Add(MyTextBox);
        p.Controls.Add(MyTextBox2);
        p.Controls.Add(MyTextBox3);
        p.Controls.Add(Btn_agregar);

        Panel1.Controls.Add(p);
        
        
        
        
    }
}
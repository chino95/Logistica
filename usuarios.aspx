<%@ Page Language="C#" AutoEventWireup="true" CodeFile="usuarios.aspx.cs" Inherits="usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Logistica Balderrama | Home</title>

    <!-- Meta-Tags -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <meta name="keywords" content="Harvester a Responsive Web Template, Bootstrap Web Templates, Flat Web Templates, Android Compatible Web Template, Smartphone Compatible Web Template, Free Webdesigns for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design">
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- //Meta-Tags -->

    <!-- Custom-Stylesheet-Links -->
    <!-- Bootstrap-CSS -->
    <link rel="stylesheet" href="App_themes/css/bootstrap.min.css" type="text/css" media="all">
    <!-- Index-Page-CSS -->
    <link rel="stylesheet" href="App_Themes/css/style.css" type="text/css" media="all">
    <!-- PopUp-Box-CSS -->
    <link rel="stylesheet" href="App_Themes/css/chocolat.css" type="text/css" media="all">
    <!-- //Custom-Stylesheet-Links -->

    <!-- Fonts -->
    <!-- Body-Font -->
    <link rel="stylesheet" href="//fonts.googleapis.com/css?family=Open+Sans:400,300,600,700" type="text/css" media="all">
    <!-- Logo-Font -->
    <link rel="stylesheet" href="//fonts.googleapis.com/css?family=Baloo+Bhai" type="text/css" media="all">
    <!-- Headings-Font -->
    <link rel="stylesheet" href="//fonts.googleapis.com/css?family=Raleway:400,500,600,700,800" type="text/css" media="all">
    <!-- //Fonts -->

</head>
<body>
    
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        


            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
        <div class="message">
        <div class="col-md-6 grid_6 c1">
            <input type="text" id="txt_nombre" class="text" name="Name" placeholder="Nombre" required="" runat="server"/>
            <input type="text" id="txt_apep" class="text" name="Apellido Paterno" placeholder="Apellido Paterno" required="" runat="server"/>
            <input type="text" id="txt_apem" class="text" name="Apellido Materno" placeholder="Apellido Materno" required="" runat="server"/>
            <div class="divider"></div>
            <asp:Button ID="Btn_agregar" runat="server" Text="Agregar" class="btn" OnClick="Btn_agregar_Click"/>
            <asp:Button ID="Btn_panel" runat="server" Text="Agrega form" class="btn" OnClick="Btn_panel_Click"/>
        </div>        
        <div class="clearfix"></div>
            <asp:GridView ID="GridView1" runat="server" CssClass="table-condensed" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:ButtonField ButtonType="Button"
                    CommandName="Select" HeaderText="eliminar" 
                     ShowHeader="True" Text="Button" />
                </Columns>
            </asp:GridView>
    </div>
    </form>
    
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form action="#" method="post" class="contact_form" runat="server">
    <div class="message">
        <div class="col-md-6 grid_6 c1">
            <input type="text" class="text" name="Name" placeholder="Su nombre" required="">
            <input type="email" class="text email" name="Email" placeholder="Su correo" required="">
            <input type="text" class="text" name="Phone" placeholder="Su telefono" required="">
        </div>

        <div class="col-md-6 grid_6 c2">
            <textarea name="Message" placeholder="Mensaje" required=""></textarea>
            <input type="submit" class="more_btn" value="Enviar Mensaje" runat="server" onserverclick="contacto">
        </div>
        <div class="clearfix"></div>
    </div>
</form>
</asp:Content>


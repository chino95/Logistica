using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


/// <summary>
/// Summary description for Cls_Conexion
/// </summary>
public class Cls_Conexion
{
   
    public void sesion(string usuario, string contraseña)
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Port=3306;database=agencia; Uid=root; pwd=1234;");
        conexion.Open();
        MySqlCommand _comando = new MySqlCommand("insert into agencia.sesion values(@usu,@contra);", conexion);
        _comando.Parameters.AddWithValue("@usu", usuario);
        _comando.Parameters.AddWithValue("@contra", contraseña);
         _comando.ExecuteReader();        
        conexion.Close();
    }
    public void contacto(string nombre,string correo,string numero,string mensaje)
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Port=3306;database=agencia; Uid=root; pwd=1234;");
        conexion.Open();
        MySqlCommand _comando = new MySqlCommand("insert into contacto values(@nombre,@correo,@nume,@mensa);", conexion);
        _comando.Parameters.AddWithValue("@nombre", nombre);
        _comando.Parameters.AddWithValue("@correo",correo);
        _comando.Parameters.AddWithValue("@nume", numero);
        _comando.Parameters.AddWithValue("@mensa", mensaje);
        _comando.ExecuteReader();
        conexion.Close();
    }
}
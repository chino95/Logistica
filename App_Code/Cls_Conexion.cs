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
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=FerreteriaL1; Uid=root; pwd=;");
        MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM `sesion` WHERE Usuario =@usu and Contraseña =@contra "), conexion);
        _comando.Parameters.AddWithValue("@usu", usuario);
        _comando.Parameters.AddWithValue("@contra", contraseña);
        MySqlDataReader _reader = _comando.ExecuteReader();
        while (_reader.Read())
        {
            usuario = _reader.GetString(1);
            contraseña = _reader.GetString(2);
        }
        _reader.Close();
        conexion.Close();
    }
}
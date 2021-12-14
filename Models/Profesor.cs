using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Profesor
    {
        private string Cedula;
        private string Nombre;
        private string Apellido_I;
        private string Apellido_II;
        private DateTime Fecha_nacimiento;
        private string Correo;
        private string Foto;
        private string Contraseña;

        public string Cedula1 { get => Cedula; set => Cedula = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido_I1 { get => Apellido_I; set => Apellido_I = value; }
        public string Apellido_II1 { get => Apellido_II; set => Apellido_II = value; }
        public DateTime Fecha_nacimiento1 { get => Fecha_nacimiento; set => Fecha_nacimiento = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Foto1 { get => Foto; set => Foto = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }

        public string Insert_Profesor_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC I_PROFESOR ?,?,?,?,?,?,?,?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Cedula1, 2);
                    objeto_conexion.nuevo_parametro(Nombre1, 2);
                    objeto_conexion.nuevo_parametro(Apellido_I1, 2);
                    objeto_conexion.nuevo_parametro(Apellido_II1, 2);
                    objeto_conexion.nuevo_parametro(Fecha_nacimiento1, 4);
                    objeto_conexion.nuevo_parametro(Correo1, 2);
                    objeto_conexion.nuevo_parametro(Foto1, 2);
                    objeto_conexion.nuevo_parametro(Contraseña1, 2);

                    CONTENEDOR = objeto_conexion.busca();

                    objeto_conexion.conexion.Close();
                    objeto_conexion.conexion.Dispose();
                    CONTENEDOR.Close();
                    return "Se insertó la información correctamente";
                }
                else return "Sin Conexión con la Base de Datos";
            }
            catch (Exception err)
            {
                return err.Message;
            }
        }
        public string Delete_Profesor_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC D_PROFESOR ?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Cedula1, 2);

                    CONTENEDOR = objeto_conexion.busca();

                    objeto_conexion.conexion.Close();
                    objeto_conexion.conexion.Dispose();
                    CONTENEDOR.Close();
                    return "Se eliminó la información correctamente";
                }
                else return "Sin Conexión con la Base de Datos";
            }
            catch (Exception err)
            {
                return err.Message;
            }
        }
        public string Update_Profesor_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC U_PROFESOR ?,?,?,?,?,?,?,?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Cedula1, 2);
                    objeto_conexion.nuevo_parametro(Nombre1, 2);
                    objeto_conexion.nuevo_parametro(Apellido_I1, 2);
                    objeto_conexion.nuevo_parametro(Apellido_II1, 2);
                    objeto_conexion.nuevo_parametro(Fecha_nacimiento1, 4);
                    objeto_conexion.nuevo_parametro(Correo1, 2);
                    objeto_conexion.nuevo_parametro(Foto1, 2);
                    objeto_conexion.nuevo_parametro(Contraseña1, 2);


                    CONTENEDOR = objeto_conexion.busca();

                    objeto_conexion.conexion.Close();
                    objeto_conexion.conexion.Dispose();
                    CONTENEDOR.Close();
                    return "Se actualizó la información correctamente";
                }
                else return "Sin Conexión con la Base de Datos";
            }
            catch (Exception err)
            {
                return err.Message;
            }
        }

        public Profesor Select_Profesor()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            Profesor profesor = new Profesor();
            profesor.Nombre1 = "NO EXISTE";
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC S_PROFESOR ?";

                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Cedula1.ToString(), 2); ;
                    CONTENEDOR = objeto_conexion.busca();
                    while (CONTENEDOR.Read())
                    {

                        profesor.Cedula1 = Convert.ToString(CONTENEDOR["CEDULA"].ToString());
                        profesor.Nombre1 = Convert.ToString(CONTENEDOR["NOMBRE"].ToString());
                        profesor.Apellido_I1 = Convert.ToString(CONTENEDOR["APELLIDO_I"].ToString());
                        profesor.Apellido_II1 = Convert.ToString(CONTENEDOR["APELLIDO_II"].ToString());
                        profesor.Fecha_nacimiento1 = Convert.ToDateTime(CONTENEDOR["FECHA_NACIMIENTO"].ToString());
                        profesor.Correo1 = Convert.ToString(CONTENEDOR["CORREO"].ToString());
                        profesor.Foto1 = Convert.ToString(CONTENEDOR["FOTO"].ToString());
                        profesor.Contraseña1 = Convert.ToString(CONTENEDOR["CONTRASENA"].ToString());

                    }
                    objeto_conexion.conexion.Close();
                    objeto_conexion.conexion.Dispose();
                    CONTENEDOR.Close();
                    return profesor;
                }
                else
                {


                    return profesor;
                }
            }
            catch (Exception error)
            {
                profesor.Nombre1 = "Error";
                return profesor;
            }
        }
        public List<Profesor> Select_All_Profesor_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            List<Profesor> lista_devolver = new List<Profesor>();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC ST_PROFESOR";
                    objeto_conexion.nueva_consulta(query);
                    CONTENEDOR = objeto_conexion.busca();
                    while (CONTENEDOR.Read())
                    {
                        Profesor profesor = new Profesor();
                        profesor.Cedula1 = Convert.ToString(CONTENEDOR["CEDULA"].ToString());
                        profesor.Nombre1 = Convert.ToString(CONTENEDOR["NOMBRE"].ToString());
                        profesor.Apellido_I1 = Convert.ToString(CONTENEDOR["APELLIDO_I"].ToString());
                        profesor.Apellido_II1 = Convert.ToString(CONTENEDOR["APELLIDO_II"].ToString());
                        profesor.Fecha_nacimiento1 = Convert.ToDateTime(CONTENEDOR["FECHA_NACIMIENTO"].ToString());
                        profesor.Correo1 = Convert.ToString(CONTENEDOR["CORREO"].ToString());
                        profesor.Foto1 = Convert.ToString(CONTENEDOR["FOTO"].ToString());
                        profesor.Contraseña1 = Convert.ToString(CONTENEDOR["CONTRASENA"].ToString());

                        lista_devolver.Add(profesor);

                    }
                    objeto_conexion.conexion.Close();
                    objeto_conexion.conexion.Dispose();
                    CONTENEDOR.Close();
                    return lista_devolver;
                }
                else
                {


                    return lista_devolver;
                }
            }
            catch (Exception error)
            {
                return lista_devolver;
            }

        }
    }
}
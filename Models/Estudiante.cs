using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Estudiante
    {
        private string Carnet;
        private string Nombre;
        private string Apellido_I;
        private string Apellido_II;
        private DateTime Fecha_nacimiento;
        private string Correo;
        private string Foto;
        private string Contraseña;

        public string Carnet1 { get => Carnet; set => Carnet = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido_I1 { get => Apellido_I; set => Apellido_I = value; }
        public string Apellido_II1 { get => Apellido_II; set => Apellido_II = value; }
        public DateTime Fecha_nacimiento1 { get => Fecha_nacimiento; set => Fecha_nacimiento = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Foto1 { get => Foto; set => Foto = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }

        public string Insert_Estudiante_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC I_ESTUDIANTE ?,?,?,?,?,?,?,?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Carnet1, 2);
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

        public string Delete_Estudiante_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC D_ESTUDIANTE ?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Carnet1, 2);

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

        public string Update_Estudiante_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC U_ESTUDIANTE ?,?,?,?,?,?,?,?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Carnet1, 2);
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
        public Estudiante Select_Estudiante()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            Estudiante estudiante = new Estudiante();
            estudiante .Nombre1 = "NO EXISTE";
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;
                    query = "EXEC S_ESTUDIANTE ?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Carnet1.ToString(), 2); ;
                    CONTENEDOR = objeto_conexion.busca();
                    while (CONTENEDOR.Read())
                    {

                        estudiante.Carnet1 = Convert.ToString(CONTENEDOR["CARNET"].ToString());
                        estudiante.Nombre1 = Convert.ToString(CONTENEDOR["NOMBRE"].ToString());
                        estudiante.Apellido_I1 = Convert.ToString(CONTENEDOR["APELLIDO_I"].ToString());
                        estudiante.Apellido_II1 = Convert.ToString(CONTENEDOR["APELLIDO_II"].ToString());
                        estudiante.Fecha_nacimiento1 = Convert.ToDateTime(CONTENEDOR["FECHA_NACIMIENTO"].ToString());
                        estudiante.Correo1 = Convert.ToString(CONTENEDOR["CORREO"].ToString());
                        estudiante.Foto1 = Convert.ToString(CONTENEDOR["FOTO"].ToString());
                        estudiante.Contraseña1 = Convert.ToString(CONTENEDOR["CONTRASENA"].ToString());

                    }
                    objeto_conexion.conexion.Close();
                    objeto_conexion.conexion.Dispose();
                    CONTENEDOR.Close();
                    return estudiante;
                }
                else
                {


                    return estudiante;
                }
            }
            catch (Exception error)
            {
                estudiante.Nombre1 = "Error";
                return estudiante;
            }
        }

        public List<Estudiante> Select_All_Estudiante_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            List<Estudiante> lista_devolver = new List<Estudiante>();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC ST_ESTUDIANTE";
                    objeto_conexion.nueva_consulta(query);
                    CONTENEDOR = objeto_conexion.busca();
                    while (CONTENEDOR.Read())
                    {
                        Estudiante estudiante = new Estudiante();
                        estudiante.Carnet1 = Convert.ToString(CONTENEDOR["CARNET"].ToString());
                        estudiante.Nombre1 = Convert.ToString(CONTENEDOR["NOMBRE"].ToString());
                        estudiante.Apellido_I1 = Convert.ToString(CONTENEDOR["APELLIDO_I"].ToString());
                        estudiante.Apellido_II1 = Convert.ToString(CONTENEDOR["APELLIDO_II"].ToString());
                        estudiante.Fecha_nacimiento1 = Convert.ToDateTime(CONTENEDOR["FECHA_NACIMIENTO"].ToString());
                        estudiante.Correo1 = Convert.ToString(CONTENEDOR["CORREO"].ToString());
                        estudiante.Foto1 = Convert.ToString(CONTENEDOR["FOTO"].ToString());
                        estudiante.Contraseña1 = Convert.ToString(CONTENEDOR["CONTRASENA"].ToString());

                        lista_devolver.Add(estudiante);

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
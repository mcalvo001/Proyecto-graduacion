using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Clase
    {
        private int Id_clase;
        private Profesor Id_profesor;
        private Materia Id_materia;
        private string Nombre_clase;
        public int Id_clase1 { get => Id_clase; set => Id_clase = value; }
        public Profesor Id_profesor1 { get => Id_profesor; set => Id_profesor = value; }
        public Materia Id_materia1 { get => Id_materia; set => Id_materia = value; }
        public string Nombre_clase1 { get => Nombre_clase; set => Nombre_clase = value; }
        public string Insert_Clase_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC I_CLASE ?,?,?,?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_clase1, 1);
                    objeto_conexion.nuevo_parametro(Id_profesor1.Cedula1, 2);
                    objeto_conexion.nuevo_parametro(Id_materia1.Id_materia1, 1);
                    objeto_conexion.nuevo_parametro(Nombre_clase1, 2);

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
        public string Delete_Clase_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC D_CLASE ?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_clase1, 1);

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
        public string Update_Clase_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC U_CLASE ?,?,?,?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_clase1, 1);
                    objeto_conexion.nuevo_parametro(Id_profesor1.Cedula1, 2);
                    objeto_conexion.nuevo_parametro(Id_materia1.Id_materia1, 1);
                    objeto_conexion.nuevo_parametro(Nombre_clase1, 2);

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
        public Clase Select_Clase()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            Clase clase = new Clase();
            clase.Id_clase1 = -1;
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC S_CLASE ?";

                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_clase1, 1); ;
                    CONTENEDOR = objeto_conexion.busca();
                    while (CONTENEDOR.Read())
                    {

                        clase.Id_clase1 = Convert.ToInt16(CONTENEDOR["ID_CLASE"].ToString());

                        Profesor profesor = new Profesor();
                        profesor.Cedula1 = Convert.ToString(CONTENEDOR["ID_PROFESOR"].ToString());
                        clase.Id_profesor1 = profesor;

                        Materia materia = new Materia();
                        materia.Id_materia1 = Convert.ToInt16(CONTENEDOR["ID_MATERIA"].ToString());
                        clase.Id_materia1 = materia;

                        clase.Nombre_clase1 = Convert.ToString(CONTENEDOR["NOMBRE_CLASE"].ToString());

                    }
                    objeto_conexion.conexion.Close();
                    objeto_conexion.conexion.Dispose();
                    CONTENEDOR.Close();
                    return clase;
                }
                else
                {
                    return clase;
                }
            }
            catch (Exception error)
            {
                clase.Id_clase1 = -2;
                return clase;
            }
        }

        public Clase Select_ClasexEstudiante()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            Clase clase = new Clase();
            clase.Id_clase1 = -1;
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC S_CLASE ?";

                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_clase1, 1); ;
                    CONTENEDOR = objeto_conexion.busca();
                    while (CONTENEDOR.Read())
                    {

                        clase.Id_clase1 = Convert.ToInt16(CONTENEDOR["ID_CLASE"].ToString());

                        Profesor profesor = new Profesor();
                        profesor.Cedula1 = Convert.ToString(CONTENEDOR["ID_PROFESOR"].ToString());
                        clase.Id_profesor1 = profesor;

                        Materia materia = new Materia();
                        materia.Id_materia1 = Convert.ToInt16(CONTENEDOR["ID_MATERIA"].ToString());
                        clase.Id_materia1 = materia;

                        clase.Nombre_clase1 = Convert.ToString(CONTENEDOR["NOMBRE_CLASE"].ToString());

                    }
                    objeto_conexion.conexion.Close();
                    objeto_conexion.conexion.Dispose();
                    CONTENEDOR.Close();
                    return clase;
                }
                else
                {
                    return clase;
                }
            }
            catch (Exception error)
            {
                clase.Id_clase1 = -2;
                return clase;
            }
        }
        public List<Clase> Select_All_Clase_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            List<Clase> lista_devolver = new List<Clase>();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC ST_CLASE";
                    objeto_conexion.nueva_consulta(query);
                    CONTENEDOR = objeto_conexion.busca();
                    while (CONTENEDOR.Read())
                    {
                        Clase clase = new Clase();

                        clase.Id_clase1 = Convert.ToInt16(CONTENEDOR["ID_CLASE"].ToString());

                        Profesor profesor = new Profesor();
                        profesor.Cedula1 = Convert.ToString(CONTENEDOR["ID_PROFESOR"].ToString());
                        clase.Id_profesor1 = profesor;

                        Materia materia = new Materia();
                        materia.Id_materia1 = Convert.ToInt16(CONTENEDOR["ID_MATERIA"].ToString());
                        clase.Id_materia1 = materia;

                        clase.Nombre_clase1 = Convert.ToString(CONTENEDOR["NOMBRE_CLASE"].ToString());

                        lista_devolver.Add(clase);

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
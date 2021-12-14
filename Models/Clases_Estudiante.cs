using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Clases_Estudiante
    {
        private Clase Id_clase;
        private Estudiante Carnet;

        public Clase Id_clase1 { get => Id_clase; set => Id_clase = value; }
        public Estudiante Carnet1 { get => Carnet; set => Carnet = value; }

        public string Delete_Clase_Estudiante_BD() {
            return "Hola";
        }
        public string Insert_Clase_Estudiante_BD()
        {
            String respuesta = "0";

            ConexionconBD conx_detalles = new ConexionconBD();


            try
            {
                if (conx_detalles.inicializaBD())
                {
                    string CONSULTA;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    CONSULTA = "EXEC I_CLASES_ESTUDIANTES ?,?";
                    conx_detalles.nueva_consulta(CONSULTA);

                    conx_detalles.nuevo_parametro(Id_clase1.Id_clase1, 1);
                    conx_detalles.nuevo_parametro(Carnet1.Carnet1, 2);


                    CONTENEDOR = conx_detalles.busca();
                    conx_detalles.conexion.Close();
                    conx_detalles.conexion.Dispose();
                    CONTENEDOR.Close();
                    return "Se ha insertado el estudiante:" + Carnet1.Carnet1.ToString() + " en la clase "+ Id_clase1.Id_clase1.ToString() + " de forma correcta";
                }
                else
                {
                    return "No hay conexión con la base de datos";
                }
            }
            catch (Exception error)
            {
                return error.Message;
            }



        }

        public List<Clases_Estudiante> ClasesxEstudiante (string carnet)
        {
            List<Clases_Estudiante> clases_estudiante = new List<Clases_Estudiante>();

            ConexionconBD objeto_conexion = new ConexionconBD();


            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC S_CLASESxESTUDIANTES ?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(carnet, 2);
                    CONTENEDOR = objeto_conexion.busca();

                    while (CONTENEDOR.Read())
                    {
                        Clases_Estudiante clases_estudiante_l = new Clases_Estudiante();

                        Clase clase = new Clase();
                        clase.Id_clase1 = Convert.ToInt16(CONTENEDOR["ID_CLASE"].ToString());
                        clases_estudiante_l.Id_clase1 = clase;

                        Estudiante estudiante = new Estudiante();
                        estudiante.Carnet1 = Convert.ToString(CONTENEDOR["CARNET"].ToString());
                        clases_estudiante_l.Carnet1 = estudiante;

                        clases_estudiante.Add(clases_estudiante_l);
                    }
                    objeto_conexion.conexion.Close();
                    objeto_conexion.conexion.Dispose();
                    CONTENEDOR.Close();
                    return clases_estudiante;
                }
                else
                {


                    return clases_estudiante;
                }
            }
            catch (Exception error)
            {
                return clases_estudiante;
            }


        }
    }
}


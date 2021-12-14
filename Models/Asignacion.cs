using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Asignacion
    {
        private int Id_asignacion;
        private Clase Id_clase;
        private Tipo Id_tipo;
        private decimal Porcentaje;
        private DateTime Fecha_inicio;
        private DateTime Fecha_fin;
        private string Nombre_Asignacion;
        private string Instrucciones;
        
        public int Id_asignacion1 { get => Id_asignacion; set => Id_asignacion = value; }
        public Clase Id_clase1 { get => Id_clase; set => Id_clase = value; }
        public Tipo Id_tipo1 { get => Id_tipo; set => Id_tipo = value; }
        public decimal Porcentaje1 { get => Porcentaje; set => Porcentaje = value; }
        public DateTime Fecha_inicio1 { get => Fecha_inicio; set => Fecha_inicio = value; }
        public DateTime Fecha_fin1 { get => Fecha_fin; set => Fecha_fin = value; }
        public string Nombre_Asignacion1 { get => Nombre_Asignacion; set => Nombre_Asignacion = value; }
        public string Instrucciones1 { get => Instrucciones; set => Instrucciones = value; }
       
        public string Insert_Asignacion_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC I_ASIGNACIONES ?,?,?,?,?,?,?,?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_asignacion1, 1);
                    objeto_conexion.nuevo_parametro(Id_clase1.Id_clase1, 1);
                    objeto_conexion.nuevo_parametro(Id_tipo1.Id_tipo1, 1);
                    objeto_conexion.nuevo_parametro(Porcentaje1, 3);
                    objeto_conexion.nuevo_parametro(Fecha_inicio1, 4);
                    objeto_conexion.nuevo_parametro(Fecha_fin1, 4);
                    objeto_conexion.nuevo_parametro(Nombre_Asignacion1, 2);
                    objeto_conexion.nuevo_parametro(Instrucciones1, 2);


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
        public string Delete_Asignacion_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC D_ASIGNACIONES ?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_asignacion1, 1);

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
        public string Update_Asignacion_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC U_ASIGNACIONES ?,?,?,?,?,?,?,?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_asignacion1, 1);
                    objeto_conexion.nuevo_parametro(Id_clase1.Id_clase1, 1);
                    objeto_conexion.nuevo_parametro(Id_tipo1.Id_tipo1, 1);
                    objeto_conexion.nuevo_parametro(Porcentaje1, 3);
                    objeto_conexion.nuevo_parametro(Fecha_inicio1, 4);
                    objeto_conexion.nuevo_parametro(Fecha_fin1, 4);
                    objeto_conexion.nuevo_parametro(Nombre_Asignacion1, 2);
                    objeto_conexion.nuevo_parametro(Instrucciones1, 2);

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
        public Asignacion Select_Asignacion()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            Asignacion asignacion = new Asignacion();
            asignacion.Id_asignacion1 = -1;
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC S_ASIGNACIONES ?";

                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_asignacion1, 1); ;
                    CONTENEDOR = objeto_conexion.busca();
                    while (CONTENEDOR.Read())
                    {

                        asignacion.Id_asignacion1 = Convert.ToInt16(CONTENEDOR["ID_ASIGNACION"].ToString());

                        Clase clase = new Clase();
                        clase.Id_clase1 = Convert.ToInt16(CONTENEDOR["ID_CLASE"].ToString());
                        asignacion.Id_clase1 = clase;

                        Tipo tipo = new Tipo();
                        tipo.Id_tipo1 = Convert.ToInt16(CONTENEDOR["ID_TIPO"].ToString());
                        asignacion.Id_tipo1 = tipo;

                        asignacion.Porcentaje1 = Convert.ToDecimal(CONTENEDOR["PORCENTAJE"].ToString());
                        asignacion.Fecha_inicio1 = Convert.ToDateTime(CONTENEDOR["FECHA_INICIO"].ToString());
                        asignacion.Fecha_fin1 = Convert.ToDateTime(CONTENEDOR["FECHA_FIN"].ToString());
                        asignacion.Nombre_Asignacion1 = Convert.ToString(CONTENEDOR["NOMBRE_ASIGNACION"].ToString());
                        asignacion.Instrucciones1 = Convert.ToString(CONTENEDOR["INSTRUCCIONES"].ToString());

                    }
                    objeto_conexion.conexion.Close();
                    objeto_conexion.conexion.Dispose();
                    CONTENEDOR.Close();
                    return asignacion;
                }
                else
                {


                    return asignacion;
                }
            }
            catch (Exception error)
            {
                asignacion.Id_asignacion1 = -2;
                return asignacion;
            }
        }

        public List<Asignacion> Select_Asignacion_Clase_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            List<Asignacion> lista_devolver = new List<Asignacion>();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC S_ASIGNACIONESxCLASE ?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_clase1.Id_clase1, 1);
                    CONTENEDOR = objeto_conexion.busca();
                    while (CONTENEDOR.Read())
                    {
                        Asignacion asignacion = new Asignacion();
                        asignacion.Id_asignacion1 = Convert.ToInt16(CONTENEDOR["ID_ASIGNACION"].ToString());

                        Clase clase = new Clase();
                        clase.Id_clase1 = Convert.ToInt16(CONTENEDOR["ID_CLASE"].ToString());
                        asignacion.Id_clase1 = clase;

                        Tipo tipo = new Tipo();
                        tipo.Id_tipo1 = Convert.ToInt16(CONTENEDOR["ID_TIPO"].ToString());
                        asignacion.Id_tipo1 = tipo;

                        asignacion.Porcentaje1 = Convert.ToDecimal(CONTENEDOR["PORCENTAJE"].ToString());
                        asignacion.Fecha_inicio1 = Convert.ToDateTime(CONTENEDOR["FECHA_INICIO"].ToString());
                        asignacion.Fecha_fin1 = Convert.ToDateTime(CONTENEDOR["FECHA_FIN"].ToString());
                        asignacion.Nombre_Asignacion1 = Convert.ToString(CONTENEDOR["NOMBRE_ASIGNACION"].ToString());
                        asignacion.Instrucciones1 = Convert.ToString(CONTENEDOR["INSTRUCCIONES"].ToString());

                        lista_devolver.Add(asignacion);

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
        public List<Asignacion> Select_All_Asignacion_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            List<Asignacion> lista_devolver = new List<Asignacion>();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC ST_ASIGNACIONES";
                    objeto_conexion.nueva_consulta(query);
                    CONTENEDOR = objeto_conexion.busca();
                    while (CONTENEDOR.Read())
                    {
                        Asignacion asignacion = new Asignacion();
                        asignacion.Id_asignacion1 = Convert.ToInt16(CONTENEDOR["ID_ASIGNACION"].ToString());

                        Clase clase = new Clase();
                        clase.Id_clase1 = Convert.ToInt16(CONTENEDOR["ID_CLASE"].ToString());
                        asignacion.Id_clase1 = clase;

                        Tipo tipo = new Tipo();
                        tipo.Id_tipo1 = Convert.ToInt16(CONTENEDOR["ID_TIPO"].ToString());
                        asignacion.Id_tipo1 = tipo;

                        asignacion.Porcentaje1 = Convert.ToDecimal(CONTENEDOR["PORCENTAJE"].ToString());
                        asignacion.Fecha_inicio1 = Convert.ToDateTime(CONTENEDOR["FECHA_INICIO"].ToString());
                        asignacion.Fecha_fin1 = Convert.ToDateTime(CONTENEDOR["FECHA_FIN"].ToString());
                        asignacion.Nombre_Asignacion1 = Convert.ToString(CONTENEDOR["NOMBRE_ASIGNACION"].ToString());
                        asignacion.Instrucciones1 = Convert.ToString(CONTENEDOR["INSTRUCCIONES"].ToString());

                        lista_devolver.Add(asignacion);

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
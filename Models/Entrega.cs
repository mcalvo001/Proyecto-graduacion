using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Entrega
    {
        private int Id_entrega;
        private Estudiante Carnet;
        private Estado Id_estado;
        private Asignacion Id_asignacion;
        private DateTime Fecha_entrega;
        private string Archivo;
        
        public int Id_entrega1 { get => Id_entrega; set => Id_entrega = value; }
        public Estudiante Carnet1 { get => Carnet; set => Carnet = value; }
        public Estado Id_estado1 { get => Id_estado; set => Id_estado = value; }
        public Asignacion Id_asignacion1 { get => Id_asignacion; set => Id_asignacion = value; }
        public DateTime Fecha_entrega1 { get => Fecha_entrega; set => Fecha_entrega = value; }
        public string Archivo1 { get => Archivo; set => Archivo = value; }


        public string Insert_Entrega_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC I_ENTREGA ?,?,?,?,?,?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_entrega1, 1);
                    objeto_conexion.nuevo_parametro(Carnet1.Carnet1, 1);
                    objeto_conexion.nuevo_parametro(Id_estado1.Id_estado1, 2);
                    objeto_conexion.nuevo_parametro(Id_asignacion1.Id_asignacion1, 2);
                    objeto_conexion.nuevo_parametro(Fecha_entrega1, 4);
                    objeto_conexion.nuevo_parametro(Archivo1, 2);

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
        public string Delete_Entrega_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC D_ENTREGA ?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_entrega1, 1);

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
        public string Update_Entrega_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    String query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC U_ENTREGA ?,?,?,?,?,?";
                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_entrega1, 1);
                    objeto_conexion.nuevo_parametro(Carnet1.Carnet1, 1);
                    objeto_conexion.nuevo_parametro(Id_estado1.Id_estado1, 2);
                    objeto_conexion.nuevo_parametro(Id_asignacion1.Id_asignacion1, 2);
                    objeto_conexion.nuevo_parametro(Fecha_entrega1, 4);
                    objeto_conexion.nuevo_parametro(Archivo1, 2);

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
        public Entrega Select_Entrega()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            Entrega entrega = new Entrega();
            entrega.Id_entrega1 = -1;
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC S_ENTREGA ?";

                    objeto_conexion.nueva_consulta(query);
                    objeto_conexion.nuevo_parametro(Id_entrega1, 1); ;
                    CONTENEDOR = objeto_conexion.busca();
                    while (CONTENEDOR.Read())
                    {

                        entrega.Id_entrega1 = Convert.ToInt16(CONTENEDOR["ID_ENTREGA"].ToString());

                        Estudiante estudiante = new Estudiante();
                        estudiante.Carnet1 = Convert.ToString(CONTENEDOR["CARNET"].ToString());
                        entrega.Carnet1 = estudiante;
                        Estado estado = new Estado();
                        estado.Id_estado1 = Convert.ToInt16(CONTENEDOR["ID_ESTADO"].ToString());
                        entrega.Id_estado1 = estado;

                        Asignacion asignacion = new Asignacion();
                        asignacion.Id_asignacion1 = Convert.ToInt16(CONTENEDOR["ID_ASIGNACION"].ToString());
                        entrega.Id_asignacion1 = asignacion;

                        entrega.Fecha_entrega1 = Convert.ToDateTime(CONTENEDOR["FECHA_ENTREGA"].ToString());
                        entrega.Archivo1 = Convert.ToString(CONTENEDOR["ARCHIVO"].ToString());

                    }
                    objeto_conexion.conexion.Close();
                    objeto_conexion.conexion.Dispose();
                    CONTENEDOR.Close();
                    return entrega;
                }
                else
                {


                    return entrega;
                }
            }
            catch (Exception error)
            {
                entrega.Id_entrega1 = -2 ;
                return entrega;
            }
        }
        public List<Entrega> Select_All_Entrega_BD()
        {
            ConexionconBD objeto_conexion = new ConexionconBD();
            List<Entrega> lista_devolver = new List<Entrega>();
            try
            {
                if (objeto_conexion.inicializaBD())
                {
                    string query;
                    System.Data.OleDb.OleDbDataReader CONTENEDOR;

                    query = "EXEC ST_ENTREGA";
                    objeto_conexion.nueva_consulta(query);
                    CONTENEDOR = objeto_conexion.busca();
                    while (CONTENEDOR.Read())
                    {
                        Entrega entrega = new Entrega();
                        entrega.Id_entrega1 = Convert.ToInt16(CONTENEDOR["ID_ENTREGA"].ToString());

                        Estudiante estudiante = new Estudiante();
                        estudiante.Carnet1 = Convert.ToString(CONTENEDOR["CARNET"].ToString());
                        entrega.Carnet1 = estudiante;

                        Estado estado = new Estado();
                        estado.Id_estado1 = Convert.ToInt16(CONTENEDOR["ID_ESTADO"].ToString());
                        entrega.Id_estado1 = estado;

                        Asignacion asignacion = new Asignacion();
                        asignacion.Id_asignacion1 = Convert.ToInt16(CONTENEDOR["ID_ASIGNACION"].ToString());
                        entrega.Id_asignacion1 = asignacion;

                        entrega.Fecha_entrega1 = Convert.ToDateTime(CONTENEDOR["FECHA_ENTREGA"].ToString());
                        entrega.Archivo1 = Convert.ToString(CONTENEDOR["ARCHIVO"].ToString());

                        lista_devolver.Add(entrega);

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
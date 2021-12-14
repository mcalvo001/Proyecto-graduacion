using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace Proyecto.Controllers
{
    public class AsignacionController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection forms)
        {
            Asignacion asignacion = new Asignacion();

            asignacion.Id_asignacion1 = Convert.ToInt16(forms.Get("id_asignacion"));

            Clase clase = new Clase();
            clase.Id_clase1 = Convert.ToInt16(forms.Get("id_clase"));
            asignacion.Id_clase1 = clase;

            Tipo tipo = new Tipo();
            tipo.Id_tipo1 = Convert.ToInt16(forms.Get("id_tipo"));
            asignacion.Id_tipo1 = tipo;

            asignacion.Porcentaje1 = Convert.ToDecimal(forms.Get("porcentaje"));
            asignacion.Fecha_inicio1 = Convert.ToDateTime(forms.Get("fecha_inicio"));
            asignacion.Fecha_fin1 = Convert.ToDateTime(forms.Get("fecha_fin"));
            asignacion.Nombre_Asignacion1 = forms.Get("nombre_asignacion");
            asignacion.Instrucciones1 = forms.Get("instrucciones");

            string[] respuesta = new string[2];
            respuesta[0] = asignacion.Update_Asignacion_BD();
            respuesta[1] = forms.Get("id_asignacion");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection forms)
        {
            Asignacion asignacion = new Asignacion();

            asignacion.Id_asignacion1 = Convert.ToInt16(forms.Get("id_asignacion"));

            Clase clase = new Clase();
            clase.Id_clase1 = Convert.ToInt16(forms.Get("id_clase"));
            asignacion.Id_clase1 = clase;

            Tipo tipo = new Tipo();
            tipo.Id_tipo1 = Convert.ToInt16(forms.Get("id_tipo"));
            asignacion.Id_tipo1 = tipo;

            asignacion.Porcentaje1 = Convert.ToDecimal(forms.Get("porcentaje"));
            asignacion.Fecha_inicio1 = Convert.ToDateTime(forms.Get("fecha_inicio"));
            asignacion.Fecha_fin1 = Convert.ToDateTime(forms.Get("fecha_fin"));
            asignacion.Nombre_Asignacion1 = forms.Get("nombre_asignacion");
            asignacion.Instrucciones1 = forms.Get("instrucciones");

            string[] respuesta = new string[2];
            respuesta[0] = asignacion.Insert_Asignacion_BD();
            respuesta[1] = forms.Get("id_asignacion");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(FormDataCollection forms)
        {
            Asignacion asignacion = new Asignacion();

            asignacion.Id_asignacion1 = Convert.ToInt16(forms.Get("id_asignacion"));

            string[] respuesta = new string[2];
            respuesta[0] = asignacion.Delete_Asignacion_BD();
            respuesta[1] = forms.Get("id_asignacion");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            Asignacion asignacion = new Asignacion();

            HttpResponseMessage response = Request.CreateResponse<List<Models.Asignacion>>(HttpStatusCode.Created, asignacion.Select_All_Asignacion_BD());
            return response;
        }
        public HttpResponseMessage Get([FromUri] int id,bool proceso)
        {

            if (proceso == true)
            {
                Asignacion asignacion = new Asignacion();

                Clase clase = new Clase();
                clase.Id_clase1 = id;
                asignacion.Id_clase1 = clase;

                HttpResponseMessage response = Request.CreateResponse<List<Models.Asignacion>>(HttpStatusCode.Created, asignacion.Select_Asignacion_Clase_BD());
                return response;
            }
            else
            {
                Asignacion asignacion = new Asignacion();
                asignacion.Id_asignacion1 = id;

                HttpResponseMessage response = Request.CreateResponse<Models.Asignacion>(HttpStatusCode.Created, asignacion.Select_Asignacion());
                return response;
            }
        }
    }
}

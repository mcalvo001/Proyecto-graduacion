using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public class EntregaController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection forms)
        {
            Entrega entrega = new Entrega();

            entrega.Id_entrega1 = Convert.ToInt16(forms.Get("id_entrega"));
            Estudiante estudiante = new Estudiante();
            estudiante.Carnet1 = forms.Get("carnet");
            entrega.Carnet1 = estudiante;

            Estado estado = new Estado();
            estado.Id_estado1 = Convert.ToInt16(forms.Get("id_estado"));
            entrega.Id_estado1 = estado;

            Asignacion asignacion = new Asignacion();
            asignacion.Id_asignacion1 = Convert.ToInt16(forms.Get("id_asignacion"));
            entrega.Id_asignacion1 = asignacion;

            entrega.Fecha_entrega1 = Convert.ToDateTime(forms.Get("fecha_entrega"));
            entrega.Archivo1 =forms.Get("archivo");

            string[] respuesta = new string[2];
            respuesta[0] = entrega.Update_Entrega_BD();
            respuesta[1] = forms.Get("id_entrega");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection forms)
        {
            Entrega entrega = new Entrega();

            entrega.Id_entrega1 = Convert.ToInt16(forms.Get("id_entrega"));

            Estudiante estudiante = new Estudiante();
            estudiante.Carnet1 = forms.Get("carnet");
            entrega.Carnet1 = estudiante;

            Estado estado = new Estado();
            estado.Id_estado1 = Convert.ToInt16(forms.Get("id_estado"));
            entrega.Id_estado1 = estado;

            Asignacion asignacion = new Asignacion();
            asignacion.Id_asignacion1 = Convert.ToInt16(forms.Get("id_asignacion"));
            entrega.Id_asignacion1 = asignacion;

            entrega.Fecha_entrega1 = Convert.ToDateTime(forms.Get("fecha_entrega"));
            entrega.Archivo1 = forms.Get("archivo");

            string[] respuesta = new string[2];
            respuesta[0] = entrega.Insert_Entrega_BD();
            respuesta[1] = forms.Get("id_entrega");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(FormDataCollection forms)
        {
            Entrega entrega = new Entrega();

            entrega.Id_entrega1 = Convert.ToInt16(forms.Get("id_entrega"));

            string[] respuesta = new string[2];
            respuesta[0] = entrega.Delete_Entrega_BD();
            respuesta[1] = forms.Get("id_entrega");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            Entrega entrega = new Entrega();

            HttpResponseMessage response = Request.CreateResponse<List<Models.Entrega>>(HttpStatusCode.Created, entrega.Select_All_Entrega_BD());
            return response;
        }
        public HttpResponseMessage Get([FromUri] int id)
        {

            Entrega entrega = new Entrega();
            entrega.Id_entrega1 = id;

            HttpResponseMessage response = Request.CreateResponse<Models.Entrega>(HttpStatusCode.Created, entrega.Select_Entrega());
            return response;
        }
    }
}

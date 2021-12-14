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
    public class EstudianteController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection forms)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.Carnet1 = forms.Get("carnet");
            estudiante.Nombre1 = forms.Get("nombre");
            estudiante.Apellido_I1 = forms.Get("apellidoI");
            estudiante.Apellido_II1 = forms.Get("apellidoII");
            estudiante.Fecha_nacimiento1 = Convert.ToDateTime(forms.Get("fecha_nacimiento"));
            estudiante.Correo1 = forms.Get("correo");
            estudiante.Foto1 = forms.Get("foto");
            estudiante.Contraseña1 = forms.Get("contraseña");

            string[] respuesta = new string[2];
            respuesta[0] = estudiante.Update_Estudiante_BD();
            respuesta[1] = forms.Get("carnet");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection forms)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.Carnet1 = forms.Get("carnet");
            estudiante.Nombre1 = forms.Get("nombre");
            estudiante.Apellido_I1 = forms.Get("apellidoI");
            estudiante.Apellido_II1 = forms.Get("apellidoII");
            estudiante.Fecha_nacimiento1 = Convert.ToDateTime(forms.Get("fecha_nacimiento"));
            estudiante.Correo1 = forms.Get("correo");
            estudiante.Foto1 = forms.Get("foto");
            estudiante.Contraseña1 = forms.Get("contraseña");

            string[] respuesta = new string[2];
            respuesta[0] = estudiante.Insert_Estudiante_BD();
            respuesta[1] = forms.Get("carnet");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;

        }
        [HttpDelete]
        public HttpResponseMessage Delete(FormDataCollection forms)
        {

           Estudiante estudiante = new Estudiante();

           estudiante.Carnet1 = forms.Get("carnet");

           string[] respuesta = new string[2];
           respuesta[0] = estudiante.Delete_Estudiante_BD();
           respuesta[1] = forms.Get("carnet");

           HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
           return response;

        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            Estudiante estudiante = new Estudiante();

            HttpResponseMessage response = Request.CreateResponse<List<Models.Estudiante>>(HttpStatusCode.Created, estudiante.Select_All_Estudiante_BD());
            return response;
        }
        public HttpResponseMessage Get([FromUri] String id)
        {

            Estudiante estudiante = new Estudiante();
            estudiante.Carnet1 = id;

            HttpResponseMessage response = Request.CreateResponse<Models.Estudiante>(HttpStatusCode.Created, estudiante.Select_Estudiante());
            return response;
        }
    }
}

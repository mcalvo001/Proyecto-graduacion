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
    public class ProfesorController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection forms)
        {
            Profesor profesor = new Profesor();

            profesor.Cedula1 = forms.Get("cedula");
            profesor.Nombre1 = forms.Get("nombre");
            profesor.Apellido_I1 = forms.Get("apellidoI");
            profesor.Apellido_II1 = forms.Get("apellidoII");
            profesor.Fecha_nacimiento1 = Convert.ToDateTime(forms.Get("fecha_nacimiento"));
            profesor.Correo1 = forms.Get("correo");
            profesor.Foto1 = forms.Get("foto");
            profesor.Contraseña1 = forms.Get("contraseña");

            string[] respuesta = new string[2];
            respuesta[0] = profesor.Update_Profesor_BD();
            respuesta[1] = forms.Get("cedula");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection forms)
        {
            Profesor profesor = new Profesor();

            profesor.Cedula1 = forms.Get("cedula");
            profesor.Nombre1 = forms.Get("nombre");
            profesor.Apellido_I1 = forms.Get("apellidoI");
            profesor.Apellido_II1 = forms.Get("apellidoII");
            profesor.Fecha_nacimiento1 = Convert.ToDateTime(forms.Get("fecha_nacimiento"));
            profesor.Correo1 = forms.Get("correo");
            profesor.Foto1 = forms.Get("foto");
            profesor.Contraseña1 = forms.Get("contraseña");

            string[] respuesta = new string[2];
            respuesta[0] = profesor.Insert_Profesor_BD();
            respuesta[1] = forms.Get("cedula");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;

        }
        [HttpDelete]
        public HttpResponseMessage Delete(FormDataCollection forms)
        {

            Profesor profesor = new Profesor();

            profesor.Cedula1 = forms.Get("cedula");

            string[] respuesta = new string[2];
            respuesta[0] = profesor.Delete_Profesor_BD();
            respuesta[1] = forms.Get("cedula");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;

        }
        [HttpGet]
        public HttpResponseMessage Get()
        {
            Profesor profesor = new Profesor();

            HttpResponseMessage response = Request.CreateResponse<List<Models.Profesor>>(HttpStatusCode.Created, profesor.Select_All_Profesor_BD());
            return response;
        }
        public HttpResponseMessage Get([FromUri] String id)
        {

            Profesor profesor = new Profesor();
            profesor.Cedula1 = id;

            HttpResponseMessage response = Request.CreateResponse<Models.Profesor>(HttpStatusCode.Created, profesor.Select_Profesor());
            return response;
        }
    }
}

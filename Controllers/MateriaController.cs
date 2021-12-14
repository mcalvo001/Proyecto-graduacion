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
    public class MateriaController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection forms)
        {
            Materia materia = new Materia();

            materia.Id_materia1 = Convert.ToInt16(forms.Get("id_materia"));
            materia.Nombre_materia1 = forms.Get("nombre_materia");

            string[] respuesta = new string[2];
            respuesta[0] = materia.Update_Materia_BD();
            respuesta[1] = forms.Get("id_materia");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta); /* "HttpStatusCode" devolvemos el código de estado HTML */
            return response;
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection forms)
        {
            Materia materia = new Materia();

            materia.Id_materia1 = Convert.ToInt16(forms.Get("id_materia"));
            materia.Nombre_materia1 = forms.Get("nombre_materia");

            string[] respuesta = new string[2];
            respuesta[0] = materia.Insert_Materia_BD();
            respuesta[1] = forms.Get("id_materia");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(FormDataCollection forms)
        {
            Materia materia = new Materia();

            materia.Id_materia1 = Convert.ToInt16(forms.Get("id_materia"));

            string[] respuesta = new string[2];
            respuesta[0] = materia.Delete_Materia_BD();
            respuesta[1] = forms.Get("id_materia");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            Materia materia = new Materia();

            HttpResponseMessage response = Request.CreateResponse<List<Models.Materia>>(HttpStatusCode.Created, materia.Select_All_Materia_BD());
            return response;
        }
    }
}

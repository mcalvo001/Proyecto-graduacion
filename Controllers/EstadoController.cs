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
    public class EstadoController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection forms)
        {
            Estado estado = new Estado();

            estado.Id_estado1 = Convert.ToInt16(forms.Get("id_estado"));
            estado.Nombre_estado1 = forms.Get("nombre_estado");

            string[] respuesta = new string[2]; 
            respuesta[0] = estado.Update_Estado_BD();
            respuesta[1] = forms.Get("id_estado");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta); 
            return response;
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection forms)
        {
            Estado estado = new Estado();

            estado.Id_estado1 = Convert.ToInt16(forms.Get("id_estado"));
            estado.Nombre_estado1 = forms.Get("nombre_estado");

            string[] respuesta = new string[2];
            respuesta[0] = estado.Insert_Estado_BD();
            respuesta[1] = forms.Get("id_estado");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(FormDataCollection forms)
        {
            Estado estado = new Estado();

            estado.Id_estado1 = Convert.ToInt16(forms.Get("id_estado"));

            string[] respuesta = new string[2];
            respuesta[0] = estado.Delete_Estado_BD();
            respuesta[1] = forms.Get("id_estado");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            Estado estado = new Estado();

            HttpResponseMessage response = Request.CreateResponse<List<Models.Estado>>(HttpStatusCode.Created, estado.Select_All_Estado_BD());
            return response;
        }
    }
}

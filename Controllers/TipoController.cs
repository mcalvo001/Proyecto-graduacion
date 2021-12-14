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
    public class TipoController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection forms)
        {
            Tipo tipo = new Tipo();

            tipo.Id_tipo1 = Convert.ToInt16(forms.Get("id_tipo"));
            tipo.Tipo_asignacion1 = forms.Get("tipo_asignacion");

            string[] respuesta = new string[2]; /*Al no poder devolver dos objetos, devolvemos un string con ambos*/
            respuesta[0] = tipo.Update_Tipo_BD();
            respuesta[1] = forms.Get("id_tipo"); /*llave primaria*/

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta); /* "HttpStatusCode" devolvemos el código de estado HTML */
            return response;
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection forms)
        {
            Tipo tipo = new Tipo();

            tipo.Id_tipo1 = Convert.ToInt16(forms.Get("id_tipo"));
            tipo.Tipo_asignacion1 = forms.Get("tipo_asignacion");

            string[] respuesta = new string[2];
            respuesta[0] = tipo.Insert_Tipo_BD();
            respuesta[1] = forms.Get("id_tipo");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(FormDataCollection forms)
        {
            Tipo tipo = new Tipo();

            tipo.Id_tipo1 = Convert.ToInt16(forms.Get("id_tipo"));

            string[] respuesta = new string[2];
            respuesta[0] = tipo.Delete_Tipo_BD();
            respuesta[1] = forms.Get("id_tipo");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            Tipo tipo = new Tipo();

            HttpResponseMessage response = Request.CreateResponse<List<Models.Tipo>>(HttpStatusCode.Created, tipo.Select_All_Tipo_BD());
            return response;
        }

    }
}

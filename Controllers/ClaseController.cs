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
    public class ClaseController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection forms)
        {
            Clase clase = new Clase();
            clase.Id_clase1 = Convert.ToInt16(forms.Get("id_clase"));
            Profesor profesor = new Profesor();
            profesor.Cedula1 = forms.Get("id_profesor");
            clase.Id_profesor1 = profesor;
            Materia materia = new Materia();
            materia.Id_materia1 = Convert.ToInt16(forms.Get("id_materia"));
            clase.Id_materia1 = materia;
            clase.Nombre_clase1 = forms.Get("nombre_clase");

                       string[] respuesta = new string[2];
            respuesta[0] = clase.Update_Clase_BD();
            respuesta[1] = forms.Get("id_clase");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection forms)
        {
            Clase clase = new Clase();
            clase.Id_clase1 = Convert.ToInt16(forms.Get("id_clase"));
            Profesor profesor = new Profesor();
            profesor.Cedula1 = forms.Get("id_profesor");
            clase.Id_profesor1 = profesor;
            Materia materia = new Materia();
            materia.Id_materia1 = Convert.ToInt16(forms.Get("id_materia"));
            clase.Id_materia1 = materia;
            clase.Nombre_clase1 = forms.Get("nombre_clase");
            string[] respuesta = new string[2];
            respuesta[0] = clase.Insert_Clase_BD();
            respuesta[1] = forms.Get("id_clase");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpDelete]
        public HttpResponseMessage Delete(FormDataCollection forms)
        {
            Clase clase = new Clase();

            clase.Id_clase1 = Convert.ToInt16(forms.Get("id_clase"));

            string[] respuesta = new string[2];
            respuesta[0] = clase.Delete_Clase_BD();
            respuesta[1] = forms.Get("id_clase");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            Clase clase = new Clase();

            HttpResponseMessage response = Request.CreateResponse<List<Models.Clase>>(HttpStatusCode.Created, clase.Select_All_Clase_BD());
            return response;
        }
        public HttpResponseMessage Get([FromUri] int id,bool proceso)
        {
            if (proceso == true)
            {
                Clase clase = new Clase();
                clase.Id_clase1 = id;

               HttpResponseMessage response = Request.CreateResponse<Models.Clase>(HttpStatusCode.Created, clase.Select_ClasexEstudiante());
               return response;
            }
            else
            {
                Clase clase = new Clase();
                clase.Id_clase1 = id;

                HttpResponseMessage response = Request.CreateResponse<Models.Clase>(HttpStatusCode.Created, clase.Select_Clase());
                return response;
            }

            
        }
    }
}

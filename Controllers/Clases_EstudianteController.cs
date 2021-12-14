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
    public class Clases_EstudianteController : ApiController
    {
        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection forms)
        {
            Clases_Estudiante clases_estudiante = new Clases_Estudiante();

            Clase clase = new Clase();
            clase.Id_clase1 = Convert.ToInt32(forms.Get("id_clase"));
            clases_estudiante.Id_clase1 = clase;

            Estudiante estudiante = new Estudiante();
            estudiante.Carnet1 = Convert.ToString(forms.Get("carnet"));
            clases_estudiante.Carnet1 = estudiante;

            string[] respuesta = new string[2];
            respuesta[0] = clases_estudiante.Insert_Clase_Estudiante_BD();
            respuesta[1] = forms.Get("id_clase");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }
        [HttpDelete]
        public HttpResponseMessage Delete(FormDataCollection forms)
        {
            Clases_Estudiante clases_estudiante = new Clases_Estudiante();

            Clase clase = new Clase();
            clase.Id_clase1 = Convert.ToInt32(forms.Get("id_clase"));
            clases_estudiante.Id_clase1 = clase;

            Estudiante estudiante = new Estudiante();
            estudiante.Carnet1 = Convert.ToString(forms.Get("carnet"));
            clases_estudiante.Carnet1 = estudiante;

            string[] respuesta = new string[2];
            respuesta[0] = clases_estudiante.Delete_Clase_Estudiante_BD();
            respuesta[1] = forms.Get("id_clase");

            HttpResponseMessage response = Request.CreateResponse<string[]>(HttpStatusCode.Created, respuesta);
            return response;
        }

        [HttpGet]
        public HttpResponseMessage Get([FromUri] string id)
        {
            Clases_Estudiante clases_estudiante = new Clases_Estudiante();

            Estudiante estudiante = new Estudiante();
            estudiante.Carnet1 = id;
            clases_estudiante.Carnet1 = estudiante;

            HttpResponseMessage response = Request.CreateResponse<List<Models.Clases_Estudiante>>(HttpStatusCode.Created, clases_estudiante.ClasesxEstudiante(clases_estudiante.Carnet1.Carnet1));
            return response;
        }

    }
}

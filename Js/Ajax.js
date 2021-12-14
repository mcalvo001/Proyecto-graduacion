var urlaconectarse = "https://localhost:44343/api/";

function Creador_Nav() {
    var navegador = "";
    navegador += "<nav class='navbar navbar-expand-lg navbar-dark bg-dark'><div class='container-fluid'><a id='index' class='navbar-brand' href='index.html'>Inicio</a><button class='navbar-toggler' type='button' data-bs-toggle='collapse' data-bs-target='#navbarSupportedContent' aria-controls='navbarSupportedContent' aria-expanded='false' aria-label='Toggle navigation'><span class='navbar-toggler-icon'></span></button><div class='collapse navbar-collapse' id='navbarSupportedContent'><ul class='navbar-nav me-auto mb-2 mb-lg-0'><li class='nav-item'><a class='nav-link' id='Asignacion' href='Asignacion.html'>Asignaciones</a></li><li class='nav-item'><a class='nav-link' id='Clase' href='Clase.html'>Clase</a></li><li class='nav-item'><a class='nav-link' id='Entrega' href='Entrega.html'>Entrega</a></li><li class='nav-item'><a class='nav-link' id='Estado' href='Estado.html'>Estado</a></li><li class='nav-item'><a class='nav-link' id='Estudiante' href='Estudiante.html'>Estudiante</a></li><li class='nav-item'><a class='nav-link' id='Materia' href='Materia.html'>Materia</a></li><li class='nav-item'><a class='nav-link' id='Profesor' href='Profesor.html'>Profesor</a></li><li class='nav-item'><a class='nav-link' id='Tipo' href='Tipo.html'>Tipo</a></li></ul><div class='d-flex'><img style='width:75px; height: 75px; border-radius:100%' src='Img/sin-foto.png' id='foto-nav' class='img-fluid'></div></div></div></nav>";
    return navegador
}
function Creador_Nav_Profesor() {
    var navegador = "";
    navegador += "<nav class='navbar navbar-expand-lg navbar-dark bg-dark'><div class='container-fluid'><a id='index' class='navbar-brand' href='index.html'>Inicio</a><button class='navbar-toggler' type='button' data-bs-toggle='collapse' data-bs-target='#navbarSupportedContent' aria-controls='navbarSupportedContent' aria-expanded='false' aria-label='Toggle navigation'><span class='navbar-toggler-icon'></span></button><div class='collapse navbar-collapse' id='navbarSupportedContent'><ul class='navbar-nav me-auto mb-2 mb-lg-0'><li class='nav-item'><a class='nav-link' id='Asignacion' href='Asignacion.html'>Asignaciones</a></li><li class='nav-item'><a class='nav-link' id='Clase' href='Clase.html'>Clase</a></li><li class='nav-item'><a class='nav-link' id='Entrega' href='Entrega.html'>Entrega</a></li><li class='nav-item'><a class='nav-link' id='Estado' href='Estado.html'>Estado</a></li><li class='nav-item'><a class='nav-link' id='Estudiante' href='Estudiante.html'>Estudiante</a></li><li class='nav-item'><a class='nav-link' id='Materia' href='Materia.html'>Materia</a></li><li class='nav-item'><a class='nav-link' id='Profesor' href='Profesor.html'>Profesor</a></li><li class='nav-item'><a class='nav-link' id='Tipo' href='Tipo.html'>Tipo</a></li></ul><div class='d-flex'><img style='width:75px; height: 75px; border-radius:100%' src='Img/sin-foto.png' id='foto-nav' class='img-fluid'></div></div></div></nav>";
    return navegador
}
function Creador_Nav_Estudiante() {
    var navegador = "";
    navegador += "<nav class='navbar navbar-expand-lg navbar-dark bg-dark'><div class='container-fluid'><a id='index' class='navbar-brand' href='index.html'>Inicio</a><button class='navbar-toggler' type='button' data-bs-toggle='collapse' data-bs-target='#navbarSupportedContent' aria-controls='navbarSupportedContent' aria-expanded='false' aria-label='Toggle navigation'><span class='navbar-toggler-icon'></span></button><div class='collapse navbar-collapse' id='navbarSupportedContent'><ul class='navbar-nav me-auto mb-2 mb-lg-0'><li class='nav-item'><a class='nav-link' id='Asignacion' href='Asignacion.html'>Asignaciones</a></li><li class='nav-item'><a class='nav-link' id='Clase' href='Clase.html'>Clase</a></li><li class='nav-item'><a class='nav-link' id='Entrega' href='Entrega.html'>Entrega</a></li><li class='nav-item'><a class='nav-link' id='Estado' href='Estado.html'>Estado</a></li><li class='nav-item'><a class='nav-link' id='Estudiante' href='Estudiante.html'>Estudiante</a></li><li class='nav-item'><a class='nav-link' id='Materia' href='Materia.html'>Materia</a></li><li class='nav-item'><a class='nav-link' id='Profesor' href='Profesor.html'>Profesor</a></li><li class='nav-item'><a class='nav-link' id='Tipo' href='Tipo.html'>Tipo</a></li></ul><div class='d-flex'><img style='width:75px; height: 75px; border-radius:100%' src='Img/sin-foto.png' id='foto-nav' class='img-fluid'></div></div></div></nav>";
    return navegador
}

function Creador_Footer() {
    var footer = "";
    footer += '<footer class="bg-light text-center text-lg-start"><div class="text-center p-3" style="background-color: rgba(0, 0, 0, 100); color: white; "> © 2020 Copyright: Mainor Calvo Alfaro</div></footer>';
    return footer
}

function Creador_Cargando(titulo, texto, id) {
    return "<div class='card' style='width: 18rem;'id='" + id + "''><img width='200' height='150' src='Img/cargando.gif' class='card-img-top' alt='Cargando'><div class='card-body'><h5 class='card-title'>" + titulo + "</h5><p class='card-text'>" + texto + "</p></div></div>";
}

function Habilitar_Botones() {
    document.getElementById("btn_guardar").disabled = true;
    document.getElementById("btn_eliminar").disabled = false;
    document.getElementById("btn_actualizar").disabled = false;
}

function Deshabilitar_Botones() {
    document.getElementById("btn_guardar").disabled = false;
    document.getElementById("btn_eliminar").disabled = true;
    document.getElementById("btn_actualizar").disabled = true;
}

var asignacion = new Object;
asignacion.id_asignacion = "";
asignacion.id_clase = "";
asignacion.id_tipo = "";
asignacion.porcentaje = "";
asignacion.fecha_inicio = "";
asignacion.fecha_fin = "";
asignacion.nombre_asignacion = "";
asignacion.instrucciones = "";

var clase = new Object;
clase.id_clase = "";
clase.id_profesor = "";
clase.id_materia = "";
clase.nombre_clase = "";

var clase_estudiante = new Object;
clase_estudiante.id_clase = "";
clase_estudiante.carnet = "";


var entrega = new Object;
entrega.id_entrega = "";
entrega.carnet = "";
entrega.id_estado = "";
entrega.id_asignacion = "";
entrega.fecha_entrega = "";
entrega.archivo = "";

var estado = new Object;
estado.id_estado = "";
estado.nombre_estado = "";

var estudiante = new Object;
estudiante.carnet = "";
estudiante.nombre = "";
estudiante.apellidoI = "";
estudiante.apellidoII = "";
estudiante.fecha_nacimiento = "";
estudiante.correo = "";
estudiante.foto = "";
estudiante.contraseña = "";

var materia = new Object;
materia.id_materia = "";
materia.nombre_materia = "";

var profesor = new Object;
profesor.cedula = "";
profesor.nombre = "";
profesor.apellidoI = "";
profesor.apellidoII = "";
profesor.fecha_nacimiento = "";
profesor.correo = "";
profesor.foto = "";
profesor.contraseña = "";

var tipo = new Object;
tipo.id_tipo = "";
tipo.tipo_asignacion = "";

function Ajax(formdata, url, verbo, espacio, id) {

    var accion = "";
    switch (verbo) {
        case "POST": {
            accion = "actualizando";
            break;
        }
        case "DELETE": {
            accion = "borrando";
            break;
        }
        default: {
            accion = "insertando";
            break;
        }
    }
    espacio.innerHTML += Creador_Cargando("Ejecutando acción tipo: " + verbo, "Se esta " + accion + " en " + url + " con Id: " + id, "info_id" + id);
    $.ajax({
        url: urlaconectarse + url,
        type: verbo,
        dataType: "json",
        data: formdata,
        success: function (data, textstatus, xhr) {
            alert(data[0]);
            $('#info_id' + data[1]).remove();
            Cargar_Tabla();
        },
        error: function (xhr, textstatus, errorthrown) {
            $('#info_id' + xhr[1]).remove();
            alert(xhr);
        }
    })
}
function Ajax_url(formdata, url, verbo, espacio, id) {

    var accion = "";
    switch (verbo) {
        case "POST": {
            accion = "actualizando";
            break;
        }
        case "DELETE": {
            accion = "borrando";
            break;
        }
        default: {
            accion = "insertando";
            break;
        }
    }
    espacio.innerHTML += Creador_Cargando("Ejecutando acción tipo: " + verbo, "Se esta " + accion + " en " + url + " con Id: " + id, "info_id" + id);
    $.ajax({
        url: urlaconectarse + url+"?id="+id,
        type: verbo,
        dataType: "json",
        data: formdata,
        success: function (data, textstatus, xhr) {
            alert(data[0]);
            $('#info_id' + data[1]).remove();
            Cargar_Tabla();
        },
        error: function (xhr, textstatus, errorthrown) {
            $('#info_id' + xhr[1]).remove();
            alert(xhr);
        }
    })
}

function Verifica_Asignacion(id) {
    $.ajax({
        url: urlaconectarse + 'Asignacion?id=' + id,
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            Cargar_Formulario(data)
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr);
        }

    });
}

function Verifica_Profesor(id) {
    $.ajax({
        url: urlaconectarse + 'Profesor?id=' + id,
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            Cargar_Formulario_Profesor(data)
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr);
        }

    });
}
function Verifica_Estudiante(id) {
    $.ajax({
        url: urlaconectarse + 'Estudiante?id=' + id,
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            Cargar_Formulario_Estudiante(data)
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr);
        }

    });
}

function Tabla_Entregas () {
    $.ajax({
        url: urlaconectarse + 'Entrega',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            if (data.length > 0) {
                for (var indice in data) {
                    var objetoserializado = JSON.stringify(data[indice]);
                    var objetoserializadocomillas = "";
                    for (var caracter in objetoserializado) {
                        objetoserializadocomillas += objetoserializado[caracter].replace('"', "'");
                    }

                    document.getElementById("entregas_body").innerHTML += '<tr><td>' + data[indice].Id_entrega1 + '</td><td>' + data[indice].Carnet1.Carnet1 + '</td><td>' + data[indice].Id_estado1.Id_estado1 + '</td><td>' + data[indice].Id_asignacion1.Id_asignacion1 + '</td><td>' + data[indice].Fecha_entrega1 + '</td><td><a href="' + `${data[indice].Archivo1}` + '" class="btn btn-primary btn-sm" target="_blank">Archivo</a></td><td><input type="button" value="Seleccionar" id="btseleccionar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Cargar_Formulario(' + objetoserializadocomillas + ')" /></td><td><input type="button" value="Eliminar" id="bteliminar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Verificar_Eliminar(' + data[indice].Id_entrega1 + ')" /></td></tr>';
                }
                console.log(data)
            }
            $('#entrega').DataTable();;
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            $("#entrega").remove();
            alert(xhr);
        }

    });
}

function Tabla_Asignaciones() {
    $.ajax({
        url: urlaconectarse + 'Asignacion',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            if (data.length > 0) {
                for (var indice in data) {
                    var objetoserializado = JSON.stringify(data[indice]);
                    var objetoserializadocomillas = "";
                    for (var caracter in objetoserializado) {
                        objetoserializadocomillas += objetoserializado[caracter].replace('"', "'");
                    }

                    document.getElementById("asignaciones_body").innerHTML += '<tr><td>' + data[indice].Id_asignacion1 + '</td><td>' + data[indice].Id_clase1.Id_clase1 + '</td><td>' + data[indice].Id_tipo1.Id_tipo1 + '</td><td>' + data[indice].Porcentaje1 + '</td><td>' + data[indice].Fecha_inicio1 + '</td><td>' + data[indice].Fecha_fin1 + '</td><td>' + data[indice].Nombre_Asignacion1 + '</td><td>' + data[indice].Instrucciones1 + '</td><td><input type="button" value="Seleccionar" id="btseleccionar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Cargar_Formulario(' + objetoserializadocomillas + ')" /></td><td><input type="button" value="Eliminar" id="bteliminar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Verificar_Eliminar(' + data[indice].Id_asignacion1 + ')" /></td></tr>';
                }
                console.log(data)
            }
            $('#asignacion').DataTable();;
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            $("#asignacion").remove();
            alert(xhr);
        }

    });
}

function Tabla_Clases() {
    $.ajax({
        url: urlaconectarse + 'Clase',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            if (data.length > 0) {
                for (var indice in data) {
                    var objetoserializado = JSON.stringify(data[indice]);
                    var objetoserializadocomillas = "";
                    for (var caracter in objetoserializado) {
                        objetoserializadocomillas += objetoserializado[caracter].replace('"', "'");
                    }

                    document.getElementById("clases_body").innerHTML += '<tr><td>' + data[indice].Id_clase1 + '</td><td>' + data[indice].Id_profesor1.Cedula1 + '</td><td>' + data[indice].Id_materia1.Id_materia1 + '</td><td>' + data[indice].Nombre_clase1 + '</td><td><input type="button" value="Seleccionar" id="btseleccionar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Cargar_Formulario(' + objetoserializadocomillas + ')" /></td><td><input type="button" value="Eliminar" id="bteliminar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Verificar_Eliminar(' + data[indice].Id_clase1 + ')" /></td></tr>';
                }
                console.log(data)
            }
            $('#clase').DataTable();;
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            $("#clase").remove();
            alert(xhr);
        }

    });
}

function Tabla_Tipos() {
    $.ajax({
        url: urlaconectarse + 'Tipo',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            if (data.length > 0) {
                for (var indice in data) {
                    var objetoserializado = JSON.stringify(data[indice]);
                    var objetoserializadocomillas = "";
                    for (var caracter in objetoserializado) {
                        objetoserializadocomillas += objetoserializado[caracter].replace('"', "'");
                    }

                    document.getElementById("tipos_body").innerHTML += '<tr><td>' + data[indice].Id_tipo1 + '</td><td>' + data[indice].Tipo_asignacion1 + '</td><td><input type="button" value="Seleccionar" id="btseleccionar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Cargar_Formulario(' + objetoserializadocomillas + ')" /></td><td><input type="button" value="Eliminar" id="bteliminar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Verificar_Eliminar(' + data[indice].Id_clase1 + ')" /></td></tr>';
                }
                console.log(data)
            }
            $('#tipo').DataTable();;
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            $("#tipo").remove();
            alert(xhr);
        }

    });
}

function Tabla_Materias() {
    $.ajax({
        url: urlaconectarse + 'Materia',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            if (data.length > 0) {
                for (var indice in data) {
                    var objetoserializado = JSON.stringify(data[indice]);
                    var objetoserializadocomillas = "";
                    for (var caracter in objetoserializado) {
                        objetoserializadocomillas += objetoserializado[caracter].replace('"', "'");
                    }

                    document.getElementById("materias_body").innerHTML += '<tr><td>' + data[indice].Id_materia1 + '</td><td>' + data[indice].Nombre_materia1 + '</td><td><input type="button" value="Seleccionar" id="btseleccionar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Cargar_Formulario(' + objetoserializadocomillas + ')" /></td><td><input type="button" value="Eliminar" id="bteliminar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Verificar_Eliminar(' + data[indice].Id_clase1 + ')" /></td></tr>';
                }
                console.log(data)
            }
            $('#materia').DataTable();;
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            $("#materia").remove();
            alert(xhr);
        }

    });
}

function Tabla_Estados() {
    $.ajax({
        url: urlaconectarse + 'Estado',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            if (data.length > 0) {
                for (var indice in data) {
                    var objetoserializado = JSON.stringify(data[indice]);
                    var objetoserializadocomillas = "";
                    for (var caracter in objetoserializado) {
                        objetoserializadocomillas += objetoserializado[caracter].replace('"', "'");
                    }

                    document.getElementById("estados_body").innerHTML += '<tr><td>' + data[indice].Id_estado1 + '</td><td>' + data[indice].Nombre_estado1 + '</td><td><input type="button" value="Seleccionar" id="btseleccionar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Cargar_Formulario(' + objetoserializadocomillas + ')" /></td><td><input type="button" value="Eliminar" id="bteliminar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Verificar_Eliminar(' + data[indice].Id_clase1 + ')" /></td></tr>';
                }
                console.log(data)
            }
            $('#estado').DataTable();;
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            $("#estado").remove();
            alert(xhr);
        }

    });
}

function Tabla_Estudiantes() {
    $.ajax({
        url: urlaconectarse + 'Estudiante',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            if (data.length > 0) {
                for (var indice in data) {
                    var objetoserializado = JSON.stringify(data[indice]);
                    var objetoserializadocomillas = "";
                    for (var caracter in objetoserializado) {
                        objetoserializadocomillas += objetoserializado[caracter].replace('"', "'");
                    }

                    document.getElementById("estudiantes_body").innerHTML += '<tr><td>' + data[indice].Carnet1 + '</td><td>' + data[indice].Nombre1 + '</td><td>' + data[indice].Apellido_I1 + '</td><td>' + data[indice].Apellido_II1 + '</td><td>' + data[indice].Fecha_nacimiento1 + '</td><td>' + data[indice].Correo1 + '</td><td>' + data[indice].Contraseña1 + '</td><td><img style="width:50px; height:50px; border-radius:100%;" src="'+ data[indice].Foto1 +'"/></td><td><input type="button" value="Seleccionar" id="btseleccionar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Cargar_Formulario(' + objetoserializadocomillas + ')" /></td><td><input type="button" value="Eliminar" id="bteliminar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Verificar_Eliminar(' + data[indice].Carnet1 + ')" /></td></tr>';
                }
                console.log(data)
            }
            $('#estudiante').DataTable();;
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            $("#estudiante").remove();
            alert(xhr);
        }

    });
}

function Tabla_Profesores() {
    $.ajax({
        url: urlaconectarse + 'Profesor',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            if (data.length > 0) {
                for (var indice in data) {
                    var objetoserializado = JSON.stringify(data[indice]);
                    var objetoserializadocomillas = "";
                    for (var caracter in objetoserializado) {
                        objetoserializadocomillas += objetoserializado[caracter].replace('"', "'");
                    }

                    document.getElementById("profesores_body").innerHTML += '<tr><td>' + data[indice].Cedula1 + '</td><td>' + data[indice].Nombre1 + '</td><td>' + data[indice].Apellido_I1 + '</td><td>' + data[indice].Apellido_II1 + '</td><td>' + data[indice].Fecha_nacimiento1 + '</td><td>' + data[indice].Correo1 + '</td><td>' + data[indice].Contraseña1 + '</td><td><img style="width:50px; height:50px; border-radius:100%;" src="' + data[indice].Foto1 + '"/></td><td><input type="button" value="Seleccionar" id="btseleccionar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Cargar_Formulario(' + objetoserializadocomillas + ')" /></td><td><input type="button" value="Eliminar" id="bteliminar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Verificar_Eliminar(' + data[indice].Carnet1 + ')" /></td></tr>';
                }
                console.log(data)
            }
            $('#profesor').DataTable();;
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            $("#profesor").remove();
            alert(xhr);
        }

    });
}

function Clases_Select(controlselect) {
    $.ajax({
        url: urlaconectarse + 'Clase',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            console.log( "Clases:",data)
            if (data.length > 0) {
                for (var indice in data) {

                    controlselect.innerHTML += '<option id = ' + data[indice].Id_clase1 + ' value =' + data[indice].Id_clase1 + '>'+ data[indice].Nombre_clase1+'</option>';

                }
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr);
        }

    });
}

function Tipos_Select(controlselect) {
    $.ajax({
        url: urlaconectarse + 'Tipo',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            console.log("Tipos:", data)
            if (data.length > 0) {
                for (var indice in data) {

                    controlselect.innerHTML += '<option id = ' + data[indice].Id_tipo1 + ' value =' + data[indice].Id_tipo1 + '>' + data[indice].Tipo_asignacion1 + '</option>';

                }
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr);
        }

    });
}

function Materias_Select(controlselect) {
    $.ajax({
        url: urlaconectarse + 'Materia',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            console.log("Materia:", data)
            if (data.length > 0) {
                for (var indice in data) {

                    controlselect.innerHTML += '<option id = ' + data[indice].Id_materia1 + ' value =' + data[indice].Id_materia1 + '>' + data[indice].Nombre_materia1 + '</option>';

                }
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr);
        }

    });
}

function Asignaciones_Select(controlselect) {
    $.ajax({
        url: urlaconectarse + 'Asignacion',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            console.log("Asignaciones:", data)
            if (data.length > 0) {
                for (var indice in data) {

                    controlselect.innerHTML += '<option id = ' + data[indice].Id_asignacion1 + ' value =' + data[indice].Id_asignacion1 + '>' + data[indice].Id_asignacion1 + ' : ' + data[indice].Nombre_Asignacion1 + '</option>';

                }
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr);
        }

    });
}

function Estados_Select(controlselect) {
    $.ajax({
        url: urlaconectarse + 'Estado',
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            console.log("Estados:", data)
            if (data.length > 0) {
                for (var indice in data) {

                    controlselect.innerHTML += '<option id = ' + data[indice].Id_estado1 + ' value =' + data[indice].Id_estado1 + '>' + data[indice].Id_estado1 + ' : ' + data[indice].Nombre_estado1 + '</option>';

                }
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr);
        }

    });
}

function ClasesxUsuario(idestudiante) {
    $.ajax({
        url: urlaconectarse + 'Clases_Estudiante?id=' + idestudiante,
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            document.getElementById("clases_body").innerHTML += "";
            if (data.length > 0) {
                for (var indice in data) {

                    var idclase1 = data[indice].Id_clase1.Id_clase1;
                    Verifica_Articulo(idclase1, "proceso=true")
                }
                console.log(data)
            }

        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            $("#clase").remove();
            alert(xhr);
        }

    });
}

function Verifica_Articulo(id, proceso) {
    $.ajax({
        url: urlaconectarse + 'Clase?id=' + id + "&" + proceso,
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
document.getElementById("clases_body").innerHTML="";
            console.log(data)
            var objetoserializado = JSON.stringify(data);
            var objetoserializadocomillas = "";
            for (var caracter in objetoserializado) {
                objetoserializadocomillas += objetoserializado[caracter].replace('"', "'");
            }
            document.getElementById("clases_body").innerHTML += '<tr><td>' + data.Id_clase1 + '</td><td>' + data.Id_profesor1.Cedula1 + '</td><td>' + data.Id_materia1.Id_materia1 + '</td><td>' + data.Nombre_clase1 + '</td><td><input type="button" value="Seleccionar" id="btseleccionar" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#modalexos" onclick="Cargar_Asignaciones(' + data.Id_clase1 + ')" /></td></tr>';
            
            $('#clase').DataTable();
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr);
        }

    });
}

function AsignacionesxClase(idclase) {
    $.ajax({
        url: urlaconectarse + 'Asignacion?id=' + idclase + "&proceso=true",
        type: 'GET',
        dataType: 'json',
        data: null,
        success: function (data, textStatus, xhr) {
            document.getElementById("asignaciones_body").innerHTML = "";
            if (data.length > 0) {
                for (var indice in data) {
                    var objetoserializado = JSON.stringify(data[indice]);
                    var objetoserializadocomillas = "";
                    for (var caracter in objetoserializado) {
                        objetoserializadocomillas += objetoserializado[caracter].replace('"', "'");
                    }

                    document.getElementById("asignaciones_body").innerHTML += '<tr><td>' + data[indice].Id_asignacion1 + '</td><td>' + data[indice].Id_clase1.Id_clase1 + '</td><td>' + data[indice].Id_tipo1.Id_tipo1 + '</td><td>' + data[indice].Porcentaje1 + '</td><td>' + data[indice].Fecha_inicio1 + '</td><td>' + data[indice].Fecha_fin1 + '</td><td>' + data[indice].Nombre_Asignacion1 + '</td><td>' + data[indice].Instrucciones1 + '</td></tr>';
                }
                console.log(data)
            }
            $('#asignacion').DataTable();;
        }
        ,
        error: function (xhr, textStatus, errorThrown) {
            $("#asignacion").remove();
            alert(xhr);
        }

    });
}

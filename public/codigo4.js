
//alert("primer js");

addEventListener('load', () => {
    
        var btnLeer = document.getElementById("btnEnviar");
        btnLeer.addEventListener('click', enviar)
    
});
    
var xhr;    
    
function enviar() {

    
    var nombre = document.getElementById("nombrestr").value;
    var apellido = document.getElementById("apellidostr").value; 

   /* alert(nombre);
    if (nombre == "") {
        document.getElementById("nombrestr").className = "error";
        alert("Falto cargar el nombre!!");
    }
    else if (edad == "") {
        document.getElementById("apellidostr").className = "error";
        alert("Faltó cargar el apellido!!");
    }
    else if{
     */   

       
        var datos = 'nombre='+ encodeURIComponent(nombre) + '&apellido=' + encodeURIComponent(apellido);
        xhr = new XMLHttpRequest();
        xhr.onreadystatechange = gestionarRespuesta; //?????
        xhr.open('POST','http://localhost:3000/agregarpersona',true);
        xhr.setRequestHeader("Content-Type","application/x-www-form-urlencoded");
        xhr.send(datos);
        
//}

}
    
    
function gestionarRespuesta() {

    alert('estoy en gestionar'); 
    
    if (xhr.readyState == 4 && xhr.status == 200) {
         
    //    var objeto = JSON.parse(xhr.responseText);
       alert(xhr.responseText);
       recibirDatos();
    
    }

    
}

    


function recibirDatos (response,request) 
{
    xhr.open('GET', 'http://localhost:3000/traerpersonas', true);
    xhr.responseType = 'text';
    xhr.onreadystatechange = traerLista;
    xhr.send();
}

function traerLista()
{
    if(xhr.readyState== 4 && xhr.status==200) 
    {
        var objPersonas = JSON.parse(xhr.responseText);

        objPersonas.forEach(function(element) {
            var tcuerpo = document.getElementById("tablaUsuarios");
            tcuerpo.innerHTML = tcuerpo.innerHTML + "<td>" + element.nombre + "</td>" + "<td>" + element.apellido + "</td>"
        }, this);
    }
    
}

window.onload = function (res,req) {

    recibirDatos();
}
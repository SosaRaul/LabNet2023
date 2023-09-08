
    let historialPuntajes = [];
    let incognita = Math.floor(Math.random() * 15) + 1;
    const puntajeBase = 20;
    let puntajeActual = puntajeBase;
    
    function Adivinar(){       
          
        let numeroIngresado = Number(document.getElementById("numeroIngresado").value);
        
        if(puntajeActual === 0)
        {
          let p = document.createElement("p");
          let pTexto = document.createTextNode("PERDISTE");
          p.appendChild(pTexto);
          document.body.appendChild(p);
          historialPuntajes.push(puntajeActual);
        }
        else
        {
          if(numeroIngresado > incognita){
            let p = document.createElement("p");
            let pTexto = document.createTextNode("Valor muy alto " + "||" + "Puntaje actual: " + puntajeActual);
            p.appendChild(pTexto);
            document.body.appendChild(p);
            puntajeActual--;
          }
          else if(numeroIngresado < incognita){
            let p = document.createElement("p");
            let pTexto = document.createTextNode("Valor muy bajo " + "||" + "Puntaje actual: " + puntajeActual);
            p.appendChild(pTexto);
            document.body.appendChild(p);
            puntajeActual--;
          }
          else{
            let p = document.createElement("p");
            let pTexto = document.createTextNode("Felicitaciones acertaste!" + "||" + "Puntaje Final: " + puntajeActual);
            p.appendChild(pTexto);
            document.body.appendChild(p);
            historialPuntajes.push(puntajeActual);
          }      
        }
    }    

    function ReiniciarAdivinanza()
    {
      puntajeActual = puntajeBase;
      incognita = Math.floor(Math.random() * 10) + 1;
    }

   function Estadisticas()
   {
     let p = document.createElement("p");
     let maxPuntaje = historialPuntajes.length != 0 ? Math.max(...historialPuntajes) : 0;
     p.appendChild(document.createTextNode("Rondas jugadas: " + historialPuntajes.length));
     p.appendChild(document.createTextNode(" - Mejor puntaje " + maxPuntaje));
     document.body.appendChild(p);
   }
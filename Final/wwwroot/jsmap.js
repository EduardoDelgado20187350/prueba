  var mymap
    function InitMapa(Obj) {
        mymap = L.map('mapid').setView([18.66, -69.80], 13);
        for (let Cliente of Obj)
        {
            L.marker([Cliente.latitud, Cliente.longitud]).addTo(mymap)
                .bindPopup(Cliente.nombre + "<br> " + Cliente.rnc
                    + "<br> " + Cliente.direccion
                    + "<br> " + Cliente.correo)
                .openPopup();

        }
        
      

        L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token={accessToken}', {
            attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>, Imagery ©️ <a href="https://www.mapbox.com/">Mapbox</a>',
            maxZoom: 18,
            id: 'mapbox/streets-v11',
            tileSize: 512,
            zoomOffset: -1,
            accessToken: 'pk.eyJ1IjoiaXNyYWVsZ3YiLCJhIjoiY2tpMHJ1dWJuMTA1NTJ5cXFwZGNiMXc5YiJ9.buarjcSJm2LkMn1FfffNcQ'
        }).addTo(mymap);
    }
    

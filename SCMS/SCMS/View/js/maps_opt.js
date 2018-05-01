function initialize() {
        var mapCanvas = document.getElementById('map-canvas');
	var myLatlng = new google.maps.LatLng(39.867886, 32.736202);        
	var mapOptions = {
          center: myLatlng,
          zoom: 15,
          mapTypeId: google.maps.MapTypeId.ROADMAP
        }
        var map = new google.maps.Map(mapCanvas, mapOptions)
	var marker = new google.maps.Marker({
      		position: myLatlng,
      		map: map,
      		title: 'Mehmet Akif Ersoy Salonu' });   
	}

      google.maps.event.addDomListener(window, 'load', initialize);




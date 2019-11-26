function initMap() {
    var myLatLng = { lat: 38.959, lng: -77.358 };
    
    
    let map = new google.maps.Map(document.getElementById('map'), {
        center: myLatLng,
        zoom: 8
    });
    var marker = new google.maps.Marker({
    position: myLatLng,
    map: map,
    title: 'VMAN PIZZA!'
    });
    alert("Confirm");
}; 
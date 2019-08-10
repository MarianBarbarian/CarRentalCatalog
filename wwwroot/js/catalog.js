function getCatalogFromServer(){
    $.ajax({
        url:'/Catalog/GetCatalog',
        type: 'GET',
        success: function(data){
            console.log("This is the response from server", data);
            displayCatalog(data);
        },
        error: function (error){
            console.error("Error on com", error);
        }
    });
}

function displayCatalog(list){
    for (var i = 0; i < list.length ; i++){
        var car = list[i];
    
        var carContainer = $("#carList");
        var carTemplate = `<div class="card-deck" style="width: 25%;">
        <div class="card">
        <img src="${car.picture}" class="card-img-top" alt="Car for rent">
        <div class="card-body">
            <h5 class="card-title">${car.year} ${car.make} ${car.model}</h5>
            <p class="card-text">${car.description}</p>
            <p class="card-text"><small class="text-muted">Cargo Space: ${car.cargoSpace} HP: ${car.hp}</small></p>
            <p class="card-text"><span class="price">$ ${car.rentPrice} </span>
            <small class="text-muted"><button class="btn btn-primary float-right" onclick="rent(${car.id})">Select Car</button></small></P>
        </div>
      </div>`;
        carContainer.append(carTemplate);
    }
}

function init(){
    console.log("Initialize Catalog");

    getCatalogFromServer()
}

window.onload = init;
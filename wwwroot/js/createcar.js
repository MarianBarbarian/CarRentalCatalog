function saveCar() {

    var make = $("#txtMake").val();
    var model = $("#txtModel").val();
    var year = $("#txtYear").val();
    var description = $("#txtDescription").val();
    var color = $("#txtColor").val();
    var hp = $("#txtHp").val();
    var rentPrice = $("#txtRentPrice").val();
    var picture = $("#txtPicture").val();
    var gasMileage = $("#txtGasMileage").val();
    var passengers = $("#txtPassengers").val();
    var cargoSpace = $("#txtCargoSpace").val();



    var newCar = {
        make: make,
        model: model,
        year: year,
        description: description,
        color: color,
        hp: hp,
        rentPrice: rentPrice,
        picture: picture,
        gasMileage: gasMileage,
        passengers: passengers,
        cargoSpace: cargoSpace,

    }

    console.log(newCar);
    $.ajax({
        url: '/Catalog/CreateCar',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(newCar),
        success: function (data) {
            console.log("This is the response from server", data);
        },
        error: function (error) {
            console.error("Error on com", error);
        }
    });
}

function init() {
    console.log("Add Vehicle");

    $("#btnSave").click(saveCar);
}

window.onload = init;
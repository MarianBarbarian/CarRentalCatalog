function saveRep() {


    var name = $("#txtName").val();
    var lastName = $("#txtlastName").val();
    var phoneNumber = $("#txtphoneNumber").val();

    var newRep = {
        name: name,
        lastName: lastName,
        phoneNumber: phoneNumber*1,
 
    };



    console.log(newRep);

    $.ajax({
        type: 'POST',
        url: '/representatives/save',
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(newRep),
        success: function (data) {
            console.log("Saved", data);
        },

        error: function (error) {
            console.error("Not Saved, ERROR", error);
        }
    });
}



function init() {
    console.log("Add Representative");

    $("#btnSave").click(saveRep);
}

window.onload = init;
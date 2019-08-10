function getListFromServer() {
    $.ajax({
        url: '/representatives/getlist',
        type: 'GET',
        success: function (data) {
            console.log("This is the response from server", data);
            displayList(data);
        },
        error: function (error) {
            console.error("Error on com", error);
        }
    });
}

function displayList(list) {
    for (var i = 0; i < list.length; i++) {
        var rep = list[i];

        var repContainer = $("#repList");
        var repTemplate = `<br><table style="width:100%" border="1" cellpadding="5" cellspacing="3">
        <tr bgcolor="#dddddd">
        <th>Representative</th>
        <th>Phone Number</th>
        </tr>
        <tr>
        <td>${rep.name} ${rep.lastName}</td>
        <td>${rep.phoneNumber}</td>
        </tr>
        </div>`;


        repContainer.append(repTemplate);

    }
}

function init() {
    console.log("List of Representatives");

    getListFromServer()
}

window.onload = init;
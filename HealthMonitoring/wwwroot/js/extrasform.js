function sendForm() {

    var formData = {
        "date": $("#txtDate").val(),
        "descri": $("#txtDescri").val(),
        "quantity": $("#txtQuantity").val(),
        "batimentos": $("#txtBat").val(),
    }

    /*    var baseUrl = "/User/Edit"*/

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:7136/api/Extra/Create",
        success: function (result) {
            if (result.response == 'ERROR')
                alert("Credenciais inválidas")
            else {
                alert("Salvo")
                ////    var baseUrl = $('#btnLogin').data('url');
                //window.location = "/User/Edit?" +
                //    "UserId=" + result.userId +
                //    "&PersonId=" + result.personId +
                //    "&Email=" + result.email;
            }
        },
        error: function (error) {

        }
    })
}
//$('#btnSubmitForm').on('click', function (event) {
//    event.preventDefault();

//    var formData = {
//        "date": $("#txtDate").val(),
//        "descri": $("#txtDescri").val(),
//        "quantity": $("#txtQuantity").val(),
//        "batimentos": $("#txtBat").val(),
//    }

//    /*    var baseUrl = "/User/Edit"*/

//    $.ajax({
//        type: "POST",
//        dataType: "json",
//        contentType: "application/json; charset=UTF-8",
//        data: JSON.stringify(formData),
//        url: "https://localhost:7136/api/Extra/Create",
//        success: function (result) {
//            if (result.response == 'ERROR')
//                alert("Credenciais inválidas")
//            else {
//                alert("Salvo")
//                ////    var baseUrl = $('#btnLogin').data('url');
//                //window.location = "/User/Edit?" +
//                //    "UserId=" + result.userId +
//                //    "&PersonId=" + result.personId +
//                //    "&Email=" + result.email;
//            }
//        },
//        error: function (error) {

//        }
//    })
//});

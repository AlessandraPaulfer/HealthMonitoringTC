function sendForm() {

    var formData = {
        "date": $("#txtDate").val(),
        "descri": $("#txtDescri").val(),
        "quantity": $("#txtQuantity").val(),
        "type": $("#txtTipo").val(),
    }

    /*    var baseUrl = "/User/Edit"*/

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:7136/api/Med/Create",
        success: function (result) {
            if (result.response == 'ERROR')
                alert("Credenciais inválidas")
            else {
                alert("Salvo")
            }
        },
        error: function (error) {

        }
    })
}

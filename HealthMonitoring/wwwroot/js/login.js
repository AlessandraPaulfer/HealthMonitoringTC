
$('form').on('submit', function(event) {
    event.preventDefault();

    var formData = {
        "password": $("#txtPassword").val(),
        "person": {
            "email": $("#txtEmail").val(),
        }
    }

/*    var baseUrl = "/User/Edit"*/

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:7136/api/User/",
        success: function (result) {
            if (result.response == 'ERROR')
                alert("Credenciais inválidas")
            else {
            //    var baseUrl = $('#btnLogin').data('url');
                window.location = "/User/Edit?" +
                    "UserId=" + result.userId +
                    "&PersonId=" + result.personId +
                    "&Email=" + result.email;
            }
        },
        error: function (error) {

        }
    })
});
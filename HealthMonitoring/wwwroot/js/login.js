
$('form').on('submit', function(event) {
    event.preventDefault();

    var formData = {
        "password": $("#txtPassword").val(),
        "person": {
            "email": $("#txtEmail").val(),
        }
    }

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
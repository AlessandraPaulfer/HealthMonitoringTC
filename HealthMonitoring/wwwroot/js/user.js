$('form').on('submit', function (event) {
    event.preventDefault();

    var myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");

    var raw = JSON.stringify({
        "id": parseInt($("#UserId").val()),
        "password": $("#txtPassword").val(),
        "confirmPassword": $("#txtConfirmPassword").val(),
        "personId": parseInt($("#PersonId").val()),
        "person": {
            "id": parseInt($("#PersonId").val()),
            "email": $("#txtEmail").val()
        }
    });

    var requestOptions = {
        method: 'PATCH',
        headers: myHeaders,
        body: raw,
        redirect: 'follow'
    };

    fetch("https://localhost:7136/api/User/update", requestOptions)
        .then(response => response.text())
        .then(result => console.log(result))
        .catch(error => console.log('error', error));
});
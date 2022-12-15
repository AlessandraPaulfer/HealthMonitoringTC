function closeForm() {
    $('.form-popup-bg-editglico').removeClass('is-visible');
}

$(document).ready(function ($) {

    /* Contact Form Interactions */
    $('#btnOpenFormEditGlico').on('click', function (event) {
        event.preventDefault();

        $('.form-popup-bg-editglico').addClass('is-visible');
    });

    //close popup when clicking x or off popup
    $('.form-popup-bg-editglico').on('click', function (event) {
        if ($(event.target).is('.form-popup-bg-editglico') || $(event.target).is('#btnCloseForm')) {
            event.preventDefault();
            $(this).removeClass('is-visible');
        }
    });
});

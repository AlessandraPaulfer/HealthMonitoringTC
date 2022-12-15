function closeForm() {
    $('.form-popup-bg-glico').removeClass('is-visible');
}

$(document).ready(function ($) {

    /* Contact Form Interactions */
    $('#btnOpenFormGlico').on('click', function (event) {
        event.preventDefault();

        $('.form-popup-bg-glico').addClass('is-visible');
    });

    //close popup when clicking x or off popup
    $('.form-popup-bg-glico').on('click', function (event) {
        if ($(event.target).is('.form-popup-bg-glico') || $(event.target).is('#btnCloseForm')) {
            event.preventDefault();
            $(this).removeClass('is-visible');
        }
    });
});

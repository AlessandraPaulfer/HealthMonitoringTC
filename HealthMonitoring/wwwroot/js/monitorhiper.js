function closeForm() {
    $('.form-popup-bg-hiper').removeClass('is-visible');
}

$(document).ready(function ($) {

    /* Contact Form Interactions */
    $('#btnOpenFormHiper').on('click', function (event) {
        event.preventDefault();

        $('.form-popup-bg-hiper').addClass('is-visible');
    });

    //close popup when clicking x or off popup
    $('.form-popup-bg-hiper').on('click', function (event) {
        if ($(event.target).is('.form-popup-bg-hiper') || $(event.target).is('#btnCloseForm')) {
            event.preventDefault();
            $(this).removeClass('is-visible');
        }
    });
});

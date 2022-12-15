function closeForm() {
    $('.form-popup-bg-edithiper').removeClass('is-visible');
}

$(document).ready(function ($) {

    /* Contact Form Interactions */
    $('#btnOpenFormEditHiper').on('click', function (event) {
        event.preventDefault();

        $('.form-popup-bg-edithiper').addClass('is-visible');
    });

    //close popup when clicking x or off popup
    $('.form-popup-bg-edithiper').on('click', function (event) {
        if ($(event.target).is('.form-popup-bg-edithiper') || $(event.target).is('#btnCloseForm')) {
            event.preventDefault();
            $(this).removeClass('is-visible');
        }
    });
});

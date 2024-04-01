$(function () {
    $("#accordion").accordion();
});

function isValidPostNum(postnum) {
    return /^\d{4}$/.test(postnum);
}

$(document).ready(function () {

    $('#naslov-form').submit(function (e) {
        var postnumValue = $('#postnum').val();
        if (!isValidPostNum(postnumValue)) {
            e.preventDefault();
            $('#error-message-post').show();
        }
    });
});

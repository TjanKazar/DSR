$(function () {
    $("#accordion").accordion();
});

function isValidEMSO(emso) {
    return /^\d{13}$/.test(emso);
}

function isValidPostNum(postnum) {
    return /^\d{4}$/.test(postnum);
}

function PassIsEqual(pass1, pass2) {
    return pass1 === pass2;
}

$(document).ready(function () {

    $("#birthdate").datepicker();

    $('#registration-form').submit(function (e) {
        var emsoValue = $('#emso').val();
        if (!isValidEMSO(emsoValue)) {
            e.preventDefault();
            $('#error-message-emso').show();
        }
    });

    $('#naslov-form').submit(function (e) {
        var postnumValue = $('#postnum').val();
        if (!isValidPostNum(postnumValue)) {
            e.preventDefault();
            $('#error-message-post').show();
        }
    });

    $('#zakljuci-form').submit(function (e) {
        var pass1value = $('#pass1').val();
        var pass2value = $('#pass2').val();
        if (!PassIsEqual(pass1value, pass2value)) {
            e.preventDefault();
            $('#error-message-pass').show();
        }
    });
});

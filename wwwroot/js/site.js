


function isValidPostNum(postnum) {
    return /^\d{4}$/.test(postnum);
}

$(document).ready(function () {
    $("#accordion").accordion();

    $("#tabs").tabs();

    $('#date-picker').datepicker({
        dateFormat: 'dd.mm.yy'
    });

    $('#slider').on('input', function () {
        var value = $(this).val();
        $(this).next('#slider-value').text(value);
    });
});

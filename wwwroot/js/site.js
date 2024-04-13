$(function () {
    $("#accordion").accordion();
});

function isValidPostNum(postnum) {
    return /^\d{4}$/.test(postnum);
}

$(document).ready(function () {

    $(function () {
        $(function () {
            $("#tabs").tabs();
        });        
    });
    $(function () {
        $('#date-picker').datepicker({
            dateFormat: 'dd.mm.yy'
        });
    });
    $(function () {
        $('#slider').on('input', function () {
            var value = $(this).val();
            $(this).next('#slider-value').text(value);
        });
    });
});

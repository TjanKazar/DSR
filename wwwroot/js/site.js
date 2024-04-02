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
        $("#datepicker").datepicker({
            dateFormat: 'dd.mm.yy'
        });
    });
    
});

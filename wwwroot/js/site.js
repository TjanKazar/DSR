$(function () {
    $("#accordion").accordion();
});

function isValidPostNum(postnum) {
    return /^\d{4}$/.test(postnum);
}

$(document).ready(function () {

    $(function () {
        $('#tabs-content').tabs({
            beforeLoad: function (event, ui) {
                ui.panel.html('<div class="loading"></div>');
            }
        });
        $(function () {
            $("#tabs").tabs();
        });
        $(function () {
            $("#tabs1").tabs();
        });

        $('#tabs-list').on('click', 'a', function () {
            var url = $(this).attr('href');
            $(url).load(url.substring(1));
        });
    });
});

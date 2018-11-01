$(function () {

    //DataTable
    $("table.mydataTables").DataTable();
    $('select.chosen-select').chosen({ width: "100%" });

});

function call_method(url, data, success, error) {
    jQuery.ajax({
        url: url,
        method: 'post',
        data: data,
        success: success,
        error: error
    });
}
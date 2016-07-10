
/* Datatables export */
$(document).ready(function () {
    var table = $('#datatable-tabletools').DataTable();
    var tt = new $.fn.dataTable.TableTools(table);

    $(tt.fnContainer()).insertBefore('#datatable-tabletools_wrapper div.dataTables_filter');

    $('.DTTT_container').addClass('btn-group');
    $('.DTTT_container a').addClass('btn btn-default btn-md');

    $('.dataTables_filter input').attr("placeholder", "Search...");
});

/* Datatables reorder */

$(document).ready(function () {
    $('#datatable-reorder').DataTable({
        dom: 'Rlfrtip'
    });
    $('#datatable-reorder_length').hide();
    $('#datatable-reorder_filter').hide();
});

$(document).ready(function () {
    $('.dataTables_filter input').attr("placeholder", "Search...");
});
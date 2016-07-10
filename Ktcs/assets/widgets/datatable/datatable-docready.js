
/* Datatables export */
$(document).ready(function () {
    var table = $('#datatable-tabletools').DataTable();
    var tt = new $.fn.dataTable.TableTools(table);

    $(tt.fnContainer()).insertBefore('#datatable-tabletools_wrapper div.dataTables_filter');

    $('.DTTT_container').addClass('btn-group');
    $('.DTTT_container a').addClass('btn btn-default btn-md');

    $('.dataTables_filter input').attr("placeholder", "Search...");

    /* Datatables reorder */
    $('#datatable-reorder').DataTable({
        dom: 'Rlfrtip'
    });
    $('#datatable-reorder_length').hide();
    $('#datatable-reorder_filter').hide();

    $('.dataTables_filter input').attr("placeholder", "Search...");

  //modal for details
  $(".openDetailInModal").click(function (e) {
        e.stopPropagation();
        $.get($(this).data('url'), function (data) {
          $('.modal-content').html(data);
          $('#detailsModal').modal({
            backdrop: true,
            keyboard: false,
            show: true
          });
        });
      });
});
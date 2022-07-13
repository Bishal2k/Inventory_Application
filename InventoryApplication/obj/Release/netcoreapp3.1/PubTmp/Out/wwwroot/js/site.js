$(document).ready(function () {
    $("#dataTableImplement").DataTable({
        "lengthMenu": [[7, 10, 25, 50, -1], [7, 10, 25, 50, "All"]],
        stateSave: true,
        order: [[0, "asc"]]
    });
})



$("#EventsTable").dataTable({
    "ajax": {
        "url": "/Events/GetEvents",
        "type": "POST"
    },
    "columns": [
            { "data": "Header", "name": "Title" },
            { "data": "Location", "name": "Location" },
            { "data": "StartDate", "name": "From Date" },
            { "data": "EndDate", "name": "To Date" },
            {
                "data": "Actions", "orderable": false, "render": function (data, type, full, meta) {
                    return '<i title="view" class="fa fa-eye btn btn-dark" data-toggle="modal" data-target=".bs-example-modal-lg"></i><i title = "edit" class="fa fa-pencil btn btn-success" data-toggle="modal" data-target=".bs-example-modal-lg"></i><i title = "edit" class="fa fa-close btn btn-danger" data-toggle="modal" data-target=".bs-example-modal-lg"></i>'
                    
                }
            },
          ], 
    "searching": false,
    "ordering": true,
    "order": [[0, "asc"]],
    "bLengthChange": false,
    "proccessing": true,
    "serverSide": true,
});

$("#NewsTable").dataTable({
    "ajax": {
        "url": "/News/GetNews",
        "type": "POST"
    },
    "columns": [
            { "data": "Header", "name": "Title" },
            { "data": "Location", "name": "Location" },
            { "data": "StartDate", "name": "From Date" },
            { "data": "EndDate", "name": "To Date" },
            {
                "data": "Actions", "orderable": false, "render": function (data, type, full, meta) {
                    return '<i title="view" class="fa fa-eye btn btn-dark" data-toggle="modal" data-target=".bs-example-modal-lg"></i><i title = "edit" class="fa fa-pencil btn btn-success" data-toggle="modal" data-target=".bs-example-modal-lg"></i><i title = "edit" class="fa fa-close btn btn-danger" data-toggle="modal" data-target=".bs-example-modal-lg"></i>'

                }
            },
    ],
    "searching": false,
    "ordering": true,
    "order": [[0, "asc"]],
    "bLengthChange": false,
    "proccessing": true,
    "serverSide": true,
});
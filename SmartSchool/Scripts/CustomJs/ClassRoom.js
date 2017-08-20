$(document).ready(function () {

});

function OnSuccess() {
    console.log("Success");
}

function OnFailure() {
    console.log("Failure");
}

function Submit() {
    ////e.preventDefault();
    //$("#addDivision").removeData("validator").removeData("unobtrusiveValidation");//remove the form validation
    //$.validator.unobtrusive.parse($("#addDivision"));//add the form validation
    //if ($(this).valid()) {
    //}
    //console.log($("#addDivision").valid());

}

$("#standards").dataTable({
    "ajax": {
        "url": "/Class/GetDivisions",
        "type": "POST"
    }, "columns": [
            { "data": "Standard","name": "Standard" },
            { "data": "Division","name": "Division" },
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

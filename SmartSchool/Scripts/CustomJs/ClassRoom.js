var studentsDataTable;
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
    },
    "columns": [
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

$("#studentsTable").dataTable({
    "ajax": {
        "url": "/Class/GetStudents",
        "type": "POST"
    },
    "columns": [
        { "data": "StudentId", "name": "StudentId", "title": "Roll No" },
        { "data": "FirstName", "name": "FirstName", "title": "First Name" },
        { "data": "MiddleName", "name": "MiddleName", "title": "Middle Name" },
        { "data": "LastName", "name": "LastName", "title": "Last Name" },
        {
            "data": "Actions", "orderable": false, "title": "Actions", "render": function (data, type, full, meta) {
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

$("#timetableTable").dataTable({
    "ajax": {
        "url": "/Class/GetTimetable",
        "type": "POST"
    },
    "columns": [
        {
            "data": "StartTime", "name": "StartTime", "title": "Time", "render": function (data, type, full, meta) {
                var dt = new Date(), time = dt.getHours() + ":" + dt.getMinutes();
                if (full.StartTime == null && full.EndTime == null) {
                    return time + " - " + time
                }
                else {
                    return ""
                }
            }
        },
        { "data": "Mon", "name": "Mon", "title": "Mon" },
        { "data": "Tue", "name": "Tue", "title": "Tue" },
        { "data": "Wed", "name": "Wed", "title": "Wed" },
        { "data": "Thu", "name": "Thu", "title": "Thur" },
        { "data": "Fri", "name": "Fri", "title": "Fri" },
        { "data": "Sat", "name": "Sat", "title": "Sat" },
        {
            "data": "Actions", "orderable": false, "title": "Actions", "render": function (data, type, full, meta) {
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

$("#examTimeTable").dataTable({
    "ajax": {
        "url": "/Class/GetExamTimetable",
        "type": "POST"
    },
    "columns": [
        { "data": "Subject", "name": "Subject", "title": "Subject" },
        { "data": "FromDate", "name": "FromDate", "title": "Date" },
        { "data": "FromTime", "name": "FromTime", "title": "From Time" },
        { "data": "ToTime", "name": "ToTime", "title": "To Time" },
        { "data": "Location", "name": "Location", "title": "Location" },
        { "data": "Batch", "name": "Batch", "title": "Batch" },
        {
            "data": "Actions", "orderable": false, "title": "Actions", "render": function (data, type, full, meta) {
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

$("#holidaysTable").dataTable({
    "ajax": {
        "url": "/Class/GetHolidays",
        "type": "POST"
    },
    "columns": [
        { "data": "FromDate", "name": "FromDate", "title": "From Date" },
        { "data": "ToDate", "name": "ToDate", "title": "To Date" },
        { "data": "Festival", "name": "Festival", "title": "Holiday" },
        {
            "data": "Actions", "orderable": false, "title": "Actions", "render": function (data, type, full, meta) {
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
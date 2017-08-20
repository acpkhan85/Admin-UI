﻿$(document).ready(function () {

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

$('#standards').dataTable({
    "ajax": {
        "url": "/Class/GetDivisions",
        "type": "GET"
    }, "columns": [
            { "data": "Standard" },
            { "data": "Division" },
            { "data": "Actions", "orderable": false },
    ],
    "searching": false,
    "ordering": true,
    "order": [[0, "asc"]],
    "bLengthChange": false,
});
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

$('#standards').dataTable({
    "ajax": {
        "url": "/Class/GetDivisions",
        "type": "POST"
    }, "columns": [
            { "data": "Standard","name": "Standard" },
            { "data": "Division","name": "Division" },
            { "data": "Actions", "orderable": false },
          
    ], 
    "fnRender": function (data) {
                                    
        return "<input type='button' value='Detail' class='reciveDetailOffer' data-details='userid=" + data[0] + "&offerid=" + data[1] + "' Title='View Details'>";
                                    
    },
    "searching": false,
    "ordering": true,
    "order": [[0, "asc"]],
    "bLengthChange": false,
    "proccessing": true,
    "serverSide": true,
});

//{
//    bSortable: false,
//    mRender: function (o) { return '<i class="ui-tooltip fa fa-pencil" style="font-size: 22px;" data-original-title="Edit"></i><i class="ui-tooltip fa fa-trash-o" style="font-size: 22px;" data-original-title="Delete"></i>'; }
//}

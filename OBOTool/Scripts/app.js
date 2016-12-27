$(document).ready(function () {
    $("#wellHeaderHeading").click(function () {
        $("#wellHeader").collapse('toggle');
    });

    $("#wellHeader").on('shown.bs.collapse', function () {

        $("#wellHeaderHeading").html("Well Header");
    });

    $("#wellHeader").on('hidden.bs.collapse', function () {

        var orig = $("#wellHeaderHeading").html();
        var wn = $("#Name").val();
        $("#wellHeaderHeading").html(orig + " - " + wn);
    });

    $("#wellsIndex").DataTable();
});

function updateSuccess(data) {
        //console.log(data);
        $("#saveMessage").html(data);
    }
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
    $(".datetime").datepicker();
});

function toJavaScriptDate(value) {
    var pattern = /Date\(([^)]+)\)/;
    var results = pattern.exec(value);
    var dt = new Date(parseFloat(results[1]));
    var hours = dt.getHours() > 12 ? dt.getHours() - 12 : dt.getHours();
    var minutes = dt.getMinutes() < 10 ? "0" + dt.getMinutes() : dt.getMinutes();
    var seconds = dt.getSeconds() < 10 ? "0" + dt.getSeconds() : dt.getSeconds();
    var timeEnd = dt.getHours() >= 12 ? " PM" : " AM";

    return (dt.getMonth() + 1) + "/" + dt.getDate() + "/" + dt.getFullYear() + " " + hours + ":" + minutes + ":" + seconds + timeEnd;
}

function updateResult(data) {
        //console.log(data);
        $("#saveMessage").html(data);
        var d = toJavaScriptDate(data.CommentDate);
        $("#commentDate").html(d);
        $("#commenter").html(data.Commenter);
    }
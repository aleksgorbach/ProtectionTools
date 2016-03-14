$(document).ready(function() {
    $("#addElement").click(function (e) {
        e.preventDefault();
        $("#elements").load("/Tools/AddConnection",
        {
            "type": $("select[name='connectionType']").val(),
            "activePower": $("input[name='activePower']").val(),
            "count": $("input[name='count']").val(),
            "usingCoefficient": $("input[name='usingCoefficient']").val(),
            "cos": $("input[name='cos']").val()
        });
    });

})
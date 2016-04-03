$(document).ready(function() {
    $("#addElement").click(function() {
        $.ajax({
            method: "POST",
            url: "/index/add",
            success: function(data) { alert(data); }
        });
    });
})
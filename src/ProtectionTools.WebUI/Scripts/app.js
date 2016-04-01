$(dociment).ready(function() {
    $("#addElement").click(function() {
        $.ajax({
            url: "/index/add",
            success: function(data) { alert(data); }
        });
    })
})
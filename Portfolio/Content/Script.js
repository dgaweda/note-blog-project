$(document).ready(function () {
    var label = $("#textAreaLabel");
    label.keyup(function (event) {
        
        if (event.which == 13) {
            label.val(label.val() + "<br />");                                                                            
        }
    });
});
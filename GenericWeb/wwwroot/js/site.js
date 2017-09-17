// Write your Javascript code.
function validateEmail(email) {
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
}

var validateContent = function (element) {
    return $(element).find(".has-error").length === 0;
}

var sendRequest = function (url) {
    if (validateContent("#emailForm")) {
        var request = {
            fromEmail: $("#email").val(),
            body: $("#body").val()
        }
        
        $.post(url, request, function () {
            alert("Your request has been submitted. We will respond asap.");
            $("#email").val("");
            $("#body").val("");
            $('#emailModal').modal('toggle');
        }).error(function () {
           alert("Your request was not submitted. Please try again");
        });
    }
    else {
       alert("Ensure all fields are properly filled out.");

    }
}

$(function () {

    $("input[type=email]").each(function (i, e) {
        $(e).on("blur keyup", function () {
            var $email = $(this);
            var valid = validateEmail($email.val());
            $email.parent().removeClass("has-error");
            if (!valid) {
                $email.parent().addClass("has-error");
            }
        });
    });

    $("input[data-req]").each(function (i, e) {
        $(e).on("blur keyup", function () {
            var $input = $(this);
            $input.parent().removeClass("has-error");
            if ($input.val().length === 0) {
                $input.parent().addClass("has-error");
            }
        });
    });
});

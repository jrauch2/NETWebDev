/*global $, toast*/

$(function () {
    // pre-load audio
    var toast = new Audio("media/toast.wav");
    // keydown to hide toast on
    var keyCodeHideToast = 27;


    $(".code").on("click", function(e) {
        e.preventDefault();
        // first pause the audio (in case it is still playing)
        toast.pause();
        // reset the audio
        toast.currentTime = 0;
        // play audio
        toast.play();

        // set the value of the toast data
        $("#toast").data("name", $(this).parent().data("product").name);
        $("#toast").data("code", $(this).parent().data("code"));
        $("#product").text($("#toast").data("name"));
        $("#code").text($("#toast").data("code"));

        // show toast
        $("#toast").toast({ autohide: false }).toast("show");
    });

    // hide toast on keydown
    $("body").keydown(function (e) {
        if (e.originalEvent.keyCode === keyCodeHideToast) {
            $("#toast").toast("hide");
        }
    });
});

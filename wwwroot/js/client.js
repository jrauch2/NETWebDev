$(function(){
    // preload audio
    var toast = new Audio('media/toast.wav');
    var keyCodeHideToast = 27;

    $('.code').on('click', function(e) {
        e.preventDefault();
        // first pause the audio (in case it is still playing)
        toast.pause();
        // reset the audio
        toast.currentTime = 0;
        // play audio
        toast.play();
        $('#toast').toast({ autohide: false }).toast('show');
    });

    $('body').keydown(function (e) {
        if (e.originalEvent.keyCode == keyCodeHideToast) {
            $('#toast').toast('hide');
        }
    });
});

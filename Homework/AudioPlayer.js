$('.repeat').hide();
$('.recycle').hide();

var MP3Array = [["蔡依林", "Life Sucks", "Life Sucks.jpg"],
    ["TAEYEON", "Four Seasons", "Four Seasons.jpg"],
    ["","",""]]

var Tbook = document.getElementById("Tbook");

(function () {
    $(".list-btn").click(function () {
        $(this).parent().toggleClass("active");
        return $(".lists").toggleClass("active");
    });

    $(".action-button").find('a').click(function () {
        if ( $(this).hasClass("play-pause") ) {
            return $(this).toggleClass("active");
        }
        if ($(this).hasClass("random")) {
            $(this).hide();
            $('.repeat').show();
        } else if ($(this).hasClass("repeat")) {
            $(this).hide();
            $('.recycle').show();
        } else if ($(this).hasClass("recycle")) {
            $(this).hide();
            $('.random').show();
        }
    });

}).call(this);



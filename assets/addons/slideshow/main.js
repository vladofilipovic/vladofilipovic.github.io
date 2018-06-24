function slideshow_init_slideshow(id) {
    $(id + " > div:gt(0)").hide();

    setInterval(function() { 
      $(id + ' > div:first')
        .fadeOut(1000)
        .next()
        .fadeIn(1000)
        .end()
        .appendTo(id);
    }, 5000);
}

function slideshow_init() {
    $(".slideshow > div:gt(0)").hide();

    var slideshow_ids = [];

    $("div.slideshow").each(function(){
       slideshow_ids.push(this.id); 
    });

    for (var i = 0; i < slideshow_ids.length; i++) {
        slideshow_init_slideshow('#' + slideshow_ids[i]);
    }
}

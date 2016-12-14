//top
$(function(){   
    $('.top dl dd .top-1').hover(function(){
        $(this).find("p").slideToggle();
    });
})


//index
$(function(){ 
    var a=$(".index-2 .index-2-1 img").height()-30;
    var b=$(".index-2 .index-2-1 img").width();
    var c=$(".index-2 .index-2-1").width();
    $(".index-2 .slick-dots").css({top:a,right:c-b});
    if($(window).width()>767){
        $(".index-2-1").height($(".index-2 .index-2-1 img").height())
    }
})

//鎷涜搐绾冲＋
$(function(){   
    $('.recruit dd .recruit1').click(function(){
        $(this).parent().addClass('hover').siblings().removeClass('hover');
        $(this).next().slideToggle().parent(".recruit dd").siblings().find(".recruit2").slideUp();
    });
})

//澶撮儴
$(function(){
   $('#right-menu').sidr({
        name: 'sidr-right',
        side: 'right'
    });
})
$(function(){
   $('#right-menu1').sidr({
        name: 'sidr-right',
        side: 'right'
    });
})
$(function(){   
    $('#right-menu').click(function(){
        $("#sidr-right li .right-nav1").prev().addClass("on");
    });
});
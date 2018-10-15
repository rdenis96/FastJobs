(function ($) {
    "use strict";

    // Sticky Nav
    $(window).on('scroll', function () {
        if ($(window).scrollTop() > 200) {
            $('.scrolling-navbar').addClass('top-nav-collapse');
        } else {
            $('.scrolling-navbar').removeClass('top-nav-collapse');
        }
    });

    /*
   One Page Navigation & wow js
   ========================================================================== */
    //Initiat WOW JS
    new WOW().init();

    // one page navigation
    $('.main-navigation').onePageNav({
        currentClass: 'active'
    });

    $(window).on('load', function () {
        $('body').scrollspy({
            target: '.navbar-collapse',
            offset: 195
        });

        $(window).on('scroll', function () {
            if ($(window).scrollTop() > 200) {
                $('.fixed-top').addClass('menu-bg');
            } else {
                $('.fixed-top').removeClass('menu-bg');
            }
        });
    });

    // Slick Nav
    $('.mobile-menu').slicknav({
        prependTo: '.navbar-header',
        parentTag: 'span',
        allowParentLinks: true,
        duplicate: false,
        label: '',
    });

    /*
       CounterUp
       ========================================================================== */
    $('.counter').counterUp({
        time: 1000
    });

    /*
       MixitUp
       ========================================================================== */
    $('#portfolio').mixItUp();

    /*
       Touch Owl Carousel
       ========================================================================== */
    var owl = $(".touch-slider");
    owl.owlCarousel({
        navigation: false,
        pagination: true,
        slideSpeed: 1000,
        stopOnHover: true,
        autoPlay: true,
        items: 2,
        itemsDesktop: [1199, 2],
        itemsDesktopSmall: [1024, 2],
        itemsTablet: [600, 1],
        itemsMobile: [479, 1]
    });

    $('.touch-slider').find('.owl-prev').html('<i class="fa fa-chevron-left"></i>');
    $('.touch-slider').find('.owl-next').html('<i class="fa fa-chevron-right"></i>');

    /*
       Sticky Nav
       ========================================================================== */
    $(window).on('scroll', function () {
        if ($(window).scrollTop() > 200) {
            $('.header-top-area').addClass('menu-bg');
        } else {
            $('.header-top-area').removeClass('menu-bg');
        }
    });

    /*
       VIDEO POP-UP
       ========================================================================== */
    $('.video-popup').magnificPopup({
        disableOn: 700,
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 10,
        preloader: false,
        fixedContentPos: false,
    });

    /*
     SMOOTH SCROLL
     ========================================================================== */
    var scrollAnimationTime = 1200,
        scrollAnimation = 'easeInOutExpo';

    $('a.scrollto').on('bind', 'click.smoothscroll', function (event) {
        event.preventDefault();
        var target = this.hash;

        $('html, body').stop().animate({
            'scrollTop': $(target).offset().top
        }, scrollAnimationTime, scrollAnimation, function () {
            window.location.hash = target;
        });
    });

    /*
       Back Top Link
       ========================================================================== */
    var offset = 200;
    var duration = 500;
    $(window).scroll(function () {
        if ($(this).scrollTop() > offset) {
            $('.back-to-top').fadeIn(400);
        } else {
            $('.back-to-top').fadeOut(400);
        }
    });

    $('.back-to-top').on('click', function (event) {
        event.preventDefault();
        $('html, body').animate({
            scrollTop: 0
        }, 600);
        return false;
    })

    /* Nivo Lightbox
      ========================================================*/
    $('.lightbox').nivoLightbox({
        effect: 'fadeScale',
        keyboardNav: true,
    });

    /* stellar js
      ========================================================*/
    $.stellar({
        horizontalScrolling: true,
        verticalOffset: 40,
        responsive: true
    });

    /*
       Page Loader
       ========================================================================== */
    $('#loader').fadeOut();

    function isEmail(email) {
        var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
        return regex.test(email);
    }

    $(document).ready(function () {
        $('#submitReg').on('click', function (e) {
            //Create User object with retrieved data from inputs

            var userCredentials = {
                email: $("[name=emailRegister]").val(),
                password: $("[name=passwordRegister]").val(),
                firstname: $("[name=firstnameRegister]").val(),
                lastname: $("[name=lastnameRegister]").val(),
                phone: $("[name=phoneRegister]").val()
            }

            if (!isEmail(userCredentials.email)) {
                alert("Email format is not correct!");
                return;
            }

            if (userCredentials.password.length < 6) {
                alert("Password length must be at least 6 characters!");
                return;
            }

            if (userCredentials.password != $("[name=passwordConfirmRegister]").val()) {
                alert("Password is not the same with confirmation password!");
                return;
            }

            if (userCredentials.firstname.length < 1) {
                alert("Please type your firstname!");
                return;
            }

            if (userCredentials.lastname.length < 1) {
                alert("Please type your lastname!");
                return;
            }

            e.preventDefault();
            $.ajax({
                type: 'POST',
                url: 'api/account/register',
                data: userCredentials,
                contentType: "application/x-www-form-urlencoded",
                success: function (data) {
                    alert(JSON.stringify(data));
                    //window.location.replace('../home')
                }
            });
        });
    });

    $(document).ready(function () {
        $('#submitLogin').on('click', function (e) {
            //Create User object with retrieved data from inputs
            var userCredentials = {
                email: $("[name=emailLogin]").val(),
                password: $("[name=passwordLogin]").val()
            }
            e.preventDefault();
            $.ajax({
                type: 'POST',
                url: 'api/account/login',
                data: userCredentials,
                contentType: "application/x-www-form-urlencoded",
                success: function (data) {
                    if (data.userId == -1)
                        alert(data.message);
                    else {
                        alert(data.message);
                        localStorage.setItem("id", data.userId);
                        window.location.replace(window.location.origin + '/home')
                    }
                }
            });
        });
    });
}(jQuery));
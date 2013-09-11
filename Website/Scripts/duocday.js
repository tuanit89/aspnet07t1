var Appvl = {};
Appvl.Util = {};
Appvl.Util.getParameter = function(a, b) {
    if (b == undefined || b == null) b = window.location.search;
    a = a.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
    var c = "[\\?&]" + a + "=([^&#]*)";
    var d = new RegExp(c);
    var e = d.exec(b);
    if (e == null) return "";
    else return decodeURIComponent(e[1].replace(/\+/g, " "));
};
$(document).ready(function() {
    duocday.Framework.preventDuplicateSubmits();
    duocday.Framework.registerMessageCloseButton();
    duocday.Framework.initHeadline(3500);
    duocday.Framework.fixWhenScroll();
    
    $(window).scroll(function () {
        duocday.ListPhoto.fixInfoPanel();
    });
});

var duocday = {};
duocday.GA = {};
var _gaq;
duocday.GA.init = function(b) {
    _gaq = _gaq || [];
    _gaq.push(['_setAccount', b]);
    _gaq.push(['_trackPageview']);
    (function() {
        var a = document.createElement('script');
        a.type = 'text/javascript';
        a.async = true;
        a.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
        var s = document.getElementsByTagName('script')[0];
        s.parentNode.insertBefore(a, s);
    })();
};
duocday.Facebook = { appId: null, preInit: null, postInit: null };
duocday.Facebook.init = function(c) {
    duocday.Facebook.appId = c;
    (function(d, s, a) {
        var b, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(a)) return;
        b = d.createElement(s);
        b.id = a;
        b.src = "//connect.facebook.net/en_US/all.js#xfbml=1&appId=" + c;
        fjs.parentNode.insertBefore(b, fjs);
    }(document, 'script', 'facebook-jssdk'));
};
duocday.Framework = {};
duocday.Framework.fixWhenScroll = function() {
    $(window).scroll(function() {
        var s = $(window).scrollTop();
        $(".fixedScrollDetector").each(function() {
            var a = $(this);
            var b = a.next();
            var c = 51;
            if (a.attr("data-fixedTop") !== undefined) c = a.attr("data-fixedTop");
            if (a.offset().top - c <= s) {
                b.css({ position: "fixed", top: c + "px" });
            } else {
                b.css({ position: "relative", top: "" });
            }
        });
    });
};
duocday.Framework.preventDuplicateSubmits = function() {
    $(".submitForm").submit(function() {
        if ($(this).valid()) {
            $('.submitButton').attr("disabled", "disabled");
        }
    });
};
duocday.Framework.registerMessageCloseButton = function() {
    $(".close").click(function() {
        $(this).parent().fadeTo(200, 0, function() { $(this).slideUp(300); });
        return false;
    });
};
duocday.Framework.initHeadline = function(a) {
    $("#headlines a").hide().first().show();
    setTimeout(duocday.Framework.showHeadline, a);
};
duocday.Framework.showHeadline = function() {
    var a = $("#headlines a:visible").fadeOut(function() {
        if (a.next().is("a")) {
            a.next().fadeIn();
        } else {
            $("#headlines a:first").fadeIn();
        }
        setTimeout(showHeadline, 3500);
    });
};
duocday.ListPhoto = { isLoading: false, page: 1, initPage: 1, hasNoMore: false, sort: null, topContributorSort: null };
duocday.ListPhoto.init = function(a, b) {
    duocday.ListPhoto.sort = a;
    duocday.ListPhoto.page = b;
    duocday.ListPhoto.initPage = b;
    $(document).ready(function() {
        duocday.ListPhoto.topContributorSort = $(".topUsersSortHome a.selected").attr("data-sort");
        duocday.ListPhoto.registerVoteButtonClick();
        duocday.ListPhoto.registerTopContributorSortClick();
        duocday.ListPhoto.registerHotkeys();
        duocday.ListPhoto.registerHideClick();
        $(window).scroll(function() {
            duocday.ListPhoto.loadMore();
            duocday.ListPhoto.fixInfoPanel();
        });
    });
    window.fbAsyncInit = function() {
        FB.Event.subscribe('edge.create', duocday.ListPhoto.recount);
        FB.Event.subscribe('edge.remove', duocday.ListPhoto.recount);
    };
};
duocday.ListPhoto.registerVoteButtonClick = function() {
    $(".voteButton").live("click", function(e) {
        e.preventDefault();
        var a = $(this).attr("data-upvote");
        var b = $(this).attr("data-id");
        if ($(this).hasClass("upVoted") || $(this).hasClass("downVoted")) {
            $(this).removeClass("upVoted downVoted");
            duocday.ListPhoto.vote(b, a, true);
        } else {
            $(".voteButton", $(this).parents(".vote")).removeClass("upVoted downVoted");
            if (a == "true") $(this).addClass("upVoted");
            else $(this).addClass("downVoted");
            duocday.ListPhoto.vote(b, a, false);
        }
    });
};
duocday.ListPhoto.vote = function(b, c, d) {
    $.post("/photos/vote", { photoId: b, isUpVote: c, isUnvote: d }, function(a) {
        if (a == "Unauthenticated") {
            window.location.href = "/account/login?returnUrl=" + document.location.pathname + document.location.search;
        } else {
        }
    });
};
duocday.ListPhoto.recount = function(a) { if (a.toString().indexOf('/photo/') > 0) $.post("/photos/countbyurl?url=" + a); };
duocday.ListPhoto.loadMore = function() {
    if ($(window).scrollTop() + $(window).height() >= $(document).height() - 300) {
        if (duocday.ListPhoto.isLoading || duocday.ListPhoto.hasNoMore) return;
        duocday.ListPhoto.isLoading = true;
        $(".loading").show();
        $.ajax({
            url: duocday.ListPhoto.sort == "vote" ? "/photos/listvotemore?page=" + (duocday.ListPhoto.page + 1) : "/photos/more?sort=" + duocday.ListPhoto.sort + "&page=" + (duocday.ListPhoto.page + 1),
            dataType: "html",
            success: function(b) {
                if (b == "No more") duocday.ListPhoto.hasNoMore = true;
                else {
                    var c = $("<div>" + b + "</div>");
                    $(".photoListItem", c).each(function() {
                        if ($(".photoListItem[data-id=" + $(this).attr("data-id") + "]").size() > 0) {
                            console.log("removed");
                            $(this).remove();
                        } else if (duocday.ListPhoto.sort != "vote" && duocday.ListPhoto.sort != "old") {
                            var a = $(".thumbnail img.thumbImg", $(this)).attr("data-src");
                            a = a.replace(/\!/g, '9').replace(/\@/g, '1').replace(/\#/g, '6');
                            $(".thumbnail img.thumbImg", $(this)).attr("src", a);
                        }
                    });
                    $("#listEnd").before(c.html());
                    try {
                        FB.XFBML.parse();
                    } catch(e) {
                    }
                    duocday.ListPhoto.page++;
                    if (duocday.ListPhoto.page - duocday.ListPhoto.initPage == 2) {
                        duocday.ListPhoto.hasNoMore = true;
                        $(".nextListPage").show();
                    }
                }
            },
            error: function() {
            },
            complete: function() {
                duocday.ListPhoto.isLoading = false;
                $(".loading").hide();
            }
        });
    }
};
duocday.ListPhoto.fixInfoPanel = function() {
    $(".photoListItem").each(function() {
        var s = $(window).scrollTop();
        var a = $(this);
        var b = $(".info", this);
        if (a.offset().top - 60 < s && s < a.offset().top - 60 + a.outerHeight()) {
            if (s + b.outerHeight() < a.offset().top + a.outerHeight() - 70) {
                console.log("AAA");
                b.css({ position: "fixed", top: "60px" });
            } else {
                b.css({ position: "relative", top: "" });
                console.log("BBB");
            }
        } else {
            b.css({ position: "relative", top: "" });
            console.log("CC");
        }
    });
};
duocday.ListPhoto.registerTopContributorSortClick = function() {
    $(".topUsersSortHome a").click(function(e) {
        e.preventDefault();
        var a = $(this).attr("data-sort");
        if (a == duocday.ListPhoto.topContributorSort) return;
        duocday.ListPhoto.topContributorSort = a;
        $(".topUsersSortHome a").removeClass("selected");
        $(this).addClass("selected");
        $("#topUserContent").load("/home/TopContributors?sort=" + a);
    });
};
duocday.ListPhoto.registerHotkeys = function() {
    $(document).keydown(function(e) {
        var a = e.keyCode;
        if (a == 37 || a == 90) {
            var b = false;
            $($(".listItemSeparator").get().reverse()).each(function() {
                if ($(this).offset().top - 60 < $(window).scrollTop()) {
                    scrollTo(0, $(this).offset().top - 60);
                    b = true;
                    return false;
                }
            });
            if (!b) scrollTo(0, 0);
        } else if (a == 39 || a == 88) {
            $(".listItemSeparator").each(function() {
                if ($(this).offset().top - 62 > $(window).scrollTop()) {
                    scrollTo(0, $(this).offset().top - 60);
                    return false;
                }
            });
        }
    });
};
duocday.ListPhoto.registerHideClick = function() {
    $("a.hide").live('click', function(e) {
        e.preventDefault();
        var a = $(this);
        $.post('/photos/hide', { id: a.attr('data-id') }, function(b) {
            if (b.Success) {
                a.html("Hidden successfully");
            } else {
                a.html(b.Message);
            }
            a.addClass("disabled");
        });
    });
};
duocday.PhotoDetails = { photoId: null };
duocday.PhotoDetails.init = function(b) {
    duocday.PhotoDetails.photoId = b;
    $(document).ready(function() {
        duocday.PhotoDetails.registerHotKeys();
        duocday.ListPhoto.registerVoteButtonClick();
        duocday.PhotoDetails.registerReportClick();
        duocday.PhotoDetails.registerDeleteClick();
        duocday.PhotoDetails.registerHideClick();
        duocday.PhotoDetails.addRef();
        var a = { maxWidth: 800, maxHeight: 600, width: '500px', height: '280px', autoSize: false, openEffect: 'none', closeEffect: 'none', closeBtn: false };
        $(".commentContainer .report").fancybox(a);
        if (Appvl.Util.getParameter("report") == "1") $.fancybox.open("#reportPhotoContainer", a);
    });
    window.fbAsyncInit = function() {
        if (typeof(duocday.Facebook.preInit) == 'function') {
            duocday.Facebook.preInit();
        }
        FB.Event.subscribe('comment.create', duocday.PhotoDetails.recount);
        FB.Event.subscribe('comment.remove', duocday.PhotoDetails.recount);
        FB.Event.subscribe('edge.create', duocday.PhotoDetails.recount);
        FB.Event.subscribe('edge.remove', duocday.PhotoDetails.recount);
        if (typeof(duocday.Facebook.postInit) == 'function') {
            duocday.Facebook.postInit();
        }
    };
};
duocday.PhotoDetails.recount = function() { $.post("/photos/count/" + duocday.PhotoDetails.photoId); };
duocday.PhotoDetails.registerHotKeys = function() {
    $(document).keydown(function(e) {
        var a = e.keyCode;
        if (a == 37 || a == 90) {
            if ($(".navButtons a.prev").size() > 0) window.location.href = $(".navButtons a.prev").attr("href");
        } else if (a == 39 || a == 88) {
            if ($(".navButtons a.next").size() > 0) window.location.href = $(".navButtons a.next").attr("href");
        }
    });
};
duocday.PhotoDetails.registerReportClick = function() {
    $("#reportPhotoContainer .submitButton").click(function() {
        var a = $.trim($("#reportFreeText").val());
        if (a == "") a = $("#reportDdl").val();
        $.fancybox.close();
        $.post("/photos/report", { photoId: duocday.PhotoDetails.photoId, reason: a });
        alert("Cảm ơn bạn đã báo cáo hình ảnh này. BQT sẽ xử lý trong thời gian sớm nhất.");
    });
};
duocday.PhotoDetails.registerDeleteClick = function() {
    $("#deletePhoto").click(function(e) {
        e.preventDefault();
        if (confirm("Bạn có chắc chắn muốn xóa?") == true) {
            $("#deleteForm").submit();
        }
    });
};
duocday.PhotoDetails.registerHideClick = function() {
    $("#hidePhoto").click(function(e) {
        e.preventDefault();
        if (confirm("Sure?") == false) {
            return false;
        }
        var a = $(this);
        $.post('/photos/hide', { id: a.attr('data-id') }, function(b) {
            if (b.Success) {
                a.html("Hidden successfully");
            } else {
                ;
                a.html(b.Message);
            }
            a.addClass("disabled");
        });
    });
};
duocday.PhotoDetails.addRef = function() {
    var i = 1;
    $(".randomBox .photoListItemSmall a").each(function() {
        $(this).attr("href", $(this).attr("href") + "?ref=r" + i);
        i++;
    });
    i = 1;
    $(".newestBox .photoListItemSmall a").each(function() {
        $(this).attr("href", $(this).attr("href") + "?ref=n" + i);
        i++;
    });
};
duocday.Uploader = { isLoading: false, page: 1, initPage: 1, hasNoMore: false, uploaderId: null };
duocday.Uploader.init = function(a, b) {
    duocday.Uploader.uploaderId = a;
    duocday.Uploader.page = b;
    duocday.Uploader.initPage = b;
    $(document).ready(function() {
        duocday.ListPhoto.registerHotkeys();
        $(window).scroll(function() {
            duocday.Uploader.loadMore();
            duocday.ListPhoto.fixInfoPanel();
        });
    });
};
duocday.Uploader.loadMore = function() {
    if ($(window).scrollTop() + $(window).height() >= $(document).height() - 50) {
        if (duocday.Uploader.isLoading || duocday.Uploader.hasNoMore) return;
        duocday.Uploader.isLoading = true;
        $(".loading").show();
        $.ajax({
            url: "/photos/uploadermore/" + duocday.Uploader.uploaderId + "?page=" + (duocday.Uploader.page + 1),
            dataType: "html",
            success: function(a) {
                if (a == "No more") duocday.Uploader.hasNoMore = true;
                else {
                    var b = $("<div>" + a + "</div>");
                    $(".photoListItem", b).each(function() {
                        if ($(".photoListItem[data-id=" + $(this).attr("data-id") + "]").size() > 0) {
                            console.log("removed");
                            $(this).remove();
                        }
                    });
                    $("#listEnd").before(b.html());
                    try {
                        FB.XFBML.parse();
                    } catch(e) {
                    }
                    duocday.Uploader.page++;
                    if (duocday.Uploader.page - duocday.Uploader.initPage == 2) {
                        duocday.Uploader.hasNoMore = true;
                        $(".nextListPage").show();
                    }
                }
            },
            error: function() {
            },
            complete: function() {
                duocday.Uploader.isLoading = false;
                $(".loading").hide();
            }
        });
    }
};
duocday.Upload = {};
duocday.Upload.init = function(a, b) {
    $(document).ready(function() {
        if (a) $(".inputForm input, .inputForm textarea, .inputForm .buttons").attr("disabled", "disabled");
        if (b) $("#Source").attr("disabled", "disabled");
        duocday.Upload.registerSelfMadeChange();
        duocday.Upload.checkLikeBeggar();
    });
};
duocday.UploadVideo = {};
duocday.UploadVideo.init = function(a) {
    $(document).ready(function() {
        if (a) $(".inputForm input, .inputForm textarea, .inputForm .buttons").attr("disabled", "disabled");
        duocday.Upload.checkLikeBeggar();
        duocday.UploadVideo.handleYoutubeUrl();
    });
};
duocday.UploadVideo.handleYoutubeUrl = function() {
    $("#YoutubeUrl").change(function() {
        var a = Appvl.Util.getParameter("v", $("#YoutubeUrl").val());
        if (a == "") {
            alert("Đường dẫn Youtube không đúng.");
            return;
        }
        $("#youtubeEmbed").html("<iframe width='518' height='300' src='http://www.youtube.com/embed/" + a + "' frameborder='0'></iframe>");
        $("#youtubeEmbed").show();
    });
};
duocday.Edit = {};
duocday.Edit.init = function(a) {
    $(document).ready(function() {
        if (a) $("#Source").attr("disabled", "disabled");
        duocday.Upload.registerSelfMadeChange();
        duocday.Upload.checkLikeBeggar();
    });
};
duocday.Upload.registerSelfMadeChange = function() {
    $("#IsSelfMade").click(function() {
        $("#Source").val('');
        $("#Source").attr("disabled", "disabled");
        if (!$("#IsSelfMade").is(':checked')) {
            $("#Source").prop("disabled", false);
        }
    });
};
duocday.Upload.checkLikeBeggar = function() { $("#Caption").change(function() { if ($(this).val().toLowerCase().indexOf("like") >= 0) alert("Chú ý: ảnh có tiêu đề câu like có thể bị xóa (xem nội quy bên phải)."); }); };
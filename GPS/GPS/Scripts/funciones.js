function setMenu() {
    $("#menu > ul li").removeClass("current_page_item");
    var uri = window.location.pathname;
    uri = uri.split('/');
    $("#menu > ul li a").each(function () {
        if (uri[2] == $(this).text()) {
            $(this).parent().addClass("current_page_item");
        }
    });
}

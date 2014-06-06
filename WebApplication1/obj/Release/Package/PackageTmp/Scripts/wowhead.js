$(function () {
    $("#results").hide();

    $("#txtSearch").keydown(KeyDownEvent);

    function KeyDownEvent() {
        var searchstring = $("#txtSearch").val();
        var cbItem = $('#cbItem').prop('checked');
        var cbClass= $('#cbClass').prop('checked');
        var cbGuide = $('#cbGuide').prop('checked');
        $("#results").load("LiveSearch.ashx?searchstring=" + searchstring + "&cbItem=" + cbItem + "&cbClass=" + cbClass + "&cbGuide=" + cbGuide);
        $("#results").show();
    }

});
var dataService = function () {

    function Request(type,data,url) {
        return $.ajax({
            url: url,
            type: type,
            data: data
        });
    }
    function CorRequest(type, data, url) {
       return $.ajax({
            crossDomain: true,
            contentType: "application/json; charset=utf-8",
            url: url,
            data: data, 
            dataType: "jsonp",
            type:type
        });
    }
    return {
        AjaxRequest: Request,
        CorRequest:CorRequest
    }

}();
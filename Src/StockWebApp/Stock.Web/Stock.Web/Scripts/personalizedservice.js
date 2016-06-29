var personalizedService = function () {
    $(function () {
        $("#savebtn").click(function () {
            var term = $("#addstock").val();
            if (term == "") {
                alert("Please choose valid stock symbol");
                return false;
            }
            var data = { term: term };
            var url = "/PersonalizedStocks/SaveSymbolToUser";
            dataService.AjaxRequest("POST", data, url).then(function (response) {
                location.reload();
            });
        });


        $(".deletebtn").click(function () {
            var prop = $(this).prop("id");
            var data = { term: prop };
            var url = "/PersonalizedStocks/DeleteStockFromUser";
            if (confirm("Are you sure you want to delete this stock from your personalized stock list?")) {
                dataService.AjaxRequest("POST", data, url).then(function (response) {
                    location.reload();
                });
            }
        });


        $("#addstock").autocomplete({
            source: function (request, response) {
                var data = { term: request.term };
                var url = "/PersonalizedStocks/GetStockSymbols";
                dataService.AjaxRequest("GET", data, url).then(function (resData) {
                    response(resData);
                });
            },
            response: function (event, ui) {
                if (!ui.content.length) {
                    var noResult = { value: "", label: "Either no match stock exist or user already has this stock" };
                    ui.content.push(noResult);
                }
            },
            change: function (event, ui) {
                if (!ui.item) {
                    $(event.target).val("");
                }
            },
            focus: function (event, ui) {
                return false;
            },
            select: function (event, ui) {
                $("#addstock").val(ui.item.label);
            },
            minLength: 2
        });
    });

    function Init() {
        $("#addstockrow").hide();
        $("#addbtn").click(function () {
            $("#addstockrow").show();
        });
    }

    return {
        Init:Init
    }

}();
/// <reference path="dashboardstockticker.js" />
var ticker = function () {
    var webServiceUrl = "http://localhost:4591/Service1.asmx/GetData";
    var url = "/PersonalizedStocks/GetUserStocks";
    var stockTickers = [];

    function OnInit(respData)
    {
        dataService.CorRequest("POST", {}, webServiceUrl).then(function (data) {
            $("#scrolldiv").html("");
            stockTickers = [];

            $.each(data, function (index, item) {
                $.each(respData, function (idx, obj) {
                    console.log(item);
                    if (item.StockSymbol === obj) {
                        var tickerObj = {};
                        tickerObj.stockPrice = item.StockPrice;
                        tickerObj.stockCode = item.StockSymbol;
                        stockTickers.push(tickerObj);
                    }
                });
            });
            //bind to UI
            $.each(stockTickers, function (indx, itm) {
                //   $("#scrolldiv").append("<li>" + itm.stockCode + "(" + itm.stockPrice + ")</li>");

                $("#scrolldiv").append('<button class="btn btn-primary" type="button">' + itm.stockCode + ' <span class="badge">' + itm.stockPrice + '</span></button>&nbsp;')
            });
            //   $("#scrolldiv").ticker();

        });
    }

    function Init() {
         dataService.AjaxRequest("GET", {}, url).then(function (respData) {

             OnInit(respData);
             setInterval(function () {
                 OnInit(respData);
             }, 10000);
        });
    }

    return {
        Init: Init
    }

}();
Configuration
1) This project is done using asp.net mvc 4.0 using .net framework 4.Ide which is used to develop the code is vs2012 and sql server 2008 is used for database
2) StockService is programmed in asp.net asmx using .net framework 3


Instruction how to install 

1) Change the database connection string in app.config in Stock.Dal project in StockWebApp
2) change the webserviceurl in dashboardticker.js in Stock.Web/Scripts , point it to that url which stockservice is using
3)create the db name stock and then Run the database script which is in /src/StockWebApp/Database/stock.sql
3) Host both the StockApp and StockService app on iis or one can run it simltaneoulsy in two VS instance and see the result. StockWebApp is consuming StockService so stockservice should be running
4) Unit and integration test are in Stock.Web.Tests project


How To Use the app
Video is recorded in swf format in wink folder you can check that .Apart from that I write brief intro how to use it

StockWebApp is app where user can create personalized stocks app. Upon login user will see dashboard where stock along its pricing will be displayed. Only those stock
will be displayed in dashboard which user has added to its personalized list. Those price will be updated every 10 seconds from asmx web service which is other component in stock. This service returns list of stock along their random price everytime client uses it. Random price are b/w 1 to 1000. Currently stock codes and their price are simulated directly from code in web service .Stocks which web service supplies along their random price are msft, goog and appl

On Personalized stock page user can add and delte stock to their list . Each user will have their own personalized list in stock app which they see upon login
There is autosuggest textbox in which user will search for stock symbols, as symbol get found in the db , it will show that, if that symbol user already has then taht symbol willl not be shown. user can delte the symbols also and add it also at any time and that updated list then get visible on dashbaord also.

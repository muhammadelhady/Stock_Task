"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/StockHub").build();


connection.on("UpdateStocks", function (Stocks) {

    var li = document.createElement("li");
    document.getElementById("tableBody").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${Stocks} `;
   
});
connection.invoke("UpdateStocks").catch(function (err) {
    return console.error(err.toString());
});



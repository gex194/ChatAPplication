var app = angular.module("app", []);

app.run(function (signalR) {
    signalR.url("https://localhost:44377/signalr");
});
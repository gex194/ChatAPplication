app.controller("ctrl", function ($scope, signalR) {
    $scope.messages = [];
    $scope.user = {};

    signalR.setHubName("liveChatHub");

    signalR.client().broadcastMessage = function (name, message, time) {
        var newChat = { name: name, message: message, time };

        $scope.$apply(function () {
            $scope.messages.push(newChat);
        });
    };

    signalR.start(function () {
        $scope.send = function () {
            var dt = new Date();
            var time = dt.getHours() + ":" + dt.getMinutes() + ":" + dt.getSeconds();

            signalR.server().send($scope.user.name, $scope.user.message, time);
            $scope.user.message = "";
        };
    });

    addEventListener("keypress", function (e) {
        if (e.key === "Enter" && $scope.user.message !== "" && $scope.user.message !== undefined) {
            $scope.send();
            $scope.user.message = "";
        }
    });
});
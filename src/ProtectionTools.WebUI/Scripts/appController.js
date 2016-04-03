(function() {
    var app = angular.module("electricityApp", []);
    var appController = function($scope, $http) {
        $scope.message = "helloworld";
        $scope.addElement = function() {
        }
    }
    app.controller("AppController", appController);
})();

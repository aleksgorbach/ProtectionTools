﻿(function() {
    var app = angular.module("electricityApp");
    var appController = function($scope, electricity) {
        $scope.message = "helloworld";
        $scope.model = {
            PowerCoef: 1.18,
            NominalVoltage: 0.38,
            Elements: []
        }

        $scope.calc = function () {
            electricity.calc($scope.model).then(function (data) {
                $scope.model = data;
            })
        }

        $scope.addElement = function() {
            electricity.addElement($scope.model)();
        }
    }
    app.controller("AppController", appController);
})();

(function electricityService($http) {
    var app = angular.module("electricityApp");

    var service = function($http) {
        var calc = function (model) {
            return $http.post("/App/Calc", model).then(function (response) {
                return response.data;
            })
        }

        var addElement = function (model) {
            model.Elements.push({
                ActivePower: 0,
                Count: 1,
                UsingCoefficient: 1,
                Cos: 1
            });
            return model;
        }
        
        return {
            calc: calc,
            addElement: addElement
        }
    }
    app.factory("electricity", service);
} ());
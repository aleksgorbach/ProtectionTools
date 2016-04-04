(function electricityService() {
    var app = angular.module("electricityApp");

    var service = function($http) {
        var calc = function (model) {
            return $http.post("/app/calc", model).then(function(response) {
                return response.data;
            });
        }

        var addElement = function (model) {
            model.Elements.push({
                ActivePower: 10,
                Count: 1,
                UsingCoefficient: 0.8,
                Cos: 0.6
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
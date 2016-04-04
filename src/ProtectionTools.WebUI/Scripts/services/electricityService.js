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
                activePower: 0,
                count: 1,
                useCoef: 1,
                cos: 1,
                nomPower: 1,
                reactiveLoad: 0
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
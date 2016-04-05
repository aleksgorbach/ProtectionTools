(function electricityService() {
    var app = angular.module("electricityApp");

    var service = function ($http) {
        var calc = function (model) {
            return $http.post("/app/calc", model).then(function (response) {
                return response.data;
            });
        }

        var addElement = function (model) {
            model.Elements.push({
                ActivePower: 10,
                Count: 1,
                UsingCoefficient: 0.6,
                Cos: 0.8
            });
            return model;
        }

        var removeElement = function (elem, model) {
            var index = model.Elements.indexOf(elem);
            model.Elements.splice(index, 1);
            return model;
        }

        var getInitialBus = function () {
            return {
                PowerCoef: 1.18,
                NominalVoltage: 0.38,
                Elements: []
            }
        }

        return {
            calc: calc,
            addElement: addElement,
            removeElement: removeElement,
            getInitialBus: getInitialBus
        }
    }
    app.factory("electricity", service);
}());
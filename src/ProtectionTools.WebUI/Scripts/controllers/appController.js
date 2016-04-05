(function() {
    angular.module("electricityApp").controller("AppController", function ($scope, electricity) {
            $scope.model = electricity.getInitialBus();
        
            $scope.calc = function() {
                electricity.calc($scope.model).then(function(data) {
                    $scope.model = data;
                });
            }

            $scope.removeElement = function(elem) {
                $scope.model = electricity.removeElement(elem, $scope.model);
            }

            $scope.addElement = function() {
                $scope.model = electricity.addElement($scope.model);
            }
        }
    );
}())

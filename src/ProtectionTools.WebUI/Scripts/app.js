(function () {
    angular.module("electricityApp", ["ngRoute", "ngMessages"])
        .config([
            "$routeProvider", function($routeProvider) {
                $routeProvider
                    .when("/app", {
                        templateUrl: "/views/appView.html",
                        controller: "AppController"
                    })
                    .otherwise({
                            redirectTo: "/app"
                        }
                    );
            }
        ]);
}());
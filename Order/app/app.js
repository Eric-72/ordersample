
var app = angular.module('app', ['ngRoute']);

app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

    $routeProvider
        .when("/order", {
            templateUrl: "/app/order/order.html",
            controller: "orderController"
        })
        .otherwise({
            redirectTo: "/order"
        });

    $locationProvider.html5Mode({
        enabled: false,
        requireBase: false
    });

}]);
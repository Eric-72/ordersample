
app.factory('orderService', ['$http', function ($http) {
    
    var getOrders = function () {
        return $http.get("/api/Orders/GetAll");
    };

    var getOrderDetails = function (id) {
        return $http.get("/api/Orders/" + id + "/GetDetails");
    };

    return {
        getOrders: getOrders,
        getOrderDetails: getOrderDetails
    }
}]);
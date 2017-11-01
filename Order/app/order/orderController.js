
app.controller('orderController', ['$scope', 'orderService', function ($scope, orderService) {
    
    orderService.getOrders()
        .then(
        function (results) {
            //on success
            $scope.orders = results.data;
        },
        function (results) {
            //on error
            $scope.hasFormError = true;
            $scope.formErrors = results.statusText;
        }
    );

    $scope.selectOrder = function (id) {
        $scope.selectedOrder = id;
        $scope.loadOrderDetails(id);
    };

    $scope.loadOrderDetails = function (id) {
        orderService.getOrderDetails(id)
            .then(
            function (results) {
                //on success
                $scope.orderDetails = results.data;
            },
            function (results) {
                //on error
                $scope.hasFormError = true;
                $scope.formErrors = results.statusText;
            }
        );
    }

}]);
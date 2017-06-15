app.controller("CarModelsController", function ($scope, $http) {
    $http.get("/api/CarModels").then(function (response) {
        $scope.carModels = response.data;
    }, function (response) {
        $scope.content = "Something went wrong";
    });
});
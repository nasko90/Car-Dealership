app.controller("TotalAmmounController", function ($scope, $http) {
    $http.get("/api/Report/GetTotalAmountForPeriod").then(function (response) {
        $scope.totalAmmount = response.data;
    }, function (response) {
        $scope.content = "Something went wrong";
    });
});
app.controller("ReportController", function ($scope, $http) {
    $http.get("/api/Report").then(function (response) {
        $scope.reports = response.data;
    }, function (response) {
        $scope.content = "Something went wrong";
    });
});
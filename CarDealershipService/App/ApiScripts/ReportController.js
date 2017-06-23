app.controller("ReportController",
    function($scope, $http) {

        $scope.startDate = new Date('2014-04-05');
        $scope.endDate = new Date('2016-08-05');       


        var url = "api/Report?startDate=" + $scope.startDate.toISOString() + "&endDate=" + $scope.endDate.toISOString();
        $http.get(url).then(function (response) {
                $scope.reports = response.data;
            },
            function(response) {
                $scope.content = "Something went wrong";
            });

        $scope.exportData = function() {
            var blob = new Blob([document.getElementById('export').innerHTML],
                {
                    type: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=utf-8"
                });
            saveAs(blob, "Report.xls");
        }

        $scope.getTotalSales = function() {
            var total = 0;
            for (var i = 0; i < $scope.reports.length; i++) {
                var sales = $scope.reports[i];
                total += sales.TotalAmountOfSalesForModel;
            }

            return total;
        }
        
    });

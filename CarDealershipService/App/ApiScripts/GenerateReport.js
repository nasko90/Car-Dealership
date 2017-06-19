function myCtrl($scope) {
    $scope.exportData = function() {
        var blob = new Blob([document.getElementById('export').innerHTML],
            {
                type: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=utf-8"
            });
    }
}
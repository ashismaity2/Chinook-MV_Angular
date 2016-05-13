angular.module('MyApp')   
.controller('AngController-Index', function ($scope, CustomerService) { 
    $scope.Customers = [];

    CustomerService.GetCustomers().then(function (d) {
        $scope.Customers = d.data;
    });
})
.factory('CustomerService', function ($http) {  
    var fac = {};
    fac.GetCustomers = function () {
        return $http.get('/Chinook/index');
    }
    return fac;
});
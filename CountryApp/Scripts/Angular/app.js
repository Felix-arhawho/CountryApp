var app = angular.module('myApp', []);

app.controller('myCountroller', function ($scope, $http) {

    getCountries();
    function getCountries() {
        $http.get("http://localhost:1925/api/Country").
        then(function (response) {
            $scope.Countries = response.data; 
        })        
    }

    $scope.createCountry = function (country) {
        $http.post("http://localhost:1925/api/Country", country).
        then(function (response) {
            alert("Country Created Successfully");
            $scope.country = {};
            $scope.$setPrestine(true);
        })
    }
})
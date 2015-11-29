'use strict';

angular.module("todoListApp.lists", [])
.controller('listController', ['$scope', '$http', function ($scope, $http) {
    $scope.lists = [];
    $scope.isDisabled = true;
    var getLists = function () {
        $http({
            method: 'GET'
            , url: '/api/lists'
        }).then(function success(response) {
            $scope.lists = response.data;
            $scope.isDisabled = false;
        }
        , function error(response) {
            console.log(response);
        })
    }
    $scope.addToList = function () {
        var name = $scope.listName;
        name = name.toLowerCase().trim();
        $scope.listName = "";
        if (name.length == 0) {
            alert('Blank String');
            return;
        }
        if ($scope.lists.indexOf(name) != -1) {
            alert ( 'List is present');
            return;
        }
        $scope.lists.push(name);
        var json = [];
        json.push(name);
        $http({
            method: 'POST'
            , url: '/api/lists'
            , data: json
        }).then(function success() {

        }
    , function error() {
        console.log(error);
    })
    };
    getLists();
}])
.directive('lists', function () {
    return {
        templateUrl: 'app/lists/lists.tpl.html'
        , restrict: 'EA'
        , controller: 'listController'
        , controllerAs: 'ctrl'

    };
});

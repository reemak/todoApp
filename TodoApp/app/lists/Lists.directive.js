'use strict';

angular.module("todoListApp.lists", [])
.controller('listController', ['$scope', function ($scope) {
    $scope.lists = [];
    $scope.addToList = function () {
        $scope.lists.push($scope.listName);
        $scope.listName = "";
    };
}])
.directive('lists', function () {
    return {
        templateUrl: 'app/lists/lists.tpl.html'
        , restrict: 'EA'
        , controller: 'listController'
        , controllerAs: 'ctrl'

    };
});

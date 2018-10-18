/// <reference path="../../assets/admin/libs/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("myController", myController);
myController.$inject = ['$scope'];
function myController($scope) {
    $scope.mesage = "this is my mesage form controller";
}

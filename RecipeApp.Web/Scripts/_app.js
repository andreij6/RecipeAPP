'use strict';

var recipeApp = angular.module('recipeApp', ['ngRoute']);

recipeApp.config(function ($routeProvider) {
    $routeProvider.when('/',
            {
                templateUrl: "Templates/Home.html",
                controller: "HomeCtrl"
            }
        ).otherwise
        (
            { redirectTo: '/' }
        );
})
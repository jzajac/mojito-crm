/*jshint globalstrict: true*/

'use strict';

angular.module('home.controllers', ['api'])
	.controller('HomeController', ['$scope', function ($scope, $q) {

        $scope.test = "foobar";

    }]);
/*jshint globalstrict: true*/

'use strict';

angular.module('home.controllers', ['api'])
	.controller('HomeController', ['$scope', '$q', 'accountApi', function ($scope, $q, accountApi) {

        $scope.queryEndpoint = function() {
            var defer = $q.defer();

            accountApi.test().then(function(data) {
                $scope.test = data;
            });

            return defer.promise;
        }

    $scope.queryEndpoint();

}]);
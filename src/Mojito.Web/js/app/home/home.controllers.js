/*jshint globalstrict: true*/

'use strict';

angular.module('home.controllers', ['api'])
	.controller('HomeController', ['$scope', '$q', 'taskApi', function ($scope, $q, taskApi) {

        $scope.queryEndpoint = function() {
            var defer = $q.defer();

            taskApi.fetchAll().then(function(data) {
                $scope.tasks = data;
            });

            return defer.promise;
        }

    $scope.queryEndpoint();

}]);
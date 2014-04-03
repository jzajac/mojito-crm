/*jshint globalstrict: true*/

'use strict';

angular.module('tasks.controllers', ['api'])
	.controller('TasksController', ['$scope', '$q', 'taskApi', function ($scope, $q, taskApi) {

        $scope.template = "templates/tasks/list.html";

        $scope.queryEndpoint = function() {
            var defer = $q.defer();

            taskApi.fetchAll().then(function(data) {
                $scope.tasks = data;
            });

            return defer.promise;
        }

    $scope.queryEndpoint();

}]);
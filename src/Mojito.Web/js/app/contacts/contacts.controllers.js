/*jshint globalstrict: true*/

'use strict';

angular.module('contacts.controllers', ['api'])
	.controller('ContactsController', ['$scope', '$q', 'taskApi', function ($scope, $q, taskApi) {

        $scope.template = "templates/contacts/list.html";

}]);
/*jshint globalstrict:true*/
/*global angular*/

'use strict';

angular.module('mojito', ['shared', 'api', 'home', 'tasks', 'contacts', 'ngRoute'])
    .config(['$routeProvider', function($routeProvider) {

        // Routing 

        // Home 
        $routeProvider.when('/home', { templateUrl: 'templates/layout.html', controller: 'HomeController' });

        // Tasks
        $routeProvider.when('/tasks', { templateUrl: 'templates/layout.html', controller: 'TasksController' });

        // Contacts
        $routeProvider.when('/contacts', { templateUrl: 'templates/layout.html', controller: 'ContactsController' });

        // Default
        $routeProvider.otherwise({ redirectTo: '/home' });

    }]);
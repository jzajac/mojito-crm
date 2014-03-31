/*jshint globalstrict:true*/
/*global angular*/

'use strict';

angular.module('mojito', ['shared', 'api', 'home', 'ngRoute'])
    .config(['$routeProvider', function($routeProvider) {

            // Routing 
            $routeProvider.when('/home', { templateUrl: 'templates/test.html', controller: 'HomeController' });
            $routeProvider.otherwise({ redirectTo: '/home' });
        }
    ]);
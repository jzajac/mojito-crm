/*jshint globalstrict: true*/

'use strict';

angular.module('shared.services', [])
	/**
	 * Common web service functions
	 */
	.service('webservice', ['$q', '$http', function ($q, $http) {
	    return {

	        /**
			 * Generic function to make a web service call
			 * @param verb HTTP Verb to use
			 * @param url URL of web service
			 * @param data Data to send as request body
			 * @returns promise
			 */
	        call: function (verb, url, data) {
	            var deferred = $q.defer();

	            $http({
	                method: verb,
	                url: url,
	                data: data,
	                headers: {
	                    'Content-type': 'application/json'
	                }
	            })
				.success(function (data) {
				    deferred.resolve(data);
				})
				.error(function () {
				    deferred.reject();
				});

	            return deferred.promise;
	        }
	    }
	}]);
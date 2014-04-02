/*jshint globalstrict:true*/

'use strict';

angular.module('api.services', ['shared.services'])
    .service('taskApi', ['webservice', function(webservice) {
            return {
                fetchAll: function () {
                    return webservice.call('GET', 'http://localhost:8080/task/', null)
                        .then(function (data) {
                            return data;
                        });
                },
            }
        }
    ]);
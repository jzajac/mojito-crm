/*jshint globalstrict:true*/

'use strict';

angular.module('api.services', ['shared.services'])
    .service('accountApi', ['webservice', function(webservice) {
            return {
                test: function () {
                    return webservice.call('GET', 'http://localhost:12008/', null)
                        .then(function (data) {
                            return data;
                        });
                },
            }
        }
    ]);
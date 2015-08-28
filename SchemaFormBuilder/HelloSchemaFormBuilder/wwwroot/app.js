(function () {
    "use strict";

    var myApp = angular.module('fancy.samples.hello-schema-form-builder', ['schemaForm']);

    myApp.controller('FormController', function ($scope, $http) {

        var vm = this;
        vm.model = {};

        $http.get('/api/Sample/Form').success(function (data) {
            vm.schema = data.Schema;
            vm.form = data.Form;
            vm.formLoaded = true;
        });

        vm.onSubmit = function (form) {
            // First we broadcast an event so all fields validate themselves
            $scope.$broadcast('schemaFormValidate');
            // Then we check if the form is valid
            if (form.$valid) {
                $http.put('/api/Sample', vm.model).success(function (data) {
                    vm.sendData = data;
                });
            }
        };

    });

})();
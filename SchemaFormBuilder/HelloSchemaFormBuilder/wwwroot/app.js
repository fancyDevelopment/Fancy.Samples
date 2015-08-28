(function () {
    "use strict";

    // Create an angular js app module
    var myApp = angular.module('fancy.samples.hello-schema-form-builder', ['schemaForm']);

    // Create a controller to load the form metaddata and send the filled form back to the server
    myApp.controller('FormController', function ($scope, $http) {

        var vm = this;

        // Create an empty model, the properties will be added by angular schema form
        vm.model = {};

        // Get the form description from the server
        $http.get('/api/Sample/Form').success(function (data) {
            // Set up the form description to view model properties to make it available at html markup
            vm.schema = data.Schema;
            vm.form = data.Form;
            vm.formLoaded = true;
        });

        // Function to be called on form submit
        vm.onSubmit = function (form) {
            // First we broadcast an event so all fields validate themselves
            $scope.$broadcast('schemaFormValidate');
            // Then we check if the form is valid
            if (form.$valid) {
                // If the form is valid we put the model back to the server
                $http.post('/api/Sample', vm.model).success(function (data) {
                    vm.sendData = data;
                });
            }
        };

    });

})();
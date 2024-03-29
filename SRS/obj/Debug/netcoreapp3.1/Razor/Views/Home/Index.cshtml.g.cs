#pragma checksum "C:\Users\user\Desktop\FunPro\SPA_SRS\SPA_SRS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3688791dc7989a872279d263359cb0d67f74f433"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\user\Desktop\FunPro\SPA_SRS\SPA_SRS\Views\_ViewImports.cshtml"
using SPA_SRS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\FunPro\SPA_SRS\SPA_SRS\Views\_ViewImports.cshtml"
using SPA_SRS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3688791dc7989a872279d263359cb0d67f74f433", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e393d48790690902773e9bf97ee6300f3349e38", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\Desktop\FunPro\SPA_SRS\SPA_SRS\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div ng-app=""SPA_SRS"">
    <div ng-view></div>
</div>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.8.2/angular.min.js""></script>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.8.2/angular-route.min.js""></script>
<script type=""text/javascript"">
    // Creating a Module to use within index page
    
    angular
        .module('SPA_SRS', ['ngRoute'])
        .config(function ($routeProvider) {
            $routeProvider
                .when('/',
                    {
                        templateUrl: 'pages/index.html',
                        controller: 'IndexController'
                    })
                .when('/create',
                    {
                        templateUrl: 'pages/create.html',
                        controller: 'CreateController'
                    })
                .when('/details/:studentId',
                    {
                        templateUrl: 'pages/details.htm");
            WriteLiteral(@"l',
                        controller: 'DetailsController'
                    })

                .when('/edit/:studentId',
                    {
                        templateUrl: 'pages/edit.html',
                        controller: 'EditDeleteController'
                    })
                .otherwise({
                    redirectTo: '/'
                });

        })
        .controller('IndexController', ['$scope', '$http', function ($scope, $http)
        {
            $scope.students = [];
            $http.get('https://localhost:44356/api/Student/')
                .then(function (res) {

                    $scope.students = res.data;
                })
        }])
        .controller('CreateController', ['$scope', '$http','$location', function ($scope, $http, $location)
        {
            $scope.module = [];
            $http.get('https://localhost:44356/api/Student/')
                .then(function (res){
                $scope.module = res.data;
           ");
            WriteLiteral(@" });
            $scope.student =
                {
                    Id : 0,
                    firstName : '',
                    lastName: '',
                    course: '',
                    age: '',
                    doB: '2002-06-18T10:34:09',
                    studentModule: ''
                };
            $scope.AddStudent = function()
            {
                $http.post('https://localhost:44356/api/Student/', $scope.student)
                    .then(function (res)
                    {
                        $location.path('/')
                    });
            }

        }])


        .controller('DetailsController', ['$scope', '$http', '$routeParams', function ($scope, $http, $routeParams)
        {
            $scope.details = [];

            $http.get('https://localhost:44356/api/Student/' + $routeParams.studentId)
                .then(function (res)
                {
                    $scope.details = res.data;
                });

     ");
            WriteLiteral(@"   }])
        .controller('EditDeleteController', ['$scope', '$http','$location', '$routeParams', function ($scope, $http, $location, $routeParams)
        {
            $scope.student = [];
            $scope.modules = [];
            $http.get('https://localhost:44356/api/Module/')
            .then(function (res){
                $scope.modules = res.data;
            });

            $http.get('https://localhost:44356/api/Student/' + $routeParams.studentId)
                .then(function (res)
                {
                    $scope.student = res.data;
                });

            $scope.Edit = function () {
                $http.put('https://localhost:44356/api/Student/' + $routeParams.studentId, $scope.edit)
                    .then(function (res) {
                        $location.path('/');
                    });
            };
            $scope.Delete = function () {
                $http.delete('https://localhost:44356/api/Student/' + $routeParams.studentId, $sco");
            WriteLiteral("pe.edit)\r\n                    .then(function (res) {\r\n                        $location.path(\'/\');\r\n                    });\r\n            };\r\n\r\n        }]);\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

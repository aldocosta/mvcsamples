/// <reference path="../../Scripts/Main/main.js" />
/// <reference path="../../Scripts/angular.min.js" />
main.controller('produtosController', ['$scope', '$http', function ($scope, $http) {
    $scope.nome = 'acs';
    $scope.retrieveProdutos = function () {
        $http.get('/produtoajax/RetornarProdutos').success(function (data) {
            $scope.produtos = data;
        });
    }
    $scope.retrieveProdutos();

    $scope.editar = function (p) {
        $scope.produto = p;
    }

    $scope.atualizar = function (pv) {
        $http.post('/produtoajax/AtualizarProduto', pv).success(function (data) {
            alert(data);
            $scope.retrieveProdutos();
        });
        //AtualizarProduto
    }

}]);
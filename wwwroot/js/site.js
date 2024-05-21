// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function brokerRendaVariavel() {
    $.ajax({
        url: "/broker/DadosRendaVariavel",
        success: function (dados) {
            document.getElementById('resultado').innerHTML = '';
            if (dados.erro != undefined) {
                alert(dados.msg);
            }
            else {
                document.getElementById('resultado').innerHTML = dados;
            }
        },
    });
}

function brokerRendaFixa() {
    $.ajax({
        url: "/broker/DadosRendaFixa",
        success: function (dados) {
            document.getElementById('resultado').innerHTML = '';
            if (dados.erro != undefined) {
                alert(dados.msg);
            }
            else {
                document.getElementById('resultado').innerHTML = dados;
            }
        },
    });
}

function aplicaFiltroConsultaAvancadaVariavel() {
    var vSigla = document.getElementById('sigla').value;
    $.ajax({
        url: "/rendaVariavel/ObtemDadosConsultaAvancada",
        data: { sigla: vSigla},
        success: function (dados) {
            if (dados.erro != undefined) {
                alert(dados.msg);
            }
            else {
                document.getElementById('resultadoConsulta').innerHTML = '';
                document.getElementById('resultadoConsulta').innerHTML = dados;
            }
        },
    });

}

function aplicaFiltroConsultaAvancadaFixa() {
    var vDescricao = document.getElementById('descricao').value;
    $.ajax({
        url: "/rendaFixa/ObtemDadosConsultaAvancada",
        data: { descricao: vDescricao },
        success: function (dados) {
            if (dados.erro != undefined) {
                alert(dados.msg);
            }
            else {
                document.getElementById('resultadoConsulta').innerHTML = '';
                document.getElementById('resultadoConsulta').innerHTML = dados;
            }
        },
    });

}

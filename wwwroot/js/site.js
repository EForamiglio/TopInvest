// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function aplicaFiltroConsultaTrade() {
    var vSigla = document.getElementById('sigla').value;
    $.ajax({
        url: "/trade/ObtemDadosConsultaAvancada",
        data: { sigla: vSigla },
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

function confirmarCompra(id) {
    if (confirm('Confirma compra da ação?')) {
        var vQtd = document.getElementById('qtd').value;
        $.ajax({
            url: "trade/EfetuaCompra",
            data: { acaoId: id, qtd: vQtd },
            success: function (dados) {
                if (dados.erro != undefined) {
                    alert(dados.msg);
                }
                else {
                    alert(dados.msg);
                }
            },
        });
    }
}

function aplicaFiltroConsultaFixo() {
    var vDescricao = document.getElementById('descricao').value;
    $.ajax({
        url: "/fixo/ObtemDadosConsultaAvancada",
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

function confirmarAplicacao(id) {
    if (confirm('Confirma aplicação?')) {
        var vValor = document.getElementById('valor').value;
        $.ajax({
            url: "fixo/EfetuaAplicacao",
            data: { fixaId: id, valor: vValor },
            success: function (dados) {
                if (dados.erro != undefined) {
                    alert(dados.msg);
                }
                else {
                    alert(dados.msg);
                }
            },
        });
    }
}

function aplicaFiltroConsultaAvancadaVariavel() {
    var vSigla = document.getElementById('sigla').value;
    var vPreco = document.getElementById('preco').value;
    $.ajax({
        url: "/rendaVariavel/ObtemDadosConsultaAvancada",
        data: { sigla: vSigla, preco: vPreco },
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
    var vDuracao = document.getElementById('duracao').value;
    $.ajax({
        url: "/rendaFixa/ObtemDadosConsultaAvancada",
        data: { descricao: vDescricao, duracao: vDuracao },
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

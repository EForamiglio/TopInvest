// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function cadastroRendaVariavel() {
    $.ajax({
        url: "/cadastro/ObtemCadastroRendaVariavel",
        success: function (dados) {
            document.getElementById('cadastroEscolhido').innerHTML = '';
            if (dados.erro != undefined) {
                alert(dados.msg);
            }
            else {
                document.getElementById('cadastroEscolhido').innerHTML = dados;
            }
        },
    });
}

function cadastroRendaFixa() {
    $.ajax({
        url: "/cadastro/ObtemCadastroRendaFixa",
        success: function (dados) {
            document.getElementById('cadastroEscolhido').innerHTML = '';
            if (dados.erro != undefined) {
                alert(dados.msg);
            }
            else {
                document.getElementById('cadastroEscolhido').innerHTML = dados;
            }
        },
    });
}

jQuery(function ($) {
    let formCadastro = $('#formCadastrarContaPagar');
    if (formCadastro.length) {
        formCadastro.validate({
            errorClass: "text-danger",
            rules: {
                Nome: {
                    required: true
                },
                Valor: {
                    required: true
                },
                DataDeVencimento: {
                    required: true
                },
                DataDePagamento: {
                    required: true
                },
            },
            messages: {
                Nome: {
                    required: 'Preencha o campo Nome para continuar'
                },
                Valor: {
                    required: 'Preencha o campo Valor para continuar'
                },
                DataDeVencimento: {
                    required: 'Preencha o campo Data de Vencimento para continuar'
                },
                DataDePagamento: {
                    required: 'Preencha o campo Data de Pagamento para continuar'
                }
            }
        });
    }
})
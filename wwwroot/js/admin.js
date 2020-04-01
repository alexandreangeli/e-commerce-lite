class Admin {

    updateDespesasTotais(input) {
        var string = 'despesasTotais';
        var data = {
            DespesasTotais: this.getValor(string, input)
        };
        debugger;
        this.postValor(string, data);
    }

    updateMargemLucro(input) {
        var string = 'margemLucro';
        var data = {
            MargemLucro: this.getValor(string, input)
        };
        this.postValor(string, data);
    }

    getValor(string, input) {
        var linhaDoItem = $(input).parents('[' + string + 'li]');
        var novoValor = $(linhaDoItem).find('input').val().replace(',', '.');
        if (novoValor < 0 || isNaN(novoValor) || novoValor == "") {
            novoValor = $(linhaDoItem).find('[' + string + ']').attr('placeholder');
        }
        return novoValor;
    }

    postValor(string, data) {

        let token = $('[name=__RequestVerificationToken]').val();
        let headers = {};
        headers['RequestVerificationToken'] = token;

        $.ajax({
            url: '/loja/update' + string,
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: headers
        }).done(function (response) {
            let linhaDoItem = $('[' + string + 'li]');
            let novoValor = eval('response.pedido.' + string);
            linhaDoItem.find('input').val(novoValor);
            linhaDoItem.find('input').attr("placeholder", novoValor);
        });
    }
}

var admin = new Admin();
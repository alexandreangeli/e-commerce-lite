class Carrinho {

    zerarCarrinho() {

        let token = $('[name=__RequestVerificationToken]').val();
        let headers = {};
        headers['RequestVerificationToken'] = token;
        debugger;
        $.ajax({
            url: '/loja/zerarcarrinho',
            type: 'POST',
            contentType: 'application/json',
            headers: headers
        }).done(function (response) {
            location.replace('/Loja/Carrinho');
        });
    }

    clickIncremento(button) {
        let data = this.getData(button);
        if (data == true) {
            return;
        }
        data.Quantidade++;
        this.postQuantidade(data);
    }

    clickDecremento(button) {
        let data = this.getData(button);
        if (data == true) {
            return;
        }
        data.Quantidade--;
        this.postQuantidade(data);
    }

    updateQuantidade(input) {
        let data = this.getData(input);
        if (data == true) {
            return;
        }
        this.postQuantidade(data);
    }

    getData(elemento) {
        var linhaDoItem = $(elemento).parents('[item-id]');
        var itemId = $(linhaDoItem).attr('item-id');
        var novaQuantidade = $(linhaDoItem).find('input').val();
        if (novaQuantidade < 0) {
            novaQuantidade = 0;
        }
        if (isNaN(novaQuantidade) || novaQuantidade == "") {
            novaQuantidade = $(linhaDoItem).find('[quantidade]').attr('placeholder');
        }

        return {
            Id: itemId,
            Quantidade: novaQuantidade
        };
    }

    postQuantidade(data) {

        let token = $('[name=__RequestVerificationToken]').val();
        let headers = {};
        headers['RequestVerificationToken'] = token;

        $.ajax({
            url: '/loja/updatequantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: headers
        }).done(function (response) {
            let itemPedido = response.itemPedido;
            let carrinhoViewModel = response.carrinhoViewModel;
            let linhaDoItem = $('[item-id=' + itemPedido.id + ']');
            let linhaBody = $('body');
            linhaDoItem.find('input').val(itemPedido.quantidade);
            linhaDoItem.find('[precoVenda]').html('R$' + (itemPedido.subtotalVenda).duasCasas());
            linhaDoItem.find('[quantidade]').attr("placeholder", itemPedido.quantidade);
            linhaBody.find('[totalVenda]').html('Valor total: R$' + (carrinhoViewModel.totalVenda).duasCasas());
            if (itemPedido.quantidade == 0) {
                linhaDoItem.remove();
                linhaBody.find('[carrinhoTexto]').html('<h1>Seu carrinho está vazio.</h1>');
            }
        });
    }
}

var carrinho = new Carrinho();

Number.prototype.duasCasas = function () {
    return this.toFixed(2).replace('.', ',');
}

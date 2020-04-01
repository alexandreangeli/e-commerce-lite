
class Carrinho {

    updateDespesasTotais(input) {
        var linhaDoItem = $(input).parents('[despesasTotais]');
        var novaDespesasTotais = $(linhaDoItem).find('input').val().replace(',', '.');
        if (novaDespesasTotais < 0 || isNaN(novaDespesasTotais)) {
            novaDespesasTotais = 400;
        }
        debugger;
        if (novaDespesasTotais == "") {
            return;
        }
        var data = {
            DespesasTotais: novaDespesasTotais
        };

        $.ajax({
            url: '/loja/updatedespesastotais',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
        });
    }

    updateMargemLucro(input) {
        var linhaDoItem = $(input).parents('[margemLucro]');
        var novaMargemLucro = $(linhaDoItem).find('input').val().replace(',', '.');
        if (novaMargemLucro < 0 || isNaN(novaMargemLucro)) {
            novaMargemLucro = 0;
        }
        if (novaMargemLucro == "") {
            return;
        }
        var data = {
            MargemLucro: novaMargemLucro
        };

        $.ajax({
            url: '/loja/updatemargemlucro',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
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
        if (isNaN(novaQuantidade)) {
            return true;
        }

        return {
            Id: itemId,
            Quantidade: novaQuantidade
        };
    }

    postQuantidade(data) {
        $.ajax({
            url: '/loja/updatequantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
        }).done(function (response) {
            let itemPedido = response.itemPedido;
            let carrinhoViewModel = response.carrinhoViewModel;
            let linhaDoItem = $('[item-id=' + itemPedido.id + ']')
            let linhaDaLista = $('[lista]')
            linhaDoItem.find('input').val(itemPedido.quantidade);
            linhaDoItem.find('[precoVenda]').html('R$'+(itemPedido.subtotalVenda).duasCasas());
            linhaDaLista.find('[totalVenda]').html('Total da venda: R$' + (carrinhoViewModel.totalVenda).duasCasas());
            if (itemPedido.quantidade == 0) {
                linhaDoItem.remove();
            }
        });
    }
}

var carrinho = new Carrinho();

Number.prototype.duasCasas = function () {
    return this.toFixed(2).replace('.', ',');
}

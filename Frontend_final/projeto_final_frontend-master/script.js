var textoContas;
var textoClientes;

axios.get('http://localhost:8080/contas')
    .then(response => {
        textoContas = JSON.stringify(response.data)
        textoContas = JSON.parse(textoContas)
    })


axios.get('http://localhost:8080/clientes')
    .then(response => {
        textoClientes = JSON.stringify(response.data)
        textoClientes = JSON.parse(textoClientes)
    })

document.getElementsByClassName("button")[0].addEventListener("click", function () {

    document.getElementsByClassName("dados")[0].innerHTML = "";

    for (var i = 0; i < textoContas.length; i++) {
        document.getElementsByClassName("dados")[0].innerHTML +=

            `<div class="contas">` +

            `<span>Número da conta: </span>${textoContas[i]['numConta']}` +
            `<br>` +
            `<span>Agência: </span>${textoContas[i]['agencia']}` +
            `<br>` +
            `<span>Tipo de conta: </span>${textoContas[i]['tipoConta']}` +
            `<br>` +
            `<span>Saldo: </span>${textoContas[i]['saldo']}` +

            `<br>` +
            `<br>` +

            `<div class="titular">` +
            `<span>Titular</span>` +
            `<br>` +
            `<br>` +
            `<span>Código: </span>${textoContas[i]['titular']['codInt']}` +
            `<br>` +
            `<span>Nome: </span>${textoContas[i]['titular']['nome']}` +
            `<br>` +
            `<span>CPF: </span>${textoContas[i]['titular']['cpf']}` +
            `<br>` +
            `<span>Telefone: </span>${textoContas[i]['titular']['telefone']}` +
            `<br>` +
            `<span>E-mail: </span>${textoContas[i]['titular']['email']}` +
            `</div>` +

            `</div>`;
    }
})

document.getElementsByClassName("button1")[0].addEventListener("click", function () {

    document.getElementsByClassName("dados")[1].innerHTML = "";

    for (var j = 0; j < textoClientes.length; j++) {
        document.getElementsByClassName("dados")[1].innerHTML +=

            `<div class="clientes">` +

            `<span>Código: </span>${textoClientes[j]['codInt']}` +
            `<br>` +
            `<span>Nome: </span>${textoClientes[j]['nome']}` +
            `<br>` +
            `<span>CPF: </span>${textoClientes[j]['cpf']}` +
            `<br>` +
            `<span>Telefone: </span>${textoClientes[j]['telefone']}` +
            `<br>` +
            `<span>E-mail: </span>${textoClientes[j]['email']}` +

            `<br>` +
            `<br>` +

            `<div class="accounts">` +
            `<span>Contas</span>` +
            `<br>` +
            `<br>` +
            `<span>Número: </span>${textoClientes[j]['contas'][0]['numConta']}` +
            `<br>` +
            `<span>Agência: </span>${textoClientes[j]['contas'][0]['agencia']}` +
            `<br>` +
            `<span>Tipo de conta: </span>${textoClientes[j]['contas'][0]['tipoConta']}` +
            `<br>` +
            `<span>Saldo: </span>${textoClientes[j]['contas'][0]['saldo']}` +
            `<br>` +
            `</div>` +

            `</div>`;
    }

    for (var j = 0; j < textoClientes.length; j++) {
        console.log(textoClientes[j].contas.length)
    }
})
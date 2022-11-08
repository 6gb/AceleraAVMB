function mudaCorDeFundo(element, cor) {
    element.style.backgroundColor = cor
}

function mudaCorDaFonte(element, cor) {
    element.style.color = cor
}

function escondeOuMostra(element, button) {
    if (element.hidden) {
        element.hidden = false
        button.innerText = "Esconder"
    } else {
        element.hidden = true;
        button.innerText = "Mostrar"
    }
}

function habilitaOuDesabilita() {
    let atividade5 = document.querySelector("#Atividade5")
    let checkboxes = atividade5.querySelectorAll("input:checked")
    let botaoClicavel = atividade5.querySelector("button")

    if (checkboxes.length >= 2) {
        botaoClicavel.disabled = false;
        botaoClicavel.title = "Sim";
    } else {
        botaoClicavel.disabled = true;
        botaoClicavel.title = "Não";
    }
}

function mudaTamanhoDaFonte(element, i) {
    element.style.fontSize = element.style.fontSize === ''
        ? `${100 + i}%` : `${parseInt(element.style.fontSize.replace('%', '')) + i}%`
}

function emMaiusculo(element) {
    element.innerText = element.innerText.toUpperCase()
}

function emMinusculo(element) {
    element.innerText = element.innerText.toLowerCase()
}

function todosCamposPreenchidos(campos) {
    preenchidos = 0
    campos.forEach(campo => preenchidos += (campo.value) ? 1 : 0)
    return preenchidos === campos.length
}

function senhasSaoIguais(senhas) {
    return senhas[0].value === senhas[1].value
}

function senhaValida(senha) {
    return senha.value.length >= 6 && senha.value.length <= 10
}

function validarFormulario(element) {
    campos = element.querySelectorAll("input")
    senhas = element.querySelectorAll("input[type='password']")
    element.querySelector("button").disabled = !(todosCamposPreenchidos(campos) && senhasSaoIguais(senhas) && senhaValida(senhas[1]))
}

function pessoaFisicaOuJuridica(form) {
    /*pessoa.querySelectorAll("input[type='radio']")*/
    if (form.querySelector("#fisica:checked")) {
        form.querySelector("#cpf").disabled = false
        form.querySelector("#cpf").hidden = false
        form.querySelector("#cnpj").disabled = true
        form.querySelector("#cnpj").hidden = true
        form.querySelector("#dataDeNascimento").disabled = false
        form.querySelector("#dataDeNascimento").hidden = false

    } else if (form.querySelector("#juridica:checked")) {
        form.querySelector("#cpf").disabled = true
        form.querySelector("#cpf").hidden = true
        form.querySelector("#cnpj").disabled = false
        form.querySelector("#cnpj").hidden = false
        form.querySelector("#dataDeNascimento").disabled = true
        form.querySelector("#dataDeNascimento").hidden = true
    }
}

function apenasNumeros(campo) {
    campo.value.includes()
}
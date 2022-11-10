const mudaCorDeFundo = (element, cor) => element.style.backgroundColor = cor
const mudaCorDaFonte = (element, cor) => element.style.color = cor
const escondeOuMostra = (element, button) => [element.hidden, button.innerText] = element.hidden ? [false, "Esconder"] : [true, "Mostrar"]

function habilitaOuDesabilitaBotao(form) {
    let botaoClicavel = form.querySelector("button"), checkboxes = form.querySelectorAll("input:checked");
    [botaoClicavel.disabled, botaoClicavel.title] = checkboxes.length >= 2 ? [false, "Sim"] : [true, "Não"]
}

function mudaTamanhoDaFonte(element, i) {
    element.style.fontSize = element.style.fontSize === ''
        ? `${100 + i}%` : `${parseInt(element.style.fontSize.replace('%', '')) + i}%`
}

const emMaiusculo = (element) => element.innerText = element.innerText.toUpperCase()
const emMinusculo = (element) => element.innerText = element.innerText.toLowerCase()

function todosCamposPreenchidos(campos) {
    let preenchidos = 0
    campos.forEach(campo => preenchidos += (campo.value) ? 1 : 0)
    return preenchidos === campos.length
}

const senhasSaoIguais = (senhas) => senhas[0].value === senhas[1].value
const senhaValida = (senha) => senha.value.length >= 6 && senha.value.length <= 10

function validarFormulario(element) {
    const $ = element.querySelector.bind(element), $$ = element.querySelectorAll.bind(element)
    let campos = $$("input"), senhas = $$("input[type='password']")
    $("button").disabled = !(todosCamposPreenchidos(campos) && senhasSaoIguais(senhas) && senhaValida(senhas[1]))
}

function pessoaFisicaOuJuridica(form) {
    const $ = form.querySelector.bind(form)
    let cpf = $("#cpf"), cnpj = $("#cnpj"), dataDeNascimento = $("#dataDeNascimento");
    [cpf.disabled, cpf.labels[0].hidden, cnpj.disabled, cnpj.labels[0].hidden, dataDeNascimento.disabled, dataDeNascimento.hidden]
        = $("#fisica:checked") ? [false, false, true, true, false, false] : [true, true, false, false, true, true]
}

function apenasNumeros(event) {
    let key = event.keyCode
    /* 0 a 9 = 48 a 57 e 95 a 106, Setas = 37 a 40, Backspace = 8, Tab = 9, Delete = 46 */
    if ((key < 96 || key > 105) && (key < 48 || key > 57) && (key < 37 || key > 40) && key != 8 && key != 9 && key != 46 )
        event.preventDefault();
}

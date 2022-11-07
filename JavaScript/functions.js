function cliqueBotao5Alertas() {
    contagemAlertas++
    alert(contagemAlertas)

    if (contagemAlertas >= 5)
        document.getElementById("botao5Alertas").disabled = true
}

function mudaCorDeFundoPara(cor) {
    document.body.style.backgroundColor = cor;
}

function escondeOuMostra(classe, tipo) {
    let element = document.querySelector(`${tipo}.${classe}`)
    let button = document.querySelector(`button.${classe}`)

    if (element.hidden) {
        element.hidden = false
        button.innerText = "Esconder"
    } else {
        element.hidden = true;
        button.innerText = "Mostrar"
    }
}

function habilitaOuDesabilita() {
    let checkboxes = document.querySelectorAll("input.Atividade5:checked")
    let botaoClicavel = document.querySelector("button.Atividade5")

    if (checkboxes.length >= 2) {
        botaoClicavel.disabled = false;
        botaoClicavel.title = "Sim";
    } else {
        botaoClicavel.disabled = true;
        botaoClicavel.title = "Não";
    }
}

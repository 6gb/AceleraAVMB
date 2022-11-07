function mudaCorDeFundoPara(element, cor) {
    element.style.backgroundColor = cor
}


function mudaCorDaFontePara(element, cor) {
    element.style.color = cor
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

function mudaTamanhoDeFonte(element, i) {
    
}
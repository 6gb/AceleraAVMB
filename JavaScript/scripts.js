var atividade1 = document.getElementById("Atividade1Aula");
var atividade2 = document.getElementById("Atividade2Aula");

for (let i = 1; i < 10; i++)
    if (i % 2 !== 0) {
        var resposta1 = document.createElement("p");
        resposta1.innerText = i;
        atividade1.appendChild(resposta1);
    }

var soma = 0;

for (let i = 1; i <= 100; i++)
    soma += i

var respostaSoma = document.createElement("p");
respostaSoma.innerText = soma;
atividade2.appendChild(respostaSoma);

var contagemAlertas = 0;

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
    document.querySelector("button.Atividade5").disabled = document.querySelectorAll("input.Atividade5:checked").length < 2
}

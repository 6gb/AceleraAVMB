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

fetch('section.html')
    .then((resposta) => resposta.text())
    .then((data) => document.querySelector("section").innerHTML = data)

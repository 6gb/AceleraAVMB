fetch('index-section.html')
    .then((resposta) => resposta.text())
    .then((data) => document.querySelector("section").innerHTML = data)

fetch('index-img.html')
    .then((resposta) => resposta.text())
    .then((data) => {
        let newDiv = document.createElement("div");
        newDiv.innerHTML = data;
        document.querySelector("header").after(newDiv);
    })

//Task #1 - Pares e ímpares:
//Deve ser criada uma função javascript que receba um argumento N, que sempre será um array de números.
//A função deve retornar a quantidade de números ímpares dentro do array.
//
//Exemplo:
//Argumentos recebidos:
//N: [1,2,1,3]
//
//Retorno:
//3

function quantidadeDeImparesEm(N) {
    let impares = 0;
    N.forEach(n => impares += (n % 2 !== 0) ? 1 : 0);
    return impares;
}

//Teste #1

let N = []

for (let i = 0; i < Math.floor(Math.random()*100); i++)
    N[i] = Math.floor(Math.random()*100);

console.log(N);
console.log(quantidadeDeImparesEm(N));
console.log(quantidadeDeImparesEm([1,2,1,3]));

//Task #2 - Palíndromo:
//Deve ser criada uma função javascript que receba um argumento A, que sempre será uma String.
//A função deve verificar se o argumento A é um palíndromo, retornando TRUE, caso seja.
//Se não for, deve retornar FALSE.
//"Palíndromo é uma palavra, frase ou número que permanece igual quando lida de trás para frente.”
//
//Exemplo:
//Argumentos recebidos:
//A: “arara”
//
//Retorno:
//TRUE

//Task #2 V1

const checaPalindromoV1 = A => A === A.split('').reverse().join('');

//Teste #2 V1

let AS = ['arara', 'osso', 'tenet', 'palindromo', 'Socorram-me, subi no ônibus em Marrocos']
AS.forEach(A => console.log(`${A}: ${checaPalindromoV1(A)}`))
// true, true, true, false, false

//Task #2 V2 psicopata edition

function soMinusculasENumeros(A) {
    let a = A.toLowerCase().normalize('NFD'), char, char0, char9, chara, charz;

    [char0, char9, chara, charz] = ['0', '9', 'a', 'z'].map(c => c.charCodeAt(0));

    for (let i = 0; i < a.length; i++) {
        char = a.charCodeAt(i);

        if ((char < char0 || char > char9) && (char < chara || char > charz))
            a = a.replace(a.charAt(i), ' ');
    }

    //a = a.replaceAll(' ', '');
    a = a.split(' ').join(''); // sem replaceAll heh

    return a;
}

function checaPalindromoV2(A) {
    let a = soMinusculasENumeros(A);
    return a === a.split('').reverse().join('');
}

// Teste #2 V2
AS.forEach(A => console.log(`${A}: ${checaPalindromoV2(A)}`))
// true, true, true, false, true

//Task #3 - Chaves e Valores:
//Deve ser criada uma função javascript que receba dois argumentos, C (String) e V.
//A função deve retornar um objeto em formato JSON com esses argumentos, a variável C será a chave e a variável V será o valor desta chave.
//
//Exemplo:
//Argumentos recebidos:
//C: “age”
//V: 28
//
//Retorno:
//{ “age”: 28 }

const emJson = (C, V) => JSON.parse(`{ "${C}": ${JSON.stringify(V)} }`);

//Testes #3

emJson("age", 28);
emJson("name", "name");
emJson("mail", null);

let objeto = {"numero": 28, "palavra": "palavra", "nulo": null}
emJson("objeto", objeto);

let array = [0, "palavra", objeto];
emJson("array", array);

let objeto2 = {"numero2": 2, "palavra2": "palavra2", "nulo2": null, "array": array}
emJson("objeto2", objeto2);

// Exemplo 1
function exibirAlerta() {
    alert('O botão foi pressionado!');
} 

document.querySelector('#btn-exibir-alerta').onclick = exibirAlerta;


// Exemplo 2
function trocarTexto() {
    document.getElementById('p-texto').innerHTML = "O texto do parágrafo <b>foi substituído</b>.";
}
document.getElementById('btn-substituir-texto').onclick = trocarTexto;


// Exemplo 3
document.getElementById('btn-ocultar').onclick = function () {
    document.getElementById('exemplo-3').style.display = 'none';
}


// Exemplo 4
document.getElementById('btn-on').onclick = function () {
    document.querySelector('.lampada').src = 'images/lamp-on.png';
}
document.getElementById('btn-off').onclick = function () {
    document.querySelector('.lampada').src = 'images/lamp-off.png';
}


// Exemplo 5
console.log("Área do círculo: " + Math.PI * Math.pow(3,2));


// Exemplo 6
const data = new Date();
const dia = ['Domingo', 'Segunda-feira', 'Terça-feira', 'Quarta-feira', 'Quinta-feira', 'Sexta-feira', 'Sábado'];

document.querySelector('.dia-semana').innerHTML = dia[data.getDay()];
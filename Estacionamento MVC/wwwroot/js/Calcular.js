$('#Salvar').click(function () {
    let ent = parseFloat(document.getElementById('Entrada').value)
    let sai = parseFloat(document.getElementById('Saida').value)
    let soma = ent + sai;
    let total = soma * 5 - 100
    alert("Caso o cliente fique ao todo 01:40:00 no estacionamento, cobrar valor de mais uma hora.");
    alert("O valor total do tempo em que o cliente utilizou o estacionamento ficou R$" + total + ",00");
});
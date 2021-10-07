$('#Calc').click(function () {
    let ent = parseFloat(document.getElementById('Entrada').value);
    let sai = parseFloat(document.getElementById('Saida').value);
    let soma = ent + sai;
    let total = soma * 5 - 100;
    alert("O valor consumido foi de R$" + total + ",00");
    
})
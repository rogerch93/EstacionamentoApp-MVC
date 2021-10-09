function VerificaCPF() {
    let campoCPF = document.getElementById('CPFedit').value
    let soma;
    let resto;
    soma = 0;
    if (campoCPF == "00000000000") {
        return false;
    }

    for (i = 1; i <= 9; i++) {
        soma = soma + parseInt(campoCPF.substring(i - 1, i)) * (11 - i);
    }

    resto = soma % 11;

    if (resto == 10 || resto == 11 || resto < 2) {
        resto = 0;
    } else {
        resto = 11 - resto;
    }

    if (resto != parseInt(campoCPF.substring(9, 10))) {
        return false;
    }

    soma = 0;

    for (i = 1; i <= 10; i++) {
        soma = soma + parseInt(campoCPF.substring(i - 1, i)) * (12 - i);
    }
    resto = soma % 11;

    if (resto == 10 || resto == 11 || resto < 2) {
        resto = 0;
    } else {
        resto = 11 - resto;
    }

    if (resto != parseInt(campoCPF.substring(10, 11))) {
        return false;
    }

    return true;
}

$('#Salvar').click(function () {
    let campoCPF = document.getElementById('CPFedit').value

    if (campoCPF !== VerificaCPF) {
        alert("CPF INVALIDO");
    }
})
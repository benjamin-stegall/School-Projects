function addition_Function() {
    var addition = 25 + 5;
    document.getElementById("math_add").innerHTML = addition;
}

function subtraction_Function() {
    var subtraction = 25 - 5;
    document.getElementById("math_sub").innerHTML = subtraction;
}

function multiplication_Function() {
    var multiplication = 25 * 5;
    document.getElementById("math_mul").innerHTML = multiplication;
}

function division_Function() {
    var division = 25 / 5;
    document.getElementById("math_div").innerHTML = division;
}

function all_Function() {
    var all = (5 + 5) * 10 / (20 - 10);
    document.getElementById("math_all").innerHTML = all;
}

function modulus_Operator() {
    var mod = 25 % 6;
    document.getElementById("math_mod").innerHTML = mod;
}

function negation_Operator() {
    var x = 5;
    document.getElementById("math_negate").innerHTML = -x;
}

var X = 5;
X++;
document.write("5 + 1 = " + X);

var X = 5;
X--;
document.write(" 5 - 1 = " + X);

window.alert(Math.random() * 10);

function pi_Function() {
    document.getElementById("math_pi").innerHTML = (Math.PI);
}
function addition_Function() {      //Add function
    var addition = 25 + 5;
    document.getElementById("math_add").innerHTML = addition;
}

function subtraction_Function() {       //Subtract function
    var subtraction = 25 - 5;
    document.getElementById("math_sub").innerHTML = subtraction;
}

function multiplication_Function() {        //Multiply function
    var multiplication = 25 * 5;
    document.getElementById("math_mul").innerHTML = multiplication;
}

function division_Function() {      //Divide function
    var division = 25 / 5;
    document.getElementById("math_div").innerHTML = division;
}

function all_Function() {       //Combined function (utilizes add, subtract, divide, multiply)
    var all = (5 + 5) * 10 / (20 - 10);
    document.getElementById("math_all").innerHTML = all;
}

function modulus_Operator() {       //Modulus function (returns division remainder)
    var mod = 25 % 6;
    document.getElementById("math_mod").innerHTML = mod;
}

function negation_Operator() {      //Negate function (makes value negative)
    var x = 5;
    document.getElementById("math_negate").innerHTML = -x;
}

var X = 5;      //Increment value
X++;
document.write("5 + 1 = " + X);

var X = 5;      //Decrement value
X--;
document.write(" 5 - 1 = " + X);

window.alert(Math.random() * 10);       //Random number (0 through 10) alert

function pi_Function() {        //Pi function (pretty much just displays the pi value)
    document.getElementById("math_pi").innerHTML = (Math.PI);
}
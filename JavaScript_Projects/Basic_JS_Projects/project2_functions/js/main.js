var A = ("A man has fallen in Lego City!"), B = ("This is a button")

function my_function() {        //Displays message and makes color blue upon click
    var result = B.fontcolor("blue");
    document.getElementById("button").innerHTML = result;
}

function my_function_2() {      //Displays message upon click
    var legoman = "Oh No! ";
    legoman += A;
    document.getElementById("paragraph").innerHTML = legoman;
}
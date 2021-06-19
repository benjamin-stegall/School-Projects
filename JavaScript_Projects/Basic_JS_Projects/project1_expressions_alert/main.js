var A = "Jeremy said \"You Suck!\" " + "What will you do?", B="48 + 32 ="
var B = B.fontcolor("red");         //Describing variables

window.alert(A);        //Displays var A in a popup

document.write(B);      //Displays var B on the page

document.write(48+32);  //Displays expression on the page

function sample_function() {        //Displays the str variable in blue when button is pressed
    var str = "This text is blue";
    var result = str.fontcolor("blue");
    document.getElementById("text").innerHTML = result;
}
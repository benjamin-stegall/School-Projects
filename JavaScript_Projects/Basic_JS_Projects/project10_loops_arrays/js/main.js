function Counter() {        //Counts to 50 immediately as there is no delay
    var Digit = "";
    var x = 0;
    while (x < 51) {
        Digit += "<br>" + x;
        x++;
        if (x == 21) { break; }     //Would count to 50 if there was no break here
    }
    document.getElementById("ten_counter").innerHTML = Digit;
}

function counter_Continue() {        
    var Digit = "";
    var x = 0;
    while (x < 21) {
        Digit += "<br>" + x;
        x++;
        if (Digit = 10) { continue; }   //Only displays 10 on the page
    }
    document.getElementById("cont_counter").innerHTML = Digit;
}


function string_Length() {      //Finds the length of the string
    var x = "SampleText";
    var y = x.length;
    document.getElementById("string_length").innerHTML = y;
}

var Foodstuffs = ["Apple", "Fish", "Pizza", "Chicken", "Steak"];
var Content = "";
var y;
function for_Loop() {               //Displays a list
    for (y = 0; y < Foodstuffs.length; y++) {
        Content += Foodstuffs[y] + "<br>";
    }
    document.getElementById("food_list").innerHTML = Content;
}

function array_Properties() {       //Displays the specified property
    var property = [];
    property[0] = "property one";
    property[1] = "property two";
    property[2] = "property three";
    property[3] = "property four";
    document.getElementById("arrays").innerHTML = "This is " + property[0] + ".";
}

function constant_Function() {          //Displays the specified properties with the specified text
    const Car = {type:"Terrain", brand: "GMC", color: "black"};
    Car.color = "black";
    Car.price = "$20,000";
    document.getElementById("constant").innerHTML = "The cost of the " + Car.brand + " was " + Car.price;
}

function value_Change() {       //Changes the value to be 25 instead of 20
    var a = 20;
    a = 25;
    document.getElementById("changed_value").innerHTML = a;
}

var b = 25;     
document.write(b);
{
    let b = 50;     //This lets the var "b" be a different value for this one section
    document.write("<br>" + b);
}
document.write("<br>" + b)      //It returns its original value here
    
function return_Function() {    //Displays "Hello." in the console
    return "Hello.";
}
console.log(return_Function())

let car = {     //Displays the properties along with the specified text
    make : "GMC ",
    model : "Terrain ",
    year : "2019 ",
    color : "black ",
    description : function() {
        return "The car is a " + this.year + this.color + this.make + this.model;
    }
};
document.getElementById("car_object").innerHTML = car.description();



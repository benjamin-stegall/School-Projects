document.write(typeof "Word");  //"Type of" operator (Finds data type of value)

document.write("1" + 5);    //Coercion operator (Forces different data types together, computer determines how)

function nan_Function() {                           //This code could end the world because it divides by zero
    document.getElementById("NaN").innerHTML = 0/0; //Thankfully, the computer avoids this and returns NaN (Not a Number) 
}

function nan_text_Function() {                                      //This checks to see if the entered data is not a number
    document.getElementById("text_NaN").innerHTML = isNaN("Text");  //In this case it returns true
}

function nan_num_Function() {                                         //This checks to see if the entered data is not a number
    document.getElementById("number_NaN").innerHTML = isNaN("2");     //In this case it returns false
}

document.write(2E310);  //Displays infinity

document.write(-3E310);  //Displays negative infinity

document.write(20 > 15);    //Checks if statement is true. It returns true in this case

document.write(20 < 15);    //Checks if statement is true. It returns false in this case

console.log(5 * 5);     //Displays answer in console

console.log(25 > 30);   //Checks if statement is true and displays result in console

document.write(20 == 30);   //Checks if statement is true. It returns false in this case

document.write(20 == 20);   //Checks if statement is true. It returns true in this case

x = 20;
y = 25;
document.write(x === y);    //Checks if values are equal. They are not in this case

a = 20;
b = 20;
document.write(a === b);    //Checks if values are equal. They are in this case

c = "20";
d = 20;
document.write(c === d);    //Checks if values are equal. They are not in this case as they are different data types

e = "string";
f = 20;
document.write(c === d);    //Checks if values are equal. They are not in this case as they are different data types

document.write(10 > 5 && 20 > 2);  //Checks if the boolean condition is met (AND)  

document.write(10 > 15 && 20 > 2);  //Checks if the boolean condition is met (AND) It is false in this case  

document.write(20 > 15 || 10 < 5); //Checks if the boolean condition is met (OR)

document.write(10 < 5 || 5 > 20); //Checks if the boolean condition is met (OR) It is false in this case

function not_Function() {
    document.getElementById("not_op_yes").innerHTML = !(20 > 25);   //Checks if the boolean condition is met (NOT)
}

function not_Function_False() {
    document.getElementById("not_op_no").innerHTML = !(20 > 10);    //Checks if the boolean condition is met (NOT) In this case it returns false
}
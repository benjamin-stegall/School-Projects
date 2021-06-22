if (20 > 10) {                          //Moved this to the top as it won't display otherwise for some reason
    window.alert("Hello") 
}

var x = 25;                             //Global variable
function numbers_Add_1() {              
    document.write(25 + x + "<br>");
}
function numbers_Add_2() {
    document.write(x + 50);
}
numbers_Add_1();
numbers_Add_2();

function numbers_Add_3() {          //Function utilizing a local variable
    var y = 50;
    console.log(y + 10);
}
function numbers_Add_Error() {      //Outside function attempting to use a local variable, causing an error
    console.log(y + 50);
}
numbers_Add_3();
numbers_Add_Error();

function get_Time() {                        //Displays one of the messages depending on time
    var Time = new Date().getHours();
    var Reply;
    if (Time < 12 == Time > 0) {
        Reply = "It is morning";
    }
    else if (Time >= 12 == Time < 18) {
        Reply = "It is the afternoon";
    }
    else {
        Reply = "It is evening";
    }
    document.getElementById("time").innerHTML = Reply;
}                         


function gpa_Function() {                       //Takes entered GPA and displays a message
    gpa = document.getElementById("gpa").value;
    if (gpa >= 5) {
        gpa_Result = "Invalid GPA";
    }
    else if (gpa < 0) {
        gpa_Result = "Invalid GPA";
    }
    else if (gpa >= 3) {                                        //This condition is low to ensure the "Invalid" conditions display properly
        gpa_Result = "You are qualified for this school";       // If someone entered "5" it would be considered valid as it meets this condition
    }
    else {
        gpa_Result = "You are not qualified for this school"
    }
    document.getElementById("gpa_text").innerHTML = gpa_Result;
}
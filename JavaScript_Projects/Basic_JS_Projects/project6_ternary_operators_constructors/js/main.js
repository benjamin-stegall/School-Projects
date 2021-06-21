document.write(Bigger = (10 < 20) ? "Left wins":"Right wins");  //Checks which value is bigger

document.write(Bigger = (20 > 25) ? "Left wins":"Right wins"); //Checks which value is bigger

function Drive_Function() {               //Checks if entered value meets requirements
    var age, can_drive;
    age = document.getElementById("Age_Drive").value;
    can_drive = (age < 16) ? "You are not old enough":"You are old enough";
    document.getElementById("Drive").innerHTML = can_drive + " to drive.";
}

function Vote_Function() {               //Checks if entered value meets requirements
    var age, can_vote;
    age = document.getElementById("Age_Vote").value;
    can_vote = (age < 18) ? "You are not old enough":"You are old enough";
    document.getElementById("Vote").innerHTML = can_vote + " to vote.";
}

function Vehicle(Make, Model, Year, Color)  {       //These functions take data from a list and display it as specified
    this.Vehicle_Make = Make;
    this.Vehicle_Model = Model;
    this.Vehicle_Year= Year;
    this.Vehicle_Color = Color;
}
var Jack = new Vehicle("Dodge", "Viper", 2020, "Red");                  
var Emily = new Vehicle("Jeep", "Trail Hawk", 2019, "Black and White"); 
var Erik = new Vehicle("Ford", "Pinto", 1971, "Mustard");
function car_Function() {
    document.getElementById("car_owners").innerHTML = 
    "Erik drives a " + Erik.Vehicle_Color + "-colored " + Erik.Vehicle_Model +
    " manufactured in " + Erik.Vehicle_Year;
}

function Employee(Position, Age, Rate) {             //These functions take data from a list and display it as specified
    this.Employee_Position = Position;
    this.Employee_Age = Age;
    this.Employee_Rate = Rate;
}
var Jake = new Employee("Janitor", "32", "$15");
var Susan = new Employee("Cashier", "17", "$9");
function employee_Function() {
    document.getElementById("employees").innerHTML = 
    "Susan is a " + Susan.Employee_Age + " year old " + Susan.Employee_Position + " making " + Susan.Employee_Rate 
    + " per hour.";
}

function count_Function() {                                     //Single Count Function
    document.getElementById("counter").innerHTML = Count();
    function Count() {
        var Starting_point = 4;
        function Plus_one() {Starting_point += 1;}
        Plus_one ();
        return Starting_point;
    }
}
function my_Dictionary() {      //Dictionary function
    var Employee = {
        Name: "Jose Vasquez",  //Dictionary content
        Position:"Janitor",
        Race: "Hispanic",
        Sex: "Male",
        DoB: "04/12/1982",
    };
delete Employee.Name        //This causes an error as the data is deleted before actually being displayed
document.getElementById("dictionary").innerHTML = Employee.Name
}
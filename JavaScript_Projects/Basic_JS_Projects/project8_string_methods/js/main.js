function full_Sentence() {          //This combines the variables together to form a sentence
    var part_1 = "This is ";
    var part_2 = "a fully complete, ";
    var part_3 = "totally normal, ";
    var part_4 = "sentence.";
    var sentence = part_1.concat(part_2, part_3, part_4);
    document.getElementById("concatenate").innerHTML = sentence;
}

function slice_Method() {           //This splits and displays the variable between the specified characters and capitalizes it
    var sentence = "According to all known laws of aviation, there is no way a bee should be able to fly.";
    var sentence_caps = sentence.toUpperCase();
    var section = sentence_caps.slice(56,92);
    document.getElementById("slice").innerHTML = section
}

function search_Method() {           //This searches for the location of "bee"
    var sentence = "According to all known laws of aviation, there is no way a bee should be able to fly.";
    var sentence_search = sentence.search("bee");
    document.getElementById("search").innerHTML = sentence_search
}

function string_Method() {          //Converts variable into a string
    var x = 200;
    document.getElementById("number_str_convert").innerHTML = x.toString();
}

function precision_Method() {   //Rounds the number as specified
    var x = 15239.3012987376112;
    document.getElementById("precision").innerHTML = x.toPrecision(10);
}

function tofixed_Method() {     //Fixes number as specified
    var x = 15239.3012987376112;
    var x_fixed = x.toFixed(2);
    document.getElementById("tofixed").innerHTML = x_fixed;
} 

function valueof_Method() {     //Finds value of the variable
    var a = "string";
    var a_value = a.valueOf();
     document.getElementById("valueof").innerHTML = a_value;
} 




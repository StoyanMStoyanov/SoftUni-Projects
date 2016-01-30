/**
 * Created by stoyan.stoyanov on 1/26/2016.
 */
function calculateArea(){
    var div = document.getElementById("textDiv").innerHTML = "text";
    div.textContent = "My text";
    var text = div.textContent;
    //var area1 = document.getElementById("area1");
    //var area2 = document.getElementById("area2").innerText = calcCircleArea(1.5);
    //var area3 = document.getElementById("area3");
    //area1.textContent = "text";
     //area2.textContent = ;

    //area3.textContent = calcCircleArea(20);
    //var text = area1.textContent;
}

function calcCircleArea(r){

    return Math.PI * Math.PI * r;
}

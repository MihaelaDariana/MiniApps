document.getElementById("buton1").addEventListener("click", ccolor);

function ccolor(){
    let cc=Math.floor(Math.random() * 10);
    switch(cc){
        case 0:
    document.getElementById("principal").style.backgroundColor = "BurlyWood";
    break;
    case 1:
        document.getElementById("principal").style.backgroundColor = "Aquamarine";
        break;
        case 2:
        document.getElementById("principal").style.backgroundColor = "BlanchedAlmond";
        break;
        case 3:
        document.getElementById("principal").style.backgroundColor = "DarkSalmon";
        break;
        case 4:
        document.getElementById("principal").style.backgroundColor = "IndianRed";
        break;
        case 5:
        document.getElementById("principal").style.backgroundColor = "lightblue";
        break;
        case 6:
        document.getElementById("principal").style.backgroundColor = "LavenderBlush";
        break;
        case 7:
        document.getElementById("principal").style.backgroundColor = "LightPink";
        break;
        case 8:
        document.getElementById("principal").style.backgroundColor = "MistyRose";
        break;
        default:
            document.getElementById("principal").style.backgroundColor = "Plum";


}
   

}
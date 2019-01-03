var bc = document.getElementById("bc");

bc.addEventListener("animationend", setMinSize);

function setMinSize() {
        bc.style.minWidth = "320px";
        bc.children[0].style.visibility = "visible";
    //if (bc.offsetTop === 71) {
    //    bc.style.minWidth = "320px";
    //    bc.children[0].style.visibility = "visible";
    //}
}

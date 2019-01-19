var uri = 'api/BinaryAPI';
var bc = document.getElementById("bc");

bc.addEventListener("animationend", setMinSize);

function toBinary() {

    var myText = $('#myText').val();
    $.getJSON(uri + '/1?value=' + myText)
        .done(function (data) {
            $('#myBinary').val(data);
        });
    clearTexts();
}

function toText() {

    var myText = $('#myBinary').val();
    $.getJSON(uri + '/2?value=' + myText)
        .done(function (data) {
            $('#myText').val(data);
        });
    clearBinary();
}

function clearTexts() {
    var myText = document.getElementById("myText");

    myText.value = "";
}

function clearBinary() {
    var myBinary = document.getElementById("myBinary");
    myBinary.value = "";
}



function setMinSize() {
        bc.style.minWidth = "320px";
        bc.children[0].style.visibility = "visible";
    //if (bc.offsetTop === 71) {
    //    bc.style.minWidth = "320px";
    //    bc.children[0].style.visibility = "visible";
    //}
}

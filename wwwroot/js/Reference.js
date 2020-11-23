var references = 1;

window.onload = function () {
    if (document.getElementById('reference2FN').value != "") {
        document.getElementById('reference2').style.display = "block";
        references = 2;
    }
    else {
        document.getElementById('reference2').style.display = "none";
    }

    if (document.getElementById('reference3FN').value != "") {
        document.getElementById('reference3').style.display = "block";
        references = 3;
    }
    else {
        document.getElementById('reference3').style.display = "none";
    }
}

function addReference() {
    if (references < 3) {
        document.getElementById(`reference${++references}`).style.display = "block";
    }
    else {
        alert("Cannot add another reference. Maximum reached!");
    }
}
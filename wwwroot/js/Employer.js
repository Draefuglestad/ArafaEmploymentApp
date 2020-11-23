var employers = 1;

window.onload = function () {
    if (document.getElementById('employer2FN').value != "") {
        document.getElementById('employer2').style.display = "block";
        references = 2;
    }
    else {
        document.getElementById('employer2').style.display = "none";
    }

    if (document.getElementById('employer3FN').value != "") {
        document.getElementById('employer3').style.display = "block";
        references = 3;
    }
    else {
        document.getElementById('employer3').style.display = "none";
    }
}

function addEmployer() {
    if (employers < 3) {
        document.getElementById(`employer${++employers}`).style.display = "block";
    }
    else {
        alert("Cannot add another employer. Maximum reached!");
    }
}
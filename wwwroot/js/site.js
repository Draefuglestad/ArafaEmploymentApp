// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function toggleSidebar() {
        $('#sidebar').toggleClass('active');
};

var employers = 1;
var mostRecentlyAddedEmployer = document.getElementById('employer');

function duplicateEmployer() {
    if (employers < 4) {
        var clone = mostRecentlyAddedEmployer.cloneNode(true);
        clone.id = "employer-" + ++employers;
        mostRecentlyAddedEmployer.insertAdjacentElement("afterend", clone);
        mostRecentlyAddedEmployer = document.getElementById(`employer-${employers}`);
    }
    else {
        alert("Cannot add another employer. Maximum reached!");
    }
}

var references = 1;
var mostRecentlyAddedReference = document.getElementById('reference');

function duplicateReference() {
    if (references < 4) {
        var clone = mostRecentlyAddedReference.cloneNode(true);
        clone.id = "reference-" + ++references;
        mostRecentlyAddedReference.insertAdjacentElement("afterend", clone);
        mostRecentlyAddedReference = document.getElementById(`reference-${references}`);
    }
    else {
        alert("Cannot add another reference. Maximum reached!");
    }
}
function scrollElementIntoView(returnId) {
    var target = document.getElementById(returnId);
    target.style.color = "green"; // scroll coming later
    target.scrollIntoView();
}

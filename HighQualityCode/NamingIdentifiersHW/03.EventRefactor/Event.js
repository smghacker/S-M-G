function onClick(ev, args) {
    var myWindow = window;
    var currentBrowser = myWindow.navigator.appCodeName;
    var isMozzila = currentBrowser == "Mozilla";
    if (isMozzila) {
        alert("Yes");
    } else {
        alert("No");
    }
}

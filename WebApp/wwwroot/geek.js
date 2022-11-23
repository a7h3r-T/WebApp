var viccek;

function letöltésBefejeződött(d) {
    console.log("Sikeres letöltés")
    console.log(d)
    viccek = d;

    for (var i = 0; i < viccek.length; i++) {
        var sor = document.createElement("div")
        sor.innerHTML = viccek[i].text;
        document.body.appendChild(sor);
    }
}

function letöltés() {
    fetch('/jokes.json')
        .then(response => response.json())
        .then(data => letöltésBefejeződött(data));
}

window.onload = letöltés();




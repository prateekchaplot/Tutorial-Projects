let cards = new Array();
init();

function init() {
    document.getElementById('btnSave').addEventListener('click', saveCard);
    getCards();
}

function getCards() {
    localforage.getItem('flashcards').then(function(value) {
        if (value != null) {
            cards = JSON.parse(value);
            document.getElementById('numCards').innerHTML = cards.length;
        }
    }).catch(function(err) {
        console.log('error: ' + err);
    });
}

function saveCard() {
    let frontContent = document.getElementById('frontCard').value;
    let backContent = document.getElementById('backCard').value;
    let card = { front: frontContent, back: backContent };
    cards.push(card);
    console.log(cards);
    clearUI();
    numCardsOut();
    storeCards();
}

numCardsOut = () => {
    document.getElementById('numCards').innerHTML = cards.length;
}

clearUI = () => {
    document.getElementById('frontCard').value = "";
    document.getElementById('backCard').value = "";
}

storeCards = () => {
    let serializedCards = JSON.stringify(cards);
    localforage.setItem('flashcards', serializedCards).then(function () {
        return localforage.getItem('key');
    }).then(function (value) {
        alert("saved");
    }).catch(function (err) {
        console.log("error: " + err);
    });
}
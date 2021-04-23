let cards = new Array();
let currentCard = 0;
let frontCard = true;

init();

function init() {
    getCards();
    document.getElementById('card').addEventListener('click', displayNextCard);
    document.getElementById('btnFlip').addEventListener('click', flipCard);
}

function getCards() {
    localforage.getItem('flashcards').then(function(value) {
        cards = JSON.parse(value);
        document.getElementById('numCards').innerHTML = cards.length;
        console.log(cards);
    }).catch(function(err) {
        console.log('error: ' + err);
    });
}

function displayNextCard() {
    let front = cards[currentCard].front;
    let back = cards[currentCard].back;
    let frontCardEle = document.getElementById('frontCard');
    let backCardEle = document.getElementById('backCard');

    frontCardEle.style.display = "block";
    backCardEle.style.display = "none";
    
    frontCardEle.innerHTML = front;
    backCardEle.innerHTML = back;
    document.getElementById('cardNum').innerHTML = currentCard + 1;

    if (currentCard < (cards.length - 1)) {
        currentCard++;
    } else {
        currentCard = 0;
    }
}

function flipCard() {
    let frontCardEle = document.getElementById('frontCard');
    let backCardEle = document.getElementById('backCard');
    
    if (frontCard) {
        backCardEle.style.display = "block";
        frontCardEle.style.display = "none";
    } else {
        backCardEle.style.display = "none";
        frontCardEle.style.display = "block";
    }

    frontCard = !frontCard;
}
function deal() {
    let dealtNumber = 0;
    model.gameStatus = "";
    model.dealStatus = "disabled";
    model.isBusted = false;
    for (let index = 0; index < 4; index++) {
        if (model.dealTo == "dealer") {
            dealtNumber = Math.floor(Math.random() * model.deck.length)
            model.dealerCards.push(model.deck[dealtNumber]);
            model.dealerValue += model.deck[dealtNumber].value;
            checkAce(dealtNumber);
            model.deck.splice(dealtNumber, 1)
            model.dealTo = "player";
        } else if (model.dealTo == "player") {
            dealtNumber = Math.floor(Math.random() * model.deck.length)
            model.playerCards.push(model.deck[dealtNumber]);
            model.playerValue += model.deck[dealtNumber].value;
            checkAce(dealtNumber);
            model.deck.splice(dealtNumber, 1)
            model.dealTo = "dealer";
        }
    }
    checkBlackjack();
}
function reset() {
    for (let index = 0; index < model.dealerCards.length;) {
        model.deck.push(model.dealerCards[0]);
        model.dealerCards.pop(0);
    }
    for (let index = 0; index < model.playerCards.length;) {
        model.deck.push(model.playerCards[0]);
        model.playerCards.pop(0);
    }
    
    for (let index = 0; index < model.splitCards.length;) {
        model.deck.push(model.splitCards[0]);
        model.splitCards.pop(0);
    }
    model.splitValue = 0;
    model.dealerValue = 0;
    model.playerValue = 0;
    model.gameStatus = "disabled";
    model.splitStatus = "disabled";
    model.dealStatus = "";
    model.isSplit = false;
    model.isBusted = false;
    model.isSplitBusted = false;
    model.winText = "";
    model.splitText = "";
    viewGame();
}

function checkAce(dealtNumber) {
    if (model.deck[dealtNumber].isAce == true && model.dealerValue <= 10 && model.dealTo == "dealer") {
        model.dealerValue += 10;
    }
    if (model.deck[dealtNumber].isAce == true && model.playerValue <= 10 && model.dealTo == "player") {
        model.playerValue += 10;
    }
    viewGame();
}

function hit() {
    if (model.isBusted == true) {
        return;
    }
    let dealtNumber = Math.floor(Math.random() * model.deck.length)
    model.playerCards.push(model.deck[dealtNumber]);
    model.playerValue += model.deck[dealtNumber].value;
    checkAce(dealtNumber);
    checkBust(dealtNumber);
    model.deck.splice(dealtNumber, 1)
}

function dealerMove() {
    let dealtNumber = Math.floor(Math.random() * model.deck.length)
    if (model.dealerValue < 17) {
        for (let index = 0; model.dealerValue < 17; index++) {
            dealtNumber = Math.floor(Math.random() * model.deck.length)
            model.dealerCards.push(model.deck[dealtNumber]);
            model.dealerValue += model.deck[dealtNumber].value;
            checkAce(dealtNumber);
            model.deck.splice(dealtNumber, 1)
        }
    }
}

function checkWin() {
    if (model.playerValue > model.dealerValue) {
        model.winText = "You won."
    } else if (model.dealerValue > 21) {
        model.winText = "Dealer busted, you won."
    } else {
        model.winText = "Dealer won."
    }
    model.isBusted = true;
    viewGame();
}

function checkBust(dealtNumber) {
    if (model.playerValue > 21) {
        model.winText = "You busted out."
        model.isBusted = true;
    }
    checkAce(dealtNumber);
}
function checkSplitBust() {
    if (model.splitValue > 21) {
        model.winText = "Split busted out."
        model.isSplitBusted = true;
    }
}

function checkBlackjack() {
    if (model.dealerCards.length == 2 && model.dealerValue == 21) {
        model.winText = "Dealer blackjack."
        model.isBusted = true;
        viewGame();
    } else if (model.playerCards.length == 2 && model.playerValue == 21) {
        model.winText = "Blackjack."
        model.isBusted = true;
        viewGame();
    } else if (model.playerCards.length == 2 && model.playerValue == 21 && model.dealerCards.length == 2 && model.dealerValue == 21) {
        model.winText = "Blackjack, dealer also has blackjack."
        model.isBusted = true;
        viewGame();
    } else {
        checkSplit();
    }
}

function stand() {
    if (model.isSplit == false) {
        if (model.isBusted == true) {
            return;
        }
    }
    if (model.isSplit == true) {
        if (model.isSplitBusted == true && model.isBusted == true) {
            return;
        } 
    }
    dealerMove();
    checkWin();
}

function checkSplit() {
    if (model.playerValue == 20 && model.playerCards.length === 2) {
        console.log("split")
        model.splitStatus = "";
    }
    viewGame();
}

function split(){
    if (model.isSplit == true) {
        if (model.isSplitBusted == true) {
            return;
        }
        model.splitText = "";
        let dealtNumber = Math.floor(Math.random() * model.deck.length)
        model.splitCards.push(model.deck[dealtNumber]);
        model.splitValue += model.deck[dealtNumber].value;
        checkSplitBust(dealtNumber);
        model.deck.splice(dealtNumber, 1)
    }
    if (model.isSplit == false) {
        model.isSplit = true;
        model.splitValue = 10;
        model.playerValue = 10;
        model.splitCards.push(model.playerCards[1]);
        model.playerCards.pop(0);
    }
    for (let index = 0; index < model.splitCards.length; index++) {
    let first = index % 1 == 0 ? 'first' : '';
    model.splitText += `<div class="${first} cards" style="color: ${model.splitCards[index].color}">${model.splitCards[index].display}</div>`;   
    }
        viewGame();
    
}
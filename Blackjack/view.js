function viewGame() {
    let html = `
    <div>
        <div>
            <button ${model.dealStatus} onclick="deal()">Deal card</button>
            <button ${model.gameStatus} onclick="hit()">Hit</button>
            <button ${model.gameStatus} onclick="stand()">Stand</button>
            <button ${model.splitStatus} onclick="split()">Split</button>
            <button ${model.gameStatus} onclick="reset()">Reset</button>
        </div>
        <div>
            <div class="gamecontainer">
            <div>Dealer: ${model.dealerValue}</div>`;
            for (let index = 0; index < model.dealerCards.length; index++) {
            let first = index % 1 == 0 ? 'first' : '';
            html += `<div class="${first} cards" style="color: ${model.dealerCards[index].color}">${model.dealerCards[index].display}</div>`;   
            }
        
            html += `</div>
            <div class="gamecontainer">
            <div>Player: ${model.playerValue}</div>`;
            for (let index = 0; index < model.playerCards.length; index++) {
            let first = index % 1 == 0 ? 'first' : '';
            html += `<div class="${first} cards" style="color: ${model.playerCards[index].color}">${model.playerCards[index].display}</div>`;   
            }
        html +=
        `
        </div>
            <div class="gamecontainer">
                 <div>Split: ${model.splitValue}</div>
                 ${model.splitText}
            </div>
        </div>
        <div class="gamecontainer">
            <div>${model.winText}</div>
        </div>
    </div>`;
    appDiv.innerHTML = html;
}
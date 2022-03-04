function purchaseFirstCar(selected) {
        model.cash -= model.starterCars[selected].cost;
        model.starterCars[selected].cost -= (model.starterCars[selected].cost * .25)
        model.currentCar.push(model.starterCars[selected]);
        model.starterCars.splice(selected, 1);
        model.dealerCars.push(model.starterCars[0], model.starterCars[1]);
        viewMain();
}

function purchaseCar(selected) {
    if (model.cash >= model.dealerCars[selected].cost){
        model.cash -= model.dealerCars[selected].cost;
        model.dealerCars[selected].cost -= (model.dealerCars[selected].cost * .25)
        model.garage.push(model.dealerCars[selected]);
        model.dealerCars.splice(selected, 1);
        viewGarage();
    } else {
        console.log('something went wrong.');
    }
}

function sellCar(selected) {
    let html = '';
    model.cash += model.garage[selected].cost;
    model.garage.splice(selected, 1);
    appDiv.innerHTML = html;
    viewGarage();
}

function selectCar(selected) {
    model.garage.push(model.currentCar[0]);
    model.currentCar.pop();
    model.currentCar.push(model.garage[selected]);
    model.garage.splice(selected, 1);
    viewGarage();
}

function upgrade(chosen) {
    if (chosen == 'power') {
        let powerUpgradeCost = 1000 + 500 * model.currentCar[0].powerStage;
        if (model.cash <= powerUpgradeCost) {
            return;
        }
        if (model.currentCar[0].powerStage == 7) {
            return;
        } else {
            model.cash -= powerUpgradeCost
            model.currentCar[0].powerStage ++;
            model.currentCar[0].horsepower += 5 + 10 * model.currentCar[0].powerStage
            model.currentCar[0].cost += powerUpgradeCost * .25
            viewUpgrades();
        }
    }
    
    if (chosen == 'handling') {
        let handlingUpgradeCost = 750 + 750 * model.currentCar[0].handlingStage;

        if (model.cash <= handlingUpgradeCost) {
            return;
        }
        if (model.currentCar[0].handlingStage == 7) {
            return;
        } else {
            model.cash -= handlingUpgradeCost
            model.currentCar[0].handlingStage ++;
            model.currentCar[0].handling += 3 + 1 * model.currentCar[0].handlingStage
            model.currentCar[0].weight += 5;
            viewUpgrades();
        }
    }
    
    if (chosen == 'weight') {
        let weightUpgradeCost = 650 + 700 * model.currentCar[0].weightStage;
        if (model.cash <= weightUpgradeCost) {
            return;
        }
        if (model.currentCar[0].weightStage == 7) {
            return;
        } else {
            model.cash -= weightUpgradeCost
            model.currentCar[0].weightStage ++;
            model.currentCar[0].weight -= 10 + 5 * model.currentCar[0].weightStage;
            model.currentCar[0].handling += 1;
            viewUpgrades();
        }
    }
}

function race(city, difficulity) {
    model.activeOpponent = Math.floor(Math.random() * model.opponents.length);
    model.resultColor = '';
    model.raceResult = '';
    console.log(city, difficulity)
    if (city == 'tokyo') {
        if (difficulity === 'easy' && model.currentCar[0].horsepower >= model.opponents[model.activeOpponent].horsepowerEasy) {
            model.resultColor = '#31e040',
            model.raceResult = 'You won! 1000 has been added to your cash balance.';
            model.cash += 1000;
        } else if (difficulity === 'easy' && model.currentCar[0].horsepower < model.opponents[model.activeOpponent].horsepowerEasy) {
            model.resultColor = 'red',
            model.raceResult = 'You lost. 250 has been taken from your cash balance.'
            model.cash -= 250;
        }
        if (difficulity === 'medium' && model.currentCar[0].horsepower >= model.opponents[model.activeOpponent].horsepowerMedium) {
                model.resultColor = '#31e040',
                model.raceResult = 'You won! 1500 has been added to your cash balance.';
                model.cash += 1500;
            } else if (difficulity === 'medium' && model.currentCar[0].horsepower < model.opponents[model.activeOpponent].horsepowerMedium) {
                model.resultColor = 'red',
                model.raceResult = 'You lost. 500 has been taken from your cash balance.'
                model.cash -= 500;
        }
        if (difficulity == 'hard' && model.currentCar[0].horsepower >= model.opponents[model.activeOpponent].horsepowerHard) {
                model.resultColor = '#31e040',
                model.raceResult = 'You won! 3000 has been added to your cash balance.';
                model.cash += 1000;
            } else if (difficulity === 'hard' && model.currentCar[0].horsepower < model.opponents[model.activeOpponent].horsepowerHard) {
                model.resultColor = 'red',
                model.raceResult = 'You lost. 1000 has been taken from your cash balance.'
                model.cash -= 1000;
        }
        viewTokyo();
    }

    if (city == 'touge') {
        if (difficulity === 'easy' && model.currentCar[0].weight <= model.opponents[model.activeOpponent].weightEasy) {
            model.resultColor = '#31e040',
            model.raceResult = 'You won! 1000 has been added to your cash balance.';
            model.cash += 1000;
        } else if (difficulity === 'easy' && model.currentCar[0].weight > model.opponents[model.activeOpponent].weightEasy) {
            model.resultColor = 'red',
            model.raceResult = 'You lost. 250 has been taken from your cash balance.'
            model.cash -= 250;
        }
        if (difficulity === 'medium' && model.currentCar[0].weight <= model.opponents[model.activeOpponent].weightMedium) {
                model.resultColor = '#31e040',
                model.raceResult = 'You won! 1500 has been added to your cash balance.';
                model.cash += 1500;
            } else if (difficulity === 'medium' && model.currentCar[0].weight > model.opponents[model.activeOpponent].weightMedium) {
                model.resultColor = 'red',
                model.raceResult = 'You lost. 500 has been taken from your cash balance.'
                model.cash -= 500;
        }
        if (difficulity == 'hard' && model.currentCar[0].weight <= model.opponents[model.activeOpponent].weightHard) {
                model.resultColor = '#31e040',
                model.raceResult = 'You won! 3000 has been added to your cash balance.';
                model.cash += 1000;
            } else if (difficulity === 'hard' && model.currentCar[0].weight > model.opponents[model.activeOpponent].weightHard) {
                model.resultColor = 'red',
                model.raceResult = 'You lost. 1000 has been taken from your cash balance.'
                model.cash -= 1000;
        }
        viewTouge();
    }

    if (city == 'track') {
        if (difficulity === 'easy' && model.currentCar[0].handling >= model.opponents[model.activeOpponent].handlingEasy) {
            model.resultColor = '#31e040',
            model.raceResult = 'You won! 1000 has been added to your cash balance.';
            model.cash += 1000;
        } else if (difficulity === 'easy' && model.currentCar[0].handling < model.opponents[model.activeOpponent].handlingEasy) {
            model.resultColor = 'red',
            model.raceResult = 'You lost. 250 has been taken from your cash balance.'
            model.cash -= 250;
        }
        if (difficulity === 'medium' && model.currentCar[0].handling >= model.opponents[model.activeOpponent].horsepowerMedium) {
                model.resultColor = '#31e040',
                model.raceResult = 'You won! 1500 has been added to your cash balance.';
                model.cash += 1500;
            } else if (difficulity === 'medium' && model.currentCar[0].handling < model.opponents[model.activeOpponent].handlingMedium) {
                model.resultColor = 'red',
                model.raceResult = 'You lost. 500 has been taken from your cash balance.'
                model.cash -= 500;
        }
        if (difficulity == 'hard' && model.currentCar[0].handling >= model.opponents[model.activeOpponent].handlingHard) {
                model.resultColor = '#31e040',
                model.raceResult = 'You won! 3000 has been added to your cash balance.';
                model.cash += 1000;
            } else if (difficulity === 'hard' && model.currentCar[0].handling < model.opponents[model.activeOpponent].handlingHard) {
                model.resultColor = 'red',
                model.raceResult = 'You lost. 1000 has been taken from your cash balance.'
                model.cash -= 1000;
        }
        viewTrack();
    }

    html += `
        <hr>
        <div>You raced against: ${model.opponents[model.activeOpponent].name}</div>
        <div>${model.opponents[model.activeOpponent].make} ${model.opponents[model.activeOpponent].model} (${model.opponents[model.activeOpponent].chassis})</div>
        <div style="color: ${model.resultColor}">${model.raceResult}</div>
    `;
    appDiv.innerHTML = html;
}

function endDay() {
    model.dayCount++
    viewMain();
}
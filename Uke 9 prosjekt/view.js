function viewGameStart(){
    let html = `
    <div>
        <h2>Welcome, racer!</h2>
        <div>This is your first day!<br>
        You're gonna need a ride to get started. You can buy more cars later, you should probably upgrade whatever you pick for now.<br>
        Please select one of the cars below to start your journey into the world of underground racing!</div>
        <hr>
    </div>
    `;
    for (let index = 0; index < model.starterCars.length; index++) {
        let first = index % 3 == 0 ? 'first' : '';
        html += `
        <div class="carcontainer multiple ${first}" onclick="purchaseFirstCar(${index})">
            <div style="font-weight: bold">${model.starterCars[index].make} ${model.starterCars[index].model} (${model.starterCars[index].chassis})</div>
            <div>Power: ${model.starterCars[index].horsepower}HP</div>
            <div>Weight: ${model.starterCars[index].weight}Kg</div>
            <div>Handling: ${model.starterCars[index].handling}</div>
            <div>Cost: ${model.starterCars[index].cost}</div>
            <img src="${model.starterCars[index].image}"></img>
        </div>
        `;
    }
    appDiv.innerHTML = html
}

function viewMain() {
    let html = `
    <div>
        <h2>Main Menu</h2>
        <button onclick="viewGarage()">Garage</button> <button onclick="viewDealership()">Dealership</button> <button onclick="viewLocations()">Go race</button>
        <div>Location: ${model.currentLocation}</div>
        <div>Cash: ${model.cash}</div>
        <div>Day: ${model.dayCount}</div> <hr>
    </div>
    `;
    for (let index = 0; index < model.currentCar.length; index++) {
    html += `
    <div class="carcontainer current">
        <div style="font-weight: bold">Current car:</div>
        <br>
        <div style="font-weight: bold">${model.currentCar[index].make} ${model.currentCar[index].model} (${model.currentCar[index].chassis})</div>
        <hr>
        <div>Power: ${model.currentCar[index].horsepower}HP</div>
        <div>Weight: ${model.currentCar[index].weight}Kg</div>
        <div>Handling: ${model.currentCar[index].handling}</div>
        <div>Value: ${model.currentCar[index].cost}</div>
    </div>
    `;
    }
    appDiv.innerHTML = html;
}

function viewGarage() {
    let html = `
    <div>
        <h2>Garage</h2>
        <button onclick="viewMain()">Home</button> <button onclick="viewUpgrades()">Upgrades</button>
        <hr>
    </div>
    `;
    for (let index = 0; index < model.currentCar.length; index++) {
    html += `
    <div class="carcontainer current">
        <div style="font-weight: bold">Current car:</div>
        <br>
        <div style="font-weight: bold">${model.currentCar[index].make} ${model.currentCar[index].model} (${model.currentCar[index].chassis})</div>
        <br>
        <div>Power: ${model.currentCar[index].horsepower}HP</div>
        <div>Weight: ${model.currentCar[index].weight}Kg</div>
        <div>Handling: ${model.currentCar[index].handling}</div>
        <div>Value: ${model.currentCar[index].cost}</div>
    </div>
    `;
}
    for (let index = 0; index < model.garage.length; index++) {
    let first = index % 3 == 0 ? 'first' : '';
    html += `
    <div class="carcontainer multiple ${first}">
        <div style="font-weight: bold">${model.garage[index].make} ${model.garage[index].model} (${model.garage[index].chassis})</div>
        <div>Power: ${model.garage[index].horsepower}HP</div>
        <div>Weight: ${model.garage[index].weight}Kg</div>
        <div>Handling: ${model.garage[index].handling}</div>
        <div>Value: ${model.garage[index].cost}</div>
        <img src="${model.garage[index].image}"></img>
        <button onclick="selectCar(${index})">Select car</button>
        <button onclick="sellCar(${index})">Sell car</button>
    </div>
    `;
    }
    appDiv.innerHTML = html;
}

function viewUpgrades() {
    html = `
    <div>
        <h2>Upgrades</h2>
        <button onclick="viewGarage()">Back</button>
        <button onclick="upgrade('power')">Upgrade Power</button>
        <button onclick="upgrade('weight')">Upgrade Weight</button>
        <button onclick="upgrade('handling')">Upgrade Handling</button>
        <div>Cash: ${model.cash}</div>
        <hr>
    </div>
    <div>
        <div style="font-weight: bold"><span>Current Car: ${model.currentCar[0].make} ${model.currentCar[0].model} (${model.currentCar[0].chassis})</div>
        <div>Power: ${model.currentCar[0].horsepower} Current stage: ${model.currentCar[0].powerStage}</div>
        <div>Weight: ${model.currentCar[0].weight} Current stage ${model.currentCar[0].weightStage}</div>
        <div>Handling: ${model.currentCar[0].handling} Current stage ${model.currentCar[0].handlingStage}</div>
    </div>
    `;
    appDiv.innerHTML = html;
}

function viewDealership() {
    html = `
    <div>
        <h2>Dealership</h2>
        <button onclick="viewMain()">Home</button>
        <hr>
    </div>
    `;
    for (let index = 0; index < model.dealerCars.length; index++) {
    html += `
    <div class="carcontainer multiple">
        <div style="font-weight: bold">${model.dealerCars[index].make} ${model.dealerCars[index].model} (${model.dealerCars[index].chassis})</div>
        <div>Power: ${model.dealerCars[index].horsepower}HP</div>
        <div>Weight: ${model.dealerCars[index].weight}Kg</div>
        <div>Handling: ${model.dealerCars[index].handling}</div>
        <div>Cost: ${model.dealerCars[index].cost}</div>
        <img src="${model.dealerCars[index].image}"></img>
        <button onclick="purchaseCar(${index})">Buy</button>
    </div>
    `;
    }
    appDiv.innerHTML = html;
}

function viewLocations() {
    html = `
    <div>
        <h2>Chose a location</h2>
        <button onclick="viewMain()">Home</button><hr>

        <div onclick="viewTokyo()">
            <h3>Tokyo Expressway</h3>
            <div>Focus: Power</div>
        </div><hr>

        <div onclick="viewTouge()">
            <h3>Touge Passes</h3>
            <div>Focus: Weight</div>
        </div><hr>

        <div onclick="viewTrack()">
            <h3>Tracks</h3>
            <div>Focus: Handling</div>
        </div>
    </div>
    `;
    appDiv.innerHTML = html;
}

function viewTokyo() {
    model.currentLocation = 'Tokyo';
    html = `
    <div style="font-weight: bolder">
        <h2>Tokyo Expressway</h2>
        <button onclick="endDay()">End day</button><hr>
        <div><span style="font-weight: bolder">Description:</span><br>
        The Tokyo Expressway, also known as the Shutoko Expressway is home to many famous street racers like Smokey Nagata, Isami Amemiya and the rest of the Mid Night racing team.
        From the long, smooth straights of the Bayshore line to the tight and technical loop of the C1, the Tokyo Expressway offers a little something for everyone. Now its your turn to make a mark on this infamous highway!</div>
        <hr>
        <button onclick="race('tokyo', 'easy')">Easy</button>
        <button onclick="race('tokyo', 'medium')">Medium</button>
        <button onclick="race('tokyo', 'hard')">Hard</button>
    </div>
    `;
    appDiv.innerHTML = html; 
}

function viewTrack() {
    model.currentLocation = 'Ebisu';
    html = `
    <div style="font-weight: bolder">
    <h2>Ebisu</h2>
    <button onclick="endDay()">End day</button><hr>
    <div>Description:<br>
    While Ebisu home to the many famous drift courses, it is also used for racing. Some of the more known courses are the 
    Minami Course and the Touge Corse. The Minami Course has been a staple of Japanese drifting ever since the 90's and its hosted
    several Formula Drift Japan races and is also known for its little bump leading up to the main straight, dubbed the "Ebisu Jump"
    drivers intentionally hit this bump to jump into a drift leading all the way through the first few hairpin turns. <br>
    The Touge Course is known for its tight, winding turns and steep inclines that is supposed to simulate Japanese mountain roads, it is not a course
    for inexperienced drivers. </div>
    <hr>
    <button onclick="race('track', 'easy')">Easy</button>
    <button onclick="race('track', 'medium')">Medium</button>
    <button onclick="race('track', 'hard')">Hard</button>
    `;
    appDiv.innerHTML = html; 
}

function viewTouge() {
    model.currentLocation = 'Mt. Haruna';
    html = `
    <div style="font-weight: bolder">
        <h2>Mount Haruna</h2>
        <button onclick="endDay()">End day</button><hr>
        <div><span style="font-weight: bolder">Description:<br>
        Mount Haruna, better known as Mount Akina is the mountain road featured in Initial D, known for its winding roads, tight hairpins and beautiful scenery,
        it along with many other mountain passes became popular spots for drifters and street racers during the late 80's and early 90's.
        Located in the Gunma preficture, it is still somewhat close to the hustle and bustle of Tokyo, many street racers come here to prove themselves.
        </div>
        <hr>
        <button onclick="race('touge', 'easy')">Easy</button>
        <button onclick="race('touge', 'medium')">Medium</button>
        <button onclick="race('touge', 'hard')">Hard</button>
    </div>
    `;
    appDiv.innerHTML = html; 
}
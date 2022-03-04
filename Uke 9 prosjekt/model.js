const model = {
    cash: 20000,
    dayCount: 1,
    activeOpponent: 0,
    resultColor: '',
    raceResult: '',
    currentCar: [],
    currentLocation: 'None selected',
    garage: [],
    starterCars: [
            {
                make: "Toyota",
                model: "Sprinter Trueno",
                chassis: "AE86",
                horsepower: 119,
                weight: 998,
                handling: 20,
                cost: 16000,
                powerStage: 0,
                handlingStage: 0,
                weightStage: 0,
                image: "TruenoAE86.png",
            },
            {
                make: "Honda",
                model: "Integra LS",
                chassis: "DC1",
                horsepower: 140,
                weight: 1200,
                handling: 18,
                cost: 18000,
                powerStage: 0,
                handlingStage: 0,
                weightStage: 0,
                image: "IntegraLSDC2.png",
            },
            {
                make: "Nissan",
                model: "240SX",
                chassis: "S13",
                horsepower: 140,
                weight: 1225,
                handling: 16,
                cost: 15000,
                powerStage: 0,
                handlingStage: 0,
                weightStage: 0,
                image: "240SXS13.png",
            },
        ],
    dealerCars: [
        {
            make: "Honda",
            model: "Civic CX",
            chassis: "EJ6",
            horsepower: 106,
            weight: 1037,
            handling: 18,
            cost: 16000,
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0,
            image: "CivicEK.png",
        },
        {
            make: "Nissan",
            model: "Silvia Spec-R",
            chassis: "S15",
            horsepower: 247,
            weight: 1240,
            handling: 22,
            cost: 30000,  
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0,
            image: "SilviaS15.png",
        },
        {
            make: "Nissan",
            model: "Skyline GT-R",
            chassis: "R34",
            horsepower: 276,
            weight: 1560,
            handling: 24,
            cost: 30000, 
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0, 
            image: "SkylineGTRR34.png",
        },
        {
            make: "Nissan",
            model: "350Z",
            chassis: "Z33",
            horsepower: 287,
            weight: 1525,
            handling: 20,
            cost: 28000,  
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0,
            image: "350ZZ33.png",
        },
        {
            make: "Mitsubishi",
            model: "Eclipse",
            chassis: "D32A",
            horsepower: 210,
            weight: 1325,
            handling: 22,
            cost: 18000,  
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0,
            image: "EclipseD32A.png",
        },
        {
            make: "Mitsubishi",
            model: "Lancer Evolution IX",
            chassis: "CT9A",
            horsepower: 286,
            weight: 1490,
            handling: 22,
            cost: 27000,  
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0,
            image: "EvoIXCT9A.png",
        },
        {
            make: "Mitsubishi",
            model: "Lancer Evolution X",
            chassis: "CZ4A",
            horsepower: 291,
            weight: 1370,
            handling: 24,
            cost: 33000,  
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0,
            image: "EvoXCZ4A.png",
        },
        {
            make: "Toyota",
            model: "Supra RZ",
            chassis: "A80",
            horsepower: 315,
            weight: 1549,
            handling: 18,
            cost: 25000, 
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0,
            image: "SupraA80.png",
        },
        {
            make: "Subaru",
            model: "Impreza WRX STI",
            chassis: "GD",
            horsepower: 300,
            weight: 1520,
            handling: 20,
            cost: 29000, 
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0,
            image: "ImprezaWRXSTIGD.png",
        },
        {
            make: "Mazda",
            model: "RX-7",
            chassis: "FD3S",
            horsepower: 255,
            weight: 1310,
            handling: 26,
            cost: 21000, 
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0,
            image: "RX7FD3S.png",
        },
        {
            make: "Mazda",
            model: "RX-8",
            chassis: "SE3P",
            horsepower: 232,
            weight: 1347,
            handling: 20,
            cost: 28000, 
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0,
            image: "RX8SE3P.png",
        },
        {
            make: "Honda",
            model: "S2000",
            chassis: "AP2",
            horsepower: 237,
            weight: 1286,
            handling: 22,
            cost: 42000, 
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0,
            image: "S2000AP2.png",
        },
        {
            make: "Honda",
            model: "NSX",
            chassis: "NA2",
            horsepower: 290,
            weight: 1392,
            handling: 26,
            cost: 70000, 
            powerStage: 0,
            handlingStage: 0,
            weightStage: 0,
            image: "NSXNA2.png",
        },
    ],
    opponents: [
        {   
            name: "Rolling Guy 1",
            make: "Toyota",
            model: "Corolla Levin",
            chassis: "AE86",
            horsepowerEasy: 190,
            horsepowerMedium: 215,
            horsepowerHard: 230,
            handlingEasy: 25,
            handlingMedium: 50,
            handlingHard: 78,
            weightEasy: 990,
            weightMedium: 950,
            weightHard: 920,
        },
        {
            name: "Blue Giant",
            make: "Nissan",
            model: "Silvia K's",
            chassis: "S13",
            horsepowerEasy: 200,
            horsepowerMedium: 250,
            horsepowerHard: 350,
            handlingEasy: 22,
            handlingMedium: 45,
            handlingHard: 70,
            weightEasy: 1140,
            weightMedium: 1100,
            weightHard: 1000,
        },
        {
            name: "Pride Killer",
            make: "Nissan",
            model: "Skyline GT-R",
            chassis: "R33",
            horsepowerEasy: 290,
            horsepowerMedium: 330,
            horsepowerHard: 420,
            handlingEasy: 28,
            handlingMedium: 40,
            handlingHard: 70,
            weightEasy: 1530,
            weightMedium: 1500,
            weightHard: 1480,
        },
        {
            name: "Takeshi Sato",
            make: "Nissan",
            model: "Silvia Spec-R",
            chassis: "S15",
            horsepowerEasy: 250,
            horsepowerMedium: 300,
            horsepowerHard: 380,
            handlingEasy: 30,
            handlingMedium: 40,
            handlingHard: 60,
            weightEasy: 1240,
            weightMedium: 1150,
            weightHard: 1100,
        },
        {
            name: "Joe Tacket",
            make: "Honda",
            model: "Civic",
            chassis: "EK9",
            horsepowerEasy: 155,
            horsepowerMedium: 180,
            horsepowerHard: 210,
            handlingEasy: 18,
            handlingMedium: 25,
            handlingHard: 40,
            weightEasy: 1000,
            weightMedium: 900,
            weightHard: 850,
        },
        {
            name: "Aki Kamura",
            make: "Mazda",
            model: "RX-7",
            chassis: "FD3S",
            horsepowerEasy: 290,
            horsepowerMedium: 350,
            horsepowerHard: 450,
            handlingEasy: 30,
            handlingMedium: 45,
            handlingHard: 65,
            weightEasy: 1200,
            weightMedium: 1100,
            weightHard: 1050,
        },
    ]
}
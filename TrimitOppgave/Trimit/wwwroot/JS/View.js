function updateView() {
    let html = `
    <div>
        <div>${model.data.jokeText}</div>
        <div>Joke ID: ${model.data.jokeId}</div>
        <button onclick="getJoke()">Get new joke!</button>
    </div>
`;

    appDiv.innerHTML = html;
}
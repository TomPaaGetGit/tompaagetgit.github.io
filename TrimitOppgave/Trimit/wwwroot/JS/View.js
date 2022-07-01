function updateView() {
    let html = `
    <div>
        <div>${model.data.jokeText}</div>
        <button onclick="getJoke()">Get new joke!</button>
    </div>
`;

    appDiv.innerHTML = html;
}
async function getJoke() {
    let response = await axios.get('/joke');
    model.data = response.data;
    updateView();
}
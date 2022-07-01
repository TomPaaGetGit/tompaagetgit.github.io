using RestSharp;
using Trimit.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.MapGet("/joke", async () =>
{
    var client = new RestClient("https://api.chucknorris.io/jokes/random");
    var request = new RestRequest();
    var Joke = await client.GetAsync<ApiJoke>(request);
    return new JokeViewModel { JokeText = Joke.Value, JokeId = Joke.Id};
});
app.UseStaticFiles();
app.Run();
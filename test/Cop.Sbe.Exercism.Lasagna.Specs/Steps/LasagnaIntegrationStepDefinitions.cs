using FluentAssertions;
using TechTalk.SpecFlow;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using Cop.Sbe.Exercism.Lasagna.WebApi;
using Microsoft.AspNetCore.Http;

namespace Cop.Sbe.Exercism.Lasagna.Specs.Steps;

[Binding, Scope(Tag="integration")]
public class LasagnaIntegrationStepDefinitions
{
    private readonly HttpClient _client;
    public LasagnaIntegrationStepDefinitions()
    {
        var factory = new Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactory<Program>();
        _client = factory.CreateDefaultClient();
    }

    [Then(@"expected minutes in oven should be (.*)")]
    public async Task ThenExpectedMinutesInOvenShouldBe(int expectedMinutes)
    {
        var rootRoute = () => _client.GetFromJsonAsync<string>("/");
        FluentActions.Invoking(rootRoute).Should().Throw<HttpRequestException>();
        var forecastRouteAsString = () => _client.GetFromJsonAsync<string>("/WeatherForecast");
        FluentActions.Invoking(forecastRouteAsString).Should().Throw<JsonException>();
        var response = await _client.GetFromJsonAsync<WeatherForecast[]>("/WeatherForecast");
        response.Should().HaveCount(5);
        var x = await _client.GetStringAsync("/api/lasagna/x");
        x.Should().Be("42");
        var actualExpectedMinutes = await _client.GetStringAsync("/api/lasagna/minutes/expected");
        actualExpectedMinutes.Should().Be(expectedMinutes.ToString());
        
    }

    [Then(@"remaining minutes in oven should be (.*) when actual minutes is (.*)")]
    public async Task ThenRemainingMinutesInOvenShouldBe(int expected, int actualMinutes)
    {
       await ShouldBe("/api/lasagna/minutes/remaining?actualMinutes=1", 39);
    }

    [Then(@"preparation time in minutes should be (.*) when added layers is (.*)")]
    public async Task ThenPreparationTimeInMinutesShouldBe(int expected, int addedLayers)
    {
        await ShouldBe("/api/lasagna/minutes/preparation?addedLayers=1",2);
    }

    [Then(
        @"elapsed time in minutes should be (.*) when added layers is (.*) and minutes in oven is (.*)"
    )]
    public async Task ThenElapsedTimeInMinutesShouldBe(int expected, int addedLayers, int minutesInOven)
    {
        await ShouldBe("/api/lasagna/minutes/elapsed?addedLayers=2&minutesInOven=1",5);
    }

    internal async Task ShouldBe(
        string route,
        int expected) {
        var response = await _client.GetAsync(route);
        response.StatusCode.Should().Be(StatusCodes.Status200OK);
        var actual = await _client.GetStringAsync(route);
        actual.Should().Be(expected.ToString());
    }

}

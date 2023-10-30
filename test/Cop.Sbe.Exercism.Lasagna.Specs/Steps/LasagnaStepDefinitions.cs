using Cop.Sbe.Exercism.Lasagna.WebApi;
using FluentAssertions;
using TechTalk.SpecFlow;

[Binding]
public class LasagnaStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;

    public LasagnaStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Then(@"expected minutes in oven should be (.*)")]
    public void ThenExpectedMinutesInOvenShouldBe(int expected)
    {
        var lasagna = new Lasagna();
        var actual = lasagna.ExpectedMinutesInOven();
        actual.Should().Be(expected);
    }

    [Then(@"remaining minutes in oven should be (.*)")]
    public void ThenRemainingMinutesInOvenShouldBe(int p0)
    {
        _scenarioContext.Pending();
    }

    [Then(@"preparation time in minutes should be (.*)")]
    public void ThenPreparationTimeInMinutesShouldBe(int p0)
    {
        _scenarioContext.Pending();
    }

    [Then(@"elapsed time in minutes should be (.*)")]
    public void ThenElapsedTimeInMinutesShouldBe(int p0)
    {
        _scenarioContext.Pending();
    }
}

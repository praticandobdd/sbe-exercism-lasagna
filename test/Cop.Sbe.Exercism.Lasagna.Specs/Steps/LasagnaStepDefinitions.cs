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
}

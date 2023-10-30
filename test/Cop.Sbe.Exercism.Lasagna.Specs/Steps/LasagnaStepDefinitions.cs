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
        Lasagna().ExpectedMinutesInOven().Should().Be(expected);
    }

    [Then(@"remaining minutes in oven should be (.*) when actual minutes is (.*)")]
    public void ThenRemainingMinutesInOvenShouldBe(int expected, int actualMinutes)
    {
        Lasagna().RemainingMinutesInOven(actualMinutes).Should().Be(expected);
    }

    [Then(@"preparation time in minutes should be (.*) when added layers is (.*)")]
    public void ThenPreparationTimeInMinutesShouldBe(int expected, int addedLayers)
    {
        Lasagna().PreparationTimeInMinutes(addedLayers).Should().Be(expected);
    }

    [Then(
        @"elapsed time in minutes should be (.*) when added layers is (.*) and minutes in oven is (.*)"
    )]
    public void ThenElapsedTimeInMinutesShouldBe(int expected, int addedLayers, int minutesInOven)
    {
        Lasagna().ElapsedTimeInMinutes(addedLayers, minutesInOven).Should().Be(expected);
    }

    static Lasagna Lasagna() => new Lasagna();
}

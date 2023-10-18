using FluentAssertions;
using TechTalk.SpecFlow;


namespace Cop.Sbe.Exercism.Lasagna.Specs.Steps
{
    [Binding]
    public sealed class LasagnaStepDefinitions
    {

        private ScenarioContext _scenarioContext;

        public LasagnaStepDefinitions(ScenarioContext scenarioContext){
            _scenarioContext = scenarioContext;
        }

        //[Then("expected minutes in oven should be 40")]
        public void ShouldReturn40AsExpectedMinutesInOven(){
             _scenarioContext.Pending();
        }

        [Then(@"minutos esperados no forno deve ser (.*)")]
        [Then(@"expected minutes in oven should be (.*)")]
         public void ThenExpectedMinutesInOvenShouldBe(int expected)
         {
            var lasagna = new WebApi.Lasagna();
            var actual = lasagna.ExpectedMinutesInOven();
            actual.Should().Be(expected);
         }

    }
}

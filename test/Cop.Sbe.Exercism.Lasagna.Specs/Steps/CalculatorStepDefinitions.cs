using FluentAssertions;
using TechTalk.SpecFlow;

namespace Cop.Sbe.Exercism.Lasagna.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
       
       // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

       private readonly ScenarioContext _scenarioContext;
       private int _firstNumber;
       private int _secondNumber;
       private int _result;

       public CalculatorStepDefinitions(ScenarioContext scenarioContext)
       {
           _scenarioContext = scenarioContext;
       }

       [Given("the first number is (.*)")]
       public void GivenTheFirstNumberIs(int number)
       {
            _firstNumber = number;
       }

       [Given("the second number is (.*)")]
       public void GivenTheSecondNumberIs(int number)
       {
            _secondNumber = number;
       }
        
       [When("the two numbers are added")]
       public void WhenTheTwoNumbersAreAdded()
       {
            _result = _firstNumber + _secondNumber;
       }

       [Then("the result should be (.*)")]
       public void ThenTheResultShouldBe(int expected)
       {
            _result.Should().Be(expected);
       }
    }
}

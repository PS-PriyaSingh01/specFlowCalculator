using specFlowCalculator;
using TechTalk.SpecFlow;
using FluentAssertions;
using System;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator cal = new Calculator();

        private int firstnumber;

        private int secondnumber;

        private int addresult;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //cal.FirstNumber = number;
            firstnumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            // cal.SecondNumber = number;
            secondnumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
           // addresult = cal.Add();
            addresult = firstnumber + secondnumber;
        }

        [When("the two numbers are substarcted")]
        public void WhenTheTwoNumbersAreSubstarcted()
        {
            // addresult = cal.Add();
            addresult = firstnumber - secondnumber;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            addresult.Should().Be(result);
        }
    }
}

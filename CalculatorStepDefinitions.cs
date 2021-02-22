using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _scenarioContext.Add("num1", number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _scenarioContext.Add("num2", number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            var n1 = _scenarioContext.Get<int>("num1");
            var n2 = _scenarioContext.Get<int>("num2");
            _scenarioContext.Add("answer", n1 + n2);

            //_scenarioContext.Pending();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            var n3 = _scenarioContext.Get<int>("answer");
            n3.Should().Be(result);

            //_scenarioContext.Pending();
        }


        [Then(@"the running total should be (.*)")]
        public void ThenTheRunningTotalShouldBe(int result)
        {
            var n3 = _scenarioContext.Get<int>("num1");
            n3.Should().Be(result);
        }





        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            var n1 = _scenarioContext.Get<int>("num1");
            var n2 = _scenarioContext.Get<int>("num2");
            _scenarioContext.Add("answer", n1 - n2);

            // ScenarioContext.Current.Pending();
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            var n1 = _scenarioContext.Get<int>("num1");
            var n2 = _scenarioContext.Get<int>("num2");
            _scenarioContext.Add("answer", n1 * n2);
        }

        //...

        [When(@"operation \+ is done to the number (.*)")]
        public void WhenOperationIsDoneToTheNumber(int number)
        {
            var n1 = _scenarioContext.Get<int>("num1");
            //need to save num1=n1+number;

            _scenarioContext.Set<int>(n1+number,  "num1");
        }

        /*[When(@"the operation \+ is done to the number (.*)")]
        public void WhenTheOperationIsDoneToTheNumber(int number)
        {
            var n1 = _scenarioContext.Get<int>("num1");
            var n2 = _scenarioContext.Get<int>("num2");
            _scenarioContext.Add("answer", n1 + n2);
        }*/

        [When(@"operation / is done to the number (.*)")]
        public void WhenOperationDivideIsDoneToTheNumber(int number)
        {
            var n1 = _scenarioContext.Get<int>("num1");
            _scenarioContext.Set<int>(n1 / number, "num1");
        }

        [When(@"operation - is done to the number (.*)")]
        public void WhenOperation_IsDoneToTheNumber(int number)
        {
            var n1 = _scenarioContext.Get<int>("num1");
            _scenarioContext.Set<int>(n1 - number, "num1");
        }

        [When(@"operation % is done to the number (.*)")]
        public void WhenOperationModulusIsDoneToTheNumber(int number)
        {
            var n1 = _scenarioContext.Get<int>("num1");
            _scenarioContext.Set<int>(n1 % number, "num1");
        }

        //...


    }
}

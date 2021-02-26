using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class MPGSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public MPGSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            
        }

        [Given(@"Miles driven is (.*\.?\d*)")]
        public void GivenMilesDrivenIs(double dnum)
        {
            int number = (int)(100000 * dnum);
            _scenarioContext.Add("num1", number);
 
        }
        
        [Given(@"Gallons used is (.*\.?.*)")]
        public void GivenGallonsUsedIs(double dnum)
        {
            int number = (int)(dnum * 100000);
            _scenarioContext.Add("num2", number);
        }

        /*[When(@"calc_mpg is called")]
        public void 
        */

        [When(@"calc_mpg is called")]
        public void WhenCalc_MpgIsCalled()
        {

            var n1 = _scenarioContext.Get<int>("num1");
            var n2 = _scenarioContext.Get<int>("num2");
            double super = (double)n1 / (double)n2 * 100000;
            _scenarioContext.Add("answer", (int)super);
        }

        [Then(@"the fuel efficiency should be (.*)")]
        public void ThenTheFuelEfficiencyShouldBe(double result)
        {
            result *= 100000;
            int dancer = (int)result;
            var n3 = _scenarioContext.Get<int>("answer");

            n3.Should().Be(dancer);
        }

        

    }
}

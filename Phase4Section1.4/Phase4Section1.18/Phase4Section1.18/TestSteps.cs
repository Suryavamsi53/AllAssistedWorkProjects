using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


namespace Phase4Section1._18
{
    
        [Binding]
        public class TestSteps
        {
            [Given(@"I have entered (.*) into the calculator")]
            public void GivenIHaveEnteredIntoTheCalculator(int p0)
            {
                Console.WriteLine("GivenIHaveEnteredIntoTheCalculator");
            }

            [When(@"I press add")]
            public void WhenIPressAdd()
            {
                Console.WriteLine("WhenIPressAdd");
            }

            [Then(@"the result should be (.*) on the screen")]
            public void ThenTheResultShouldBeOnTheScreen(int p0)
            {
                Console.WriteLine("ThenTheResultShouldBeOnTheScreen");
            }

        }
    }

 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
 

    namespace Phase4Section1._19
    {
        [Binding]
        public class TestSteps
        {
            [Given(@"I enter below information in the login form")]
            public void GivenIEnterBelowInformationInTheLoginForm(Table table)
            {
                foreach (TableRow row in table.Rows)
                {
                    foreach (String value in row.Values)
                        Console.WriteLine(value);
                }
            }

        }
    }


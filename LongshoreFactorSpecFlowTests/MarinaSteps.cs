﻿using System;
using TechTalk.SpecFlow;

namespace LongshoreFactorSpecFlowTests
{
    [Binding]
    public class MarinaSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Employer is a Marina")]
        public void GivenEmployerIsAMarina()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"It should not be Longshore")]
        public void ThenItShouldNotBeLongshore()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

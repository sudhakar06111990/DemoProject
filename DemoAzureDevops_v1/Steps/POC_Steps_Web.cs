using DemoAzureDevops_v1.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace DemoAzureDevops_v1.Steps
{
    [Binding]
    class POC_Steps_Web
    {
        Pages_POC_Web obj = new Pages_POC_Web();
        [Given(@"I Navigate to FB Page")]
        public void GivenINavigateToFBPage()
        {
            Thread.Sleep(3000);
            obj.launchFB();
            Thread.Sleep(3000);
        }
        [When(@"I Login to FB Page")]
        public void GivenILoginToFBPage()
        {
            obj.login();
        }
       [Given(@"I Navigate to Gmail Page")]
        public void GivenINavigateToGmailPage()
        {
            Thread.Sleep(3000);
            obj.launchGmail();
            Thread.Sleep(3000);
        }
    }
}

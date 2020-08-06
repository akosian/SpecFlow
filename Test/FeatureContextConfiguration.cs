using Frame;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Test.pages;

namespace Test
{
    [Binding]
    public class FeatureContextConfiguration
    {

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            featureContext.FeatureContainer.RegisterInstanceAs<Form>(new CatalogPage());
            featureContext.FeatureContainer.RegisterInstanceAs<Form>(new LoginForm());
            featureContext.FeatureContainer.RegisterInstanceAs<Form>(new MainPage());
            featureContext.FeatureContainer.RegisterInstanceAs<Form>(new TabsForm());
            Console.WriteLine("Starting " + featureContext.FeatureInfo.Title);
        }

        [AfterFeature]
        public static void AfterFeature(FeatureContext featureContext)
        {
            Console.WriteLine("Finished " + featureContext.FeatureInfo.Title);
        }
    }
}
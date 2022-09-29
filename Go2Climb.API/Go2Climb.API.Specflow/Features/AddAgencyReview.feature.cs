﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Go2Climb.API.Specflow.AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AddAgencyReviewFeature : object, Xunit.IClassFixture<AddAgencyReviewFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AddAgencyReview.feature"
#line hidden
        
        public AddAgencyReviewFeature(AddAgencyReviewFeature.FixtureData fixtureData, Go2Climb_API_Specflow_AcceptanceTests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "AddAgencyReview", "As a tourist I want to rate the service I hired to show my opinion so that more u" +
                    "sers know about it.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
    #line hidden
#line 5
        testRunner.Given("the Endpoint https://localhost:5001/api/v1/agencyreviews is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Email",
                        "Password",
                        "PhoneNumber",
                        "Description",
                        "Location",
                        "Ruc",
                        "Photo",
                        "Score"});
            table1.AddRow(new string[] {
                        "1",
                        "Climbling",
                        "Climbling@go.com",
                        "123",
                        "987654321",
                        "funny",
                        "calle 2",
                        "12345678",
                        "none",
                        "5"});
#line 6
        testRunner.And("A Agency already exists", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "LastName",
                        "Email",
                        "Password",
                        "PhoneNumber"});
            table2.AddRow(new string[] {
                        "1",
                        "Luis",
                        "Perez",
                        "lperez@gmail.com",
                        "mypass12345",
                        "999888777"});
#line 10
        testRunner.And("A Customer already hire a service", ((string)(null)), table2, "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Add new review to the agency")]
        [Xunit.TraitAttribute("FeatureTitle", "AddAgencyReview")]
        [Xunit.TraitAttribute("Description", "Add new review to the agency")]
        [Xunit.TraitAttribute("Category", "service-adding")]
        public virtual void AddNewReviewToTheAgency()
        {
            string[] tagsOfScenario = new string[] {
                    "service-adding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new review to the agency", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 15
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
    this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "AgencyId",
                            "CustomerId",
                            "Date",
                            "Comment",
                            "ProfessionalismScore",
                            "SecurityScore",
                            "QualityScore",
                            "CostScore"});
                table3.AddRow(new string[] {
                            "1",
                            "1",
                            "25-04-2022",
                            "The experience was great",
                            "5",
                            "5",
                            "5",
                            "4"});
#line 16
        testRunner.When("A AgencyReview Request is Sent", ((string)(null)), table3, "When ");
#line hidden
#line 19
        testRunner.Then("A Response With status 200 is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AddAgencyReviewFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AddAgencyReviewFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

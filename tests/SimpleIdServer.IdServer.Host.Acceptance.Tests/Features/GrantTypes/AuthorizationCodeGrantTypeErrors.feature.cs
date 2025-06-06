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
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features.GrantTypes
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AuthorizationCodeGrantTypeErrorsFeature : object, Xunit.IClassFixture<AuthorizationCodeGrantTypeErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AuthorizationCodeGrantTypeErrors.feature"
#line hidden
        
        public AuthorizationCodeGrantTypeErrorsFeature(AuthorizationCodeGrantTypeErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "AuthorizationCodeGrantTypeErrors", "\tCheck errors returned when using \'authorization_code\' grant-type", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=authorization_code\' with no code parameter")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=authorization_code\' with no code parameter")]
        public void SendGrant_TypeAuthorization_CodeWithNoCodeParameter()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=authorization_code\' with no code parameter", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table221 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table221.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table221, "When ");
#line hidden
#line 9
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("JSON \'$.error_description\'=\'missing parameter code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=authorization_code,code=code\' with no redirect_uri")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=authorization_code,code=code\' with no redirect_uri")]
        public void SendGrant_TypeAuthorization_CodeCodeCodeWithNoRedirect_Uri()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=authorization_code,code=code\' with no redirect_uri", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 15
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table222 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table222.AddRow(new string[] {
                            "response_type",
                            "code"});
                table222.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table222.AddRow(new string[] {
                            "state",
                            "state"});
                table222.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table222.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table222.AddRow(new string[] {
                            "scope",
                            "secondScope"});
#line 16
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table222, "When ");
#line hidden
#line 25
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table223 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table223.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table223.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table223.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table223.AddRow(new string[] {
                            "code",
                            "$code$"});
#line 27
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table223, "When ");
#line hidden
#line 34
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("JSON \'$.error_description\'=\'missing parameter redirect_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost,clien" +
            "t_id=firstClient,client_secret=password\' with unauthorized grant_type")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost,clien" +
            "t_id=firstClient,client_secret=password\' with unauthorized grant_type")]
        public void SendGrant_TypeAuthorization_CodeCodeCodeRedirect_UriHttpLocalhostClient_IdFirstClientClient_SecretPasswordWithUnauthorizedGrant_Type()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost,clien" +
                    "t_id=firstClient,client_secret=password\' with unauthorized grant_type", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 39
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 40
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table224 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table224.AddRow(new string[] {
                            "response_type",
                            "code"});
                table224.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table224.AddRow(new string[] {
                            "state",
                            "state"});
                table224.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table224.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table224.AddRow(new string[] {
                            "scope",
                            "secondScope"});
#line 41
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table224, "When ");
#line hidden
#line 50
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table225 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table225.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table225.AddRow(new string[] {
                            "code",
                            "$code$"});
                table225.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost"});
                table225.AddRow(new string[] {
                            "client_id",
                            "firstClient"});
                table225.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 52
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table225, "And ");
#line hidden
#line 60
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 62
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.And("JSON \'$.error_description\'=\'grant type authorization_code is not supported by the" +
                        " client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
            "client_id=thirdClient,client_secret=password\' with previous issued token")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
            "client_id=thirdClient,client_secret=password\' with previous issued token")]
        public void SendGrant_TypeAuthorization_CodeCodeCodeRedirect_UriHttpLocalhost8080Client_IdThirdClientClient_SecretPasswordWithPreviousIssuedToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
                    "client_id=thirdClient,client_secret=password\' with previous issued token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 65
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 66
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table226 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table226.AddRow(new string[] {
                            "response_type",
                            "code"});
                table226.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table226.AddRow(new string[] {
                            "state",
                            "state"});
                table226.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table226.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table226.AddRow(new string[] {
                            "scope",
                            "secondScope"});
#line 67
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table226, "When ");
#line hidden
#line 76
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table227 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table227.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table227.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table227.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table227.AddRow(new string[] {
                            "code",
                            "$code$"});
                table227.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 78
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table227, "And ");
#line hidden
                TechTalk.SpecFlow.Table table228 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table228.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table228.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table228.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table228.AddRow(new string[] {
                            "code",
                            "$code$"});
                table228.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 86
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table228, "And ");
#line hidden
#line 94
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 96
 testRunner.And("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.And("JSON \'$.error_description\'=\'authorization code has already been used, all tokens " +
                        "previously issued have been revoked\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
            "client_id=thirdClient,client_secret=password\' with bad code")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
            "client_id=thirdClient,client_secret=password\' with bad code")]
        public void SendGrant_TypeAuthorization_CodeCodeCodeRedirect_UriHttpLocalhost8080Client_IdThirdClientClient_SecretPasswordWithBadCode()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
                    "client_id=thirdClient,client_secret=password\' with bad code", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 99
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table229 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table229.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table229.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table229.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table229.AddRow(new string[] {
                            "code",
                            "invalidCode"});
                table229.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 100
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table229, "When ");
#line hidden
#line 108
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 110
 testRunner.And("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
 testRunner.And("JSON \'$.error_description\'=\'bad authorization code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
            "client_id=thirdClient,client_secret=password\' with code not issued by the client" +
            "")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
            "client_id=thirdClient,client_secret=password\' with code not issued by the client" +
            "")]
        public void SendGrant_TypeAuthorization_CodeCodeCodeRedirect_UriHttpLocalhost8080Client_IdThirdClientClient_SecretPasswordWithCodeNotIssuedByTheClient()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send \'grant_type=authorization_code,code=code,redirect_uri=http://localhost:8080," +
                    "client_id=thirdClient,client_secret=password\' with code not issued by the client" +
                    "", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 113
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 114
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table230 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table230.AddRow(new string[] {
                            "response_type",
                            "code"});
                table230.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table230.AddRow(new string[] {
                            "state",
                            "state"});
                table230.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table230.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table230.AddRow(new string[] {
                            "scope",
                            "secondScope"});
#line 115
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table230, "When ");
#line hidden
#line 124
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table231 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table231.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table231.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table231.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table231.AddRow(new string[] {
                            "code",
                            "$code$"});
                table231.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:9080"});
#line 126
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table231, "And ");
#line hidden
#line 134
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 135
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 136
 testRunner.And("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 137
 testRunner.And("JSON \'$.error_description\'=\'not the same redirect_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="authorization code cannot be used twice")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "authorization code cannot be used twice")]
        public void AuthorizationCodeCannotBeUsedTwice()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("authorization code cannot be used twice", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 139
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 140
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table232 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table232.AddRow(new string[] {
                            "response_type",
                            "code"});
                table232.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table232.AddRow(new string[] {
                            "state",
                            "state"});
                table232.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table232.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table232.AddRow(new string[] {
                            "scope",
                            "secondScope"});
#line 141
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table232, "When ");
#line hidden
#line 150
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table233 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table233.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table233.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table233.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table233.AddRow(new string[] {
                            "code",
                            "$code$"});
                table233.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 152
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table233, "And ");
#line hidden
                TechTalk.SpecFlow.Table table234 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table234.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table234.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table234.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table234.AddRow(new string[] {
                            "code",
                            "$code$"});
                table234.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 160
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table234, "And ");
#line hidden
#line 168
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 169
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 170
 testRunner.Then("JSON \'error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 171
 testRunner.Then("JSON \'error_description\'=\'authorization code has already been used, all tokens pr" +
                        "eviously issued have been revoked\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="cannot have a mismatch between dpop_jkt and the DPoP proof")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationCodeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "cannot have a mismatch between dpop_jkt and the DPoP proof")]
        public void CannotHaveAMismatchBetweenDpop_JktAndTheDPoPProof()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("cannot have a mismatch between dpop_jkt and the DPoP proof", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 173
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 174
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table235 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table235.AddRow(new string[] {
                            "htm",
                            "POST"});
                table235.AddRow(new string[] {
                            "htu",
                            "https://localhost:8080/token"});
#line 176
 testRunner.When("build DPoP proof", ((string)(null)), table235, "When ");
#line hidden
                TechTalk.SpecFlow.Table table236 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table236.AddRow(new string[] {
                            "response_type",
                            "code"});
                table236.AddRow(new string[] {
                            "client_id",
                            "sixtyFiveClient"});
                table236.AddRow(new string[] {
                            "state",
                            "state"});
                table236.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table236.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table236.AddRow(new string[] {
                            "scope",
                            "secondScope"});
                table236.AddRow(new string[] {
                            "dpop_jkt",
                            "invalid"});
#line 181
 testRunner.And("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table236, "And ");
#line hidden
#line 191
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table237 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table237.AddRow(new string[] {
                            "client_id",
                            "sixtyFiveClient"});
                table237.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table237.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table237.AddRow(new string[] {
                            "code",
                            "$code$"});
                table237.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table237.AddRow(new string[] {
                            "DPoP",
                            "$DPOP$"});
#line 193
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table237, "And ");
#line hidden
#line 202
 testRunner.And("extract header \'DPoP-Nonce\' to \'nonce\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table238 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table238.AddRow(new string[] {
                            "htm",
                            "POST"});
                table238.AddRow(new string[] {
                            "htu",
                            "https://localhost:8080/token"});
                table238.AddRow(new string[] {
                            "nonce",
                            "$nonce$"});
#line 204
 testRunner.And("build DPoP proof", ((string)(null)), table238, "And ");
#line hidden
                TechTalk.SpecFlow.Table table239 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table239.AddRow(new string[] {
                            "client_id",
                            "sixtyFiveClient"});
                table239.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table239.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table239.AddRow(new string[] {
                            "code",
                            "$code$"});
                table239.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table239.AddRow(new string[] {
                            "DPoP",
                            "$DPOP$"});
#line 210
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table239, "And ");
#line hidden
#line 219
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 221
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 222
 testRunner.Then("JSON \'error\'=\'invalid_dpop_proof\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 223
 testRunner.Then("JSON \'error_description\'=\'there is a mismatch between the dpop_jkt and the DPoP p" +
                        "roof\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                AuthorizationCodeGrantTypeErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AuthorizationCodeGrantTypeErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

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
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features.ClientAuths
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ClientSecretJwtAuthenticationErrorsFeature : object, Xunit.IClassFixture<ClientSecretJwtAuthenticationErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ClientSecretJwtAuthenticationErrors.feature"
#line hidden
        
        public ClientSecretJwtAuthenticationErrorsFeature(ClientSecretJwtAuthenticationErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/ClientAuths", "ClientSecretJwtAuthenticationErrors", "\tCheck errors returned during the \'client_secret_jwt\' authentication", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Error is returned when client_assertion is not a JWE token")]
        [Xunit.TraitAttribute("FeatureTitle", "ClientSecretJwtAuthenticationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when client_assertion is not a JWE token")]
        public void ErrorIsReturnedWhenClient_AssertionIsNotAJWEToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when client_assertion is not a JWE token", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table114 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table114.AddRow(new string[] {
                            "iss",
                            "eightClient"});
#line 5
 testRunner.Given("build JWS by signing with a random RS256 algorithm and store the result into \'cli" +
                        "entAssertion\'", ((string)(null)), table114, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table115 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table115.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table115.AddRow(new string[] {
                            "scope",
                            "scope"});
                table115.AddRow(new string[] {
                            "client_id",
                            "eightClient"});
                table115.AddRow(new string[] {
                            "client_assertion_type",
                            "urn:ietf:params:oauth:client-assertion-type:jwt-bearer"});
                table115.AddRow(new string[] {
                            "client_assertion",
                            "$clientAssertion$"});
#line 9
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table115, "When ");
#line hidden
#line 17
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("JSON \'$.error_description\'=\'client assertion must be encrypted JWT (JWE)\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Error is returned when client_assertion is not encrypted with the correct client_" +
            "secret")]
        [Xunit.TraitAttribute("FeatureTitle", "ClientSecretJwtAuthenticationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when client_assertion is not encrypted with the correct client_" +
            "secret")]
        public void ErrorIsReturnedWhenClient_AssertionIsNotEncryptedWithTheCorrectClient_Secret()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when client_assertion is not encrypted with the correct client_" +
                    "secret", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 22
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table116 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table116.AddRow(new string[] {
                            "iss",
                            "eightClient"});
#line 23
 testRunner.Given("build JWS by signing with a random RS256 algorithm and store the result into \'cli" +
                        "entAssertionJws\'", ((string)(null)), table116, "Given ");
#line hidden
#line 27
 testRunner.And("build JWE by encrypting the \'$clientAssertionJws$\' JWS with the client secret \'Pr" +
                        "oEMLh5e_qnzdNA\' and store the result into \'clientAssertionJwe\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table117 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table117.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table117.AddRow(new string[] {
                            "scope",
                            "scope"});
                table117.AddRow(new string[] {
                            "client_id",
                            "eightClient"});
                table117.AddRow(new string[] {
                            "client_assertion_type",
                            "urn:ietf:params:oauth:client-assertion-type:jwt-bearer"});
                table117.AddRow(new string[] {
                            "client_assertion",
                            "$clientAssertionJwe$"});
#line 29
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table117, "When ");
#line hidden
#line 37
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("JSON \'$.error_description\'=\'client assertion cannot be decryted by the client sec" +
                        "ret\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Error is returned when json web token is not signed by the correct Json Web Key")]
        [Xunit.TraitAttribute("FeatureTitle", "ClientSecretJwtAuthenticationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when json web token is not signed by the correct Json Web Key")]
        public void ErrorIsReturnedWhenJsonWebTokenIsNotSignedByTheCorrectJsonWebKey()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when json web token is not signed by the correct Json Web Key", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table118 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table118.AddRow(new string[] {
                            "iss",
                            "eightClient"});
#line 43
 testRunner.Given("build JWS by signing with a random RS256 algorithm and store the result into \'cli" +
                        "entAssertionJws\'", ((string)(null)), table118, "Given ");
#line hidden
#line 47
 testRunner.And("build JWE by encrypting the \'$clientAssertionJws$\' JWS with the client secret \'Pr" +
                        "oEMLh5e_qnzdNU\' and store the result into \'clientAssertionJwe\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table119 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table119.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table119.AddRow(new string[] {
                            "scope",
                            "scope"});
                table119.AddRow(new string[] {
                            "client_id",
                            "eightClient"});
                table119.AddRow(new string[] {
                            "client_assertion_type",
                            "urn:ietf:params:oauth:client-assertion-type:jwt-bearer"});
                table119.AddRow(new string[] {
                            "client_assertion",
                            "$clientAssertionJwe$"});
#line 49
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table119, "When ");
#line hidden
#line 57
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And("JSON \'$.error_description\'=\'client assertion is not signed by a known Json Web Ke" +
                        "y\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Error is returned when iss != sub")]
        [Xunit.TraitAttribute("FeatureTitle", "ClientSecretJwtAuthenticationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when iss != sub")]
        public void ErrorIsReturnedWhenIssSub()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when iss != sub", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 62
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table120 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table120.AddRow(new string[] {
                            "iss",
                            "eightClient"});
                table120.AddRow(new string[] {
                            "sub",
                            "invalid"});
#line 63
 testRunner.Given("build JWS by signing with the key \'eightClientKeyId\' coming from the client \'eigh" +
                        "tClient\' and store the result into \'clientAssertionJws\'", ((string)(null)), table120, "Given ");
#line hidden
#line 68
 testRunner.And("build JWE by encrypting the \'$clientAssertionJws$\' JWS with the client secret \'Pr" +
                        "oEMLh5e_qnzdNU\' and store the result into \'clientAssertionJwe\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table121 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table121.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table121.AddRow(new string[] {
                            "scope",
                            "scope"});
                table121.AddRow(new string[] {
                            "client_id",
                            "eightClient"});
                table121.AddRow(new string[] {
                            "client_assertion_type",
                            "urn:ietf:params:oauth:client-assertion-type:jwt-bearer"});
                table121.AddRow(new string[] {
                            "client_assertion",
                            "$clientAssertionJwe$"});
#line 70
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table121, "When ");
#line hidden
#line 78
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 80
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.And("JSON \'$.error_description\'=\'bad client assertion issuer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Error is returned when aud is invalid")]
        [Xunit.TraitAttribute("FeatureTitle", "ClientSecretJwtAuthenticationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when aud is invalid")]
        public void ErrorIsReturnedWhenAudIsInvalid()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when aud is invalid", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 83
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table122 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table122.AddRow(new string[] {
                            "iss",
                            "eightClient"});
                table122.AddRow(new string[] {
                            "sub",
                            "eightClient"});
                table122.AddRow(new string[] {
                            "aud",
                            "invalid"});
#line 84
 testRunner.Given("build JWS by signing with the key \'eightClientKeyId\' coming from the client \'eigh" +
                        "tClient\' and store the result into \'clientAssertionJws\'", ((string)(null)), table122, "Given ");
#line hidden
#line 90
 testRunner.And("build JWE by encrypting the \'$clientAssertionJws$\' JWS with the client secret \'Pr" +
                        "oEMLh5e_qnzdNU\' and store the result into \'clientAssertionJwe\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table123 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table123.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table123.AddRow(new string[] {
                            "scope",
                            "scope"});
                table123.AddRow(new string[] {
                            "client_id",
                            "eightClient"});
                table123.AddRow(new string[] {
                            "client_assertion_type",
                            "urn:ietf:params:oauth:client-assertion-type:jwt-bearer"});
                table123.AddRow(new string[] {
                            "client_assertion",
                            "$clientAssertionJwe$"});
#line 92
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table123, "When ");
#line hidden
#line 100
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 101
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 102
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 103
 testRunner.And("JSON \'$.error_description\'=\'bad client assertion audiences\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Error is returned when client_assertion is expired")]
        [Xunit.TraitAttribute("FeatureTitle", "ClientSecretJwtAuthenticationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when client_assertion is expired")]
        public void ErrorIsReturnedWhenClient_AssertionIsExpired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when client_assertion is expired", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 105
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table124 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table124.AddRow(new string[] {
                            "iss",
                            "eightClient"});
                table124.AddRow(new string[] {
                            "sub",
                            "eightClient"});
                table124.AddRow(new string[] {
                            "aud",
                            "https://localhost:8080/token"});
#line 106
 testRunner.Given("build expired JWS by signing with the key \'eightClientKeyId\' coming from the clie" +
                        "nt \'eightClient\' and store the result into \'clientAssertionJws\'", ((string)(null)), table124, "Given ");
#line hidden
#line 112
 testRunner.And("build JWE by encrypting the \'$clientAssertionJws$\' JWS with the client secret \'Pr" +
                        "oEMLh5e_qnzdNU\' and store the result into \'clientAssertionJwe\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table125 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table125.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table125.AddRow(new string[] {
                            "scope",
                            "scope"});
                table125.AddRow(new string[] {
                            "client_id",
                            "eightClient"});
                table125.AddRow(new string[] {
                            "client_assertion_type",
                            "urn:ietf:params:oauth:client-assertion-type:jwt-bearer"});
                table125.AddRow(new string[] {
                            "client_assertion",
                            "$clientAssertionJwe$"});
#line 114
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table125, "When ");
#line hidden
#line 122
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 123
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 124
 testRunner.And("JSON \'$.error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 125
 testRunner.And("JSON \'$.error_description\'=\'client assertion is expired\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                ClientSecretJwtAuthenticationErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ClientSecretJwtAuthenticationErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

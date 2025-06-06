﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using FormBuilder.Link;
using FormBuilder.Models;
using FormBuilder.Models.Rules;
using FormBuilder.Models.Transformer;
using FormBuilder.Transformers;
using SimpleIdServer.IdServer.Sms;
using SimpleIdServer.IdServer.Sms.UI.ViewModels;
using SimpleIdServer.IdServer.UI.ViewModels;
using System.Collections.ObjectModel;

namespace FormBuilder.Builders;

public static class StandardSmsRegisterWorkflows
{
    public static string workflowId = "0ba03d04-2990-4153-8484-0cb8092959cd";

    public static WorkflowRecord DefaultWorkflow = WorkflowBuilder.New(workflowId)
        .AddSmsRegistration()
        .Build(DateTime.UtcNow);

    public static WorkflowBuilder AddSmsRegistration(this WorkflowBuilder builder, FormRecord? nextStep = null)
    {
        builder.AddStep(StandardSmsRegisterForms.SmsForm)
            .AddLinkHttpRequestAction(StandardSmsRegisterForms.SmsForm, Constants.EmptyStep, StandardSmsRegisterForms.smsSendConfirmationCodeFormId, "Confirmation code", new WorkflowLinkHttpRequestParameter
            {
                Method = HttpMethods.POST,
                IsAntiforgeryEnabled = true,
                Target = "/{realm}/" + SimpleIdServer.IdServer.Sms.Constants.AMR + "/Register",
                Transformers = new List<ITransformerParameters>
                {
                    new RegexTransformerParameters()
                    {
                        Rules = new ObservableCollection<MappingRule>
                        {
                            new MappingRule { Source = $"$.{nameof(RegisterSmsViewModel.Realm)}", Target = "realm" }
                        }
                    },
                    new RelativeUrlTransformerParameters()
                }
            }, false)
            .AddLinkHttpRequestAction(StandardSmsRegisterForms.SmsForm, nextStep ?? Constants.EmptyStep, StandardSmsRegisterForms.smsRegisterFormId, "Register", new WorkflowLinkHttpRequestParameter
            {
                Method = HttpMethods.POST,
                IsAntiforgeryEnabled = true,
                Target = "/{realm}/" + SimpleIdServer.IdServer.Sms.Constants.AMR + "/Register",
                Transformers = new List<ITransformerParameters>
                {
                    new RegexTransformerParameters()
                    {
                        Rules = new ObservableCollection<MappingRule>
                        {
                            new MappingRule { Source = $"$.{nameof(RegisterSmsViewModel.Realm)}", Target = "realm" }
                        }
                    },
                    new RelativeUrlTransformerParameters()
                }
            }, true)
            .AddTransformedLinkUrlAction(StandardSmsRegisterForms.SmsForm, nextStep ?? Constants.EmptyStep, StandardSmsRegisterForms.backButtonId, "Back", "{returnUrl}", new List<ITransformerParameters>
            {
                new RegexTransformerParameters
                {
                    Rules = new ObservableCollection<MappingRule>
                    {
                        new MappingRule { Source = $"$.{nameof(IRegisterViewModel.ReturnUrl)}", Target = "returnUrl" }
                    }
                }
            }, false);
        return builder;
    }
}

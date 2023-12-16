using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace BlankProcess1
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Testing.API.ITestingService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.Core.Activities.API.ISystemService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace BlankProcess1.ObjectRepository
{
    public static class Descriptors
    {
        public static class Edge__118_31_23_11_8312_webui_servlet_login_app
        {
            public static _Implementation._Edge__118_31_23_11_8312_webui_servlet_login_app.__Edge__118_31_23_11_8312_webui_servlet_login Edge__118_31_23_11_8312_webui_servlet_login { get; private set; } = new _Implementation._Edge__118_31_23_11_8312_webui_servlet_login_app.__Edge__118_31_23_11_8312_webui_servlet_login();
        }
    }
}

namespace BlankProcess1._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _Edge__118_31_23_11_8312_webui_servlet_login_app._Edge__118_31_23_11_8312_webui_servlet_login
    {
        public class __密码 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __密码(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "MDqXzkhV4Eq1udG-jWe5iw/uSxkaOR4akGJhHy5U_PJDg", DisplayName = "密码", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Edge__118_31_23_11_8312_webui_servlet_login_app._Edge__118_31_23_11_8312_webui_servlet_login
    {
        public class __用户名 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __用户名(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "MDqXzkhV4Eq1udG-jWe5iw/1NgkLNxnnkShAY3nDeNZOg", DisplayName = "用户名", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Edge__118_31_23_11_8312_webui_servlet_login_app
    {
        public class __Edge__118_31_23_11_8312_webui_servlet_login : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Edge__118_31_23_11_8312_webui_servlet_login()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "MDqXzkhV4Eq1udG-jWe5iw/u4qYh7kWaESkPmwSu68zJw", DisplayName = "Edge: 118.31.23.11:8312/webui/servlet/login", Screen = this};
                密码 = new _Implementation._Edge__118_31_23_11_8312_webui_servlet_login_app._Edge__118_31_23_11_8312_webui_servlet_login.__密码(this, null);
                用户名 = new _Implementation._Edge__118_31_23_11_8312_webui_servlet_login_app._Edge__118_31_23_11_8312_webui_servlet_login.__用户名(this, null);
            }

            public _Implementation._Edge__118_31_23_11_8312_webui_servlet_login_app._Edge__118_31_23_11_8312_webui_servlet_login.__密码 密码 { get; private set; }

            public _Implementation._Edge__118_31_23_11_8312_webui_servlet_login_app._Edge__118_31_23_11_8312_webui_servlet_login.__用户名 用户名 { get; private set; }
        }
    }
}
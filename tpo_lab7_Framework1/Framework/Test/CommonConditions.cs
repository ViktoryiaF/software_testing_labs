﻿using System;
using System.IO;
using Framework.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using Framework.PageObject;
using NUnit.Framework.Interfaces;


namespace Framework.Test
{
    public class CommonConditions: TestListener
    {
        protected IWebDriver Driver;
     //   const string StartPage = "https://tickets.by/gd";

        [SetUp]
        public void OpenBrowser()
        {
            Driver = DriverSingleton.GetDriver();
        }

        [TearDown]
        public void CloseBrowser()
        {
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
                TestListener.OnTestFailure();

            if (TestContext.CurrentContext.Result.Outcome == ResultState.Success)
                TestListener.OnTestSuccess();

            DriverSingleton.CloseDriver();
        }
    }
}

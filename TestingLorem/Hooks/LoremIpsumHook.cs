﻿using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestingLorem.Drivers;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestingLorem.Hooks
{
    [Binding]
    public sealed class LoremIpsumHook: LoremIpsumDriver
    {
        private LoremIpsumDriver ipsumDriver;
        public LoremIpsumHook(LoremIpsumDriver loremIpsumDriver)
        {
            ipsumDriver = loremIpsumDriver;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");

            new DriverManager().SetUpDriver(new ChromeConfig());

            ipsumDriver.Driver = new ChromeDriver(options);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            ipsumDriver.Driver.Quit();
        }
    }
}

﻿using System.Collections.Generic;
using JDI.Core.Interfaces.Complex;
using JDI.Core.Settings;
using JDI.Matchers.NUnit;
using JDI.UIWebTests.Enums;
using JDI.UIWebTests.UIObjects;
using NUnit.Framework;

namespace JDI.UIWebTests.Tests.Complex
{
    public class DropdownExpandedTests
    {
        private static readonly IList<string> ColorsOptions = new List<string>
            {"Colors", "Red", "Green", "Blue", "Yellow"};

        private IDropDown<Colors> _colors()
        {
            return TestSite.MetalsColorsPage.Colors;
        }

        [SetUp]
        public void SetUp()
        {
            JDISettings.Logger.Info("Navigating to Metals and Colors page.");
            TestSite.MetalsColorsPage.Open();
            TestSite.MetalsColorsPage.CheckTitle();
            TestSite.MetalsColorsPage.IsOpened();
            _colors().Expand();
            JDISettings.Logger.Info("Setup method finished");
            JDISettings.Logger.Info("Start test: " + TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void SelectStringTest()
        {
            _colors().Select("Blue");
            CommonActionsData.CheckAction("Colors: value changed to Blue");
        }
        
        [Test]
        public void SelectIndexTest()
        {
            _colors().Select(4);
            CommonActionsData.CheckAction("Colors: value changed to Blue");
        }
        
        [Test]
        public void SelectEnumTest()
        {
            _colors().Select(Colors.Blue);
            CommonActionsData.CheckAction("Colors: value changed to Blue");
        }

        [Test]
        public void GetOptionsTest()
        {
            new Check().CollectionEquals(_colors().Options, ColorsOptions);
        }

        [Test]
        public void GetNamesTest()
        {
            new Check().CollectionEquals(_colors().Names, ColorsOptions);
        }

        [Test]
        public void GetValuesTest()
        {
            new Check().CollectionEquals(_colors().Values, ColorsOptions);
        }

        [Test]
        public void GetOptionsAsTextTest()
        {
            new Check().AreEquals(_colors().OptionsAsText, "Colors, Red, Green, Blue, Yellow");
        }

        [Test]
        public void SetValueTest()
        {
            _colors().Value = "Blue";
            CommonActionsData.CheckAction("Colors: value changed to Blue");
        }

        [Test]
        public void GetNameTest()
        {
            new Check().AreEquals(_colors().Name, "Colors");
        }

        [Test]
        public void GetSelectedTest()
        {
            new Check().AreEquals(_colors().Selected(), "Colors");
        }

        [Test]
        public void GetValueTest()
        {
            new Check().AreEquals(_colors().Value, "Colors");
        }
    }
}
﻿using System.Globalization;
using JDI.Light.Asserts;
using JDI.Light.Elements.Base;
using JDI.Light.Interfaces.Common;
using OpenQA.Selenium;

namespace JDI.Light.Elements.Common
{
    public class NumberSelector : UIElement, INumberSelector
    {
        protected NumberSelector(By byLocator) : base(byLocator)
        {
        }

        public string Placeholder => GetAttribute("placeholder");

        public double Min => double.Parse(GetAttribute("min"), CultureInfo.InvariantCulture);

        public double Max => double.Parse(GetAttribute("max"), CultureInfo.InvariantCulture);

        public double Value => double.Parse(GetAttribute("value"), CultureInfo.InvariantCulture);

        public double Step => double.Parse(GetAttribute("step"), CultureInfo.InvariantCulture);

        public void SetNumber(double number, bool checkEnabled = true)
        {
            CheckEnabled(checkEnabled);
            Clear();
            SendKeys(number.ToString(CultureInfo.InvariantCulture));
        }

        public new NumberAssert Is() => new NumberAssert(this);
        public new NumberAssert AssertThat() => Is();
    }
}
﻿using JDI.Core.Attributes;
using JDI.Core.Interfaces.Common;
using JDI.Core.Selenium.Elements.Complex;
using JDI.Core.Selenium.Elements.Composite;
using JDI.Light.Tests.Enums;

namespace JDI.Light.Tests.UIObjects.Sections
{
    public class Summary : Section
    {
        // Exception in CascadeInit
        //[FindBy(Css = "#odds-selector p")]
        //public Selector<Odds> OddNumbersSelector;

        [FindBy(Id = "calculate-button")] public IButton Calculate;

        [FindBy(Css = "#odds-selector p")] public RadioButtons<Odds> OddNumbers;
    }
}
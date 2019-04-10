﻿using System;
using JDI.Light.Interfaces.Common;
using OpenQA.Selenium;

namespace JDI.Light.Elements.Common
{
    public class DataList : Selector, IDataList
    {
        public DataList(By byLocator) : base(byLocator)
        {
        }
        
        public void Select(string text)
        {
            SetText(text);
        }

        public void Select(Enum value)
        {
            SetText(value.ToString());
        }

        public void Select(int index)
        {
            // TODO: Select by index
        }

        public string GetValue()
        {
            return WebElement.GetAttribute("value");
        }

        private void SetText(string text)
        {
            var str = "value='" + text + "'";
            JsExecutor.ExecuteScript("arguments[0]." + str + ";", WebElement);
        }
    }
}
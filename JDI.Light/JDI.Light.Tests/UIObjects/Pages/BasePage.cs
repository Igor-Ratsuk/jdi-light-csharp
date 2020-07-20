﻿using JDI.Light.Attributes;
using JDI.Light.Elements.Composite;
using JDI.Light.Interfaces.Common;
using JDI.Light.Tests.UIObjects.Forms;
using JDI.Light.Tests.UIObjects.Sections;

namespace JDI.Light.Tests.UIObjects.Pages
{
    public class BasePage : WebPage
    {
        [FindBy(Css = ".uui-header")]
        public static  readonly Header Header;

        [FindBy(Css = ".footer-content")]
        public static readonly Footer Footer;

        [FindBy(Id = "login-form")]
        public LoginForm LoginForm;

        [FindBy(XPath = ".//div[@class='logout']/button")]
        public IButton LogoutButton;

        [FindBy(Css = "a>div.profile-photo")]
        public IButton Profile { get; set; }
    }
}
﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace UnicornProject.Framework.Selenium
{
    public class Element : IWebElement
    {
        private readonly IWebElement _element;

        public readonly string Name;

        public By FoundBy { get; set; }

        public IWebElement Current => _element ?? throw new NullReferenceException("_element is null!");

        public Element(IWebElement element, string name)
        {
            _element = element;
            Name = name;
        }

        public string TagName => Current.TagName;

        public string Text => Current.Text;

        public bool Enabled => Current.Enabled;

        public bool Selected => Current.Selected;

        public Point Location => Current.Location;

        public Size Size => Current.Size;

        public bool Displayed => Current.Displayed;

        public void Clear()
        {
            Current.Click();
        }

        public void Click()
        {
            FW.Log.Step($"Click {Name}");
            Current.Click();
        }

        public IWebElement FindElement(By by)
        {
            return Current.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return Current.FindElements(by);
        }

        public string GetAttribute(string attributeName)
        {
            return Current.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return Current.GetCssValue(propertyName);
        }

        public string GetProperty(string propertyName)
        {
            return Current.GetProperty(propertyName);
        }

        public void SendKeys(string text)
        {
            FW.Log.Step($"Set {Name}");
            Current.SendKeys(text);
        }

        public void Submit()
        {
            Current.Submit();
        }
    }
}

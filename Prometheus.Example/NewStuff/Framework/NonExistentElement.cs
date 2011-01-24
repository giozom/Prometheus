using System;
using System.Collections.Generic;

namespace Prometheus.Example.NewStuff.Framework
{
    public class NonExistentElement : IHtmlElement
    {
        private readonly string _selector;

        public NonExistentElement(string cssSelector)
        {
            _selector = cssSelector;
        }

        public bool Exists
        {
            get { return false; }
        }

        public string Source
        {
            get { throw ElementDoesNotExistsException(); }
        }

        public string Href
        {
            get { throw ElementDoesNotExistsException(); }
        }

        public bool IsChecked
        {
            get { throw ElementDoesNotExistsException(); }
        }

        public bool Visible
        {
            get { return false; }
        }

        public string Text
        {
            get { throw ElementDoesNotExistsException(); }
        }

        public string Value
        {
            get { throw ElementDoesNotExistsException(); }
        }

        public void Click()
        {
            throw ElementDoesNotExistsException();
        }

        public void Clear()
        {
            throw ElementDoesNotExistsException();
        }

        public void Type(string text)
        {
            throw ElementDoesNotExistsException();
        }

        public void ShiftFocus()
        {
            throw ElementDoesNotExistsException();
        }

        public void Select()
        {
            throw ElementDoesNotExistsException();
        }

        public void MouseOver()
        {
            throw ElementDoesNotExistsException();
        }

        public IHtmlElement GetElement(string cssSelector)
        {
            throw ElementDoesNotExistsException();
        }

        public IEnumerable<IHtmlElement> GetElements(string cssSelector)
        {
            throw ElementDoesNotExistsException();
        }

        private Exception ElementDoesNotExistsException()
        {
            return new Exception(string.Format("The element \'{0}\' does not exists.", _selector));
        }
    }
}
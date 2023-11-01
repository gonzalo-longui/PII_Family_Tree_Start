using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class Visitor
    {
        public string Content
        {
            get
            {
                return this.VisitorContent;
            }
        }

        protected string VisitorContent { get; set; } = "0";

        public abstract void Visit(Person person);
    }
}
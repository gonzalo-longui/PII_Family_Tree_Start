using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class AgeVisitor : Visitor
    {
        public override void Visit(Person person)
        {
            this.VisitorContent = (Int32.Parse(this.VisitorContent) + person.Age).ToString();
        }
    }
}
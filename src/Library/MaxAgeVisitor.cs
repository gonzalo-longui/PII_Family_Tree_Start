using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class MaxAgeVisitor : Visitor
    {
        public override void Visit(Person person)
        {
            if (person.Age > int.Parse(VisitorContent))
            {
                this.VisitorContent = person.Age.ToString();
            }
        }
    }
}
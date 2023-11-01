using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class MaxNameLengthVisitor : Visitor
    {
        public override void Visit(Person person)
        {
            if (person.Name.Length > int.Parse(VisitorContent))
            {
                this.VisitorContent = person.Name.Length.ToString();
            }
        }
    }
}
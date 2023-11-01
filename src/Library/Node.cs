using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;
        public Person person;

        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number, Person person1)
        {
            this.number = number;
            this.person = person1;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
    }
}

using System;
using System.Runtime.InteropServices;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("name1", 10);
            Person p2 = new Person("name2", 20);
            Person p3 = new Person("name3", 30);
            Person p4 = new Person("name4", 40);
            Person p5 = new Person("name5", 50);
            Person p6 = new Person("name6", 60);
            Person p7 = new Person("name7", 70);
            Person p8 = new Person("reallylongname", 80);
            Node n1 = new Node(1, p1);
            Node n2 = new Node(2, p2);
            Node n3 = new Node(3, p3);
            Node n4 = new Node(4, p4);
            Node n5 = new Node(5, p5);
            Node n6 = new Node(6, p6);
            Node n7 = new Node(7, p7);
            Node n8 = new Node(7, p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            AgeVisitor ageVisitor = new AgeVisitor();
            ageVisitor.Visit(n1.person);
            ageVisitor.Visit(n2.person);
            ageVisitor.Visit(n3.person);
            ageVisitor.Visit(n4.person);
            ageVisitor.Visit(n5.person);
            ageVisitor.Visit(n6.person);
            ageVisitor.Visit(n7.person);
            ageVisitor.Visit(n8.person);

            MaxAgeVisitor maxAgeVisitor = new MaxAgeVisitor();
            maxAgeVisitor.Visit(n1.person);
            maxAgeVisitor.Visit(n2.person);
            maxAgeVisitor.Visit(n3.person);
            maxAgeVisitor.Visit(n4.person);
            maxAgeVisitor.Visit(n5.person);
            maxAgeVisitor.Visit(n6.person);
            maxAgeVisitor.Visit(n7.person);
            maxAgeVisitor.Visit(n8.person);

            MaxNameLengthVisitor maxNameLengthVisitor = new MaxNameLengthVisitor();
            maxNameLengthVisitor.Visit(n1.person);
            maxNameLengthVisitor.Visit(n2.person);
            maxNameLengthVisitor.Visit(n3.person);
            maxNameLengthVisitor.Visit(n4.person);
            maxNameLengthVisitor.Visit(n5.person);
            maxNameLengthVisitor.Visit(n6.person);
            maxNameLengthVisitor.Visit(n7.person);
            maxNameLengthVisitor.Visit(n8.person);

            Console.WriteLine(ageVisitor.Content);
            Console.WriteLine(maxAgeVisitor.Content);
            Console.WriteLine(maxNameLengthVisitor.Content);
        }
    }
}

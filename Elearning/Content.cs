// https://docs.google.com/document/d/1YxpUHX84ZBY6UILHctzRWywnt7bWSSup4JTn6Or4p-k/edit?usp=sharing 
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Content
    {
        public string Name { get ; }
        public string Author { get ; }

        public Content(string name, string author)
        {
            Name = name;
            Author = author;
        }
    }
}

// https://docs.google.com/document/d/1YxpUHX84ZBY6UILHctzRWywnt7bWSSup4JTn6Or4p-k/edit?usp=sharing 
using Microsoft.VisualBasic;
using System;

namespace Elearning
{
    public class Content
    {
        private readonly string name;
        private readonly string author;
        public Content(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
    }
}
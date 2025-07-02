using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAndSolidPrinciples
{
    //Document class
    public abstract class Document
    {
        //properties
        public string FileName { get; set; }

        //constructor
        public Document(string fileName)
        {
            FileName = fileName;
        }
        //abstract methods
        public abstract void OpeningTheDocument();
        public abstract void ReadContentOfTheDocument();
        public abstract void PrintTheDocument();
    }

    //PdfDocument class that inherits the parent document class
    public class PdfDocument : Document
    {
        //contructor
        public PdfDocument(string fileName) : base(fileName) { }

        //method to open the file document
        public override void OpeningTheDocument()
        {
            Console.WriteLine($"Opening PDF document: {FileName}");
        }
        //method to read the content in the file document

        public override void ReadContentOfTheDocument()
        {
            Console.WriteLine("Reading content from PDF...");
        }
        //method to print the document

        public override void PrintTheDocument()
        {
            Console.WriteLine("Printing PDF document...");
        }
    }

    //word document class that inherits document parent class
    public class WordDocument : Document
    {
        public WordDocument(string fileName) : base(fileName) { }

        //method to open the file document
        public override void OpeningTheDocument()
        
        {
            Console.WriteLine($"Opening Word document: {FileName}");
        }
        //method to read the content in the file document

        public override void ReadContentOfTheDocument()
        {
            Console.WriteLine("Reading content from Word document...");
        }

        //method to print the document
        public override void PrintTheDocument()
        {
            Console.WriteLine("Printing Word document...");
        }

    }
    }

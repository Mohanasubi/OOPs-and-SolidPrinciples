using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Document
    {
        public string FileName { get; set; }

        public Document(string fileName)
        {
            FileName = fileName;
        }

        public abstract void open();
        public abstract void readContent();
        public abstract void print();
    }

    public class PdfDocument : Document
    {
        public PdfDocument(string fileName) : base(fileName) { }

        public override void open()
        {
            Console.WriteLine($"Opening PDF document: {FileName}");
        }

        public override void readContent()
        {
            Console.WriteLine("Reading content from PDF...");
        }

        public override void print()
        {
            Console.WriteLine("Printing PDF document...");
        }
    }

    public class WordDocument : Document
    {
        public WordDocument(string fileName) : base(fileName) { }

        public override void open()
        {
            Console.WriteLine($"Opening Word document: {FileName}");
        }

        public override void readContent()
        {
            Console.WriteLine("Reading content from Word document...");
        }

        public override void print()
        {
            Console.WriteLine("Printing Word document...");
        }

    }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art
{

    public class Painting
    {
        public String Name { get; set; }
        public DateTime CreationDate { get; set; }
        public float Price { get; set; }
        private bool IsExhibited = true;
        private bool IsExisting = true;
        private string Answer = "yes";

        public Painting(string name, DateTime creationDate, float price)
        {
            Name = name;
            CreationDate = creationDate;
            Price = price;
        }

        private void ExistingWarning()
        {
            if(!IsExisting)
            {
                Console.WriteLine("Do you want to add a new painting?");
                Answer = Console.ReadLine();
                if (Answer == "yes") Console.WriteLine("New painting added successfully");
            }
        }

        private void ExhibitedWarning()
        {
            if (!IsExhibited)
            {
                Console.WriteLine("This painting is acrhived. Do you want to add it to the exhibition?");
                Answer = Console.ReadLine();
                if (Answer == "yes") Console.WriteLine($"Painting {Name} added to the exhibition successfully");
            }
        }

        public void PaintingInfo()
        {
            ExistingWarning();
            ExhibitedWarning();
            Console.WriteLine($"This is a painting called {Name} in cost {Price} created at {CreationDate}");
        }
    }

    public class Genre
    {
        public String Name { get; set; }
        public String Description { get; set; }

        public Genre(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void GenreInfo()
        {
            Console.WriteLine($"Info about genre: ");
        }
    }

    public class Landscape : Genre
    {
        public Landscape(string name, string description)
            : base(name, description)
        {
            Name = name;
            Description = description;
        }

        public override void GenreInfo()
        {
            base.GenreInfo();
            Console.WriteLine($"This is a genre called {Name} about {Description}");
        }
    }

    public class Portrait : Genre
    {
        public Portrait(string name, string description)
            : base(name, description)
        {
            Name = name;
            Description = description;
        }

        public override void GenreInfo()
        {
            base.GenreInfo();
            Console.WriteLine($"This is a genre called {Name} about {Description}");
        }
    }

    public class History : Genre
    {
        public History(string name, string description)
            : base(name, description)
        {
            Name = name;
            Description = description;
        }

        public override void GenreInfo()
        {
            base.GenreInfo();
            Console.WriteLine($"This is a genre called {Name} about {Description}");
        }
    }

    public class Impressionism : Genre
    {
        public Impressionism(string name, string description)
            : base(name, description)
        {
            Name = name;
            Description = description;
        }

        public override void GenreInfo()
        {
            base.GenreInfo();
            Console.WriteLine($"This is a genre called {Name} about {Description}");
        }
    }

    public class Seascape : Genre
    {
        public Seascape(string name, string description)
            : base(name, description)
        {
            Name = name;
            Description = description;
        }

        public override void GenreInfo()
        {
            base.GenreInfo();
            Console.WriteLine($"This is a genre called {Name} about {Description}");
        }
    }

    public class Painter
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Country { get; set; }

        public Painter(string name, string surname, string country)
        {
            Name = name;
            Surname = surname;
            Country = country;
        }

        public void PainterInfo()
        {
            Console.WriteLine($"Painter {Surname} {Name} was born in {Country}");
        }
    }

    public class Hall
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public String Name { get; set; }

        public Hall(int height, int width, string name)
        {
            Height = height;
            Width = width;
            Name = name;
        }

        public void HallInfo()
        {
            Console.WriteLine($"{Name} hall height is {Height}, width {Width}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Genre Landscape = new Landscape("Landscape", "Description");
            Genre Portrait = new Portrait("Portrait", "");
            Genre History = new History("History", "");
            Genre Impressionism = new Impressionism("Impressionism", "");
            Genre Seascape = new Seascape("Seascape", "");

            Landscape.GenreInfo();
            Portrait.GenreInfo();
            History.GenreInfo();
            Impressionism.GenreInfo();
            Seascape.GenreInfo();

            Console.ReadKey();
        }
    }
}

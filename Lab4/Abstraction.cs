using System;

namespace Lab4
{
    public abstract class Abstraction
    {
        protected string name;//назва компанії
        protected string location;//місце знаходження
        protected string activity;//сфера діяльності

        public Abstraction()
        {
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Location: ");
            location = Console.ReadLine();
            Console.Write("Activity: ");
            activity = Console.ReadLine();
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Location
        {
            get => location;
            set => location = value;
        }

        public string Activity
        {
            get => activity;
            set => activity = value;
        }
    }
}
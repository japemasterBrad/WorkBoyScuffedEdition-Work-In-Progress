using System;
using System.Collections;


namespace WorkBoyScuffedEdition
{
    public class Phonebook
    {
        public string Name { get; set; }
        public int Number { get; set; }
        
        ArrayList phoneBookNames = new ArrayList();
        ArrayList phoneBookNumbers = new ArrayList();

        public Phonebook(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public void phoneBookInsert()
        {
            phoneBookNames.Add(Name);
            phoneBookNumbers.Add(Number);
        }
    }
}


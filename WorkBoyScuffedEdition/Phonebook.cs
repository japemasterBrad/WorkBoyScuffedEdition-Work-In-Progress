using System;
using System.Collections;


namespace WorkBoyScuffedEdition
{
    public class Phonebook
    {
        //public string Name { get; set; }
        //public int Number { get; set; }
        
        public ArrayList phoneBookNames = new ArrayList();
        public ArrayList phoneBookNumbers = new ArrayList();

        
        public void PhoneBookInsert(string Name, long Number)
        {
            phoneBookNames.Add(Name);
            phoneBookNumbers.Add(Number);
        }

    }
}


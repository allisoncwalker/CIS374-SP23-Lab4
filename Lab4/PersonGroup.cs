

namespace Lab4
{
    public class PersonGroup
    {
        public List<Person> Persons { get; set; } = new List<Person>();

        public char? StartingLetter {
            get {
                // if Persons is SORTED
                return Persons[0].FirstName[0];
            }
        }

        // Finished
        public char? EndingLetter
        {
            get
            {
                return Persons[0].FirstName[-1];
            }
        }

        public int Count => Persons.Count;

        public Person this[int i]
        {
            get
            {
                if (Persons == null)
                    throw new NullReferenceException("Persons is null");

                if (i < 0 || i > Persons.Count)
                    throw new IndexOutOfRangeException();

                Persons.Sort();
                return Persons[i];
            }
        }

        public PersonGroup(List<Person> persons = null)
        {
            if( persons != null)
            {
                foreach(var p in persons)
                {
                    Persons.Add(p);
                }
            }

            Persons.Sort();
        }

        public override string ToString()
        {
            return "[" + String.Join(", ", Persons)+ "]";
        }


        // Finished ?
        public static List<PersonGroup> GeneratePersonGroups(List<Person> persons, int distance)
        {
            persons.Sort();

            var personGroups = new List<PersonGroup>();

            var Groupon = new PersonGroup();

            // This isn't correct code. 
            // It's is just a sample of how to interact with the classes.
            //var group1 = new PersonGroup();
            //var group2 = new PersonGroup();

            foreach (Person person in persons)
            {
                if (Groupon = 0)
                {
                    Groupon.Persons.Add(person); 
                }
                else if(person.Distance(Groupon[0]) <= distance)
                {
                    Groupon.Persons.Add(person);
                }
                else
                {
                    personGroups.Add(Groupon);
                    Groupon = new PersonGroup();
                    Groupon.Persons.Add(person);

                }
            }

            //personGroups.Add(Groupon);
            //Groupon = new PersonGroup();
            //Groupon.Persons.Add(person);
          

            return personGroups;
        }

    }
}

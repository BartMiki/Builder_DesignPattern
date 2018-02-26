namespace Proxy_DesignPattern
{
    public class ResponsiblePerson
    {
        private readonly Person _person;

        public ResponsiblePerson(Person person)
        {
            _person = person;
        }

        public int Age
        {
            get => _person.Age;
            set => _person.Age = value;
        }

        public string Drink()
        {
            return   Age < 18 ? "too young" : _person.Drink();
        }

        public string Drive()
        {
            return  Age < 16 ? "too young" : _person.Drive();
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }
    }
}
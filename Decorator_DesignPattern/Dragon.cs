namespace Decorator_DesignPattern
{
    public class Dragon // no need for interfaces
    {
        private Lizard _lizard = new Lizard();
        private Bird _bird = new Bird();

        public int Age
        {
            get { return _bird.Age; }
            set
            {
                _bird.Age = value;
                _lizard.Age = value;
            }
        }

        public string Fly()
        {
            return _bird.Fly();
        }

        public string Crawl()
        {
            return _lizard.Crawl();
        }
    }
}
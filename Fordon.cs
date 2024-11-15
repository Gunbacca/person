namespace person
{
    public class Fordon
    {
        private string tillverkare;
        private string model;
        private string adress;

        public Fordon(string t,string m,string a)
        {
            tillverkare=t;
            model=m;
            adress=a;
        }

        public string Tillverkare
        {
            get {return tillverkare;}
            set {tillverkare=value;}
        }
        public string Model
        {
        get {return model;}
        set {model = value;}
        }
        public string Adress{
            get {return adress;}
            set {adress = value;}
        }
    }
}
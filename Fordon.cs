namespace person
{
    public class Fordon
    {
        private string tillverkare;
        private string model;
        private string adress;

        public void settillverkare(string t) {tillverkare = t;}
        public string gettillverkare() {return tillverkare;}
        public void setmodel(string m) {model = m;}
        public string getmodel() {return model;}
        public void setadress(string a) {adress = a;}
        public string getsadress() {return adress;}


    }
}
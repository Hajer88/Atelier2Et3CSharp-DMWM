namespace Atelier2Et3CSharp_DMWM
{
    public class Lampe
    {
        public bool allume;
        public Lampe()
        {
            allume = false;
        }
        public void allumer()
        {
            allume = true;
        }
        public void eteindre()
        {
            allume = false;
        }
    }
}
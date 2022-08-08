using System;

namespace MockEsim
{
    public class Koira
    {
        private string nimi;
        private int ika;
        private Koira emo;
        private Koira isa;


        public static Koira pennunTeko(Koira m, Koira f)
        {
            Koira pentu = new Koira();
            if(!(m.onSukuKypsä() && f.onSukuKypsä()))
            {
                throw new ArgumentException();
            }

            return pentu;
        }

        public virtual Boolean onSukuKypsä()
        {
            throw new NotImplementedException();
        }
    }
}

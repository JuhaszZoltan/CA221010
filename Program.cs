namespace CA221010
{
    public class Allat
    {
        public string Nev { get; set; }
        public float Suly { get; private set; } = 0f;
        public virtual string HangotAdKi() => "valami - valami";
        public void Taplalkozik(float kgKaja) => Suly += kgKaja;
    }

    public class Macska : Allat
    {
        public int EletekSzama { get; set; } = 9;
        public new string HangotAdKi() => "miaú - miaú";
    }

    public class Kutya : Allat
    {
        public bool Huseges { get; set; } = true;

        public override string HangotAdKi()
        {
            return "vau - vau";
        }
    }

    internal class Program
    {
        static void Main()
        {
            #region jegyzet
            // ENCAPSULATION
            //  - logikailag összetartozó dolgok (fields, methods) egy egységbe vannak zárva
            //  - a helyes állapotért ez az egység felel
            // INHERITANCE
            //  - elsősorban az osztályok "továbbfejleszthetőség"ének lehetősége
            //  - a child class MINDENT örököl a parent-től
            //  - el tudja "fedni" az eredeti metódust, ha azonos a fejléce
            //  de a régi 'örökölt' nem "tűnik el" (korai kötés)
            // POLIMORFISM
            //  - az ősosztály példányai képesek használni
            //  a gyermekosztály metódusait is, megfelelő körülmények között
            //  (késői kötés)
            #endregion

            Allat allat = new Allat()
            {
                Nev = "Gertrúd",
            };

            Macska macska = new Macska()
            {
                Nev = "Lukrécia",
                EletekSzama = 7,
            };

            Kutya kutya = new Kutya()
            {
                Nev = "Bodri",
            };

            Console.WriteLine($"{allat.Nev} mondja: {allat.HangotAdKi()}");
            Console.WriteLine($"{macska.Nev} mondja: {macska.HangotAdKi()}");
            Console.WriteLine($"{kutya.Nev} mondja: {kutya.HangotAdKi()}");

            kutya.Taplalkozik(3.5f);
            Console.WriteLine($"{kutya.Nev} {kutya.Suly} Kg");


            List<Allat> allatok = new List<Allat>();

            allatok.Add(allat);
            allatok.Add(macska);
            allatok.Add(kutya);

            Console.WriteLine("<Allat> lista bejárása:");
            foreach (Allat a in allatok)
            {
                Console.WriteLine($"{a.Nev} mondja: {a.HangotAdKi()}");

                if (a is Macska) Console.WriteLine((a as Macska).HangotAdKi());
            }


            Allat valami_1 = new Kutya();
            Console.WriteLine(valami_1.HangotAdKi());

            Allat valami_2 = new Macska();
            Console.WriteLine((valami_2 as Macska).HangotAdKi());

            //Macska valami_3 = new Allat();

            //abstract
            //interface
            //ctor hívási lánc
            //static
            //is, as


        }
    }
}
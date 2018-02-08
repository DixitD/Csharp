using System;


namespace Prime_Minister
{
        class PrimeMinister
        {
            public string name;
            public string year;

            public PrimeMinister(string name, string year)
            {
                this.name = name;
                this.year = year;
            }

            public override string ToString()
            {
                return String.Format("{0}, {1}", name, year);
            }
        }
}

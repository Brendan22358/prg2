using System;
using System.IO;

namespace prg2._4_functional_programming
{
    public class csv_reader
    {
        csv_reader sr = new csv_reader("C:\\roster.csv");
        private string v;

        public csv_reader(string v)
        {
            this.v = v;
        }
    }
}
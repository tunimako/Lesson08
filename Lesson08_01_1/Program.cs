// ** 1 UŽDUOTIS **

//Sukurti struktūrą Saskaita. Public laukai gavejas , siuntejas, moketiViso, saskaitosNumeris.
//Visi laukai tik skaitymui, perduodami per konstruktorių išskyrus saskaitosNumeris , jis generuojasi automatiškai konstruktoriuje (NR_metai_menuo_diena_01)

using System;

namespace Lesson08_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saskaita uzMaista = new Saskaita("", "", 1);
            Console.WriteLine(uzMaista.SaskaitosNumeris);
        }
    }
}

using System;
using HtmlAgilityPack;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using FinParser;

namespace Fin_pars
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            HtmlDocument html = new HtmlDocument();


            for (int i = 0; ;i++)
            {
                Console.WriteLine("SBER : " + FinParser.Parse.NowPrice("SBER.ME", ref wc, ref html) + " : " + DateTime.Now);
                Console.WriteLine("GAZP : " + FinParser.Parse.NowPrice("GAZP.ME", ref wc, ref html) + " : " + DateTime.Now);
                Console.WriteLine("TSLA : " + FinParser.Parse.NowPrice("TSLA", ref wc, ref html) + " : " + DateTime.Now);
                Console.WriteLine("ALRS : " + FinParser.Parse.NowPrice("ALRS.ME", ref wc, ref html) + " : " + DateTime.Now);
            }
            
            Console.ReadLine();

        }
    }
}

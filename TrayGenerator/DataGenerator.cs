using System;

namespace TrayGenerator
{
    public static class DataGenerator
    {
        public static string InnIp
        {
            get
            {
                var r = new Random();
                var inn = new int[12];
                do
                {
                    inn[0] = r.Next(10);
                    inn[1] = r.Next(10);
                }
                while (inn[0] + inn[1] == 0);

                for (var i = 2; i < 10; i++)
                {
                    inn[i] = r.Next(10);
                }
                inn[10] = (inn[0] * 7 + inn[1] * 2 + inn[2] * 4 + inn[3] * 10 + inn[4] * 3 + inn[5] * 5 + inn[6] * 9 + inn[7] * 4 + inn[8] * 6 + inn[9] * 8) % 11;
                if (inn[10] == 10) { inn[10] = 0; }
                inn[11] = (inn[0] * 3 + inn[1] * 7 + inn[2] * 2 + inn[3] * 4 + inn[4] * 10 + inn[5] * 3 + inn[6] * 5 + inn[7] * 9 + inn[8] * 4 + inn[9] * 6 + inn[10] * 8) % 11;
                if (inn[11] == 10) { inn[11] = 0; }

                var innString = "";
                for (var i = 0; i < 12; i++)
                {
                    innString += inn[i].ToString();
                }

                return innString;
            }
        }
    }
}

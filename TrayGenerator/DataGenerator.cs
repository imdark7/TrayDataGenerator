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
                } while (inn[0] + inn[1] == 0);

                for (var i = 2; i < 10; i++)
                {
                    inn[i] = r.Next(10);
                }
                inn[10] = ((inn[0] * 7 + inn[1] * 2 + inn[2] * 4 + inn[3] * 10 + inn[4] * 3 + inn[5] * 5 + inn[6] * 9 + inn[7] * 4 + inn[8] * 6 + inn[9] * 8) % 11 ) % 10;
                inn[11] = ((inn[0] * 3 + inn[1] * 7 + inn[2] * 2 + inn[3] * 4 + inn[4] * 10 + inn[5] * 3 + inn[6] * 5 + inn[7] * 9 + inn[8] * 4 + inn[9] * 6 + inn[10] * 8) % 11 ) % 10;

                var innString = "";
                for (var i = 0; i < 12; i++)
                {
                    innString += inn[i].ToString();
                }

                return innString;
            }
        }

        public static string InnUl
        {
            get
            {
                var r = new Random();
                var inn = new int[10];
                do
                {
                    inn[0] = r.Next(10);
                    inn[1] = r.Next(10);
                } while (inn[0] + inn[1] == 0);

                for (var i = 2; i < 9; i++)
                {
                    inn[i] = r.Next(10);
                }
                inn[9] = ((inn[0] * 2 + inn[1] * 3 + inn[2] * 10 + inn[3] * 3 + inn[4] * 5 + inn[5] * 9 + inn[6] * 4 + inn[7] * 6 + inn[8] * 8) % 11 ) % 10;

                var innString = "";

                for (var i = 0; i < 10; i++)
                {
                    innString += inn[i].ToString();
                }

                return innString;
            }
        }

        public static string OgrnIp
        {
            get
            {
                var r = new Random();
                var ogrn = new int[15];
                ogrn[0] = r.Next(1, 10);
                for (var i = 1; i < 14; i++)
                {
                    ogrn[i] = r.Next(10);
                }
                while (ogrn[3] + ogrn[4] == 0)
                {
                    ogrn[3] = r.Next(10);
                    ogrn[4] = r.Next(10);
                }
                while (ogrn[5] + ogrn[6] == 0)
                {
                    ogrn[5] = r.Next(10);
                    ogrn[6] = r.Next(10);
                }

                ogrn[14] = (int) (long.Parse($"{ogrn[0]}{ogrn[1]}{ogrn[2]}{ogrn[3]}{ogrn[4]}{ogrn[5]}{ogrn[6]}{ogrn[7]}{ogrn[8]}{ogrn[9]}{ogrn[10]}{ogrn[11]}{ogrn[12]}{ogrn[13]}") % 13 % 10);
                var ogrnString = "";
                for (var i = 0; i < 15; i++)
                {
                    ogrnString += ogrn[i].ToString();
                }

                return ogrnString;
            }
        }

        public static string OgrnUl
        {
            get
            {
                var r = new Random();
                var ogrn = new int[13];
                ogrn[0] = r.Next(1, 10);
                for (var i = 1; i < 12; i++)
                {
                    ogrn[i] = r.Next(10);
                }
                while (ogrn[3] + ogrn[4] == 0)
                {
                    ogrn[3] = r.Next(10);
                    ogrn[4] = r.Next(10);
                }
                while (ogrn[5] + ogrn[6] == 0)
                {
                    ogrn[5] = r.Next(10);
                    ogrn[6] = r.Next(10);
                }
                ogrn[12] = (int)(long.Parse($"{ogrn[0]}{ogrn[1]}{ogrn[2]}{ogrn[3]}{ogrn[4]}{ogrn[5]}{ogrn[6]}{ogrn[7]}{ogrn[8]}{ogrn[9]}{ogrn[10]}{ogrn[11]}") % 11 ) % 10;
                var ogrnString = "";
                for (var i = 0; i < 13; i++)
                {
                    ogrnString += ogrn[i].ToString();
                }

                return ogrnString;
            }
        }

        public static string Snils
        {
            get
            {
                var r = new Random();
                var snils = new int[11];
                do
                {
                    snils[0] = r.Next(10);
                    snils[1] = r.Next(10);
                    snils[2] = r.Next(10);
                } while (snils[0] + snils[1] + snils[2] == 0 || int.Parse($"{snils[0]}{snils[1]}{snils[2]}") == 1);
                do
                {
                    snils[3] = r.Next(10);
                    snils[4] = r.Next(10);
                    snils[5] = r.Next(10);
                } while (snils[3] + snils[4] + snils[5] == 0 || int.Parse($"{snils[3]}{snils[4]}{snils[5]}") == 1);
                for (var i = 6; i < 9; i++)
                {
                    snils[i] = r.Next(10);
                }
                var sum = snils[0] * 9 + snils[1] * 8 + snils[2] * 7 + snils[3] * 6 + snils[4] * 5 + snils[5] * 4 +
                          snils[6] * 3 + snils[7] * 2 + snils[8] * 1;
                var snilsString = $"{snils[0]}{snils[1]}{snils[2]}{snils[3]}{snils[4]}{snils[5]}{snils[6]}{snils[7]}{snils[8]}";
                if (sum < 100)
                {
                    return $"{snilsString}{sum}";
                }
                if (sum == 100 || sum == 101)
                {
                    return $"{snilsString}00";
                }
                return $"{snilsString}{sum % 101}";
            }
        }
    }
}

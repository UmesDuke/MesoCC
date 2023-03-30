using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesoCC
{
    internal class ISBN10
    {
        private int[] c = {10, 9, 8, 7, 6, 5, 4, 3, 2};
        private int[] b = null;

        private int mod = 11;
        private int lenght = 9;

        public ISBN10() { }

        public bool SetBase(string valueOf)
        {
            if (valueOf == null 
                || valueOf.Length != lenght)
            {
                b = null;
                return false;
            }
            b = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                char car = valueOf[i];
                if (!char.IsNumber(car))
                {
                    b = null;
                    return false;
                }
                b[i] = Convert.ToInt32(car.ToString());
            }
            return true;
        }

        public string GetISB10()
        {
            int d = GetNumeroValidacion();
            if (d == -1)
            {
                return null;
            }
            StringBuilder buff = new StringBuilder();
            int index = 0;
            for (;;)
            {
                if (index >= b.Length)
                {
                    if (d == 10)
                    {
                        return buff.Append('x').ToString();
                    }
                    return buff.Append(d).ToString();
                }
                buff.Append(b[index++]);
            }
        }
        private int GetNumeroValidacion()
        {
            if (b == null || b.Length < 1)
            {
                return -1;
            }
            int d, p_punto = 0;
            for (int i = 0; i < lenght; i++)
            {
                p_punto += (b[i] * c[i]);
            }
            d = p_punto % mod;
            return (mod - d);
        }
    }
}

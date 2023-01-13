using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AloneWork_2_2._20.Models
{
    class Calculation
    {
        public static string GetResult(string str)
        {
            //создаем экземпляр класса DataTable

            return new DataTable().Compute(str, null).ToString();

        }
    }
}

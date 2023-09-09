using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPaqueteJahzSuma
{
    public class Operaciones
    {
        #region Variables...
        decimal num1;
        decimal num2;
        #endregion Variables...

        #region Constructor...
        public Operaciones(decimal num1, decimal num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        #endregion Constructor

        #region Métodos...
        public decimal suma() => num1 + num2;
        public decimal restar() => num1 - num2;
        public decimal multiplicacion() => num1 * num2;
        public decimal division() => num1 / num2;

        #endregion Métodos...
    }
}

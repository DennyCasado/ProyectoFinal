using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoNomina
{
    public class Nomina
    {
        private int diasLaborados;

        public int DiasLaborados  { get; set; }

        //metodo para calcular la nomina
        public decimal CalculoNomina (int diasLab, decimal valorDia)
        {
            decimal totalSalario = diasLab * valorDia;
            return totalSalario;
        
        }

    }
}

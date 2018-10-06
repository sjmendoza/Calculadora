using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        public double numero;
        public string operacion;

        public Calculadora(double numero,string operacion)
        {
            this.numero = numero;
            this.operacion = operacion;
        }

        public Calculadora()
        {
            
        }


        public void setNumero(double numero)
        {
            numero = this.numero;
        }

        public Double getNumero()
        {
            return this.numero;
        }

        public double Sumar(double N1,double N2)
        {
            double suma=0.0;
            return suma = N1 + N2;
        }

        public double Restar(double N1,double N2)
        {
            double resta = 0.0;
            return resta = N1-N2;
        }

        public double Dividir(double N1,double N2)
        {
            double division= 0.0;
            return division = N1/N2;
        }

        public double Multiplicar(double N1,double N2)
        {
            double multiplicacion= 0.0;
            return multiplicacion = N1 * N2;
        }

        public double operaciones(string operacion,double n1,double n2)
        {
            double resultado = 0.0;
            switch (operacion)
            {
                case "+":
                    return resultado=Sumar(n1,n2);
                break;
                case "-":
                    return resultado=Restar(n1, n2);
                break;
                case "/":
                    return resultado=Dividir(n1, n2);
                break;
                case "*":
                    return resultado=Multiplicar(n1, n2);
                break;
            }
            return resultado;
               
        }

    }
}

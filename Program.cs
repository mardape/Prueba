using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace calculadora;

class Program
{
    static void Main(string[] args)
    {
        int n1= 0, n2= 0, resultado;

        PedirValor(ref n1,ref n2);
        resultado=Suma(n1,n2);

        Console.WriteLine("resultado: "+resultado);




    }

    static void  PedirValor (ref int j, ref int k){
        Console.WriteLine("ingrese valor");
        j=int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese valor");
        k=int.Parse(Console.ReadLine());
    }

    static int Suma (int a, int b){
        int r;
        r=a+b;
        return r;
    }




}


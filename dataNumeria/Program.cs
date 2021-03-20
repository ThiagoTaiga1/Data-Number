using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace dataNumeria
{
    public class Program {
        class data{
            //APi que mostra quantos dias voçê tem na terra e sua idade baseada na data atual!
            static void Main(string[] args){
               DateTime data1,data2;
               TimeSpan result;
//criando variaveis data para guardar meu nascimento e a data atual !
               data1 = DateTime.Parse("01/03/2000");
               data2 = DateTime.Parse("02/03/2021");
//resultado da data 1 com data 2!
               result = data2 - data1;
//pedindo para ler o resultado das datas ! 
               Console.WriteLine($"voce tem {result.Days} dias ");
               Console.WriteLine($"voce tem {result.Days /30/12} anos");
               Console.ReadKey();
            }
        }
    }
}
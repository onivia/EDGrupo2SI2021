using System;
using System.Threading.Tasks;
using _27mayo2021;
using Xunit;
using Xunit.Abstractions;

namespace pruebasunitarias
{
    public class PruebaUnitaria1
    {
        private readonly ITestOutputHelper _output;
        public PruebaUnitaria1(ITestOutputHelper output)
        {
            _output = output;            
        }

        [Fact(Skip = "no entra en este set de pruebas")]
        public void sumarTest()
        {
            int resultadoEsperado = 50;
            int resultadoObtenido = Operacion.sumar(20,30);
            Assert.Equal(resultadoEsperado,resultadoObtenido);
            //_output.WriteLine("hola companeros");
        }

        [Fact(Skip = "este tampoco entra en este set de pruebas")]
        public void dividirTest() {            
            Action a1 = () => Operacion.dividir(100,0);            
            Exception ex = Record.Exception(a1);
            
            Assert.Null(ex);
        }

        [Fact(Timeout = 1000)]
        public async Task timeTest()
        {
            await Task.Delay(2000);
        }
    }
}

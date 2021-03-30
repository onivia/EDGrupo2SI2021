using System;

namespace _29mar2021_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura();
            factura.NitCliente = "800123"; //set
            factura.liquidar();
            OrdenCompra oc = new OrdenCompra();
            oc.liquidar();
            ValidarDocumento(oc);
            ValidarDocumento(factura);
        }

        static void ValidarDocumento(IValidable documento) {
            documento.validar();
        }
    }
}

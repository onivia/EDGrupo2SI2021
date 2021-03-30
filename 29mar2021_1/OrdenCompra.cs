using System;

namespace _29mar2021_1
{
    class OrdenCompra : DocumentoPago, IValidable
    {
        public OrdenCompra()
        {            
        }

        public override void consolidar()
        {
            throw new NotImplementedException();
        }

        public void validar()
        {
            throw new NotImplementedException();
        }
    }
}
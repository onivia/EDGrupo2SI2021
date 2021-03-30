using System;

namespace _29mar2021_1
{
    class Factura : DocumentoPago, IValidable
    {
        private string nitCliente;
        public string NitCliente {
            get {
                return nitCliente;
            }
            set {
                if(!value.Contains("-"))
                    nitCliente = value;
                else
                    throw new Exception("NO SE PERMITEN NIT con '-'");
            }
        }

        private string nombreCliente;
        public string NombreCliente {
            get {
                return nombreCliente;                
            }
            set {
                nombreCliente = value;
            }
        }
        private decimal total;
        public decimal Total {
            get {
                return total;                
            }
            set {
                total = value;
            }
        }

        public Factura() { //constructor por default
            //inicializar las variables
            this.total = 0;
        }

        public Factura(decimal total) { //constructor
            //inicializar las variables
            this.total = total;
            liquidar();
        }

        public void validar()
        {
            throw new NotImplementedException();
        }

        public override void consolidar()
        {
            throw new NotImplementedException();
        }
    }
}

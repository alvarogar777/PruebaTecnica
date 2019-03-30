using System;
namespace PruebaTecnica.Util
{
    public class OptionMenuException : Exception
    {
        private string message = "Debera ingresar un numero";

        public override string Message{
            get{return message;}
        }
    }
}
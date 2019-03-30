using AlvaroGarcia.Interfaz;
using System;
namespace AlvaroGarcia.Model
{
    public class Avion : Vehiculo,IBitacora
    {
        public Avion(){}

        public Avion(float velocidadMaxima,float velocidadMinima,string marca,string modelo,float alturaMaxima,float alturaMinima) 
        : base(velocidadMaxima,velocidadMinima,marca,modelo)
        {
            this.AlturaMaxima=alturaMaxima;
            this.AlturaMinima=alturaMinima;
        }
        private float alturaMaxima;
        public float AlturaMaxima
        {
            get { return alturaMaxima;}
            set { alturaMaxima = value;}
        }

        private float alturaMinima;
        public float AlturaMinima
        {
            get { return alturaMinima;}
            set { alturaMinima = value;}
        }

        public void Despegar(){}

        public void Aterrizar(){}

        public void DisminuirAltura(float pie){}
        
        public override void encender(){}

        public override void apagar(){}
        
        public void MostrarDetalle(){}

        public override string ToString(){
            return $"Velocidad Minima: {VelocidadMinima} - Velocidad Maxima : {VelocidadMaxima} - Marca : {Marca} - Moleo : {Modelo} - Altura Maxima : {AlturaMaxima} - Altura Minima : {AlturaMinima}";
        }
    }
}
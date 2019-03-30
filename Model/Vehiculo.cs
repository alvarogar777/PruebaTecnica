namespace AlvaroGarcia.Model
{
    public abstract class Vehiculo
    {
        public Vehiculo(){}
        public Vehiculo(float velocidadMaxima,float velocidadMinima,string marca,string modelo){
            this.VelocidadMaxima=velocidadMaxima;
            this.VelocidadMinima=velocidadMinima;
            this.Marca=marca;
            this.Modelo=modelo;
        }
        private float velocidadMaxima;
        public float VelocidadMaxima
        {
            get { return velocidadMaxima;}
            set { velocidadMaxima = value;}
        }

        private float velocidadMinima;
        public float VelocidadMinima
        {
            get { return velocidadMinima;}
            set { velocidadMinima = value;}
        }

        private string marca;
        public string Marca
        {
            get { return marca;}
            set { marca = value;}
        }
        
        private string modelo;
        public string Modelo
        {
            get { return modelo;}
            set { modelo = value;}
        }
        
        public abstract void encender();

        public abstract void apagar();
        
        
    }
}
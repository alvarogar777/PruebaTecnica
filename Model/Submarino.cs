namespace AlvaroGarcia.Model
{
    public class Submarino : Vehiculo
    {
        public Submarino(){}
        public Submarino(float velocidadMaxima,float velocidadMinima,string marca,string modelo,float profundidadMaxima)
        : base(velocidadMaxima,velocidadMinima,marca,modelo)
        {
            this.ProfundidadMaxima=profundidadMaxima;
        }
        private float profundidadMaxima;
        public float ProfundidadMaxima
        {
            get { return profundidadMaxima;}
            set { profundidadMaxima = value;}
        }
        
        public void Sumergir(float metros){}

        public override void encender(){}

        public override void apagar(){}

        public override string ToString(){
            return $"Velocidad Minima: {VelocidadMinima} - Velocidad Maxima : {VelocidadMaxima} - Marca : {Marca} - Moleo : {Modelo} - Profundidad Maxima : {ProfundidadMaxima} ";
        }
    }
}
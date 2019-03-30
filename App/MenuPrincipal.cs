using System;
using static System.Console;
using AlvaroGarcia.Model;
using System.Collections.Generic;

namespace AlvaroGarcia.App
{
    public class MenuPrincipal
    {

        public MenuPrincipal(){
            this.ListaVehiculo= new List<Vehiculo>(); 
        }
        private List<Vehiculo> listaVehiculo;
        public List<Vehiculo> ListaVehiculo
        {
            get { return listaVehiculo;}
            set { listaVehiculo = value;}
        }
        
        public void MostrarMenu()
        {
            int opcion=0;
            string lectura="";
            do{
                try{
                    WriteLine("1. Crear Objeto Avion");
                    WriteLine("2. Crear Objeto Submarino");
                    WriteLine("3. Mostrar Objetos Avion");
                    WriteLine("4. Mostrar Objetos Submarino");
                    WriteLine("5. Salir");
                    lectura=ReadLine();
                    opcion=Convert.ToInt16(lectura);
                    if (opcion == 1)
                    {
                        Clear();
                        WriteLine("Nuevo Avion: ");
                        CrearObjeto(opcion);
                    }
                    else if (opcion == 2)
                    {
                        Clear();
                        WriteLine("Nuevo Submarino: ");
                        CrearObjeto(opcion);
                    }
                    else if (opcion == 3)
                    {
                        Clear();
                        WriteLine("La lista de aviones es: ");
                        MostrarObjetos(opcion);
                    }
                    else if (opcion == 4)
                    {
                        Clear();
                        WriteLine("La lista de Submarinos es: ");
                        MostrarObjetos(opcion);
                    }
                }
                catch(Exception e){
                    Clear();
                    WriteLine($"Debera Ingresar un valor valido {e.Message}");
                }
            }while(opcion !=5);
            Clear();
        }

        public void CrearObjeto(int opcion)
        {
            float velocidadMaxima=0.00f;
            float velocidadMinima=0.00f;
            string marca="";
            string modelo="";
            float alturaMaxima=0.00f;
            float alturaMinima=0.00f;
            float profundidadMaxima=0.00f;
            Vehiculo vehiculo = null;
            
            WriteLine("Ingrese Velocidad Maxima");
            velocidadMaxima=Convert.ToSingle(ReadLine());
            WriteLine("Ingrese Velocidad Minima");
            velocidadMinima=Convert.ToSingle(ReadLine());
            WriteLine("Ingrese Marca");
            marca=ReadLine();
            WriteLine("Ingrese Modelo");
            modelo=ReadLine();
            if (opcion == 1)
            {
                WriteLine("Ingrese Altura Maxima");
                alturaMaxima=Convert.ToSingle(ReadLine());  
                WriteLine("Ingrese Altura Minima");
                alturaMinima=Convert.ToSingle(ReadLine());
                vehiculo = new Avion(velocidadMaxima,velocidadMinima,marca,modelo,alturaMaxima,alturaMinima);                
            }
            else if (opcion == 2)
            {
                WriteLine("Ingrese Profundidad Maxima");
                profundidadMaxima=Convert.ToSingle(ReadLine());
                vehiculo = new Submarino(velocidadMaxima,velocidadMinima,marca,modelo,profundidadMaxima);                
            }
            Clear();
            this.ListaVehiculo.Add(vehiculo);
            WriteLine("Ingresado correctamente");
        }

        public void MostrarObjetos(int opcion){
            
            foreach (var item in this.ListaVehiculo)
            {
                if(opcion == 3  && item.GetType() == typeof(Avion)){                    
                    WriteLine(item);                    
                }
                else if (opcion == 4 && item.GetType() == typeof(Submarino))
                {
                    WriteLine(item);
                }
                
            }
            ReadKey();
            Clear();
        }
    }
}
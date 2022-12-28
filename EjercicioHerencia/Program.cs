using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Program
    {
        static void Main()
        {
            Avion miAvion = new Avion();

            miAvion.ArrancarMotor();
            miAvion.Despegar();
            miAvion.Aterrizar();
            miAvion.PararMotor();

            Console.WriteLine("\nProbando coche");

            Coche miCoche = new Coche();

            miCoche.ArrancarMotor();
            miCoche.Acelerar();
            miCoche.Frenar();
            miCoche.PararMotor();

            Console.WriteLine("\nPolimorfismo en accion");
            Vehiculo miVehiculo = miCoche;
            miVehiculo.Conducir();

            miVehiculo = miAvion;
            miVehiculo.Conducir();



        }
    }

    class Vehiculo
    {
        public void ArrancarMotor() => Console.WriteLine("Arranca el motor");
        public void PararMotor() => Console.WriteLine("Detiene el motor");
        public virtual void Conducir() => Console.WriteLine("Se conduce");
    }

    class Avion : Vehiculo
    {
        public void Aterrizar() => Console.WriteLine("Aterrizando");
        public void Despegar() => Console.WriteLine("Despegando");
        public override void Conducir() => Console.WriteLine("Se pilota");
    }
    class Coche : Vehiculo
    {
        public void Acelerar() => Console.WriteLine("Acelerando");
        public void Frenar() => Console.WriteLine("Frenando");
    }
}

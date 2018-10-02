using System;
namespace AlquilerCoche
{
  class Program
  {
    static void Main(string[] args)
    {
      // Variables que usamos
      string name, licenseAnswer;
      int age;
      bool driversLicense;
      int origin;
      int totalDays, weeks, days, payedDays, cost;
      
      // Constantes, precio por día y días de la semana
      const int pricePerDay = 10;
      const int daysPerWeek = 7;
      
      // Pedimos el nombre del cliente
      Console.WriteLine("¿Cómo te llamas?");
      name = Console.ReadLine();
      Console.WriteLine("Cliente " + name);
      Console.WriteLine();
      
      // Pedimos la edad del cliente
      Console.WriteLine("¿Cuantos años tienes?");
      age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Cliente " + name + ", " + age + " añs.");
      Console.WriteLine();
      
      // Preguntamos si tiene carnet
      Console.WriteLine("¿Tienes carnet de conducir? (S/N)");
      licenseAnswer = Console.ReadLine();
      
      // Utilizamos la respuesta del carnet para ver darle valor al booleano
      // Primero mostramos la primera parte del mensaje con un Write, la
      // acabamos dentro del if else con un WriteLine para tener una frase
      // en la misma linea
      Console.Write("Cliente " + name + ", " + age + " años, ");
      if (licenseAnswer == "S" || licenseAnswer == "s")
      {
        driversLicense = true;
        Console.WriteLine(" con carnet de conducir.");
      }
      // Si no escribe S o s, consideramos que es no, sóo podemos hacer
      // algo respecto a que metan una respuesta sin sentido cuando
      // aprendamos bucles
      else
      {
        driversLicense = false;
        Console.WriteLine(" sin carnet de conducir.");
      }
      
      Console.WriteLine();
      
      // Si no tiene carnet o tiene menos de 18 añs, no damos opción a que
      // alquile un coche
      if(!driversLicense || age < 18)
      {
        Console.WriteLine("No puedes alquilar un coche.");
      }
      else
      {
        // Preguntamos dóde quiere recoger el coche, y lo guardamos
        // en la variable origin y usamos un switch para mostrar
        // al cliente la opció elegida
        Console.WriteLine("¿Dónde quieres recoger el coche?");
        Console.WriteLine("1- Bilbao");
        Console.WriteLine("2- Madrid");
        Console.WriteLine("3- Barcelona");
        Console.WriteLine("4- Santander");
        origin = Convert.ToInt32(Console.ReadLine());
        
        // Una vez má usamos Write para una parte de la frase y lo
        // acabamos con un WriteLine
        Console.Write("Vas a recoger el coche en ");
        switch(origin)
        {
          case 1:
            Console.WriteLine("Bilbao");
            break;
          case 2:
            Console.WriteLine("Madrid");
            break;
          case 3:
            Console.WriteLine("Barcelona");
            break;
          case 4:
            Console.WriteLine("Santander");
            break;
        }
        // Preguntamos la duración del alquiler en días
        Console.WriteLine("¿durante cuantos días quieres utilizar el coche?");
        totalDays = Convert.ToInt32(Console.ReadLine());
        // A partir de los dís totales calculamos las
        // semanas y dís restantes que alquilarál coche.
        // Por cada semana, restamos un dí de alquiler
        weeks = totalDays / daysPerWeek; // para calcular las semanas dividimos dias totales por dís en una semana
        days = totalDays % daysPerWeek; // para calcular los dís restantes hacemos % dís en una semana
        payedDays = totalDays - weeks; // oferta de un dí menos de alquiler pagado por semana alquilada
        cost = payedDays * pricePerDay; // el coste es los dís que pagamos por el precio por dí del alquiler
        Console.WriteLine();
        
        // Mostramos el mensaje con toda la informació recogida hasta ahora
        // Sabemos que tiene carnet de conducir ya que nunca llegarí dentro
        // de este if en caso contrario
        Console.Write("Cliente " + name + ", " + age + " años, con carnet de conducir, ");
        Console.Write("vas a recoger el coche en ");
        switch (origin)
        {
          case 1:
            Console.Write("Bilbao");
            break;
          case 2:
            Console.Write("Madrid");
            break;
          case 3:
            Console.Write("Barcelona");
            break;
          case 4:
            Console.Write("Santander");
            break;
        }
        
        Console.Write(" y alquilas el coche durante ");
        
        // Solo mostramos el mensaje de semanas si han alquilado más de 7 días
        if (weeks > 0)
        {
          Console.Write(weeks + " semanas y ");
        }
        Console.Write(days + " días");
        // Este WriteLine aquís el que hace que se escriba una líea nueva
        Console.WriteLine(" por un coste de " + cost + " Euros.");
        
        Console.ReadKey();
      }
    }
  }
}

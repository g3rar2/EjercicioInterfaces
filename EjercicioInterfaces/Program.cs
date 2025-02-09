using EjercicioInterfaces;

Operaciones operaciones = new Operaciones();

Console.Write("Ingrese el primer lado del Triangulo: ");
operaciones.lado1 =int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo lado del Triangulo: ");
operaciones.lado2 = int.Parse(Console.ReadLine());

Console.Write("Ingrese la altura del Prisma: ");
operaciones.altura = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de lempiras a convertir: ");
operaciones.lempiras = int.Parse(Console.ReadLine());

Console.Write("Ingrese los grados celsius a convertir: ");
operaciones.celsius = int.Parse(Console.ReadLine());


operaciones.Imprimir();
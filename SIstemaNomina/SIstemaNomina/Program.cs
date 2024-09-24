
using SIstemaNomina.Clases;
Console.WriteLine("EMPLEADO ASALARIADO\n");
EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado();
empleadoAsalariado.Asignar();
empleadoAsalariado.ToString();
Console.WriteLine("\nEMPLEADO POR HORAS\n");
EmpleadoPorHoras empleadoPorHoras = new EmpleadoPorHoras();
empleadoPorHoras.Asignar();
empleadoPorHoras.Calcular();
Console.WriteLine("\nEMPLEADO POR COMISION\n");
EmpleadoPorComision empleadoPorComision = new EmpleadoPorComision();
empleadoPorComision.Asignar();
Console.WriteLine("\nEMPLEADO BASE MAS COMISION");
EmpleadoBaseMasComision empleadoBaseMasComision = new EmpleadoBaseMasComision();
empleadoBaseMasComision.Asignar();
Console.WriteLine(empleadoAsalariado.ToString());
Console.WriteLine(empleadoPorHoras.ToString());
Console.WriteLine(empleadoPorComision.ToString());
Console.WriteLine(empleadoBaseMasComision.ToString());
Console.ReadLine();




Console.ReadLine();
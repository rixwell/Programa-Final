using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraccion
{
    internal class Program
    {
        static List<Conductor> conductores = new List<Conductor>();
        static List<Vehiculo> vehiculos = new List<Vehiculo>();
        static List<AgenteTransito> agentes = new List<AgenteTransito>();
        static List<Multa> multas = new List<Multa>();

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Menú Principal\n");
                Console.WriteLine("1. Registrar conductor.");
                Console.WriteLine("2. Registrar vehículo.");
                Console.WriteLine("3. Registrar agente de tránsito.");
                Console.WriteLine("4. Registrar infracción.");
                Console.WriteLine("5. Mostrar conductores.");
                Console.WriteLine("6. Mostrar vehículos.");
                Console.WriteLine("7. Mostrar agentes de tránsito.");
                Console.WriteLine("8. Mostrar infracciones.");
                Console.WriteLine("9. Salir.\n");

                Console.Write("Selecciones una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        RegistrarConductor(opcion);
                        break;

                    case "2":
                        Console.Clear();
                        RegistrarVehiculo(opcion);
                        break;

                    case "3":
                        Console.Clear();
                        RegistrarAgente(opcion);
                        break;

                    case "4":
                        Console.Clear();
                        RegistrarInfraccion();
                        break;

                    case "5":

                        Console.Clear();

                        if (conductores == null || conductores.Count == 0)
                        {
                            Console.WriteLine("No hay conductores agregados.\n");
                            Console.WriteLine("Presione la tecla Enter para volver al Menú Principal.");
                            Console.ReadLine();
                        }

                        else
                        {
                            foreach (Conductor conductor in conductores)
                            {
                                Console.WriteLine("\nNombre del conductor: " + conductor.Nombre);
                                Console.WriteLine("Cédula del conductor: " + conductor.Cedula);
                                Console.WriteLine("Dirección del conductor: " + conductor.Direccion);
                                Console.WriteLine("Tipo de licencia del conductor: " + conductor.TipoLicencia);
                                Console.WriteLine("Fecha de nacimiento del conductor: " + conductor.FechaNacimiento);
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                            }

                            Console.WriteLine("\nPresione la tecla Enter para volver al Menú Principal.");
                            Console.ReadLine();
                        }

                        break;

                    case "6":

                        Console.Clear();

                        if (vehiculos == null || vehiculos.Count == 0)
                        {
                            Console.WriteLine("No hay vehículos agregados.\n");
                            Console.WriteLine("Presione la tecla Enter para volver al Menú Principal.");
                            Console.ReadLine();
                        }

                        else
                        {

                            foreach (Vehiculo vehiculo in vehiculos)
                            {
                                Console.WriteLine("\nPlaca del vehículo del conductor: " + vehiculo.Placa);
                                Console.WriteLine("Marca del vehículo del conductor: " + vehiculo.Marca);
                                Console.WriteLine("Modelo del vehículo del conductor: " + vehiculo.Modelo);
                                Console.WriteLine("Color del vehículo del conductor: " + vehiculo.Color);
                                Console.WriteLine("Año del vehículo del conductor: " + vehiculo.Anio);
                                Console.WriteLine("Número de Chasis del vehículo del conductor: " + vehiculo.NumeroChasis);
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                            }

                            Console.WriteLine("\nPresione la tecla Enter para volver al Menú Principal.");
                            Console.ReadLine();
                        }

                        break;

                    case "7":

                        Console.Clear();

                        if (agentes == null || agentes.Count == 0)
                        {
                            Console.WriteLine("No hay agentes de tránsito agregados.\n");
                            Console.WriteLine("Presione la tecla Enter para volver al Menú Principal.");
                            Console.ReadLine();
                        }

                        else
                        {
                            foreach (AgenteTransito agente in agentes)
                            {
                                Console.WriteLine("\nCódigo de empleado del agente de tránsito: " + agente.CodigoEmpleado);
                                Console.WriteLine("Nombre del agente de tránsito: " + agente.Nombre);
                                Console.WriteLine("Dirección del agente de tránsito: " + agente.Direccion);
                                Console.WriteLine("Fecha de ingreso del agente de tránsito: " + agente.FechaIngreso);
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                            }

                            Console.WriteLine("\nPresione la tecla Enter para volver al Menú Principal.");
                            Console.ReadLine();
                        }

                        break;

                    case "8":

                        Console.Clear();

                        if (multas == null || multas.Count == 0)
                        {
                            Console.WriteLine("No hay infracciones agregadas.\n");
                            Console.WriteLine("Presione la tecla Enter para volver al Menú Principal.");
                            Console.ReadLine();
                        }

                        else
                        {

                            foreach (Multa multa in multas)
                            {
                                Console.WriteLine("\nTipo de infracción: " + multa.TipoInfraccion);
                                Console.WriteLine("Monto de la infracción: " + multa.Monto);
                                Console.WriteLine("Conductor a quien se aplicó la infracción: " + multa.conductor.Nombre);
                                Console.WriteLine("Vehículo al que se aplicó la infracción: " + multa.vehiculo.Marca + " " + multa.vehiculo.Modelo);
                                Console.WriteLine("Agente de tránsito que registró la multa: " + multa.agente.Nombre);
                                Console.WriteLine("--------------------------------------------------------------------------------------------");
                            }

                            Console.WriteLine("Presione la tecla Enter para volver al Menú Principal.");
                            Console.ReadLine();
                        }

                        break;

                    case "9":

                        salir = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opción inválida.\n");
                        Console.WriteLine("Presione la tecla Enter para volver al Menú Principal.");
                        Console.ReadLine();
                        break;
                }

                Console.WriteLine();
            }
        }

        static Conductor RegistrarConductor(string option)
        {
            Console.WriteLine("\nIngrese los datos del conductor.\n");

            Console.Write("Nombre completo: ");
            string nombre = Console.ReadLine();

            Console.Write("Cédula: ");
            string cedula = Console.ReadLine();

            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();

            Console.Write("Tipo de licencia (A, B o C): ");
            string tipoLicencia = Console.ReadLine();

            Console.Write("Fecha de nacimiento (YYYY/MM/DD): ");
            string fechaNacimiento = Console.ReadLine();

            fechaNacimiento = fechaNacimiento.Substring(0, 4) + "/" + fechaNacimiento.Substring(4, 2) + "/" + fechaNacimiento.Substring(6, 2);

            Conductor conductor = new Conductor
            {
                Nombre = nombre,
                Cedula = cedula,
                Direccion = direccion,
                TipoLicencia = tipoLicencia,
                FechaNacimiento = Convert.ToDateTime(fechaNacimiento)
            };

            conductores.Add(conductor);


            if (option.Equals("1"))
            {
                Console.WriteLine("\nConductor registrado exitosamente.");
                Console.WriteLine("Presione la tecla Enter para volver al Menú Principal.");
                Console.ReadLine();
                Menu();
            }

            return conductor;
        }

        static Vehiculo RegistrarVehiculo(string option)
        {
            Console.WriteLine("\nIngrese los datos del vehículo.\n");

            Console.Write("Placa: ");
            string placa = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Color: ");
            string color = Console.ReadLine();

            Console.Write("Año: ");
            int anio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número de chasis: ");
            string chasis = Console.ReadLine();

            Vehiculo vehiculo = new Vehiculo
            {
                Placa = placa,
                Marca = marca,
                Modelo = modelo,
                Color = color,
                Anio = anio,
                NumeroChasis = chasis
            };

            vehiculos.Add(vehiculo);
            

            if (option.Equals("2"))
            {
                Console.WriteLine("\nVehículo registrado exitosamente.");
                Console.WriteLine("Presione la tecla Enter para volver al Menú Principal.");
                Console.ReadLine();
                Menu();
            }

            return vehiculo;
        }

        static AgenteTransito RegistrarAgente(string option)
        {
            Console.WriteLine("\nIngrese los datos del agente de tránsito.\n");

            Console.Write("Código de empleado: ");
            string codigo = Console.ReadLine();

            Console.Write("Nombre completo: ");
            string nombre = Console.ReadLine();

            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();

            Console.Write("Fecha de ingreso (YYYY/MM/DD): ");
            string fechaIngreso = Console.ReadLine();

            fechaIngreso = fechaIngreso.Substring(0, 4) + "/" + fechaIngreso.Substring(4, 2) + "/" + fechaIngreso.Substring(6, 2);

            AgenteTransito agente = new AgenteTransito
            {
                CodigoEmpleado = codigo,
                Nombre = nombre,
                Direccion = direccion,
                FechaIngreso = Convert.ToDateTime(fechaIngreso)
            };

            agentes.Add(agente);
            

            if (option.Equals("3"))
            {
                Console.WriteLine("\nAgente de tránsito registrado exitosamente.");
                Console.WriteLine("Presione la tecla Enter para volver al Menú Principal.");
                Console.ReadLine();
                Menu();
            }

            return agente;
        }

        static void RegistrarInfraccion()
        {
            Console.WriteLine("Registro de infracciones.\n");

            Conductor conductor = RegistrarConductor("0");
            Vehiculo vehiculo = RegistrarVehiculo("0");
            AgenteTransito agente = RegistrarAgente("0");

            Console.WriteLine("\n\nTipos de infracciones:\n");
            Console.WriteLine("1. Obstrucción del tránsito - RD$1,800.00");
            Console.WriteLine("2. Pase de semáforo en rojo - RD$5,950.00");
            Console.WriteLine("3. Hablar por el celular - RD$3,750.00");
            Console.WriteLine("4. Conducir sin el cinturón de seguridad - RD$2,560.00");
            Console.WriteLine("5. Licencia vencida - RD$3,890.00");

            Console.Write("\nSeleccione el tipo de infracción: ");
            int tipoInfraccion = int.Parse(Console.ReadLine());

            Multa multa = new Multa();
            multa.vehiculo = vehiculo;
            multa.conductor = conductor;
            multa.agente = agente;

            switch (tipoInfraccion)
            {
                case 1:
                    multa.TipoInfraccion = "Obstrucción del tránsito";
                    multa.Monto = 1800;
                    break;

                case 2:

                    multa.TipoInfraccion = "Pase de semáforo en rojo";
                    multa.Monto = 5950;
                    break;

                case 3:

                    multa.TipoInfraccion = "Hablar por el celular";
                    multa.Monto = 3750;
                    break;

                case 4:

                    multa.TipoInfraccion = "Conducir sin el cinturón de seguridad";
                    multa.Monto = 2560;
                    break;

                case 5:

                    multa.TipoInfraccion = "Licencia vencida";
                    multa.Monto = 3890;
                    break;

                default:

                    Console.WriteLine("Opción inválida.");
                    break;
            }

            if (multa != null)
            {
                multas.Add(multa);

                Console.WriteLine("\nInfracción registrada correctamente.");
            }

            Console.WriteLine("Presione la tecla Enter para volver al Menú Principal.");
            Console.ReadLine();
            Menu();
        }
    }

    public class Conductor
    {
        public int ConductorId { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public string Direccion { get; set; }

        public string TipoLicencia { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }

    public class Vehiculo
    {
        public int VehiculoId { get; set; }

        public string Placa { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Color { get; set; }

        public int Anio { get; set; }

        public string NumeroChasis { get; set; }
    }

    public class AgenteTransito
    {
        public int AgenteTransitoId { get; set; }

        public string CodigoEmpleado { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaIngreso { get; set; }
    }

    public class Multa
    {
        public int MultaId { get; set; }

        public string TipoInfraccion { get; set; }

        public decimal Monto { get; set; }

        public Conductor conductor { get; set; }

        public Vehiculo vehiculo { get; set; }

        public AgenteTransito agente { get; set; }
    }

}


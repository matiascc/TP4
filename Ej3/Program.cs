using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            String iNroDocumento, iNombre;
            Controlador control = new Controlador();
            double iAcuerdo, iSaldo;

            Fachada fachada = new Fachada();
            int aux = 1;                   //Variable para el siguiente while siendo '1', uno de los valores aceptados.

            while (aux == 1 || aux == 2)            //Si el num no es 1 o 2 termina el programa.
            {
                Console.WriteLine();
                Console.WriteLine("1- Agregar un Cliente");
                Console.WriteLine("2- Buscar un Cliente");
                Console.WriteLine("Otra numero para salir");

                aux = Convert.ToInt32(Console.ReadLine());                          //Lee del teclado y le asigna el num a aux.

                switch (aux)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el tipo de documento del Cliente:");
                        Console.WriteLine("1- DNI");
                        Console.WriteLine("2- CUIT");
                        Console.WriteLine("3- CUIL");
                        Console.WriteLine("4- LE");
                        Console.WriteLine("5- LC");
                        TipoDocumento mTipoDocumento = fachada.ElegirTipoDocumento(Convert.ToInt32(Console.ReadLine()));     //Utiliza el metodo de la fachada para elegir el Tipo de Documento.

                        Console.WriteLine();

                        Console.Write("Ingrese el Nro de Documento: ");
                        iNroDocumento = Convert.ToString(Console.ReadLine());

                        Console.Write("Ingrese el nombre del Cliente: ");
                        iNombre = Convert.ToString(Console.ReadLine());

                        fachada.AgregarCliente(mTipoDocumento, iNroDocumento, iNombre);
                        Console.WriteLine("El cliente ha sido agregado");
                        break;

                    case 2:
                        Console.Write("Ingrese Nro Doc: ");
                        iNroDocumento = Console.ReadLine();
                        if (fachada.ExisteCliente(iNroDocumento))
                        {
                            PantallaClienteEncontrado(fachada.BuscarClientePorDoc(iNroDocumento));

                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 0:
                                    Console.WriteLine();
                                    Console.Write("Ingrese el acuerdo de descubierto de la nueva cuenta: ");
                                    fachada.BuscarCuentasPorDoc(iNroDocumento).CuentaCorriente = new Cuenta(Convert.ToDouble(Console.ReadLine()));
                                    fachada.BuscarCuentasPorDoc(iNroDocumento).CajaAhorro = new Cuenta(0);
                                    break;
                                case 1:
                                    Console.WriteLine();
                                    Console.Write("Ingrese el acuerdo de descubierto de la nueva cuenta: ");
                                    iAcuerdo = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Ingrese el saldo de la nueva cuenta: ");
                                    iSaldo = Convert.ToDouble(Console.ReadLine());
                                    fachada.BuscarCuentasPorDoc(iNroDocumento).CuentaCorriente = new Cuenta(iAcuerdo, iSaldo);
                                    fachada.BuscarCuentasPorDoc(iNroDocumento).CajaAhorro = new Cuenta(0);
                                    break;
                                case 2:
                                    Console.WriteLine();
                                    Console.Write("Ingrese el acuerdo de descubierto de la nueva cuenta: ");
                                    fachada.BuscarCuentasPorDoc(iNroDocumento).CajaAhorro = new Cuenta(Convert.ToDouble(Console.ReadLine()));
                                    fachada.BuscarCuentasPorDoc(iNroDocumento).CuentaCorriente = new Cuenta(0);
                                    break;
                                case 3:
                                    Console.WriteLine();
                                    Console.Write("Ingrese el acuerdo de descubierto de la nueva cuenta: ");
                                    iAcuerdo = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Ingrese el saldo de la nueva cuenta: ");
                                    iSaldo = Convert.ToDouble(Console.ReadLine());
                                    fachada.BuscarCuentasPorDoc(iNroDocumento).CajaAhorro = new Cuenta(iAcuerdo, iSaldo);
                                    fachada.BuscarCuentasPorDoc(iNroDocumento).CuentaCorriente = new Cuenta(0);
                                    break;
                            }

                            PantallaDeSaldos();

                            int num = Convert.ToInt32(Console.ReadLine());

                            while (1 <= num && num <= 6)       //Si el num no esta en este rango vuelve a la pantalla inicial
                            {
                                switch (num)
                                {
                                    case 1:
                                        MostrarSaldo(fachada.BuscarCuentasPorDoc(iNroDocumento).CuentaCorriente.Saldo);       //este metodo ubicado fuera del main contiene una escritura en pantalla que se utiliza en repetidas ocasiones
                                        MostrarAcuerdo(fachada.BuscarCuentasPorDoc(iNroDocumento).CuentaCorriente.Acuerdo);   //este metodo ubicado fuera del main contiene una escritura en pantalla que se utiliza en repetidas ocasiones
                                        break;
                                    case 2:
                                        MostrarSaldo(fachada.BuscarCuentasPorDoc(iNroDocumento).CajaAhorro.Saldo);
                                        MostrarAcuerdo(fachada.BuscarCuentasPorDoc(iNroDocumento).CajaAhorro.Acuerdo);
                                        break;
                                    case 3:
                                        Console.WriteLine("Ingrese el valor a debitar");
                                        try
                                        {
                                            fachada.DebitarCuentaCorriente(Convert.ToDouble(Console.ReadLine()), iNroDocumento);
                                        }
                                        catch (AcreditarDebitarException exc)
                                        {
                                            Console.WriteLine("Ha ocurrido un error al debitar. \n {0}", exc);
                                        }
                                        finally
                                        {
                                            iSaldo = fachada.BuscarCuentasPorDoc(iNroDocumento).CuentaCorriente.Saldo;
                                            MostrarSaldo(iSaldo);
                                        }
                                        break;
                                    case 4:
                                        Console.WriteLine("Ingrese el valor a debitar");
                                        try
                                        {
                                            fachada.DebitarCajaAhorro(Convert.ToDouble(Console.ReadLine()), iNroDocumento);
                                        }
                                        catch (AcreditarDebitarException exc)
                                        {
                                            Console.WriteLine("Ha ocurrido un error al debitar. \n {0}", exc);
                                        }
                                        finally
                                        {
                                            iSaldo = fachada.BuscarCuentasPorDoc(iNroDocumento).CajaAhorro.Saldo;
                                            MostrarSaldo(iSaldo);
                                        }
                                        break;
                                    case 5:
                                        Console.WriteLine("Ingrese el valor a acreditar");
                                        try
                                        {
                                            fachada.AcreditarCuentaCorriente(Convert.ToDouble(Console.ReadLine()), iNroDocumento);
                                        }
                                        catch (AcreditarDebitarException exc)
                                        {
                                            Console.WriteLine("Ha ocurrido un error al acreditar. \n {0}", exc);
                                        }
                                        finally
                                        {
                                            iSaldo = fachada.BuscarCuentasPorDoc(iNroDocumento).CuentaCorriente.Saldo;
                                            MostrarSaldo(iSaldo);
                                        }
                                        break;
                                    case 6:
                                        Console.WriteLine("Ingrese el valor a acreditar");
                                        try
                                        {
                                            fachada.AcreditarCajaAhorro(Convert.ToDouble(Console.ReadLine()), iNroDocumento);
                                        }
                                        catch (AcreditarDebitarException exc)
                                        {
                                            Console.WriteLine("Ha ocurrido un error al acreditar. \n {0}", exc);
                                        }
                                        finally
                                        {
                                            iSaldo = fachada.BuscarCuentasPorDoc(iNroDocumento).CajaAhorro.Saldo;
                                            MostrarSaldo(iSaldo);
                                        }
                                        break;
                                    default:
                                        num = 0;
                                        break;
                                }
                                PantallaDeSaldos();
                                num = Convert.ToInt32(Console.ReadLine());
                            }

                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("No se ha agregado ningún Cliente");
                            break;
                        }

                }
            }
        }

        static void MostrarSaldo(double pSaldo)
        {
            Console.WriteLine();
            Console.WriteLine("El saldo de la cuenta es: " + pSaldo);
        }

        static void MostrarAcuerdo(double pAcuerdo)
        {
            Console.WriteLine();
            Console.WriteLine("El acuerdo de descubierto de la cuenta es: " + pAcuerdo);
        }

        static void PantallaClienteEncontrado(Cliente pCliente)
        {
            Console.WriteLine();
            Console.WriteLine("Cliente: " + (pCliente.Nombre));
            Console.WriteLine("Con tipo de documento: " + (pCliente.TipoDocumento) + "  y Nro: " + (pCliente.NroDocumento));
            Console.WriteLine();
            Console.WriteLine("Operaciones a realizar:");
            Console.WriteLine("0- Inicializar Cuenta Corriente sin saldo");
            Console.WriteLine("1- Inicializar Cuenta Corriente con saldo");
            Console.WriteLine("2- Inicializar Caja de Ahorro sin saldo");
            Console.WriteLine("3- Inicializar Caja de Ahorro con saldo");
        }

        static void PantallaDeSaldos()
        {
            Console.WriteLine();
            Console.WriteLine("1- Revisar Cuenta Corriente");
            Console.WriteLine("2- Revisar Caja de Ahorro");
            Console.WriteLine("3- Debitar saldo Cuenta Corriente");
            Console.WriteLine("4- Debitar saldo Caja de Ahorro");
            Console.WriteLine("5- Acreditar saldo Cuenta Corriente");
            Console.WriteLine("6- Acreditar saldo Caja de Ahorro");
            Console.WriteLine("Para salir pulse cualquier otro número");
        }
    
    }
}

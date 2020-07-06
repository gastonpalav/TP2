using Business.Entities;
using Business.Logic;
using System;

namespace UI.Consola
{
    public class Usuarios
    {
        private UsuarioLogic UsuarioNegocio;

        public Usuarios()
        {
            this.UsuarioNegocio = new UsuarioLogic();
        }

        public void Menu()

        {
            Console.WriteLine("Seleccione opcion : 1- Listado general , 2 - Consulta , 3- Agregar , 4-Modificar , 5- Eliminar , 6- Salir");

            Console.WriteLine("  ");
            ConsoleKeyInfo opcion = Console.ReadKey();
            Console.WriteLine("  ");
            while (opcion.Key != ConsoleKey.D6)

            {
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        ListadoGeneral();
                        break;

                    case ConsoleKey.D2:
                        Consultar();
                        break;

                    case ConsoleKey.D3:
                        Agregar();
                        break;

                    case ConsoleKey.D4:
                        Modificar();
                        break;

                    case ConsoleKey.D5:
                        Eliminar();
                        break;
                }
                Console.WriteLine("1– Listado General \n 2– Consulta \n 3– Agregar \n 4 - Modificar \n 5 - Eliminar \n 6 - Salir");
                Console.WriteLine("  ");
                opcion = Console.ReadKey();
                Console.WriteLine("  ");
            }

            Console.ReadKey();
        }

        private void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                this.UsuarioNegocio.Delete(ID);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        private void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(ID);
                Console.Write("Ingrese Nombre: ");
                usuario.Nombre = Console.ReadLine();
                Console.Write("Ingrese Apellido: ");
                usuario.Apellido = Console.ReadLine();
                Console.Write("Ingrese Clave: ");
                usuario.Clave = Console.ReadLine();
                Console.Write("Ingrese Email: ");
                usuario.Email = Console.ReadLine();
                Console.Write("Ingrese Habilitacion de Usuario (1-Si/otro-No): ");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modified;
                this.UsuarioNegocio.Save(usuario);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("LA ID ingresada debe ser un numero entero");
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        private void Agregar()
        {
            Usuario usuario = new Usuario();

            Console.Clear();
            Console.Write("Ingrese Nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido: ");
            usuario.Apellido = Console.ReadLine();
            Console.Write("Ingrese Nombre de Usuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.Write("Ingrese Clave: ");
            usuario.Clave = Console.ReadLine();
            Console.Write("Ingrese Email: ");
            usuario.Email = Console.ReadLine();
            Console.Write("Ingrese Habilitacion de Usuario (1-Si/otro-No): ");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New;
            this.UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", usuario.ID);
        }

        private void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del Usuario a consultar : ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(this.UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada no es un numero entero");
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Precione una tecla para continuar");
                Console.ReadKey();
            }
        }

        private void ListadoGeneral()
        {
            Console.Clear();

            foreach (Usuario usuario in this.UsuarioNegocio.GetAll())
            {
                MostrarDatos(usuario);
            }
        }

        private void MostrarDatos(Usuario usuario)
        {
            Console.WriteLine("Usuario: {0}", usuario.ID);
            Console.WriteLine("\t\tNombre: {0}", usuario.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usuario.Apellido);
            Console.WriteLine("\t\tNombre De Usuario: {0}", usuario.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usuario.Clave);
            Console.WriteLine("\t\tEmail: {0}", usuario.Email);
            Console.WriteLine("\t\tHabilitado: {0}", usuario.Habilitado);
            Console.WriteLine();
        }
    }
}
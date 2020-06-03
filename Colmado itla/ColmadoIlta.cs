using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Colmado_itla
{


    public class Colmado
    {

        enum OpcionMenuProducto
        {
            AGREGAR = 1,
            EDITAR,
            ELIMINAR,
            MENU_PRINCIPAL,
        }
        enum OpcionMenuColamdo
        {
            PRODUCTOS = 1,
            CLIENTES,
            VENTAS,
            CERRAR,
        }

        enum OpcionMenuCliente
        {
            AGREGAR = 1,
            EDITAR,
            ELIMINAR,
            MENU_PRINCIPAL,
        }
        enum OpcionMenuVentas
        {
            VENDER = 1,
            MENU_PRINCIPAL,
        }
        List<Clientes> ListaCliente = new List<Clientes>();
        List<Productos> ListaProductos = new List<Productos>();

        public static void Main(string[] args)
        {
            Colmado colmado = new Colmado();
            colmado.MenuPrincipal();

        }

        public void AgregarCliente()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Inserte el nombre del cliente");
                String nombre = Console.ReadLine();


                Clientes cliente = new Clientes()
                {
                    Nombre = nombre,
                };

                ListaCliente.Add(cliente);

                Console.WriteLine("El cliente ha sido agregado \n Presione Cualquiere tecla para volver al menu");
                Console.ReadKey();
                Console.Clear();
                MenuClientes();




            }
            catch (Exception)
            {
                Console.WriteLine("Por favor introducir una opcion valida");
                Console.ReadKey();
                Console.Clear();
                AgregarCliente();

                throw;
            }
        }

        public void EditarCliente()
        {
            try
            {
                Console.WriteLine("Por favor inserte el nombre del Cliente a editar \n Inserte la primera letra en mayuscula");
                String busqueda = Console.ReadLine();

                Clientes cliente = ListaCliente.FirstOrDefault(X => X.Nombre == busqueda);

                if (cliente == null)
                {
                    Console.Clear();
                    Console.WriteLine("Cliente no encontrado \n Por favor trate de nuevo");
                    Console.ReadKey();
                    EditarCliente();
                }

                Console.WriteLine("Inserte el nuevo nombre del Cliente");
                String nombre = Console.ReadLine();


                cliente.Nombre = nombre;


                Console.WriteLine("El cliente ha sido modificado!");
                Console.ReadKey();
                Console.Clear();
                MenuClientes();


            }
            catch (Exception)
            {
                Console.WriteLine("Por favor introducir una opcion valida");
                Console.ReadKey();
                Console.Clear();
                EditarCliente();

                throw;
            }

        }

        public void BorrarCliente()
        {
            try
            {
                Console.WriteLine("Inserte el nombre del cliente que desea eliminar \n Escribir la primera letra en mayuscula");
                String busqueda = Console.ReadLine();

                Clientes cliente = ListaCliente.FirstOrDefault(X => X.Nombre == busqueda);

                if (cliente == null)
                {
                    Console.Clear();
                    Console.WriteLine("Cliente no encontrado \n Por favor trate de nuevo");
                    Console.ReadKey();
                    BorrarCliente();
                }

                ListaCliente.Remove(cliente);

                Console.WriteLine("El Cliente ha sido elminado");
                Console.ReadKey();
                Console.Clear();
                MenuClientes();

            }
            catch (Exception)
            {
                Console.WriteLine("Por favor introducir una opcion valida");
                Console.ReadKey();
                Console.Clear();
                BorrarCliente();

            }

        }

        public void AgregarProducto()
        {

            try
            {
                Console.Clear();
                Console.WriteLine("Inserte el nombre del producto");
                String nombre = Console.ReadLine();
                Console.WriteLine("Inserte la cantidad de productos");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el precio del productos");
                int precio = Convert.ToInt32(Console.ReadLine());

                Productos producto = new Productos()
                {
                    Nombre = nombre,
                    Cantidad = cantidad,
                    Precio = precio,

                };

                ListaProductos.Add(producto);

                Console.WriteLine("El producto ha sido agregado \n Presione Cualquiere tecla para volver al menu");
                Console.ReadKey();
                Console.Clear();
                MenuProductos();



            }
            catch (Exception)
            {
                Console.WriteLine("Por favor introducir una opcion valida");
                Console.ReadKey();
                Console.Clear();
                AgregarProducto();

                throw;
            }
        }

        public void EditarProducto()
        {

            try
            {
                Console.WriteLine("Por favor inserte el nombre del producto a editar \n Inserte la primera letra en mayuscula");
                String busqueda = Console.ReadLine();

                Productos producto = ListaProductos.FirstOrDefault(X => X.Nombre == busqueda);

                if (producto == null)
                {
                    Console.Clear();
                    Console.WriteLine("Producto no encontrado \n Por favor trate de nuevo");
                    Console.ReadKey();
                    EditarProducto();
                }

                Console.WriteLine("Inserte el nuevo nombre del producto");
                String nombre = Console.ReadLine();
                Console.WriteLine("Inserte la nueva cantidad del producto");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el nuevo precio del producto");
                int precio = Convert.ToInt32(Console.ReadLine());

                producto.Nombre = nombre;
                producto.Cantidad = cantidad;
                producto.Precio = precio;

                Console.WriteLine("El prodcuto ha sido modificado!");
                Console.ReadKey();
                Console.Clear();
                MenuProductos();

            }
            catch (Exception)
            {
                Console.WriteLine("Por favor introducir una opcion valida");
                Console.ReadKey();
                Console.Clear();
                EditarProducto();

                throw;
            }

        }

        public void BorrarProducto()
        {

            try
            {
                Console.WriteLine("Inserte el nombre del producto que desea eliminar \n Escribir la primera letra en mayuscula");
                String busqueda = Console.ReadLine();

                Productos producto = ListaProductos.FirstOrDefault(X => X.Nombre == busqueda);

                if (producto == null)
                {
                    Console.Clear();
                    Console.WriteLine("Producto no encontrado \n Por favor trate de nuevo");
                    Console.ReadKey();
                    BorrarProducto();
                }

                ListaProductos.Remove(producto);

                Console.WriteLine("El prodcuto ha sido elminado");
                Console.ReadKey();
                Console.Clear();
                MenuProductos();
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor introducir una opcion valida");
                Console.ReadKey();
                Console.Clear();
                BorrarProducto();

            }

        }


        public void MenuPrincipal()
        {

            try
            {

                Console.Clear();
                Console.WriteLine("Bienvenido al colmado itla \nPor favor selecccione una opcion");
                Console.WriteLine("1. Menu Productos \n2.Menu Clientes \n3.Menu Ventas \n4.Cerrar Tienda");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case (int)OpcionMenuColamdo.PRODUCTOS:
                        Console.Clear();
                        MenuProductos();
                        break;
                    case (int)OpcionMenuColamdo.CLIENTES:
                        MenuClientes();
                        break;
                    case (int)OpcionMenuColamdo.VENTAS:
                        MenuVentas();
                        break;
                    case (int)OpcionMenuColamdo.CERRAR:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Por favor introducir una opcion valida");
                        Console.ReadKey();
                        MenuPrincipal();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor introducir una opcion valida");
                Console.ReadKey();
                MenuPrincipal();

            }

        }

        public void MenuClientes()
        {


            try
            {
                Console.Clear();
                Console.WriteLine("1. Agregar Cliente \n2. Editar Cliente \n3. Eliminar Clintes \n4. Menu Princial");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case (int)OpcionMenuCliente.AGREGAR:
                        AgregarCliente();
                        break;
                    case (int)OpcionMenuCliente.EDITAR:
                        EditarCliente();
                        break;
                    case (int)OpcionMenuCliente.ELIMINAR:
                        BorrarCliente();
                        break;
                    case (int)OpcionMenuCliente.MENU_PRINCIPAL:
                        MenuPrincipal();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Por favor introducir una opcion valida");
                        Console.ReadKey();
                        MenuClientes();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor introducir una opcion valida");
                Console.ReadKey();
                MenuClientes();

            }


        }

        public void MenuProductos()
        {





            try
            {
                Console.Clear();
                Console.WriteLine("1. Agregar Producto \n 2. Editar Producto \n 3. Eliminar Producto \n 4. Menu Princial");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case (int)OpcionMenuProducto.AGREGAR:
                        Console.Clear();
                        AgregarProducto();
                        break;
                    case (int)OpcionMenuProducto.EDITAR:
                        EditarProducto();
                        break;
                    case (int)OpcionMenuProducto.ELIMINAR:
                        BorrarProducto();
                        break;
                    case (int)OpcionMenuProducto.MENU_PRINCIPAL:
                        MenuPrincipal();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Por favor introducir una opcion valida");
                        Console.ReadKey();
                        MenuProductos();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor introducir una opcion valida");
                Console.ReadKey();
                MenuProductos();

            }


        }
        public void MenuVentas()
        {




            try
            {
                Console.Clear();
                Console.WriteLine("1. Realizar venta  \n 2. Menu Princial");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case (int)OpcionMenuVentas.VENDER:
                        Vender();
                        break;
                    
                    case (int)OpcionMenuVentas.MENU_PRINCIPAL:
                        MenuPrincipal();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Por favor introducir una opcion valida");
                        Console.ReadKey();
                        MenuVentas();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor introducir una opcion valida");
                Console.ReadKey();
                MenuVentas();

            }


        }

        public void Vender()
        {
            List<Productos> ListaProductosVender = new List<Productos>();

            Console.WriteLine("Por favor inserte el nombre del Cliente que comprara \n Inserte la primera letra en mayuscula");
            String busqueda = Console.ReadLine();

            Clientes cliente = ListaCliente.FirstOrDefault(X => X.Nombre == busqueda);
            Console.Clear();

            if (cliente == null)
            {
                Console.Clear();
                Console.WriteLine("Cliente no encontrado \n Por favor trate de nuevo");
                Console.ReadKey();
                Vender();
            }
            bool repeat = true;
            while (repeat)
            {
                SeleccionProducto(ListaProductosVender, out repeat);

            }
            Ventas ventas = new Ventas();
            ventas.Cliente = cliente;
            ventas.Productos = ListaProductosVender;
            Console.WriteLine("Resumen de venta");
            foreach (var producto in ListaProductosVender)
            {

                Console.WriteLine($"Producto: {producto.Nombre }, Cantidad: {producto.Cantidad}, Precio: {producto.Precio} , Subtotal: {producto.Subtotal }");


            }

            Console.ReadKey();
        }

        private void SeleccionProducto(List<Productos> ListaProductosVender ,out bool repeat)
        {
            foreach (var producto in ListaProductos)
            {

                Console.WriteLine($"Producto: {producto.Nombre }, Cantidad: {producto.Cantidad}, Precio: {producto.Precio} ");


            }
            Console.ReadKey();

            Console.WriteLine("Por favor inserte el nombre del producto a comprar \n Inserte la primera letra en mayuscula");
            String productoElegir = Console.ReadLine();
            Console.WriteLine("Cuantos desea comprar");
            int CantidadProdcuto = Convert.ToInt32(Console.ReadLine());

            Productos productos = ListaProductos.FirstOrDefault(X => X.Nombre == productoElegir);

            if (productos.Cantidad < CantidadProdcuto)
            {
                Console.WriteLine("No hay suficiente en inventario");
            }

            productos.Cantidad = CantidadProdcuto;
            ListaProductosVender.Add(productos);

            Console.WriteLine("Productos seleccionados");
            foreach (var producto in ListaProductosVender)
            {

                Console.WriteLine($"Producto: {producto.Nombre }, Cantidad: {producto.Cantidad}, Precio: {producto.Precio} ");


            }
            Console.WriteLine("Seleccione una opcion.\n 1. Agregar otro producto\n 2. Terminar la compra");
            int seleccion = Convert.ToInt32(Console.ReadLine());

            
            repeat = seleccion == 2;
        }
        
    }
}

using System;
using PracticaFinal_20200874.Clases;
using System.Threading;
using System.Text;
using System.Text.RegularExpressions;




namespace PracticaFinal_20200874
{
    class Program
    {
       


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.Clear();
            string valorDeposito;
            String nombre=string.Empty, apellido, ide, sexo, estado, direccion;
            long telefono, identi;
            int agn, mes, dia;
            bool valid;
            
            float Balanc;

            string diaS, mesS, agnoS, telS;//para validar

            Persona persona1 = new Persona();



            Console.WriteLine("");
            Console.WriteLine("\t\t\t ██████╗░██╗███████╗███╗░░██╗██╗░░░██╗███████╗███╗░░██╗██╗██████╗░░█████╗░");
            Console.WriteLine("\t\t\t ██╔══██╗██║██╔════╝████╗░██║██║░░░██║██╔════╝████╗░██║██║██╔══██╗██╔══██╗");
            Console.WriteLine("\t\t\t ██████╦╝██║█████╗░░██╔██╗██║╚██╗░██╔╝█████╗░░██╔██╗██║██║██║░░██║██║░░██║");
            Console.WriteLine("\t\t\t ██╔══██╗██║██╔══╝░░██║╚████║░╚████╔╝░██╔══╝░░██║╚████║██║██║░░██║██║░░██║");
            Console.WriteLine("\t\t\t ██████╦╝██║███████╗██║░╚███║░░╚██╔╝░░███████╗██║░╚███║██║██████╔╝╚█████╔╝");
            Console.WriteLine("\t\t\t ╚═════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝╚═╝╚═════╝░░╚════╝░");
            

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("A Continuacion Procederemos A La Recoleccion De Datos Para Realizar El Registro Bancario");
            Console.WriteLine("");

            Console.WriteLine("Introduzca Su Nombre, Por favor: ");
            Console.SetCursorPosition(33, 11);
            nombre = Console.ReadLine();

            while (persona1.Letra(nombre))
            {
                //Llamar metodo que evalua los caracteres
                if (persona1.Letra(nombre))
                {
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("Introduzca Su Nombre, Por favor: " + "t\t\t\t\t Solo se aceptan letras");
                    Console.SetCursorPosition(33, 11);
                    nombre = Console.ReadLine();
                }
                else
                {
                    
                }
                
            }
//=======================================================APELLIDO================================================================================
            Console.WriteLine("Introduzca Su Apellido, Por favor: ");
            Console.SetCursorPosition(35, 12);
            apellido = Console.ReadLine();

            while (persona1.Letra(apellido))
            {
                //Llamar metodo que evalua los caracteres
                if (persona1.Letra(apellido))
                {
                    Console.SetCursorPosition(0, 12);
                    Console.WriteLine("Introduzca Su Apellido, Por favor: " + "t\t\t\t\t Solo se aceptan letras");
                    Console.SetCursorPosition(35, 12);
                    apellido = Console.ReadLine();
                }
                else
                {

                }

            }

            //------------------------------------------------------------DIA--------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Dia De Nacimiento, Por favor: ");
            Console.SetCursorPosition(31, 13);
            diaS = Console.ReadLine();
            valid = int.TryParse(diaS, out dia);
            while (valid = !int.TryParse(diaS, out dia))
            {
                Console.SetCursorPosition(0, 13);
                Console.WriteLine("Dia De Nacimiento, Por favor: " + "\t\t\t Borre y vuelva a intentarlo");
                Console.SetCursorPosition(31, 13);
                diaS = Console.ReadLine();
            }

            while (dia > 31 || dia < 1)
            {
                try
                {
                    Console.SetCursorPosition(0, 13);
                    Console.WriteLine("Dia De Nacimiento, Por favor: " + "\t\t\t Borre y vuelva a intentarlo");
                    Console.SetCursorPosition(31, 13);
                    dia = int.Parse(Console.ReadLine());

                }
                catch (FormatException e)
                {

                }
            }

  //------------------------------------------------------------MES--------------------------------------------------------------------
  //---------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Mes De Nacimiento, Por favor: ");
            Console.SetCursorPosition(31, 14);
            mesS = Console.ReadLine();
            valid = int.TryParse(mesS, out mes);
            while (valid = !int.TryParse(mesS, out mes))
            {
                Console.SetCursorPosition(0, 14);
                Console.WriteLine("Mes De Nacimiento, Por favor: " + "\t\t\t Borre y vuelva a intentarlo");
                Console.SetCursorPosition(31, 14);
                mesS = Console.ReadLine();
            }

            while (mes > 12 || mes < 1)
            {
                try
                {
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("Mes De Nacimiento, Por favor: " + "\t\t\t Borre y vuelva a intentarlo");
                    Console.SetCursorPosition(31, 14);
                    mes = int.Parse(Console.ReadLine());
                    


                }
                catch (FormatException e)
                {

                }
            }
//------------------------------------------------------------AGNO--------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Agno De Nacimiento, Por favor: ");
            Console.SetCursorPosition(31, 15);
            agnoS = Console.ReadLine();
            valid = int.TryParse(agnoS, out agn);
            while (valid = !int.TryParse(agnoS, out agn))
            {
                Console.SetCursorPosition(0, 15);
                Console.WriteLine("Agno De Nacimiento, Por favor: " + "\t\t\t Borre y vuelva a intentarlo");
                Console.SetCursorPosition(31, 15);
                agnoS = Console.ReadLine();

               
            }

            while (agn>2003 || agn<1915)
            {
                try
                {
                    Console.SetCursorPosition(0, 15);
                    Console.WriteLine("Agno De Nacimiento, Porfavor: " + "\t\t\t Borre y vuelva a intentarlo");
                    Console.SetCursorPosition(31, 15);
                    agn = int.Parse(Console.ReadLine());

                }
                catch (FormatException e)
                {
                
                }
            }
//------------------------------------------------------------ID--------------------------------------------------------------------
  //---------------------------------------------------------------------------------------------------------------------------------
         
            Console.WriteLine("Introduzca Su Numero de Identificacion: ");
            Console.SetCursorPosition(40, 16);
            ide = Console.ReadLine();
            valid = long.TryParse(ide, out identi);
            while (valid = !long.TryParse(ide, out identi))
            {
                Console.SetCursorPosition(0, 16);
                Console.WriteLine("Introduzca Su Numero de Identificacion: " + "\t\t\t Borre y vuelva a intentarlo");
                Console.SetCursorPosition(40, 16);
                ide = Console.ReadLine();
            }

            /*while (ide.Length != 13)
            {
                if (ide.Length > 13)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error has excedido la cantidad de caracteres");
                    Console.WriteLine("Introduce Tu Numero de Identificacion Con Guiones nuevamente");
                    ide = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error No Has Completado La Cantidad De Caracteres");
                    Console.WriteLine("Introduce Tu Numero de Identificacion Con Guiones nuevamente");
                    ide = Console.ReadLine();
                }
                sexo.Equals('M')||sexo.Equals('m')/*|| sexo.Equals('f')|| sexo.Equals('F')
        }*/

   //------------------------------------------------------------SEXO--------------------------------------------------------------------
  //---------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Introduzca Su Sexo M/F: ");
            Console.SetCursorPosition(25, 17);
            sexo = Console.ReadLine();
            while (!sexo.Equals("F")&&!sexo.Equals("M")&&!sexo.Equals("m")&&!sexo.Equals("f"))
            {
                Console.SetCursorPosition(0, 17);
                Console.WriteLine("Introduzca Su Sexo M/F:  " + "\t\t\t Borre y vuelva a intentarlo");
                Console.SetCursorPosition(25, 17);
                sexo = Console.ReadLine();
            }
 //------------------------------------------------------------ESTADO--------------------------------------------------------------------
  //---------------------------------------------------------------------------------------------------------------------------------          
            Console.WriteLine("Introduzca Su Estado Civil: ");
            Console.SetCursorPosition(28, 18);
            estado = Console.ReadLine();
//------------------------------------------------------------TELEFONO--------------------------------------------------------------------
  //---------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Introduzca Su Telefono: ");
            Console.SetCursorPosition(25, 19);
            telS = Console.ReadLine();
            valid = long.TryParse(telS, out telefono);
            while (valid = !long.TryParse(telS, out telefono))
            {
                Console.SetCursorPosition(0, 19);
                Console.WriteLine("Introduzca Su Telefono: " + "\t\t\t Borre y vuelva a intentarlo");
                Console.SetCursorPosition(25, 19);
                telS = Console.ReadLine();
            }
//------------------------------------------------------------DIRECCION--------------------------------------------------------------------
  //---------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Introduzca Su Direccion: ");
            Console.SetCursorPosition(25, 20);
            direccion = Console.ReadLine();          
            Console.Clear();
            Console.ReadKey();
//------------------------------------------------------------INSTANCIAS Y METODOS--------------------------------------------------------------------
  //---------------------------------------------------------------------------------------------------------------------------------
            DateTime fecha2 = new DateTime(agn, mes, dia);
            
            Persona mipersona = new Persona( nombre, apellido, identi,fecha2,sexo,estado,telefono,direccion);
            mipersona.setvalidacion(agn, mes, dia);


           
            Console.WriteLine("\t\t\t__________________________________________________________________________");
            Console.WriteLine("\t\t\t Gracias Por Proporcionar Tus Datos, Estos se mostraran a continuacion ");
            Console.WriteLine("\t\t\t__________________________________________________________________________");
            Console.WriteLine("\t\t\t Espere Porfavor...");
            Thread.Sleep(1000);

            mipersona.MostrarDatos();

            Console.WriteLine("\t\t\t Para Proceder A Crear Su Cuenta Pulse ENTER...");
            Console.SetCursorPosition(75, 16);
            Console.ReadKey();
            Console.Clear();
            
           /* int cargar1 = 30, cargar2 = 0, stop = 100;
            while (cargar2 <= stop)

            {
                Console.WriteLine();
                Console.SetCursorPosition(30, 14);
                Console.Write(" CREANDO CUENTA % " + cargar2);
                Thread.Sleep(100);
                Console.SetCursorPosition(30, 10);
                Console.Write("|————————————————————————————————————————————————|");
                Console.SetCursorPosition(30, 12);
                Console.Write("|————————————————————————————————————————————————|");
                Console.SetCursorPosition(30, 11);
                Console.Write("|");
                Console.SetCursorPosition(79, 11);
                Console.Write("|");
                cargar2++;

                if (cargar1 < 80)
                {
                    Console.SetCursorPosition(cargar1, 11);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("»");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(100);
                }
                cargar1++;
                
            }*/

            Console.Clear();

            Cuenta micuenta1 = new Cuenta(); //constructor vacio

            Console.WriteLine("\t\t\t ———————————————————————————————————————————————————");
            Console.WriteLine("\t\t\t SU CUENTA HA SIDO CREADA CON EXITO");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t TITULAR DE LA CUENTA: " + mipersona.getNombre);
            Console.WriteLine("\t\t\t NUMERO DE CUENTA: " + micuenta1.getNumero().ToString("##-##-##"));
            Console.WriteLine("\t\t\t BALANCE: " + micuenta1.getBalance());
            Console.WriteLine("\t\t\t ———————————————————————————————————————————————————");

            Console.WriteLine("");
            Console.WriteLine("\t\t\t PARA PODER ACTIVAR TU CUENTA DEBES REALIZAR UN DEPOSITO, PULSA ENTER...");
            Console.SetCursorPosition(100, 8);
            Console.ReadLine();
//------------------------------------------------------------DEPOSITO INICIAL--------------------------------------------------------------------
  //---------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\t\t\t INTRODUZCA EL MONTO A DEPOSITAR: ");
            Console.SetCursorPosition(60, 9);
            valorDeposito = Console.ReadLine();
            valid = float.TryParse(valorDeposito, out Balanc);

            while (valid = !float.TryParse(valorDeposito, out Balanc))
            {
                Console.SetCursorPosition(0, 9);
                Console.WriteLine("\t\t\t INTRODUZCA EL MONTO A DEPOSITAR: ");
                Console.SetCursorPosition(60, 9);
                valorDeposito = Console.ReadLine();
            }
            while (Balanc <= 0) //VALIDAR QUE NO SE DEPOSITE 0 NI ALGO NEGATIVO
            {
                Console.Clear();
                if (Balanc == 0)//VALIDACION PARA 0
                {
                    Console.WriteLine("\t\t\t DEPOSITO FALLIDO NO HAS ASIGNADO UN MONTO");
                    Console.WriteLine("");
                }
                else if (Balanc < 0) //VALIDACION PARA NEGATIVO
                {
                    Console.WriteLine("\t\t\t DEPOSITO FALLIDO EL MONTO ASIGNADO EN NEGATIVO");
                    Console.WriteLine("");
                }

                Console.WriteLine("\t\t\t INTRODUZCA LA CANTIDAD A DEPOSITAR: ");
                Console.SetCursorPosition(60, 2);
                valorDeposito = Console.ReadLine();

                while (valid = !float.TryParse(valorDeposito, out Balanc))
                {  //BUCLE POR SI SE INTRODUCE LETRA NUEVAMENTE
                    Console.Clear();
                    Console.WriteLine("\t\t\t HAS INTRODUCIDO UN CARACTER DESCONOCIDO VUELVE A INTENTARLO");
                    Console.WriteLine("");
                    Console.WriteLine("\t\t\t INTRODUZCA LA CANTIDAD A DEPOSITAR: " + "\t\t\t\t BORRE Y VUELVA A INTENTARLO");
                    Console.SetCursorPosition(60, 2);
                    valorDeposito = Console.ReadLine();
                    Console.WriteLine("");
                }
                
            } 
//------------------------------------------------------------VARIABLES ALGUNAS PARA LA CUENTA--------------------------------------------------------------------
  //---------------------------------------------------------------------------------------------------------------------------------
            string elegido = "1";
            float BalanceD, BalanceR;
            String valor;
            string editarvalor, editar;
            long telEdi;

            double montoPrestamo;
            int tiempo;

            

            while (elegido!="0")
            {
                Console.Clear();
                Cuenta micuenta = new Cuenta(Balanc);
               


                Console.WriteLine("\t\t\t BIENVENIDO A SU CUENTA " + mipersona.getNombre);
                Console.WriteLine("");
                Console.WriteLine("\t\t\t ELIGE TU OPCION ");
                Console.WriteLine("\t\t\t --> 1. PARA REALIZAR UN DEPOSITO.");
                Console.WriteLine("\t\t\t --> 2. PARA REALIZAR UN RETIRO.");
                Console.WriteLine("\t\t\t --> 3. PARA VER TU BALANCE.");
                Console.WriteLine("\t\t\t --> 4. PARA VER TU PERFIL.");
                Console.WriteLine("\t\t\t --> 5. PARA PARA VER TU INFORMACION PERSONAL.");
                Console.WriteLine("\t\t\t --> 6. PARA EDITAR DATOS");
                Console.WriteLine("\t\t\t --> 7. PARA CALCULAR PRESTAMO");
                Console.WriteLine("\t\t\t --> 8. PARA SALIR");

                Console.CursorLeft = 25;
                elegido = Console.ReadLine();
                


                switch (elegido)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\t\t\t BIENVENIDO " + mipersona.getNombre+ " REALIZA TU DEPOSITO");
                     //   Console.WriteLine("\t\t\t INTRODUCE EL NUMERO DE CUENTA DEL DESTINATARIO: ");
                        Console.WriteLine("\t\t\t INTRODUZCA LA CANTIDAD A DEPOSITAR: ");
                        Console.SetCursorPosition(60, 1);
                        valor = Console.ReadLine();

                        valid = float.TryParse(valor, out BalanceD);
                        
                        while(valid=!float.TryParse(valor, out BalanceD))
                        {
                            //VALIDAR QUE NO SE ENTRE LETRA
                            Console.Clear();
                            Console.WriteLine("\t\t\t HAS INTRODUCIDO UN CARACTER DESCONOCIDO VUELVE A INTENTARLO");
                            Console.WriteLine("");
                            Console.WriteLine("\t\t\t INTRODUZCA LA CANTIDAD A DEPOSITAR: ");
                            Console.SetCursorPosition(60, 2);
                            valor = Console.ReadLine();
                            Console.WriteLine("");
                        }
     
                        while (BalanceD<=0) //VALIDAR QUE NO SE DEPOSITE 0 NI ALGO NEGATIVO
                        {
                            Console.Clear();
                            if (BalanceD == 0)//VALIDACION PARA 0
                            {
                                Console.WriteLine("\t\t\t DEPOSITO FALLIDO NO HAS ASIGNADO UN MONTO");
                                Console.WriteLine("");
                            }
                            else if (BalanceD < 0) //VALIDACION PARA NEGATIVO
                            {
                                Console.WriteLine("\t\t\t DEPOSITO FALLIDO EL MONTO ASIGNADO EN NEGATIVO");
                                Console.WriteLine("");
                            }

                            Console.WriteLine("\t\t\t INTRODUZCA LA CANTIDAD A DEPOSITAR: ");
                            Console.SetCursorPosition(60, 2);
                            valor = Console.ReadLine();

                                 while (valid = !float.TryParse(valor, out BalanceD))
                                 {  //BUCLE POR SI SE INTRODUCE LETRA NUEVAMENTE
                                        Console.Clear();
                                        Console.WriteLine("\t\t\t HAS INTRODUCIDO UN CARACTER DESCONOCIDO VUELVE A INTENTARLO");
                                        Console.WriteLine("");
                                        Console.WriteLine("\t\t\t INTRODUZCA LA CANTIDAD A DEPOSITAR: ");
                                        Console.SetCursorPosition(60, 2);
                                        valor = Console.ReadLine();
                                        Console.WriteLine("");
                                 }

                        }

                        Balanc=micuenta.getDeposito(BalanceD); //METODO PARA SUMAR LOS DEPOSITOS
                      //  Balanc = Balanc + BalanceD;

                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("\t\t\t BIENVENIDO " + mipersona.getNombre + " REALIZA TU RETIRO");
                        Console.WriteLine("\t\t\t TU BALANCE ES DE: " + micuenta.getBalance().ToString("0.0"));
                        Console.WriteLine("\t\t\t INTRODUZCA LA CANTIDAD A RETIRAR: ");
                        Console.SetCursorPosition(60, 2);
                        valor = Console.ReadLine();

                        valid = float.TryParse(valor, out BalanceR);

                        while (valid = !float.TryParse(valor, out BalanceR))
                        {
                            //VALIDAR QUE NO SE ENTRE LETRA
                            Console.Clear();
                            Console.WriteLine("\t\t\t HAS INTRODUCIDO UN CARACTER DESCONOCIDO VUELVE A INTENTARLO");
                            Console.WriteLine("");
                            Console.WriteLine("\t\t\t INTRODUZCA LA CANTIDAD A RETIRAR: ");
                            Console.SetCursorPosition(60, 2);
                            valor = Console.ReadLine();
                            Console.WriteLine("");
                        }


                        while (BalanceR <= 0) //VALIDAR QUE NO SE retire 0 NI ALGO NEGATIVO
                        {
                            Console.Clear();
                            if (BalanceR == 0)//VALIDACION PARA 0
                            {
                                Console.WriteLine("\t\t\t RETIRO FALLIDO NO HAS ASIGNADO UN MONTO");
                                Console.WriteLine("");
                            }
                            else if (BalanceR < 0) //VALIDACION PARA NEGATIVO
                            {
                                Console.WriteLine("\t\t\t RETIRO FALLIDO EL MONTO ASIGNADO EN NEGATIVO");
                                Console.WriteLine("");
                            }

                            Console.WriteLine("\t\t\t INTRODUZCA LA CANTIDAD A RETIRAR: ");
                            Console.SetCursorPosition(60, 2);
                            valor = Console.ReadLine();
                            while (valid = !float.TryParse(valor, out BalanceR))
                            {  //BUCLE POR SI SE INTRODUCE LETRA NUEVAMENTE
                                Console.Clear();
                                Console.WriteLine("\t\t\t HAS INTRODUCIDO UN CARACTER DESCONOCIDO VUELVE A INTENTARLO");
                                Console.WriteLine("");
                                Console.WriteLine("\t\t\t INTRODUZCA LA CANTIDAD A RETIRAR: ");
                                Console.SetCursorPosition(60, 2);
                                valor = Console.ReadLine();
                                Console.WriteLine("");
                            }

                            
                        }
                        float BalanceRerror = micuenta.getBalance();
                        while (BalanceR > BalanceRerror)
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\tNO PUEDES REALIZAR ESTE RETIRO PORQUE EL SALDO ES INSUFUCIENTE ");
                            Console.WriteLine("\t\t\t INTRODUZCA LA CANTIDAD A RETIRAR: ");
                            Console.SetCursorPosition(60, 2);
                            valor = Console.ReadLine();                           

                            while (valid = !float.TryParse(valor, out BalanceR))
                            {
                                //VALIDAR QUE NO SE ENTRE LETRA
                                Console.Clear();
                                Console.WriteLine("\t\t\t HAS INTRODUCIDO UN CARACTER DESCONOCIDO VUELVE A INTENTARLO");
                                Console.WriteLine("");
                                Console.WriteLine("\t\t\t INTRODUZCA LA CANTIDAD A RETIRAR: ");
                                Console.SetCursorPosition(60, 2);
                                valor = Console.ReadLine();
                                Console.WriteLine("");
                            }
                        }

                        Balanc = micuenta.getRetiro(BalanceR);
                        break;
                        
                    case "3":
                        Console.WriteLine("\t\t\t "+mipersona.getNombre + " TU BALANCE ES DE: " + micuenta.getBalance().ToString("0,0") + " $");
                        Console.CursorLeft = 30;
                        Console.ReadLine();
                        break;
                        
                    case "4":
                        Console.WriteLine("\t\t\t ———————————————————————————————————————————————————");
                        Console.WriteLine("\t\t\t PERFIL DE " + mipersona.getNombre);
                        Console.WriteLine("");
                        Console.WriteLine("\t\t\t TITULAR DE LA CUENTA: " + mipersona.getNombre);
                        Console.WriteLine("\t\t\t NUMERO DE CUENTA: " + micuenta1.getNumero().ToString("##-##-##"));
                        Console.WriteLine("\t\t\t BALANCE: " + micuenta.getBalance().ToString("0,0") + " $");
                        Console.WriteLine("\t\t\t ———————————————————————————————————————————————————");
                        Console.ReadLine();

                        break;
                    case "5":
                        mipersona.MostrarDatos();
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("PRESIONE LA OPCION QUE DESEA EDITAR");
                        Console.WriteLine("1. EDITAR DIRECCION");
                        Console.WriteLine("2. EDITAR NUMERO");
                        Console.WriteLine("3. EDITAR ESTADO CIVIL");

                        editarvalor = Console.ReadLine();
                        
                        if (editarvalor == "1")
                        {
                            Console.WriteLine("INTRODUCE TU NUEVA DIRECCION:");
                            editar = Console.ReadLine();
                            mipersona.EditarD(editar);
                        }
                        else if (editarvalor == "2")
                        {
                            Console.WriteLine("INTRODUCE TU NUEVO NUMERO:");
                            valor = Console.ReadLine();
                            valid = long.TryParse(valor, out telEdi);

                            while(valid =!long.TryParse(valor, out telEdi))
                            {
                                Console.WriteLine("INTRODUCE TU NUEVO NUMERO:");
                                valor = Console.ReadLine();
                            }

                            mipersona.EditarN(telEdi);
                        }
                        else if(editarvalor=="3")
                        {
                            Console.WriteLine("INTRODUCE TU NUEVO ESTADO CIVIL:");
                            editar = Console.ReadLine();
                            mipersona.EditarE(editar);
                        }
                        

                        
                        break;

                    case "7":

                        Console.WriteLine("\t\t\t INTRODUCE EL MONTO A TOMAR PRESTADO:");
                        valor = Console.ReadLine();

                        valid=double.TryParse(valor, out montoPrestamo);
                        while(valid = !double.TryParse(valor, out montoPrestamo))
                        {
                            Console.WriteLine("\t\t\t INTRODUCE EL MONTO A TOMAR PRESTADO:");
                            valor = Console.ReadLine();
                        }



                        Console.WriteLine("\t\t\t INTRODUCE EL TIEMPO EN EL QUE LO PAGARAS:");
                        valor = Console.ReadLine();
                        valid = int.TryParse(valor, out tiempo);
                        while (valid = !int.TryParse(valor, out tiempo))
                        {
                            Console.WriteLine("\t\t\t INTRODUCE EL TIEMPO EN EL QUE LO PAGARAS EN MESES:");
                            valor = Console.ReadLine();
                        }

                        CalculadoraPrestamo prestamo = new CalculadoraPrestamo(montoPrestamo, tiempo);

                        Console.WriteLine("\t\t\t TOTAL A PAGAR " + prestamo.Cuota());                       

                        Console.WriteLine("\t\t\t INTES A PAGAR " + prestamo.INTERES());


                        Console.ReadLine();




                        break;
                    case "8":

                        Console.Clear();
                        int salir = 1;
                        String salir2;
                        Console.WriteLine("\t\t\t\t PRESIONA 1 PARA SALIR \n" +
                            "\t\t\t\t PRESIONA 2 PARA REGRESAR");
                        Console.CursorLeft = 33;
                        salir2 = Console.ReadLine();
                        valid = int.TryParse(salir2, out salir);


                        //BUCLE EN CASO QUE SE ALMACENE UNA LETRA AL INICIO DE SALIR
                        while (valid = !int.TryParse(salir2, out salir))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\t\t\t ERROR CARACTER NO NUMERICO");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\t\t\t\t PRESIONA 1 PARA SALIR \n" +
                           "\t\t\t\t PRESIONA 2 PARA REGRESAR");
                            Console.CursorLeft = 33;
                            salir2 = Console.ReadLine();
                            Console.Clear();
                            

                        }


                        //BUCLE EN CASO DE QUE SE ELIJA UN NUMERO PERO NO SEA EL 1 NI EL 2
                        while (salir != 2 && salir != 1)
                        {
                            
                            Console.WriteLine("");
                            Console.WriteLine("\t\t\t\t ERROR HAS ELEGIDO UN NÚMERO, PERO ESTE NO SE ENCUENTRA EN LAS OPCIONES.");
                            Console.WriteLine(" \t\t\t\t INTENTA NUEVAMENTE");
                            
                            Console.WriteLine("\t\t\t\t PRESIONA 1 PARA SALIR \n" +
                           "\t\t\t\t PRESIONA 2 PARA REGRESAR");
                            Console.CursorLeft = 33;
                            salir2 = Console.ReadLine();
                            valid = int.TryParse(salir2, out salir);

                            // BUCLE EN CASO DE QUE SALTE EL ERROR DE QUE NO SE ESCOJIO EL 1 NI EL 2 PERO NUEVAMENTE ELIJAN UNA LETRA
                            while (valid = !int.TryParse(salir2, out salir))
                            {

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\t\t\t\t ERROR CARÁCTER NO NUMÉRICO. INTENTA NUEVAMENTE");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\t\t\t\t PRESIONA 1 PARA SALIR \n" +
                               "\t\t\t\t PRESIONA 2 PARA REGRESAR");
                                Console.CursorLeft = 33;
                                salir2 = Console.ReadLine();
                            }
                            
                        }

                        if (salir == 1)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("REGRESANDO...");
                            Thread.Sleep(1000);

                        }



                        break;

                    default:
                        Console.WriteLine("\t\t\t LO SIENTO LA OPCION ELEGIDA NO ES CORRECTA VUELVE A INTENTARLO");
                        break;

                       

                }
                


            }




        }

    }
}


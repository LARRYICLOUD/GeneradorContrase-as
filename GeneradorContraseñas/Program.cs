using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorContraseñas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");

            //Las contraseñas seran entre 8 y 20 caracteres
            // van a contener al menos una letra minuscula
            // una letra mayuscula
            //un numero
            //y un caracter especial de entre seis posibles opciones//

            //Se crea una clase especificamente para manejar los campos y metodos que van a generar la contraseña

            //Variables necesarias
            string nombreUsuario, opcion, contraseña;

            //Un titulo para el programa 
            Console.WriteLine("\t\tRegistro\n\n");
            //pedimos el nombre de usuario
            Console.WriteLine("Ingrese de un nombre de usuario");
            nombreUsuario = Console.ReadLine();
            //preguntamos si se desea hacer uso del generador de contraseñas o escribir una nosotros mismos
            Console.Write("¿Desea que le generemos una contraseña segura? (si/no):");
            opcion = Console.ReadLine();
            opcion =opcion.ToLower();//Convertimos a minuscula la respuesta del usuario (en caso de que use mayuscula o una combinacin de ambas)
            //Seguimos una de las dos posibles rutas
            switch (opcion)
            {
                case "si":
                    //Instanciamos a la clase contraseña para poder hacer uso de ella
                    Contraseña contraseña1 = new Contraseña();
                    //Llamamos a su metodo "GenerarContraseña" y le asignamos lo que devuelve a nuestra variable local "contraseña"
                    contraseña = contraseña1.GenerarContraseña();

                Console.WriteLine($"Esta es la contraseña que generamos para ti, guardala en un lugar seguro: {contraseña}");
                    Console.Write("\nPresiona cualquier tecla para terminar tu registro");
                    Console.ReadKey();
                    Console.Clear();
                    //Mostramos un resumen de los datos
                    Console.WriteLine($"\nTus datos de acceso son los siguientes:\n\tusuario: {nombreUsuario}\n\tcontraseña: {contraseña}");
                    break;
                case "no":
                    break;
            }



        }
    }
    class Contraseña
    {
        //Campos
        // 4 colecciones de caracteres para escoger y generar contraseña
        string numeros = "0123456789";
        string letrasMin = "abcdefghijklmnñopqrstuvwwxyz";
        string letrasMay = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        string caracterEspecial = "$%#&!?";
        //Contadores para verificar el numero de caracteres de cada grupo
        int numContiene = 0, minContiene = 0, mayContiene = 0, espContiene = 0;

        //Metodo para generar contraseña
        public string GenerarContraseña()
        {
            //Aqui guardamos la contraseña
            string contraseñaGenerada = "";
            //Instanciamos la clase random para usarla mas adelante
            Random random = new Random();

            //Declaramos la variable que guardara el tamaño que tendra la contraseña, generamos un numero aleatorio para determinar la longitud entre 8 y 20 caracteres y s elo asignamos a la variable
            int longitudContraseña = random.Next(8, 21);
            //variables que van a determinar el numero de caracteres que se usaran de cada grupo.
            //Basandose en un porcentaje de la longitud de la contraseña
            double numTener = longitudContraseña * .15; //el 15% de los caracteres seran numeros
            double minTener = longitudContraseña * .35; //letras minusculas
            double mayTener = longitudContraseña * .35; //letras mayusculas
            double espTener = longitudContraseña * .15; //caracteres especiales
            //Variable de tipo char que va almacenar a cada uno de los caracteres que van a conformar a la contraseña
            char caracterEscogido;

            //Usamos una iteracion while para ir colocando un caracter(de los 4 del grupo) hasta que completemos la longitud que se establecio anteriormente
            while (contraseñaGenerada.Length  < longitudContraseña)
            {
                //Volvemos a usar un numero aleatorio, esta vez para seleccionar uno d elos 4 grupos de string que tenemos
                switch (random.Next(0, 4))
                {
                    case 0://numeros
                        // Si los caracteres numericos que contienen la contraseña son menores a los que debe contener, entonces ingresa al bloque de codigo y los genera
                        if(numContiene < numTener)
                        {
                            //a "caracterEscogido"se le va asignar un caracter aleatorio de los contenidos en el string "numeros", basandose el indice y apoyandose  de la propiedad "Length". ejemplo
                            //caracterEscogido = numero[random.Next(10)] por que son diez elementos
                            //caracterEscogido = numeros[3] tomaria el cuarto caracter 

                            caracterEscogido = numeros[random.Next(numeros.Length)];
                            //Se le acumula el caracter excogido por Random a la contraseña generada
                            contraseñaGenerada += caracterEscogido;
                            //Se aumenta en 1 a los caracteres numericos que contienela contraseña
                            numContiene++;

                        }
                        break;

                        case 1:
                        if(minContiene < minTener)
                        {
                            caracterEscogido = letrasMin[random.Next(letrasMin.Length)];
                            contraseñaGenerada += caracterEscogido;
                            minContiene++;
                        }
                        break;

                        case 2:
                        if (mayContiene < mayTener)
                        {
                            caracterEscogido = letrasMay[random.Next(letrasMay.Length)];
                            contraseñaGenerada += caracterEscogido;
                            mayContiene++;
                        }
                        break;

                        case 3:
                        if (espContiene < espTener)
                        {
                            caracterEscogido = caracterEspecial[random.Next(caracterEspecial.Length)];
                            contraseñaGenerada += caracterEscogido;
                            espContiene++;
                        }
                        break;

                }
            }

            return contraseñaGenerada;

        }

    }

}
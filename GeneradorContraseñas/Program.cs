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





        }
    }
    class Contraseña
    {
        //Campos
        // 4 colecciones de caracteres para escoger y generar contraseña
        string numeros = "0123456789";
        string letrasMin = "abcdefghijklmnñopqrstuvwwxyz";
        string letrasMay = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        string caracterespecial = "$%#&!?";
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
                        break;

                        case 2:
                        break;

                        case 3:
                        break;



                }





            }

        }



    }

}
 using System;
 class RemoveCharacter {
   static void Main() {

     string mensaje = "CarlosAlbertoLopezJaramillo";
        // int size = s.Length;

        if (mensaje.Length >= 20)
        {
            mensaje = mensaje.Remove(20, 7).Insert(20, "...");
            Console.WriteLine("El mensaje tiene más de 20 carácteres, será modificado: \n" + mensaje);


        }
        else
        {
            Console.WriteLine("El arreglo no tiene más de 20 carácteres por lo tanto no" +
                "va a ser modificado" + mensaje);

        }

    }
 }
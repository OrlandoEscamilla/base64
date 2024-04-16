using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.IO;
using System.Net.Http;

namespace base64
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // URL de la imagen que queremos descargar
            string urlImagen = "Aqui va la cadena de la url de internet de la imagen"; //ruta de la imagen de internet;

            // Nombre del archivo donde se guardará la imagen
            string nombreArchivo = "imagen.jpg";

            string nuevaruta = "C:";

            // Descargar la imagen
            DescargarImagen(urlImagen, nombreArchivo);

            Console.WriteLine("Imagen descargada correctamente.");
            Console.WriteLine("hola");


            for (int i = 0; i< 10; i++)
            {
                Console.WriteLine("Este es un mensaje que se repite 10 veces");
            }
        }

            static void DescargarImagen(string urlImagen, string nombreArchivo)
            {
                // Crear una solicitud web
                WebRequest request = WebRequest.Create(urlImagen);

                // Obtener la respuesta de la solicitud
                using (WebResponse response = request.GetResponse())
                {
                    // Obtener el flujo de datos de la respuesta
                    using (Stream stream = response.GetResponseStream())
                    {
                        // Guardar el flujo de datos en un archivo
                        using (FileStream fileStream = new FileStream(nombreArchivo, FileMode.Create))
                        {
                            byte[] buffer = new byte[1024];
                            int bytesLeidos;

                            while ((bytesLeidos = stream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                fileStream.Write(buffer, 0, bytesLeidos);
                            }
                        }
                    }
                }
            }
        
    }
}

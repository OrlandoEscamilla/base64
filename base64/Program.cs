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
            string urlImagen = "https://media.geeksforgeeks.org/wp-content/cdn-uploads/20230305130205/";

            // Nombre del archivo donde se guardará la imagen
            string nombreArchivo = "imagen.jpg";

            // Descargar la imagen
            DescargarImagen(urlImagen, nombreArchivo);


            Console.WriteLine("Imagen descargada correctamente.");
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

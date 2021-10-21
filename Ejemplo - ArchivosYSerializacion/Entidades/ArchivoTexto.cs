using System;
using System.IO;

namespace Entidades
{
    public class ArchivoTexto : IArchivos<string>
    {
        public void Escribir(string dato, string path)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.WriteLine(dato);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Leer(string path)
        {
            string returnAux = string.Empty;
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        returnAux += $"{streamReader.ReadLine()}\n";
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return returnAux;
        }
    }
}

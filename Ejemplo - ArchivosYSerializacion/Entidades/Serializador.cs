using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializador<T> : IArchivos<T> where T: class
    {

        private IArchivos<T>.ETipoArchivo tipo;

        public Serializador(IArchivos<T>.ETipoArchivo tipo)
        {
            this.tipo = tipo;
        }
        public void Escribir(T dato, string path)
        {
            try
            {
                if (this.tipo == IArchivos<T>.ETipoArchivo.XML)
                {
                    if(Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8))
                        {
                            xmlTextWriter.Formatting = Formatting.Indented;
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            xmlSerializer.Serialize(xmlTextWriter, dato);
                        }
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("Extension Invalida para XML");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        ArchivoTexto archivoTexto = new ArchivoTexto();
                        archivoTexto.Escribir(JsonSerializer.Serialize(dato, typeof(T)), path);
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("Extension Invalida para JSON");
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public T Leer(string path)
        {
            
            try
            {
                if (this.tipo == IArchivos<T>.ETipoArchivo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextReader xmlTextReader = new XmlTextReader(path))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            return (T)xmlSerializer.Deserialize(xmlTextReader);
                        }
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("Extension Invalida para XML");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        ArchivoTexto archivoTexto = new ArchivoTexto();
                        string texto = archivoTexto.Leer(path);
                        return JsonSerializer.Deserialize<T>(texto);
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("Extension Invalida para JSON");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

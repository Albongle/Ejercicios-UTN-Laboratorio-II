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

    //Otra Manera
    public class GestorArchivo : IArchivos<Persona>, IArchivos<string>
    {

        private IArchivos<Persona>.ETipoArchivo tipo;
       
        public GestorArchivo()
        {

        }
        public GestorArchivo(IArchivos<Persona>.ETipoArchivo tipo)
        {
            this.tipo = tipo;
        }

        public IArchivos<Persona>.ETipoArchivo Tipo { set => tipo = value; }

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

        void IArchivos<Persona>.Escribir(Persona dato, string path)
        {
            try
            {
                if (this.tipo == IArchivos<Persona>.ETipoArchivo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8))
                        {
                            xmlTextWriter.Formatting = Formatting.Indented;
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
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
                        archivoTexto.Escribir(JsonSerializer.Serialize(dato, typeof(Persona)), path);
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

        Persona IArchivos<Persona>.Leer(string path)
        {
            try
            {
                if (this.tipo == IArchivos<Persona>.ETipoArchivo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextReader xmlTextReader = new XmlTextReader(path))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                            return (Persona)xmlSerializer.Deserialize(xmlTextReader);
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
                        return JsonSerializer.Deserialize<Persona>(archivoTexto.Leer(path));
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

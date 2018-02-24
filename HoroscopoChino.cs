using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace HoroscopoChino
{
    [DataContract]
    class HoroscopoChino
    {
        [DataMember]
        public string Animal { get; set; }

        [DataMember]
        public string[] Annos { get; set; }

        List<HoroscopoChino> lista;        

        public void Obtener_Horoscopos(string ruta)
        {
            lista = new List<HoroscopoChino>();

            if(File.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string linea = "";                 
                    while ((linea = sr.ReadLine()) != null)
                    {
                        HoroscopoChino hor = new HoroscopoChino()
                        {
                            Animal = linea.Split(':')[0],
                            Annos = linea.Split(':')[1].Split(',')
                        };
                        lista.Add(hor);
                    }
                }
            }
            else
            {
                lista = null;
            }
        }

        public void GuardarComoXml(string ruta)
        {
            if (lista == null)
                return;

            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<HoroscopoChino />");

            foreach (var animal in this.lista)
            {
                XmlElement NodoAnimal = doc.CreateElement("Animal");
                NodoAnimal.SetAttribute("Nombre", animal.Animal);

                foreach (var anno in animal.Annos)
                {
                    XmlElement NodoAnno = doc.CreateElement("Año");
                    NodoAnno.InnerText = anno.Trim();
                    NodoAnimal.AppendChild(NodoAnno);
                }
                doc.DocumentElement.AppendChild(NodoAnimal);
            }

            doc.Save(ruta);
        }

        public void GuardarComoJson(string ruta)
        {            
            MemoryStream ms = new MemoryStream();            

            DataContractJsonSerializer oDataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<HoroscopoChino>));

            oDataContractJsonSerializer.WriteObject(ms, lista);
            string datosJson = Encoding.Default.GetString(ms.ToArray());

            using (StreamWriter sw = new StreamWriter(ruta, false))
            {
                sw.WriteLine(datosJson);
            }
        }
    }
}

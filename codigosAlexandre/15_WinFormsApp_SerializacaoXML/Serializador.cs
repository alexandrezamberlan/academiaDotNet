using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _15_WinFormsApp_SerializacaoXML
{
    internal class Serializador
    {
        public static void serializarXML(List<Paciente> lista)
        {
            try
            {
                FileStream procurador = new FileStream(@"C:\teste\pacientes.xml", FileMode.Create);
                XmlSerializer serializadorXML = new XmlSerializer(typeof(Paciente));

                foreach (Paciente p in lista)
                {
                    serializadorXML.Serialize(procurador, p);
                }
               
                procurador.Close();

                MessageBox.Show("Sucesso para serializar com XML","Alerta");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static void deserializarXML(List<Paciente> lista)
        {
            try
            {
                XmlSerializer serializadorXML = new XmlSerializer(typeof(Paciente));
                StreamReader procurador = new StreamReader(@"C:\teste\pacientes.xml");

                Paciente p = (Paciente)serializadorXML.Deserialize(procurador);    
                
                procurador.Close();

                MessageBox.Show("Sucesso para deserializar com XML " + p.Nome + " - " + p.Cpf, "Alerta");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}

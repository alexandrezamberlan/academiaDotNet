using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsSerialização
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txbSerializar.Text;
                FileStream procurador = new FileStream(@"C:\teste\dados.data", FileMode.Create);
                BinaryFormatter serializador = new BinaryFormatter();
                serializador.Serialize(procurador, texto);
                procurador.Close();

                MessageBox.Show("Serializado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDesserializar_Click(object sender, EventArgs e)
        {
            FileStream procurador = new FileStream(@"C:\teste\dados.data", FileMode.Open);
            BinaryFormatter serializador = new BinaryFormatter();
            string dadosDesserializados = (string)serializador.Deserialize(procurador);
            procurador.Close();

            txbDesserializar.Text = dadosDesserializados;
        }

        private void btnSerializar2_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.idade = 67;
                p.nome = "Maria de Fátima";
                p.salario = 12000;

                FileStream procurador = new FileStream(@"C:\teste\pessoaSOAP.xml", FileMode.Create);
                SoapFormatter serializadorSOAP = new SoapFormatter();

                serializadorSOAP.Serialize(procurador, p);
                procurador.Close();

                MessageBox.Show("Sucesso para serializar SOAP");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDesserializar2_Click(object sender, EventArgs e)
        {
            FileStream procurador = new FileStream(@"C:\teste\pessoaSOAP.xml", FileMode.Open);
            Pessoa p = new Pessoa();
            SoapFormatter serializadorSOAP = new SoapFormatter();
            p = (Pessoa)serializadorSOAP.Deserialize(procurador);

            procurador.Close();
        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.idade = 67;
                p.nome = "Maria de Fátima";
                p.salario = 12000;

                FileStream procurador = new FileStream(@"C:\teste\pessoa1.xml", FileMode.Create);
                XmlSerializer serializadorXML = new XmlSerializer(typeof(Pessoa));

                serializadorXML.Serialize(procurador, p);
                procurador.Close();

                MessageBox.Show("Sucesso para serializar com XML");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDesserializarXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializadorXML = new XmlSerializer(typeof(Pessoa));
            StreamReader procurador = new StreamReader(@"C:\teste\pessoa1.xml");
            Pessoa p = (Pessoa)serializadorXML.Deserialize(procurador.BaseStream);
            //codigo para exibir os dados da pessoa deserializada
            MessageBox.Show("Nome: " + p.nome + " Idade: " + p.idade + " Salário: " + p.salario);

            procurador.Close();
        }

        private void btnSerializarJson_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.idade = 67;
                p.nome = "Maria de Fátima";
                p.salario = 12000;

                JsonSerializer serializadorJSON = new JsonSerializer();
                StreamWriter procurador = new StreamWriter(@"C:\teste\pessoa.json");
                JsonWriter escritorJSON = new JsonTextWriter(procurador);
                serializadorJSON.Serialize(escritorJSON, p);
                procurador.Close();
                escritorJSON.Close();

                MessageBox.Show("Sucesso para serializar com JSON");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDesserializarJson_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\teste\pessoa.json");

            Pessoa p = JsonConvert.DeserializeObject<Pessoa>(json);
            //codigo para exibir os dados da pessoa deserializada
            MessageBox.Show("Nome: " + p.nome + " Idade: " + p.idade + " Salário: " + p.salario);
        }
    }
}

namespace _14_GlicemiaCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_nomeBanco.Text.Equals("") || banco.abrirConexao(textBox_nomeBanco.Text) == null)
                {
                    throw new Exception();
                }
                MessageBox.Show("Banco conectado: " + textBox_nomeBanco.Text, "Alerta");
                button_conectar.Enabled = false;   
                button_desconectar.Enabled = true;
                textBox_nomeBanco.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas para conectar com o banco","Alerta");
            }            
        }

        private void button_desconectar_Click(object sender, EventArgs e)
        {
            try
            {                
                banco.fecharConexao();
                MessageBox.Show("Banco desconectado: " + textBox_nomeBanco.Text, "Alerta");
                button_conectar.Enabled = true;
                button_desconectar.Enabled = false;
                textBox_nomeBanco.Text = "";
                textBox_nomeBanco.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas para desconectar com o banco", "Alerta");
            }
        }

        Banco banco = new Banco();
    }
}
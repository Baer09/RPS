namespace BOT_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarInstancia_Click(object sender, EventArgs e)
        {
            //TextWriter txt = new StreamWriter();
            // create folder with idInstancia as a name
            string dir = @"C:\" + txtInstancia.Text;
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

        }

        private void txtInstancia_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            //create path
            string instancia = txtInstancia.Text;
            string idProducto = lblIdProducto.Text;
            string path = @"C:\" + instancia + @"\" + instancia + idProducto + ".txt";
            //create txt file & save data

            savedDataToTxtFile(txtInstancia.Text, lblIdProducto.Text, path, txtIdProveedor.Text);
            txtIdProveedor.Clear();
            /*
            if (!File.Exists(path))
            {
                //FileStream file = File.Create(path);
                string appendText = txtIdProveedor.Text + "\n";
                //File.AppendAllText(path, appendText);

            }
            else if (File.Exists(path)) {
                string appendText = txtIdProveedor.Text + "\n";
                File.AppendAllText(path, appendText);
            }
            */


        }




        private void btnSunProveedor_Click(object sender, EventArgs e)
        {
            string instancia = txtInstancia.Text;
            string sunProducto = lblSunProveedor.Text;
            string path = @"C:\" + instancia + @"\" + instancia + sunProducto + ".txt";

            savedDataToTxtFile(txtInstancia.Text, lblSunProveedor.Text, path, txtSunProveedor.Text);

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            string instancia = txtInstancia.Text;
            string proveedor = lblProveedor.Text;
            string path = @"C:\" + instancia + @"\" + instancia + proveedor + ".txt";

            savedDataToTxtFile(txtInstancia.Text, lblProveedor.Text, path, txtProveedor.Text);

        }

        private void btnTipoProveedor_Click(object sender, EventArgs e)
        {
            string instancia = txtInstancia.Text;
            string tipoProveedor = lblTipoProveedor.Text;
            string path = @"C:\" + instancia + @"\" + instancia + tipoProveedor + ".txt";

            savedDataToTxtFile(txtInstancia.Text, lblTipoProveedor.Text, path, txtTipoProveedor.Text);

        }

        private void btnPais_Click(object sender, EventArgs e)
        {
            string instancia = txtInstancia.Text;
            string pais = lblPais.Text;
            string path = @"C:\" + instancia + @"\" + instancia + pais + ".txt";

            savedDataToTxtFile(txtInstancia.Text, lblPais.Text, path, txtPais.Text);

        }

        private void btnEstatus_Click(object sender, EventArgs e)
        {
            string instancia = txtInstancia.Text;
            string estatus = lblStatus.Text;
            string path = @"C:\" + instancia + @"\" + instancia + estatus + ".txt";

            savedDataToTxtFile(txtInstancia.Text, lblStatus.Text, path, txtEstatus.Text);

        }

        private void btnSolicitante_Click(object sender, EventArgs e)
        {
            string instancia = txtInstancia.Text;
            string solicitante = lblSolicitante.Text;
            string path = @"C:\" + instancia + @"\" + instancia + solicitante + ".txt";

            savedDataToTxtFile(txtInstancia.Text,lblSolicitante.Text,path,txtSolicitante.Text);

        }

        public void savedDataToTxtFile(string instancia, string labelName, string path, string txtBox)
        {

            if (!File.Exists(path))
            {
                //FileStream file = File.Create(path);
                string appendText = txtBox + "\n";
                File.AppendAllText(path, appendText);

            }
            else if (File.Exists(path))
            {
                string appendText = txtBox + "\n";
                File.AppendAllText(path, appendText);
            }



        }

        
    }
}
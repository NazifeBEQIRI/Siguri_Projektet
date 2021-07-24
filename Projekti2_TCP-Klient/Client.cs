using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;
using System.Security.Cryptography;
using System.Xml;

namespace TCP_Klienti
{
    public partial class Client : Form
    {
        public static Socket server;
        static string receivedData;
        private string IP_Address = "";
        private int PortNo = 0;
        private bool Connected;
        public string tokeni;

        private static RSACryptoServiceProvider rsaClient = new RSACryptoServiceProvider();
        private static RSACryptoServiceProvider rsaServer = new RSACryptoServiceProvider();

        private static string publicKeyServer;
        public Client()
        {
            InitializeComponent();
            this.MinimizeBox = false;
        }
        private void SendDataToServer(string data)
        {
            server.Send(Encoding.ASCII.GetBytes(data));
        }

        private string ReceiveDataFromServer()
        {
            byte[] data = new byte[2048];
            int recv_data = server.Receive(data);
            string stringData = Encoding.ASCII.GetString(data, 0, recv_data);

            byte[] EncryptedData;
            byte[] IV;
            byte[] key;
            string[] stringDataList = stringData.Split('*');
            IV = Convert.FromBase64String(stringDataList[0]);
            key = Convert.FromBase64String(stringDataList[1]);
            EncryptedData = Convert.FromBase64String(stringDataList[2]);
            stringData = MyDES.DecryptTextFromMemory(EncryptedData, key, IV);


            receivedData = stringData;
            return stringData;
        }
        private void SendRequestToSrv(string teksti)
        {
            try
            {
                server.Send(Encoding.ASCII.GetBytes(teksti));
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message.ToString());
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[2048];

            if (txtIP.Text.Trim() != "" && txtPorti.Text.Trim() != "")
            {
                IP_Address = txtIP.Text.Trim();
                PortNo = Convert.ToInt32(txtPorti.Text.Trim());

                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP_Address), PortNo);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    server.Connect(ipep);

                    txtReceiveAnswer.AppendText("Jeni të lidhur me serverin:" + txtIP.Text + " dhe Portin: " + txtPorti.Text + "\n");
                    BWchatLog.RunWorkerAsync();

                    publicKeyServer = ReceiveDataFromServer();
                    txtReceiveAnswer.AppendText("\n\n");
                    rsaServer.FromXmlString(publicKeyServer);

                    Connected = true;
                }
                catch (SocketException ex)
                {
                    txtReceiveAnswer.AppendText("E pamundur që të lidheni me server. Ju lutem kontrolloni IP adresen dhe portin!");
                    txtReceiveAnswer.AppendText("\n" + ex.ToString());
                    Connected = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please fill IP Address and/or Port first!");
            }
        }

        protected bool ValidateEmail(TextBox txtEmail, ErrorProvider errorProvider1)
        {
            bool bStatus = true;

            string email = txtEmail.Text.TrimEnd();

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                errorProvider1.SetError(txtEmail, "");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "Invalid Email!");
                bStatus = false;
            }
            return bStatus;
        }

        protected bool ValidateField(TextBox textbox, string Errormsg, ErrorProvider errorProvider1)
        {

            bool bStatus = true;

            if (textbox.Text == "")
            {
                errorProvider1.SetError(textbox, Errormsg);
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(textbox, "");
            }
            return bStatus;
        }

        protected void AllowOnlyNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Connected)
                MessageBox.Show("Duhet të lidheni me server!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            bool bValidEmriMbiemri = ValidateField(txtEmriMbiemri, "Emri Mbiemri duhet të shënohet!", errorProvider1);
            bool bValidEmail = ValidateEmail(txtEmail, errorProvider1);
            bool bValidllojiFatures = ValidateField(txtllojiFatures, "llojiFatures duhet të shënohet!", errorProvider1);
            bool bValidviti = ValidateField(txtviti, "viti duhet të shënohet!", errorProvider1);
            bool bValidvleraEuro = ValidateField(txtvleraEuro, "vleraEuro duhet të shënohet!", errorProvider1);
            bool bValidmuaji = ValidateField(txtmuaji, "muaji duhet të shënohet!", errorProvider1);
            bool bValidUserName = ValidateField(txtUserName, "UserName-i duhet të shënohet!", errorProvider1);
            bool bValidPassword = ValidateField(txtPassword, "Pasword-i duhet të shënohet!", errorProvider1);

            if (!bValidEmriMbiemri || !bValidEmail || !bValidllojiFatures || !bValidviti || !bValidvleraEuro || !bValidmuaji || !bValidUserName || !bValidPassword)
                MessageBox.Show("Të dhënat janë jo valide!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    Shfrytezuesi shfrytezuesi = new Shfrytezuesi();
                    shfrytezuesi.emriMbiemri = txtEmriMbiemri.Text.Trim();
                    shfrytezuesi.email = txtEmail.Text.Trim();
                    shfrytezuesi.vleraEuro = Convert.ToDecimal(txtvleraEuro.Text.Trim());
                    shfrytezuesi.userId = txtUserName.Text.Trim();
                    shfrytezuesi.llojiFatures = txtllojiFatures.Text.Trim();
                    shfrytezuesi.viti = Convert.ToInt16(txtviti.Text.Trim());
                    shfrytezuesi.muaji = txtmuaji.Text.Trim();
                    shfrytezuesi.PasswordHash = txtPassword.Text.Trim();

                    //JavaScriptSerializer js = new JavaScriptSerializer();
                    //string json = js.Serialize(shfrytezuesi); 

                    string json = JsonConvert.SerializeObject(shfrytezuesi);
                    string SendCommand = "Regjistrimi " + json;

                    SendCommand = DESEncrypt(SendCommand);
                    SendRequestToSrv(SendCommand);

                    txtReceiveAnswer.AppendText("\n");
                    txtReceiveAnswer.Refresh();
                   
                    txtReceiveAnswer.AppendText("\n" + ReceiveDataFromServer());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void txtvleraEuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumeric(sender, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Connected)
                MessageBox.Show("Duhet të lidheni me server!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            bool bValidUserName = ValidateField(txtUserName1, "UserName-i duhet të shënohet!", errorProvider1);
            bool bValidPassword = ValidateField(txtPassword1, "Pasword-i duhet të shënohet!", errorProvider1);

            if (!bValidUserName || !bValidPassword)
                MessageBox.Show("Të dhënat janë jo valide!", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    Login login = new Login();
                    login.userId = txtUserName1.Text.Trim();
                    login.PasswordHash = txtPassword1.Text.Trim();
                    string json = JsonConvert.SerializeObject(login);
                    string SendCommand = "Authentifikimi " + json;

                    SendCommand = DESEncrypt(SendCommand);
                    SendRequestToSrv(SendCommand);

                    txtReceiveAnswer.AppendText("\n");
                    txtReceiveAnswer.Refresh();
                    string pergjigja = ReceiveDataFromServer();

                    if (pergjigja.Contains('@'))
                    {
                        string[] pergjigjaArray = pergjigja.Split('@');
                        tokeni = pergjigjaArray[1];
                        VerifyToken vtoken = new VerifyToken();

                        txtReceiveAnswer.AppendText("\n" + pergjigjaArray[0] + "\n" + vtoken.verifyToken(tokeni));
                    }
                    else
                    {
                        txtReceiveAnswer.AppendText("\n" + pergjigja + "\n" );
                    }
                           
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
        string DESEncrypt(string data)
        {
            DESCryptoServiceProvider DESalg = new DESCryptoServiceProvider();

            byte[] EncryptedData = MyDES.EncryptTextToMemory(data, DESalg.Key, DESalg.IV);

            byte[] RSAKey = RSA.RSAEncrypt(DESalg.Key, rsaServer.ExportParameters(false), false);

            return Convert.ToBase64String(DESalg.IV) + "*" + Convert.ToBase64String(RSAKey) + "*" + Convert.ToBase64String(EncryptedData);


        }

        private void BWchatLog_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void lblvleraEuro_Click(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void lblEmriMbiemri_Click(object sender, EventArgs e)
        {

        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPorti_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtReceiveAnswer_TextChanged(object sender, EventArgs e)
        {

        }

            private void txtvleraEuro_TextChanged(object sender, EventArgs e)
            {
               
            }
            
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtllojiFatures_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtviti_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmuaji_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmriMbiemri_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblllojiFatures_Click(object sender, EventArgs e)
        {

        }

        private void lblviti_Click(object sender, EventArgs e)
        {

        }

        private void lblmuaji_Click(object sender, EventArgs e)
        {

        }

        private void grbRegjistrimi_Enter(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword1_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName1_Click(object sender, EventArgs e)
        {

        }
    }
}

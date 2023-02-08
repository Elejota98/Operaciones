using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class FrmLogin : Form
    {
        Login login = new Login();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                login.Usuario = txtUsuario.Text;
                login.Clave = txtContraseña.Text;

                DataTable tabla = new DataTable();
                tabla = LoginController.Login(login);
                if (tabla.Rows.Count <= 0)
                {
                    MensajeError("Este usuario no existe");
                }
                else
                {
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        login.Clave = tabla.Rows[i]["Contraseña"].ToString();
                    }

                    if (Decrypt(login.Clave) != txtContraseña.Text)
                    {
                        this.MensajeError("Contraseña Incorrecta");
                        txtContraseña.Text = "";
                        txtContraseña.Focus();
                    }
                    else
                    {
                        FrmMenu frmm = new FrmMenu();                        
                        login.Documento = Convert.ToString(tabla.Rows[0][0]);
                        frmm.Documento = Convert.ToString(tabla.Rows[0][0]);
                        frmm.Nombre = Convert.ToString(tabla.Rows[0][2]);
                        frmm.Cargo = Convert.ToString(tabla.Rows[0][3]);
                        FrmAutorizado frmAutorizados = new FrmAutorizado(Convert.ToString(tabla.Rows[0][0]), Convert.ToString(tabla.Rows[0][3]));
                        frmm.Show(this);
                        this.Hide();
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #region Funciones

        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        #endregion

        #region mensajes

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

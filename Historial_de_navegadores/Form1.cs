using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using System.Diagnostics;
using System.IO.IsolatedStorage;
using System.Collections;
using System.Data.SQLite;
using static System.Net.WebRequestMethods;
using System.Media;
using Historial_de_navegadores.Properties;

namespace Historial_de_navegadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_opciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            
        }

        private void panel_cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de salir?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.TransparencyKey = BackColor;
            panel_barra_lateral.Visible = false;
            //ocultar_boton_lateral();
            listBox_lista.BackColor = Color.Black;
            groupBox1.Visible = false;
            listBox_lista.Visible = false;
            label1.Visible = false;
            ocultar_checkBox();
            label_cargando.Location = new Point(341, 154);
            label_cargando.Visible = false;
            //panel_barra_lateral.Parent = panel_formulario1;
            //panel_barra_lateral.BackColor = Color.Transparent;
        }

        /* ########################## OCULTAR  CHECKBOX ######################*/
        private void ocultar_checkBox()
        {
            checkBox_visitas.Visible = false;
            checkBox_descargas.Visible = false;
            checkBox_urls.Visible = false;

        }
        /* ########################## MOSTRAR  CHECKBOX ######################*/
        private void mostrar_checkBox()
        {
            checkBox_visitas.Visible = true;
            checkBox_descargas.Visible = true;
            checkBox_urls.Visible = true;

        }
        /* #################### OCULTAR BOTONES LATERALES ####################*/
        private void ocultar_boton_lateral()
        {
            panel_firefox.Visible = false;
            panel_chrome.Visible = false;
            panel_explorer.Visible = false;
            panel_configuracion.Visible = false;
        }

        /* #################### MOSTRAR BOTONES LATERALES ####################*/
        private void mostrar_boton_lateral()
        {
            panel_firefox.Visible = true;
            panel_chrome.Visible = true;
            panel_explorer.Visible = true;
            panel_configuracion.Visible = true;
        }

        /* ####################################################################
           ############################### SONIDO #############################
           ####################################################################*/
        public void sonido()
        {
            string ruta = "star.WAV";
            SoundPlayer sonido1 = new SoundPlayer(ruta);
            sonido1.Play();
            
        }



        private void panel_opciones_MouseMove(object sender, MouseEventArgs e)
        {
            sonido();
            panel_barra_lateral.Visible = true;
            panel_opciones.Size = new Size(79, 60);
        }

        private void panel_opciones_MouseLeave(object sender, EventArgs e)
        {
            panel_opciones.Size = new Size(69, 50);
        }

        private void panel_ocultar_panel_Click(object sender, EventArgs e)
        {
            panel_barra_lateral.Visible = false;
        }

        /* #######################################################################################
           ############################ BUSQUEDA DE ARCHIVOS FIREFOX #############################
           #######################################################################################*/

        // El @ permite que la ruta con el simbolo \ sea similar a windows...
        public void busquda_firefox()
        {

            try 
            {
                
                string usuarios = @"C:\Users\";          // Usuarios...
                string getlogin = Environment.UserName; // Usuario_login...
                string firefox_places = @"\AppData\Roaming\Mozilla\Firefox\Profiles\"; 
               
                string [] directorio = Directory.GetFiles(usuarios + getlogin + firefox_places, "*.sqlite", SearchOption.AllDirectories);
                foreach(var item in directorio)
                {
                    label_cargando.Visible = false;
                    listBox_lista.Items.Add(item);
                    //listBox_lista.Visible = true;
                 
                }
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* ################################ HISTORIAL FIREFOX ####################################*/

        private void historial_firefox()
        {
            try
            {
                label_cargando.Visible = true;
                //SQLiteConnection conexion = new SQLiteConnection("Data Source=E:/VISUAL STUDIO PROGRAMACION IV/1Visual Studio Community 2022/Historial_de_navegadores/Historial_de_navegadores/bin/Debug/cookies.sqlite");
                SQLiteConnection conexion = new SQLiteConnection("Data Source="+ label1.Text);
                conexion.Open();

                /*if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                    //MessageBox.Show("Conectado...");
                }*/

                //SQLiteCommand cmd = new SQLiteCommand("select name from sqlite_master WHERE type='table'", conexion);
                SQLiteCommand cmd = new SQLiteCommand("select *from moz_cookies", conexion);
                cmd.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet, "moz_cookies");

                label_cargando.Visible = false;
                dataGridView1.DataSource = dataSet.Tables["moz_cookies"];

                //conexion.Close();
                label1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message) ;
                
                
            }
        }


        /* ################################ SITIOS VISITADOS FIREFOX #############################*/

        private void content_prefs_firefox()
        {
            try
            {
                
                SQLiteConnection conexion1 = new SQLiteConnection("Data Source="+ label1.Text);

                if (conexion1.State != ConnectionState.Open)
                {
                    conexion1.Open();
                    //MessageBox.Show("Conectado...");
                }

                //SQLiteCommand cmd = new SQLiteCommand("select name from sqlite_master WHERE type='table'", conexion);
                SQLiteCommand cmd1 = new SQLiteCommand("select *from groups", conexion1);
                cmd1.CommandType = CommandType.Text;
                SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd1);
                DataSet dataSet1 = new DataSet();
                da1.Fill(dataSet1, "groups");

                dataGridView1.DataSource = dataSet1.Tables["groups"];

                conexion1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        /* ################################ DESDE MI HISTORIAL FIREFOX ###########################*/

        private void moz_formhistory_firefox()
        {
            try
            {
                label_cargando.Visible = true;
                SQLiteConnection conexion = new SQLiteConnection("Data Source=" + label1.Text);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                    //MessageBox.Show("Conectado...");
                }

                //SQLiteCommand cmd = new SQLiteCommand("select name from sqlite_master WHERE type='table'", conexion);
                SQLiteCommand cmd = new SQLiteCommand("select *from moz_formhistory", conexion);
                cmd.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet, "moz_formhistory");

                label_cargando.Visible = false;
                dataGridView1.DataSource = dataSet.Tables["moz_formhistory"];

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }


        /* ################################ SITIOS WEB FIREFOX ###################################*/

        private void moz_place_firefox()
        {
            try
            {
                label_cargando.Visible = true;
                SQLiteConnection conexion = new SQLiteConnection("Data Source=" + label1.Text);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                    //MessageBox.Show("Conectado...");
                }

                //SQLiteCommand cmd = new SQLiteCommand("select name from sqlite_master WHERE type='table'", conexion);
                SQLiteCommand cmd = new SQLiteCommand("select *from moz_places", conexion);
                cmd.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet, "moz_places");

                label_cargando.Visible = false;
                dataGridView1.DataSource = dataSet.Tables["moz_places"];

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        /* #######################################################################################*/
        /* #######################################################################################*/






        /* #######################################################################################
           ############################# BUSQUEDA DE ARCHIVOS CHROME #############################
           #######################################################################################*/

        public void busquda_chrome()
        {

            try
            {
                label_cargando.Visible = true;
                string usuarios = @"C:\Users\";          // Usuarios...
                string getlogin = Environment.UserName; // Usuario_login...
                string chrome_places = @"\AppData\Local\Google\Chrome\User Data\Default\";

                //string[] directorio = Directory.GetFiles(usuarios + getlogin + chrome_places, "*.*", SearchOption.AllDirectories);
                string[] directorio = Directory.GetFiles(usuarios + getlogin + chrome_places, "History", SearchOption.AllDirectories);
                foreach (var item in directorio)
                {
                    label_cargando.Visible = false;
                    listBox_lista.Items.Add(item);
                    //listBox_lista.Visible = true;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /* ################################ HISTORIAL CHROME #####################################*/

        private void historial_chrome()
        {
            try
            {
                label_cargando.Visible = true;
                SQLiteConnection conexion = new SQLiteConnection("Data Source=" + label1.Text);
                conexion.Open();

                /*if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                    //MessageBox.Show("Conectado...");
                }*/

                SQLiteCommand cmd = new SQLiteCommand("select *from clusters_and_visits", conexion);
                cmd.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet, "clusters_and_visits");

                label_cargando.Visible = false;
                dataGridView1.DataSource = dataSet.Tables["clusters_and_visits"];

                //conexion.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }


        /* ################################ DESCARGAS CHROME #####################################*/

        private void descargas_chrome()
        {
            try
            {

                SQLiteConnection conexion = new SQLiteConnection("Data Source=" + label1.Text);
                conexion.Open();


                SQLiteCommand cmd = new SQLiteCommand("select *from downloads", conexion);
                cmd.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet, "downloads");

                dataGridView1.DataSource = dataSet.Tables["downloads"];

                //conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }


        /* ################################ DESCARGAS CHROME #####################################*/

        private void urls_chrome()
        {
            try
            {

                SQLiteConnection conexion = new SQLiteConnection("Data Source=" + label1.Text); // DB seleccionada...
                conexion.Open();


                SQLiteCommand cmd = new SQLiteCommand("select *from urls", conexion);
                cmd.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet, "urls");

                dataGridView1.DataSource = dataSet.Tables["urls"];

                //conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }






        private void panel_firefox_Click(object sender, EventArgs e)
        {
            label_cargando.Visible = true;
            listBox_lista.Items.Clear();
            busquda_firefox();
            //ocultas_elementos();
            groupBox1.Visible = false;
            listBox_lista.Visible = true;

        }

        private void listBox_lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = listBox_lista.SelectedItem.ToString();
            string ruta = label1.Text;
        }


        /* #######################################################################################
           ################### PROCEDIMIENTO PARA EXTRAER INFORMACION DE DB ######################
           #######################################################################################*/

        private void listBox_lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //label1.Visible = true;
            string ruta = label1.Text;
            
            string cadena = ruta.Substring(ruta.LastIndexOf(@"\")+1); // Obtiene el ultimo elemento de una cadena...
            //MessageBox.Show(cadena);
            if (cadena == "content-prefs.sqlite")
            {
               
                content_prefs_firefox();
                //ocultar_checkBox();
                groupBox1.Visible = true;
               
            }
            else if(cadena == "cookies.sqlite")
            {
               
                historial_firefox();
                //ocultar_checkBox();
                groupBox1.Visible = true;
            }
            else if(cadena == "formhistory.sqlite")
            {
                moz_formhistory_firefox();
                //ocultar_checkBox();
                groupBox1.Visible = true;
            }
            else if (cadena == "places.sqlite")
            {
                moz_place_firefox();
                //ocultar_checkBox();
                groupBox1.Visible = true;
            }
            else if (cadena == "History")
            {
                historial_chrome();
                mostrar_checkBox();
                checkBox_visitas.Checked = true;
                groupBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("No disponible...");
            }
        }

        private void panel_cerrar_dataG_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            ocultar_checkBox();
        }

        private void panel_chrome_Click(object sender, EventArgs e)
        {
            listBox_lista.Items.Clear();
            busquda_chrome();
            
            groupBox1.Visible = false;
            listBox_lista.Visible = true;
        }

        private void checkBox_visitas_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_visitas.Checked == true)
            {
                
                checkBox_descargas.Checked = false;
                checkBox_urls.Checked = false;
                historial_chrome();
            }
        }

        private void checkBox_descargas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_descargas.Checked == true)
            {

                checkBox_visitas.Checked = false;
                checkBox_urls.Checked = false;
                descargas_chrome();
            }
        }

        private void checkBox_urls_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_urls.Checked == true)
            {

                checkBox_visitas.Checked = false;
                checkBox_descargas.Checked = false;
                urls_chrome();
            }
        }

       

        private void panel_firefox_MouseMove(object sender, MouseEventArgs e)
        {

            //sonido();
            panel_firefox.Size = new Size(64, 47);

            panel_chrome.Size = new Size(54, 37);
            panel_explorer.Size = new Size(54, 37);
            panel_configuracion.Size = new Size(54, 37);

            toolTip1.SetToolTip(panel_firefox, "DB Firefox...");
            
        }

        private void panel_firefox_MouseLeave(object sender, EventArgs e)
        {
            panel_firefox.Size = new Size(54, 37);
        }

        private void panel_chrome_MouseMove(object sender, MouseEventArgs e)
        {
            //sonido();
            panel_firefox.Size = new Size(54, 37);

            panel_chrome.Size = new Size(64, 47);

            panel_explorer.Size = new Size(54, 37);
            panel_configuracion.Size = new Size(54, 37);
            toolTip1.SetToolTip(panel_chrome, "DB Chrome...");
            

        }

        private void panel_chrome_MouseLeave(object sender, EventArgs e)
        {
            panel_chrome.Size = new Size(54, 37);
        }

        private void panel_explorer_MouseMove(object sender, MouseEventArgs e)
        {
            //sonido();
            panel_firefox.Size = new Size(54, 37);
            panel_chrome.Size = new Size(54, 37);

            panel_explorer.Size = new Size(64, 47);

            panel_configuracion.Size = new Size(54, 37);
            toolTip1.SetToolTip(panel_explorer, "DB Edge...");
            
        }

        private void panel_explorer_MouseLeave(object sender, EventArgs e)
        {
            panel_explorer.Size = new Size(54, 37);
        }

        private void panel_configuracion_MouseMove(object sender, MouseEventArgs e)
        {

            //sonido();
            panel_firefox.Size = new Size(54, 37);
            panel_chrome.Size = new Size(54, 37);
            panel_explorer.Size = new Size(54, 37);

            panel_configuracion.Size = new Size(64, 47);
            toolTip1.SetToolTip(panel_configuracion, "Configuracion...");
             
        }

        private void panel_configuracion_MouseLeave(object sender, EventArgs e)
        {
            panel_configuracion.Size = new Size(54, 37);
        }

        private void panel_ocultar_panel_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(panel_ocultar_panel, "Cerrar");
        }

        private void panel_cerrar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(panel_cerrar, "Salir");
        }

        private void panel_explorer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No disponible...");
        }

        private void panel_configuracion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No disponible...");
        }
    }
}

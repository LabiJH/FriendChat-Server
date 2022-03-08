/***************************************************************************************************************************************************************************
Programm:                       FriendChat
Funktion:                       Ein Chat Client zum verbinden an einen Server sowie schicken von Nachrichten
                                an einen anderen Clienten
Letzte Änderung:                21-06-2016
Autor:                          Labinot Jaha
***************************************************************************************************************************************************************************/
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

namespace FriendChat
{
    public partial class FriendChat : Form
    {
        public FriendChat()
        {
            InitializeComponent();
            EmpfangenSenden.RunWorkerAsync();
        }

        private void SendeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = "LBK_NixName";
                if (Username.Text != "")
                {
                    username = Username.Text;
                }
                byte[] textArray = Encoding.ASCII.GetBytes(username + ": " + ChatFenster.Text);                 // Verschlüsselung der Nachricht
                string[] serverAdresse = ServerAdresse.Text.Split(':');                                         // Splitten der Server Adresse in IP & Port

                IPAddress ipAdresse = IPAddress.Parse(serverAdresse[0]);                                        // IP Adressen Split
                int port = Convert.ToInt32(serverAdresse[1]);                                                   // Port Split
                IPEndPoint verbindungsAdresse = new IPEndPoint(ipAdresse, port);                                // Zusammenfügen der beiden zu einer Verbindungs Adresse
                ClientVariablen.udpClient.Send(textArray, textArray.Length, verbindungsAdresse);                // Senden der Nachricht an die Adresse
            }
            catch (Exception)
            {
                Application.Exit();                                                                             // Schließen der Applikation bei einem Error
            }
        }

        /* Verbindungs Button */
        private void VerbindungsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = "LBK_NixName";
                if (Username.Text != "")
                {
                    username = Username.Text;
                }
                byte[] textArray = Encoding.ASCII.GetBytes("> " + username + " hat sich Verbunden <");          // Senden des Usernames sowie Bestätigunsnachricht das der Client verbunden wurde
                string[] serverAdresse = ServerAdresse.Text.Split(':');                                         // Splitten der Server Adresse in IP & Port

                IPAddress ipAdresse = IPAddress.Parse(serverAdresse[0]);                                        // IP Adressen Split
                int port = Convert.ToInt32(serverAdresse[1]);                                                   // Port Split
                IPEndPoint verbindungsAdresse = new IPEndPoint(ipAdresse, port);                                // Zusammenfügen der beiden zu einer Verbindungs Adresse
                ClientVariablen.udpClient.Send(textArray, textArray.Length, verbindungsAdresse);                // Senden der Nachricht an die Adresse
            }
            catch (Exception)
            {
                Application.Exit();                                                                             // Schließen der Applikation bei einem Error
            }
        }

        private void EmpfangenSenden_DoWork(object sender, DoWorkEventArgs e)                                   // Dieser BackgroundWorker sendet & zeigt Nachrichten an
        {
            /* Unendliche Schleife */
            while (true)
            {
                byte[] empfangArray = ClientVariablen.udpClient.Receive(ref ClientVariablen.empfangsEndPoint);  // Empfangen der Nachricht vom Server
                string empfangeneNachricht = Encoding.ASCII.GetString(empfangArray);                            // Entschlüsseln der empfangenen Nachricht
                Chat.AppendText(empfangeneNachricht + Environment.NewLine);                                     // Schreiben der Nachricht in den ChatLog
            }
        }
    }
    /* Globale Client Variablen um den Clienten auf jedem PC starten zu können */
    public class ClientVariablen
    {
        public static UdpClient udpClient = new UdpClient(0);                                       // Erstellen des UDP Clienten sowie Port
        public static IPEndPoint empfangsEndPoint = new IPEndPoint(IPAddress.Any, 0);               // Die Adresse des derzeitigen Clienten
        /* Danke Niclas */
        string[][][][][][][][][] superJaggedArray;
    }
}

/***************************************************************************************************************************************************************************
Programm:                       FriendServer
Funktion:                       Der Server zum FriendChat der die empfangenen Nachrichten weiterleitet
                                an die anderen Clienten.
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
using System.Threading;

namespace FriendServer
{
    public partial class FriendServer : Form
    {
        public FriendServer()
        {
            InitializeComponent();
            ConnecterWorker.RunWorkerAsync();
        }

        private void ConnecterWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> clientListe = new List<string>();                          // Schonmal verbundene Clients werden in dieser Liste abgespeichert
            bool neuerClient;                                                       // Prüfungs Varaible um zu gucken ob der Client schonmal verbunden war
            int schleifenCounter;                                                  // Ein Zähler für das prüfen des Clienten

            UdpClient udpClient = new UdpClient(55555);                                   // Empfangs Port der Clients
            IPEndPoint serverClientAdresse = new IPEndPoint(IPAddress.Any, 0);            // Empfangs Addresse der Clients (Nimmt die Adresse der Clienten an)

            /* Ausgeben der Server Adresse sowie Port */
            string HostName = Dns.GetHostName();                                                    // Hostname der PC
            IPHostEntry hostInfo = Dns.GetHostByName(HostName);                                     // Auslesen der !!IPV4!! Addresse des derzeitigen Host PCs
            string ipadresse = hostInfo.AddressList[0].ToString();                                      // Schreiben der IPv4 Addresse in eine Variable
            string portPlatzhalter = (((IPEndPoint)udpClient.Client.LocalEndPoint).Port.ToString());    // Schreiben des Ports in eine Variable
            Adresse.Text = "Der Server wird gehostet von: " + ipadresse + ":" + portPlatzhalter; 

            /* Unendliche Schleife */
            while (true)
            {
                neuerClient = false;
                schleifenCounter = 0;
                try                                                                                     // Der Try verhindert das Abstürzen bei einem einzigen Fehler
                {
                    byte[] nachrichtenEmpfaenger = udpClient.Receive(ref serverClientAdresse);          // Hier wird auf eine Nachricht eines Clienten gewartet    
                    string nachricht = Encoding.ASCII.GetString(nachrichtenEmpfaenger);                 // Hier werden die Nachrichten des Clienten lesbar gemacht

                    do
                    {
                        if (clientListe.Contains(serverClientAdresse.ToString()))                     // Hier wird überprüft ob der Client bereits schonmal verbunden war
                        {

                        }
                        else
                        {
                            neuerClient = true;
                            clientListe.Add(serverClientAdresse.ToString());                          // Client wird in die Liste hinzugefügt
                        }
                        schleifenCounter++;
                    } while (neuerClient == false && schleifenCounter <= clientListe.Count);

                    ChatAbfang.AppendText(nachricht + Environment.NewLine);                     // Abfangen der Nachricht im Server Fenster

                    /* Sendeschleife */
                    foreach (string str in clientListe)                                         // Jeder String wird in den Folgenden Array geschrieben
                    {
                        string[] splitArrayIPPort;                                              // Schreiben der Client Adressen in den Array mit der Foreach Schleife
                        string clientPort;
                        string clientIP;

                        splitArrayIPPort = str.Split(':');                                          // Abtrennen von IPv4-Adresse und Port des Senders
                        clientIP = splitArrayIPPort[0];                                                
                        clientPort = splitArrayIPPort[1];                                              

                        int port = Convert.ToInt32(clientPort);                                         // Port zum Versenden
                        IPAddress sendeAddresse = IPAddress.Parse(clientIP);                            // IPv4 zum Versenden

                        IPEndPoint sendeEndPoint = new IPEndPoint(sendeAddresse, port);                 // Adressen an die gesendet wird

                        byte[] sendeArray = Encoding.ASCII.GetBytes(nachricht.ToString());                    // Codierung der Nachricht in Bytes
                        udpClient.Send(sendeArray, sendeArray.Length, sendeEndPoint);                         // Senden der Nachricht zum jeweiligen Clienten
                    }
                }
                catch (Exception)
                {
                    Application.Exit();                                                                 // Schließen der Applikation durch einen Error
                }
            }
        }
    }
}

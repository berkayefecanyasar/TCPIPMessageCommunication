using System.Net.Sockets;
using System.Net;
using System.Text;
using SuperSimpleTcp;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Windows.Forms;

namespace BerkayTCPApp
{
    public partial class Form1 : Form
    {
        #region Definition Part
        SimpleTcpClient client;
        SimpleTcpServer server;
        private bool isServer;
        private string lastClient;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private Message lastClientMessage;
        private bool isConnected = false;
        private bool isListen = false;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Application Type Selection Part
        private void rdbServer_CheckedChanged(object sender, EventArgs e)
        {
            isServer = true;
            SetUIAppType();
        }

        private void rdbClient_CheckedChanged(object sender, EventArgs e)
        {
            isServer = false;
            SetUIAppType();
        }

        private void SetUIAppType()
        {
            btnListen.Visible = isServer;
            btnConnect.Visible = !isServer;
            if (isServer)
            {
                tbxServerIp.Text = "127.0.0.1";
                tbxServerPort.Text = "200";
                tbxServerIp.ReadOnly = true;
            }
            else
            {
                tbxServerIp.ReadOnly = false;
                btnListen.Visible = false;
            }
        }
        #endregion

        #region Client Connection Part
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                if (int.TryParse(tbxServerPort.Text, out int port) && IsValidPort(port))
                {
                    try
                    {
                        client = new SimpleTcpClient(tbxServerIp.Text, port);
                        client.Events.Connected += Client_Connected;
                        client.Events.Disconnected += Client_Disconnected;
                        client.Events.DataReceived += Client_DataReceived;
                        client.Connect();

                        btnConnect.Text = "Disconnect";
                        isConnected = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred while connecting: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid port. Please enter a correct port number between 1 and 65535.");
                }
            }
            else
            {
                try
                {
                    client.DisconnectAsync();
                    btnConnect.Text = "Connect";
                    isConnected = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while disconnecting: " + ex.Message);
                }
            }
        }
        private bool IsValidPort(int port)
        {
            // Port numaraları 1 ile 65535 arasında olmalıdır.
            return port > 0 && port <= 65535;
        }

        private void Client_Disconnected(object? sender, ConnectionEventArgs e)
        {
            AddMessageToList("Disconnect from server.");
        }

        private void Client_Connected(object? sender, ConnectionEventArgs e)
        {
            AddMessageToList("Connected to server.");
        }
        #endregion

        #region Client Data Receiving and Parsing Part
        private void Client_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            var receivedmessage = e.Data.ToArray();

            var receivedm1 = M1Message.Parse(receivedmessage);
            if (receivedm1 != null)
            {
                receivedm1.Info = "Received";
                AddMessageToList(receivedm1);

            }
            var receivedm2 = M2Message.Parse(receivedmessage);
            if (receivedm2 != null)
            {
                receivedm2.Info = "Received";
                AddMessageToList(receivedm2);

            }
        }
        #endregion

        #region Server Connection Part
        private void btnListen_Click(object sender, EventArgs e)
        {
            if (!isListen)
            {
                if (int.TryParse(tbxServerPort.Text, out int port) && IsValidPort(port))
                {
                    server = new SimpleTcpServer(tbxServerIp.Text, port);
                    server.Events.ClientConnected += ClientConnected;
                    server.Events.ClientDisconnected += ClientDisconnected;
                    server.Events.DataReceived += ServerDataReceived;
                    try
                    {
                        server.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error starting server: {ex.Message}");
                        return;
                    }

                    btnListen.Text = "Stop";
                    isListen = true;
                    AddMessageToList("Server started.");
                }
                else
                {
                    MessageBox.Show("Invalid port. Please enter a correct port number between 1 and 65535.");
                }
            }
            else
            {
                if (server != null)
                {
                    try
                    {
                        server.Stop();
                        AddMessageToList("Server stopped.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error stopping server: {ex.Message}");
                        return;
                    }
                    btnListen.Text = "Listen";
                    isListen = false;
                }
            }
        }


        private void ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            AddMessageToList("Client disconnected." + e.IpPort);
        }

        private void ClientConnected(object? sender, ConnectionEventArgs e)
        {
            AddMessageToList("Client connected." + e.IpPort);
            lastClient = e.IpPort;
        }

        #endregion

        #region Server Data Receiving, Parsing and Creating Response Part
        private void ServerDataReceived(object? sender, DataReceivedEventArgs e)
        {
            var receivedmessage = e.Data.ToArray();

            var receivedm1 = M1Message.Parse(receivedmessage);
            if (receivedm1 != null)
            {
                receivedm1.Info = "Received";
                AddMessageToList(receivedm1);
                var m2 = M2Message.CreateRandomMessage();
                SendMessage(m2);
                return;

            }

            var receivedm2 = M2Message.Parse(receivedmessage);
            if (receivedm2 != null)
            {
                receivedm2.Info = "Received";
                AddMessageToList(receivedm2);
                var m1 = M1Message.CreateRandomMessage();
                SendMessage(m1);
                return;
            }

            var unknownmessage = UnknownMessage.Parse(receivedmessage);
            AddMessageToList(unknownmessage);

        }
        #endregion

        #region Sending Message Part
        private void Send_Button_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            if (tbcMessages.SelectedTab.Name == "Message1")
            {
                var m1 = new M1Message();
                int referenceNoM1;
                if (int.TryParse(txtReferanceNoM1.Text, out referenceNoM1))
                {
                    m1.ReferenceNo = referenceNoM1;
                }
                else
                {
                    MessageBox.Show("Please enter a valid reference number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                m1.Name = txtName.Text;
                m1.Surname = txtSurname.Text;

                short rank;
                if (short.TryParse(cbRank.SelectedIndex.ToString(), out rank))
                {
                    m1.Rank = rank;
                }
                else
                {
                    MessageBox.Show("Please select a valid rank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SendMessage(m1);
            }
            if (tbcMessages.SelectedTab.Name == "Message2")
            {
                var m2 = new M2Message();
                int referenceNoM2;
                if (int.TryParse(txtReferanceNoM2.Text, out referenceNoM2))
                {
                    m2.ReferenceNo = referenceNoM2;
                }
                else
                {
                    MessageBox.Show("Please enter a valid reference number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                byte validity;
                if (byte.TryParse(txtLocationValid.Text, out validity) && (validity == 0 || validity == 1))
                {
                    m2.Validity = validity;
                }
                else
                {
                    MessageBox.Show("Please enter a valid validity status (0 or 1).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int latitude;
                if (int.TryParse(txtLatitude.Text, out latitude))
                {
                    m2.Lan = latitude;
                }
                else
                {
                    MessageBox.Show("Please enter a valid latitude.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int longitude;
                if (int.TryParse(txtLongitude.Text, out longitude))
                {
                    m2.Lon = longitude;
                }
                else
                {
                    MessageBox.Show("Please enter a valid longitude.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int altitude;
                if (int.TryParse(txtAltitude.Text, out altitude))
                {
                    m2.Alt = altitude;
                }
                else
                {
                    MessageBox.Show("Please enter a valid altitude.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SendMessage(m2);
            }

        }


        #endregion

        #region Message Sending with Selected Interval
        private void tmrStart_Click(object sender, EventArgs e)
        {
            timer.Interval = Convert.ToInt32(txtTimer.Text);
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Tick += timer_Tick;
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            Random random = new Random();
            if (tbcMessages.SelectedTab.Name == "Message1")
            {
                var m1 = new M1Message();
                int referenceNoM1;
                if (int.TryParse(txtReferanceNoM1.Text, out referenceNoM1))
                {
                    m1.ReferenceNo = referenceNoM1;
                }
                else
                {
                    MessageBox.Show("Please enter a valid reference number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                m1.Name = txtName.Text;
                m1.Surname = txtSurname.Text;

                short rank;
                if (short.TryParse(cbRank.SelectedIndex.ToString(), out rank))
                {
                    m1.Rank = rank;
                }
                else
                {
                    MessageBox.Show("Please select a valid rank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SendMessage(m1);
            }
            if (tbcMessages.SelectedTab.Name == "Message2")
            {
                var m2 = new M2Message();
                int referenceNoM2;
                if (int.TryParse(txtReferanceNoM2.Text, out referenceNoM2))
                {
                    m2.ReferenceNo = referenceNoM2;
                }
                else
                {
                    MessageBox.Show("Please enter a valid reference number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                byte validity;
                if (byte.TryParse(txtLocationValid.Text, out validity) && (validity == 0 || validity == 1))
                {
                    m2.Validity = validity;
                }
                else
                {
                    MessageBox.Show("Please enter a valid validity status (0 or 1).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int latitude;
                if (int.TryParse(txtLatitude.Text, out latitude))
                {
                    m2.Lan = latitude;
                }
                else
                {
                    MessageBox.Show("Please enter a valid latitude.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int longitude;
                if (int.TryParse(txtLongitude.Text, out longitude))
                {
                    m2.Lon = longitude;
                }
                else
                {
                    MessageBox.Show("Please enter a valid longitude.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int altitude;
                if (int.TryParse(txtAltitude.Text, out altitude))
                {
                    m2.Alt = altitude;
                }
                else
                {
                    MessageBox.Show("Please enter a valid altitude.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SendMessage(m2);
            }

        }

        private void tmrStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        #endregion

        #region Message Manupilations (Sending and Adding to List)
        private void SendMessage(Message message)
        {
            if (message == null)
            {
                return;
            }
            if (message == lastClientMessage)
            {
                return;
            }

            lastClientMessage = message;

            if (isServer)
            {
                message.Info = "Transmitted";
                AddMessageToList(message);
                server.Send(lastClient, message.ToByteArray());

            }
            else
            {
                message.Info = "Transmitted";
                AddMessageToList(message);
                client.Send(message.ToByteArray());
            }
        }

        private void AddMessageToList(object message)
        {
            if (lstMessages.InvokeRequired)
            {
                lstMessages.Invoke(new Action<object>(AddMessageToList), message);
            }
            else
            {
                lstMessages.Items.Add(message);
            }
        }
        #endregion

        #region MessageList Visualisation Message Details Part
        private void lstMessages_Click(object sender, EventArgs e)
        {
            pnlM1.Visible = false;
            pnlM2.Visible = false;
            pnlUnknown.Visible = false;

            if (lstMessages.SelectedItem is M1Message m1)
            {
                pnlM1.Visible = true;
                txtMessageName.Text = m1.Name;
                txtMessageSurname.Text = m1.Surname;
                txtMessageReferanceNoM1.Text = m1.ReferenceNo.ToString();

                if (m1.Rank == (short)0)
                {
                    txtMessageRank.Text = "Üsteğmen";
                }
                else if (m1.Rank == (short)1)
                {
                    txtMessageRank.Text = "Teğmen";

                }
                else if (m1.Rank == (short)2)
                {
                    txtMessageRank.Text = "Asteğmen";
                }
            }
            else if (lstMessages.SelectedItem is M2Message m2)
            {
                pnlM2.Visible = true;
                txtMessageReferanceNoM2.Text = m2.ReferenceNo.ToString();
                txtMessageAltitude.Text = m2.Alt.ToString();
                txtMessageLoc.Text = m2.Validity.ToString();
                txtMessageLongitude.Text = m2.Lon.ToString();
                txtMessageLatitude.Text = m2.Lan.ToString();
            }
            else if (lstMessages.SelectedItem is UnknownMessage um)
            {
                pnlUnknown.Visible = true;
                txtMessageUnknown.Text = um.Data.ToString();
            }

        }
        #endregion


    }
}

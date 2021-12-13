using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

using TrainCrew;

namespace TrainCrewRollsing
{
    public partial class FormRollsing : Form
    {

        string Type_Old = "";
        string Dest_Old = "";
        private static readonly HttpClient client = new HttpClient();
        public FormRollsing()
        {
            InitializeComponent();
            this.comboTrainSeries.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTrainSeries.Text = Properties.Settings.Default.Train;
            textBoxRollsingIP.Text = Properties.Settings.Default.RollsingIP;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            var state = TrainCrewInput.GetTrainState();
            if (comboTrainSeries.Text != "")
            {
                if (state.Class != "" && state.Class != Type_Old || state.BoundFor != "" && state.BoundFor != Dest_Old)
                {

                    if (state.Class == "回送" || state.Class == "試運転" || state.Class == "団体")
                    {
                        setRollsing(comboTrainSeries.Text, "Special", state.Class, state.BoundFor);
                    }
                    else if (state.BoundFor == "")
                    {
                        setRollsing(comboTrainSeries.Text, "FullType", state.Class, "");
                    }
                    else if (state.Class == "")
                    {
                        setRollsing(comboTrainSeries.Text, "FullDest", "", state.BoundFor);
                    }
                    else
                    {
                        setRollsing(comboTrainSeries.Text, "Normal", state.Class, state.BoundFor);
                    }
                }
            }
            

        }

        public async void setRollsing(string train, string mode, string type, string dest)
        {
            var values = new Dictionary<string, string>
                {
                    { "Train", train },
                    { "Mode", mode },
                    { "Type", type },
                    { "Dest", dest }
                };

            var content = new FormUrlEncodedContent(values);
            await client.PostAsync("http://"+ Properties.Settings.Default.RollsingIP +"/setRollsing/", content);
            pictureRollsing.Load("http://"+ Properties.Settings.Default.RollsingIP +"/output.gif");
            Type_Old = type;
            Dest_Old = dest;
        }

        private void buttonRollsingSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RollsingIP = textBoxRollsingIP.Text;
            Properties.Settings.Default.Train = comboTrainSeries.Text;
            Properties.Settings.Default.Save();
            setRollsing(comboTrainSeries.Text, "Special", "回送", "");
            Type_Old = "";
            Dest_Old = "";
        }

        private void buttonRollsingTest_Click(object sender, EventArgs e)
        {
            setRollsing(comboTrainSeries.Text, "Special", "試運転", "");
            Type_Old = "";
            Dest_Old = "";
        }
    }
}

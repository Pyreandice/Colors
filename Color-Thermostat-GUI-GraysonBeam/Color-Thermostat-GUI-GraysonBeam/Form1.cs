using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Thermostat_GUI_GraysonBeam
{
    public partial class ColorsForm : Form
    {
        private const int NumZero = 0;
        private const int NumOne = 1;
        private const int NumTwentyFive = 25;
        private const int NumTwentySix = 26;
        private const int NumFifty = 50;
        private const int NumFiftyOne = 51;
        private const int NumSeventyFive = 75;
        private const int NumSeventySix = 76;
        private const int NumOneHundred = 100;
        private const int NumTwoFiftyFive = 255;

        public ColorsForm()
        {
            this.InitializeComponent();
        }

        public void CalculateTemperatureColor()
        {
            int.TryParse(this.TemperatureTextBox.Text, out var temperature);
            if (temperature < NumOne || temperature > NumOneHundred)
            {
                this.TemperatureTextBox.BackColor = Color.IndianRed;
            }
            else
            {
                this.TemperatureTextBox.BackColor = Color.White;
            }

            if (temperature >= NumZero && temperature <= NumTwentyFive)
            {
                var zeta = (temperature - NumOne) / (NumTwentyFive - NumOne);
                var tote = NumTwoFiftyFive * zeta + NumTwoFiftyFive * (NumOne - zeta);
            }
            else if (temperature >= NumTwentySix && temperature <= NumFifty)
            {
                var zeta = (temperature - NumTwentySix) / (NumFifty - NumTwentySix);
                var tote = NumTwoFiftyFive * zeta + NumTwoFiftyFive * (NumOne - zeta);


            }
            else if (temperature >= NumFiftyOne && temperature <= NumSeventyFive)
            {
                // do this
            }
            else if (temperature >= NumSeventySix && temperature <= NumOneHundred)
            {
                // do this
            }
        }

        public int ParseTemperatureTextBox(out int temperatureValue)
        {
            int.TryParse(this.TemperatureTextBox.Text, out var temperature);
            if (temperature < NumOne || temperature > NumOneHundred)
            {
                this.TemperatureTextBox.BackColor = Color.IndianRed;
            }
            else
            {
                this.TemperatureTextBox.BackColor = Color.White;
                this.CalculateTemperatureColor();
            }
            temperatureValue = temperature;

            return temperatureValue;
        }

        private void TemperatureButton_Click(object sender, EventArgs e)
        {
            ParseTemperatureTextBox(out int temperatureValue);
            this.TemperatureResultRichTextBox.Text = $@"{temperatureValue:G}";
        }
    }
}

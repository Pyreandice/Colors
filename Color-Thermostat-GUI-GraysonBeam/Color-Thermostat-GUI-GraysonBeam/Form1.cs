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
    using System.Diagnostics.CodeAnalysis;

    public partial class ColorsForm : Form
    {
        /// <summary>
        /// The num zero.
        /// </summary>
        private const int Zero = 0;

        /// <summary>
        /// The num one.
        /// </summary>
        private const int One = 1;

        /// <summary>
        /// The num twenty five.
        /// </summary>
        private const int TwentyFive = 25;

        /// <summary>
        /// The num twenty six.
        /// </summary>
        private const int TwentySix = 26;

        /// <summary>
        /// The num fifty.
        /// </summary>
        private const int Fifty = 50;

        /// <summary>
        /// The num fifty one.
        /// </summary>
        private const int FiftyOne = 51;

        /// <summary>
        /// The num seventy five.
        /// </summary>
        private const int SeventyFive = 75;

        /// <summary>
        /// The num seventy six.
        /// </summary>
        private const int SeventySix = 76;

        /// <summary>
        /// The num one hundred.
        /// </summary>
        private const int OneHundred = 100;

        /// <summary>
        /// The num two fifty five.
        /// </summary>
        private const int TwoFiftyFive = 255;

        /// <summary>
        ///  The num two fifty six.
        /// </summary>
        private const int TwoFiftySix = 256;

        /// <summary>
        /// The conversion factor.
        /// </summary>
        private const int ConversionFactor = 65536;

        public ColorsForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The calculate temperature color.
        /// </summary>
        /// <param name="userColor">
        /// The user color.
        /// </param>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1126:PrefixCallsCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        private void CalculateTemperatureColor()
        {
            int.TryParse(this.TemperatureTextBox.Text, out var temperature);
            if (temperature < One || temperature > OneHundred)
            {
                this.TemperatureTextBox.BackColor = Color.IndianRed;
            }
            else
            {
                this.TemperatureTextBox.BackColor = Color.White;
            }

            if (temperature >= Zero && temperature <= TwentyFive)
            {
                var redValue = (double)Zero;
                var greenValue = ((double)temperature - (double)One) / ((double)TwentyFive - (double)One);
                var blueValue = (TwoFiftyFive * greenValue) + (TwoFiftyFive * (One - greenValue));
                var userColor = (ConversionFactor * redValue) + (greenValue * TwoFiftySix) + blueValue;

                this.TemperatureResultRichTextBox.Text = string.Format(
                    @"The user has entered {0:G} {1} The RGB values are ({2:G3}, {3:G3}, {4:G3}) {5} The color value would be {6:G3}",
                    temperature,
                    Environment.NewLine,
                    redValue,
                    greenValue,
                    blueValue,
                    Environment.NewLine,
                    userColor);
                this.BackColor = Color.FromArgb((int)redValue, (int)greenValue, (int)blueValue);
            }
            else if (temperature >= TwentySix && temperature <= Fifty)
            {
                var redValue = (temperature - TwentySix) / (Fifty - TwentySix);
                var greenValue = (TwoFiftyFive * redValue) + (TwoFiftyFive * (One - redValue));
                var blueValue = 0; // temp till formula is made
            }
            else if (temperature >= FiftyOne && temperature <= SeventyFive)
            {
                var redValue = (temperature - FiftyOne) / SeventyFive * (SeventyFive - FiftyOne);
                var greenValue = (TwoFiftyFive * redValue) + (TwoFiftyFive * (One - redValue));
                var blueValue = 0; // temp till formula is made
            }
            else if (temperature >= SeventySix && temperature <= OneHundred)
            {
                var redValue = (temperature - SeventySix) / OneHundred * (OneHundred - SeventySix);
                var greenValue = (TwoFiftyFive * redValue) + (TwoFiftyFive * (One - redValue));
                var blueValue = 0; // temp till formula is made
            }
        }

        //public int ParseTemperatureTextBox(out int temperatureValue)
        //{
        //    int.TryParse(this.TemperatureTextBox.Text, out var temperature);
        //    if (temperature < One || temperature > OneHundred)
        //    {
        //        this.TemperatureTextBox.BackColor = Color.IndianRed;
        //    }
        //    else
        //    {
        //        this.TemperatureTextBox.BackColor = Color.White;
        //        this.CalculateTemperatureColor(out double userColor);
        //    }
        //    temperatureValue = temperature;

        //    return temperatureValue;
        //}

        private void TemperatureButton_Click(object sender, EventArgs e)
        {
            this.CalculateTemperatureColor();
        }

        private void TemperatureNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.CalculateTemperatureColor();
        }
    }
}

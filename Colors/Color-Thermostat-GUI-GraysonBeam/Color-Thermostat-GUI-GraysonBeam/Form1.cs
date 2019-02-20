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
                var redValues = (double)0;
                var greenValueZ = ((double)temperature - (double)One) / ((double)TwentyFive - (double)One);
                var greenValueY = (TwoFiftyFive * greenValueZ) + (TwoFiftyFive * (One - greenValueZ));
                var blueValueZ = ((double)temperature - (double)One) / ((double)TwentyFive - (double)One);
                var blueValueY = (Zero * blueValueZ) + TwoFiftyFive * (One - blueValueZ);
                var userColor = (ConversionFactor * redValues) + (greenValueY * TwoFiftySix) + blueValueY;

                this.TemperatureResultRichTextBox.Text = string.Format(
                    @"The user has entered {0:G} {1} The RGB values are ({2:G3}, {3:G3}, {4:G3}) {5} The color value would be {6:G3}",
                    temperature,
                    Environment.NewLine,
                    redValues,
                    greenValueY,
                    blueValueY,
                    Environment.NewLine,
                    userColor);
                this.BackColor = Color.FromArgb((int)redValues, (int)greenValueY, (int)blueValueY);
            }
            else if (temperature >= TwentySix && temperature <= Fifty)
            {
                var redValues = (double)0;
                var greenValueZ = ((double)temperature - (double)TwentySix) / ((double)Fifty - (double)TwentySix);
                var greenValueY = (TwoFiftyFive * greenValueZ) + (TwoFiftyFive * (One - greenValueZ));
                var blueValueZ = ((double)temperature - (double)TwentySix) / ((double)Fifty - (double)TwentySix);
                var blueValueY = (Zero * blueValueZ) + TwoFiftyFive * (One - blueValueZ);
                var userColor = (ConversionFactor * redValues) + (greenValueY * TwoFiftySix) + blueValueY;

                this.TemperatureResultRichTextBox.Text = string.Format(
                    @"The user has entered {0:G} {1} The RGB values are ({2:G3}, {3:G3}, {4:G3}) {5} The color value would be {6:G3}",
                    temperature,
                    Environment.NewLine,
                    redValues,
                    greenValueY,
                    blueValueY,
                    Environment.NewLine,
                    userColor);
                this.BackColor = Color.FromArgb((int)redValues, (int)greenValueY, (int)blueValueY);
            }
            else if (temperature >= FiftyOne && temperature <= SeventyFive)
            {
                var redValueZ = ((double) temperature - (double) FiftyOne) / ((double) SeventyFive - (double) FiftyOne);
                var redValueY = (TwoFiftyFive * redValueZ) + (TwoFiftyFive * (One - redValueZ));
                var greenValueZ = ((double)temperature - (double)FiftyOne) / ((double)SeventyFive - (double)FiftyOne);
                var greenValueY = (TwoFiftyFive * greenValueZ) + (TwoFiftyFive * (One - greenValueZ));
                var blueValues = 0;
                var userColor = (ConversionFactor * redValueY) + (greenValueY * TwoFiftySix) + blueValues;

                this.TemperatureResultRichTextBox.Text = string.Format(
                    @"The user has entered {0:G} {1} The RGB values are ({2:G3}, {3:G3}, {4:G3}) {5} The color value would be {6:G3}",
                    temperature,
                    Environment.NewLine,
                    redValueY,
                    greenValueY,
                    blueValues,
                    Environment.NewLine,
                    userColor);
                this.BackColor = Color.FromArgb((int)redValueY, (int)greenValueY, (int)blueValues);
            }
            else if (temperature >= SeventySix && temperature <= OneHundred)
            {
                var redValueZ = ((double)temperature - (double)SeventySix) / ((double)OneHundred - (double)SeventySix);
                var redValueY = (TwoFiftyFive * redValueZ) + (TwoFiftyFive * (One - redValueZ));
                var greenValueZ = ((double)temperature - (double)SeventySix) / ((double)OneHundred - (double)SeventySix);
                var greenValueY = (TwoFiftyFive * greenValueZ) + (TwoFiftyFive * (One - greenValueZ));
                var blueValues = 0;
                var userColor = (ConversionFactor * redValueY) + (greenValueY * TwoFiftySix) + blueValues;

                this.TemperatureResultRichTextBox.Text = string.Format(
                    @"The user has entered {0:G} {1} The RGB values are ({2:G3}, {3:G3}, {4:G3}) {5} The color value would be {6:G3}",
                    temperature,
                    Environment.NewLine,
                    redValueY,
                    greenValueY,
                    blueValues,
                    Environment.NewLine,
                    userColor);
                this.BackColor = Color.FromArgb((int)redValueY, (int)greenValueY, (int)blueValues);
            }
        }

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

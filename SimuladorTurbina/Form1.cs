using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimuladorTurbina
{
    public partial class Form1 : Form
    {
        #region VdF Variables de Formulario
        int SDVEstado = 0;
        int SAVEstado = 0;

        float SHValor = 0;
        float SLValor = 0;

        float SHSetpoint = 0;
        float SLSetpoint = 0;

        #endregion VdF Variables de Formulario

        public Form1()
        {
            InitializeComponent();
            ParametrosIniciales();
        }
        private void ParametrosIniciales()
        {
            textBoxSHValor.Text = "0.0";
            textBoxSLValor.Text = "0.0";

            SHSetpoint = 11000;
            textBoxSHSetpoint.Text = Convert.ToString(SHSetpoint);

            SLSetpoint = 275;
            textBoxSLSetpoint.Text = Convert.ToString(SLSetpoint);

            buttonSDVOff.BackColor = Color.Red;
            buttonSHParo.BackColor = Color.Red;
            buttonSLParo.BackColor = Color.Red;
            buttonSAVOff.BackColor = Color.Red;
        }
        #region AjAvanzados
        private void buttonSHAplicarSetpoint_Click(object sender, EventArgs e)
        {
            SHSetpoint = (float)Convert.ToDecimal(textBoxSHSetpoint.Text);
            textBoxSHSetpoint.Text = Convert.ToString(SHSetpoint);

        }
        private void buttonSLAplicarSetpoint_Click(object sender, EventArgs e)
        {
            SLSetpoint = (float)Convert.ToDecimal(textBoxSLSetpoint.Text);
            textBoxSLSetpoint.Text = Convert.ToString(SLSetpoint);
        }
        #endregion AjAvanzados

        #region SH
        #region SH+
        private void buttonSHMarcha_Click(object sender, EventArgs e)
        {
            timerSH.Enabled = true;
            timerSHDecrement.Enabled = false;
        }

        private void timerSH_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Incremento = rnd.Next(220, 350);
            SHValor += Incremento;
            textBoxSHValor.Text = Convert.ToString(SHValor);
            if (SHValor >= SHSetpoint - 350)
            {
                SHValor = SHSetpoint;
                textBoxSHValor.Text = Convert.ToString(SHValor);
                timerSH.Enabled = false;
                buttonSHMarcha.BackColor = System.Drawing.Color.Yellow;
                buttonSHParo.BackColor = default;
            }
        }
        #endregion SH+
        #region SH-

        private void buttonSHParo_Click(object sender, EventArgs e)
        {
            timerSHDecrement.Enabled = true;
            timerSH.Enabled = false;
        }
        private void timerSHDecrement_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Decremento = rnd.Next(220, 350);
            SHValor -= Decremento;
            textBoxSHValor.Text = Convert.ToString(SHValor);
            if (SHValor <= 350)
            {
                SHValor = 0;
                textBoxSHValor.Text = Convert.ToString(SHValor);
                timerSHDecrement.Enabled = false;
                buttonSHParo.BackColor = Color.Red;
                buttonSHMarcha.BackColor = default;
            }
        }
        #endregion SH-
        #endregion SH

        #region SL
        #region SL+
        private void buttonSLMarcha_Click(object sender, EventArgs e)
        {
            timerSL.Enabled = true;
            timerSLDecrement.Enabled = false;
        }
        private void timerSL_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Incremento = rnd.Next(15, 27);
            SLValor += Incremento;
            textBoxSLValor.Text = Convert.ToString(SLValor);
            if (SLValor >= SLSetpoint - 27)
            {
                SLValor = SLSetpoint;
                textBoxSLValor.Text = Convert.ToString(SLValor);
                timerSL.Enabled = false;
                buttonSLMarcha.BackColor = System.Drawing.Color.Yellow;
                buttonSLParo.BackColor = default;
            }
        }
        #endregion SL+
        #region SL-
        private void buttonSLParo_Click(object sender, EventArgs e)
        {
            timerSLDecrement.Enabled = true;
            timerSL.Enabled = false;
        }
        private void timerSLDecrement_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Decremento = rnd.Next(15, 27);
            SLValor -= Decremento;
            textBoxSLValor.Text = Convert.ToString(SLValor);
            if (SLValor <= 27)
            {
                SLValor = 0;
                textBoxSLValor.Text = Convert.ToString(SLValor);
                timerSLDecrement.Enabled = false;
                buttonSLParo.BackColor = Color.Red;
                buttonSLMarcha.BackColor = default;
            }
        }
        #endregion SL-
        #endregion SL

        #region SV
        #region SAV
        #region SAV+
        private void buttonSAVOn_Click(object sender, EventArgs e)
        {
            timerSAV.Enabled = true;
            timerSAVDecrement.Enabled = false;
        }
        private void timerSAV_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Incremento = rnd.Next(7, 13);
            SAVEstado += Incremento;
            textBoxSAVEstado.Text = Convert.ToString(SAVEstado);

            if (SAVEstado >= 86)
            {
                SAVEstado = 100;
                textBoxSAVEstado.Text = Convert.ToString(SAVEstado);
                timerSAV.Enabled = false;
                buttonSAVOn.BackColor = System.Drawing.Color.Yellow;
                buttonSAVOff.BackColor = default;
            }
        }
        #endregion SAV+
        #region SAV-
        private void buttonSAVOff_Click(object sender, EventArgs e)
        {
            timerSAVDecrement.Enabled = true;
            timerSAV.Enabled = false;
        }
        private void timerSAVDecrement_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Decremento = rnd.Next(7, 13);
            SAVEstado -= Decremento;
            textBoxSAVEstado.Text = Convert.ToString(SAVEstado);
            if (SAVEstado <= 13)
            {
                SAVEstado = 0;
                textBoxSAVEstado.Text = Convert.ToString(SAVEstado);
                timerSAVDecrement.Enabled = false;
                buttonSAVOff.BackColor = Color.Red;
                buttonSAVOn.BackColor = default;
            }
        }
        #endregion SAV-
        #endregion SAV
        #region SDV
        #region SDV+
        private void buttonSDVOn_Click(object sender, EventArgs e)
        {
            timerSDV.Enabled = true;
            timerSDVDecrement.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Incremento = rnd.Next(7, 13);
            SDVEstado += Incremento;
            textBoxSDVEstado.Text = Convert.ToString(SDVEstado);

            if (SDVEstado >= 86)
            {
                SDVEstado = 100;
                textBoxSDVEstado.Text = Convert.ToString(SDVEstado);
                timerSDV.Enabled = false;
                buttonSDVOn.BackColor = System.Drawing.Color.Yellow;
                buttonSDVOff.BackColor = default;
            }
        }

        #endregion SDV+
        #region SDV-
        private void buttonSDVOff_Click(object sender, EventArgs e)
        {
            timerSDVDecrement.Enabled = true;
            timerSDV.Enabled = false;
        }
        private void timerSDVDecrement_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Decremento = rnd.Next(7, 13);
            SDVEstado -= Decremento;
            textBoxSDVEstado.Text = Convert.ToString(SDVEstado);
            if (SDVEstado <= 13)
            {
                SDVEstado = 0;
                textBoxSDVEstado.Text = Convert.ToString(SDVEstado);
                timerSDVDecrement.Enabled = false;
                buttonSDVOff.BackColor = Color.Red;
                buttonSDVOn.BackColor = default;
            }
        }







        #endregion SDV-

        #endregion SDV
        #endregion SV
    }
}

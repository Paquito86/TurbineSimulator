
namespace SimuladorTurbina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSHAplicarSetpoint = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSHSetpoint = new System.Windows.Forms.TextBox();
            this.buttonSHMarcha = new System.Windows.Forms.Button();
            this.buttonSHParo = new System.Windows.Forms.Button();
            this.textBoxSHValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSLAplicarSetpoint = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSLSetpoint = new System.Windows.Forms.TextBox();
            this.buttonSLMarcha = new System.Windows.Forms.Button();
            this.buttonSLParo = new System.Windows.Forms.Button();
            this.textBoxSLValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxSDVFlujo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSDVOn = new System.Windows.Forms.Button();
            this.buttonSDVOff = new System.Windows.Forms.Button();
            this.textBoxSDVEstado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timerSDV = new System.Windows.Forms.Timer(this.components);
            this.timerSH = new System.Windows.Forms.Timer(this.components);
            this.timerSHDecrement = new System.Windows.Forms.Timer(this.components);
            this.timerSDVDecrement = new System.Windows.Forms.Timer(this.components);
            this.timerSL = new System.Windows.Forms.Timer(this.components);
            this.timerSLDecrement = new System.Windows.Forms.Timer(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSAVStepSize10 = new System.Windows.Forms.Button();
            this.buttonSAVStepSize5 = new System.Windows.Forms.Button();
            this.buttonSAVStepSize1 = new System.Windows.Forms.Button();
            this.buttonSAVStepDown = new System.Windows.Forms.Button();
            this.buttonSAVStepUp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSAVOn = new System.Windows.Forms.Button();
            this.buttonSAVOff = new System.Windows.Forms.Button();
            this.textBoxSAVEstado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timerSAV = new System.Windows.Forms.Timer(this.components);
            this.timerSAVDecrement = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador de Turbina y Sistemas de Soporte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonSHMarcha);
            this.groupBox1.Controls.Add(this.buttonSHParo);
            this.groupBox1.Controls.Add(this.textBoxSHValor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema Hidráulico";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSHAplicarSetpoint);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxSHSetpoint);
            this.groupBox2.Location = new System.Drawing.Point(6, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 67);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajustes Avanzados";
            // 
            // buttonSHAplicarSetpoint
            // 
            this.buttonSHAplicarSetpoint.Location = new System.Drawing.Point(202, 18);
            this.buttonSHAplicarSetpoint.Name = "buttonSHAplicarSetpoint";
            this.buttonSHAplicarSetpoint.Size = new System.Drawing.Size(75, 23);
            this.buttonSHAplicarSetpoint.TabIndex = 11;
            this.buttonSHAplicarSetpoint.Text = "Aplicar";
            this.buttonSHAplicarSetpoint.UseVisualStyleBackColor = true;
            this.buttonSHAplicarSetpoint.Click += new System.EventHandler(this.buttonSHAplicarSetpoint_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Valor por defecto: 11.000,0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ajuste (Setpoint)";
            // 
            // textBoxSHSetpoint
            // 
            this.textBoxSHSetpoint.Location = new System.Drawing.Point(96, 21);
            this.textBoxSHSetpoint.Name = "textBoxSHSetpoint";
            this.textBoxSHSetpoint.Size = new System.Drawing.Size(100, 20);
            this.textBoxSHSetpoint.TabIndex = 6;
            // 
            // buttonSHMarcha
            // 
            this.buttonSHMarcha.Location = new System.Drawing.Point(9, 44);
            this.buttonSHMarcha.Name = "buttonSHMarcha";
            this.buttonSHMarcha.Size = new System.Drawing.Size(75, 23);
            this.buttonSHMarcha.TabIndex = 3;
            this.buttonSHMarcha.Text = "Marcha";
            this.buttonSHMarcha.UseVisualStyleBackColor = true;
            this.buttonSHMarcha.Click += new System.EventHandler(this.buttonSHMarcha_Click);
            // 
            // buttonSHParo
            // 
            this.buttonSHParo.Location = new System.Drawing.Point(104, 43);
            this.buttonSHParo.Name = "buttonSHParo";
            this.buttonSHParo.Size = new System.Drawing.Size(75, 23);
            this.buttonSHParo.TabIndex = 2;
            this.buttonSHParo.Text = "Paro";
            this.buttonSHParo.UseVisualStyleBackColor = true;
            this.buttonSHParo.Click += new System.EventHandler(this.buttonSHParo_Click);
            // 
            // textBoxSHValor
            // 
            this.textBoxSHValor.Location = new System.Drawing.Point(99, 17);
            this.textBoxSHValor.Name = "textBoxSHValor";
            this.textBoxSHValor.Size = new System.Drawing.Size(80, 20);
            this.textBoxSHValor.TabIndex = 1;
            this.textBoxSHValor.Text = "0,0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aceite Hidráulico";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.buttonSLMarcha);
            this.groupBox3.Controls.Add(this.buttonSLParo);
            this.groupBox3.Controls.Add(this.textBoxSLValor);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 146);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sistema de Lubricación";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSLAplicarSetpoint);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBoxSLSetpoint);
            this.groupBox4.Location = new System.Drawing.Point(6, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 67);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ajustes Avanzados";
            // 
            // buttonSLAplicarSetpoint
            // 
            this.buttonSLAplicarSetpoint.Location = new System.Drawing.Point(202, 18);
            this.buttonSLAplicarSetpoint.Name = "buttonSLAplicarSetpoint";
            this.buttonSLAplicarSetpoint.Size = new System.Drawing.Size(75, 23);
            this.buttonSLAplicarSetpoint.TabIndex = 10;
            this.buttonSLAplicarSetpoint.Text = "Aplicar";
            this.buttonSLAplicarSetpoint.UseVisualStyleBackColor = true;
            this.buttonSLAplicarSetpoint.Click += new System.EventHandler(this.buttonSLAplicarSetpoint_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Valor por defecto: 275,0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ajuste (Setpoint)";
            // 
            // textBoxSLSetpoint
            // 
            this.textBoxSLSetpoint.Location = new System.Drawing.Point(96, 21);
            this.textBoxSLSetpoint.Name = "textBoxSLSetpoint";
            this.textBoxSLSetpoint.Size = new System.Drawing.Size(100, 20);
            this.textBoxSLSetpoint.TabIndex = 6;
            // 
            // buttonSLMarcha
            // 
            this.buttonSLMarcha.Location = new System.Drawing.Point(9, 43);
            this.buttonSLMarcha.Name = "buttonSLMarcha";
            this.buttonSLMarcha.Size = new System.Drawing.Size(75, 23);
            this.buttonSLMarcha.TabIndex = 3;
            this.buttonSLMarcha.Text = "Marcha";
            this.buttonSLMarcha.UseVisualStyleBackColor = true;
            this.buttonSLMarcha.Click += new System.EventHandler(this.buttonSLMarcha_Click);
            // 
            // buttonSLParo
            // 
            this.buttonSLParo.Location = new System.Drawing.Point(107, 43);
            this.buttonSLParo.Name = "buttonSLParo";
            this.buttonSLParo.Size = new System.Drawing.Size(75, 23);
            this.buttonSLParo.TabIndex = 2;
            this.buttonSLParo.Text = "Paro";
            this.buttonSLParo.UseVisualStyleBackColor = true;
            this.buttonSLParo.Click += new System.EventHandler(this.buttonSLParo_Click);
            // 
            // textBoxSLValor
            // 
            this.textBoxSLValor.Location = new System.Drawing.Point(102, 17);
            this.textBoxSLValor.Name = "textBoxSLValor";
            this.textBoxSLValor.Size = new System.Drawing.Size(80, 20);
            this.textBoxSLValor.TabIndex = 1;
            this.textBoxSLValor.Text = "0,0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Aceite Lubricante";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(321, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 136);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sistema de Drenaje de Vapor";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxSDVFlujo);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.buttonSDVOn);
            this.groupBox6.Controls.Add(this.buttonSDVOff);
            this.groupBox6.Controls.Add(this.textBoxSDVEstado);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(229, 111);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Válvula de Drenaje Principal";
            // 
            // textBoxSDVFlujo
            // 
            this.textBoxSDVFlujo.Enabled = false;
            this.textBoxSDVFlujo.Location = new System.Drawing.Point(87, 74);
            this.textBoxSDVFlujo.Name = "textBoxSDVFlujo";
            this.textBoxSDVFlujo.Size = new System.Drawing.Size(89, 20);
            this.textBoxSDVFlujo.TabIndex = 9;
            this.textBoxSDVFlujo.Text = "0,0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Flujo de Vapor";
            // 
            // buttonSDVOn
            // 
            this.buttonSDVOn.Location = new System.Drawing.Point(6, 19);
            this.buttonSDVOn.Name = "buttonSDVOn";
            this.buttonSDVOn.Size = new System.Drawing.Size(75, 23);
            this.buttonSDVOn.TabIndex = 7;
            this.buttonSDVOn.Text = "Apertura";
            this.buttonSDVOn.UseVisualStyleBackColor = true;
            this.buttonSDVOn.Click += new System.EventHandler(this.buttonSDVOn_Click);
            // 
            // buttonSDVOff
            // 
            this.buttonSDVOff.Location = new System.Drawing.Point(101, 19);
            this.buttonSDVOff.Name = "buttonSDVOff";
            this.buttonSDVOff.Size = new System.Drawing.Size(75, 23);
            this.buttonSDVOff.TabIndex = 6;
            this.buttonSDVOff.Text = "Cierre";
            this.buttonSDVOff.UseVisualStyleBackColor = true;
            this.buttonSDVOff.Click += new System.EventHandler(this.buttonSDVOff_Click);
            // 
            // textBoxSDVEstado
            // 
            this.textBoxSDVEstado.Location = new System.Drawing.Point(113, 48);
            this.textBoxSDVEstado.Name = "textBoxSDVEstado";
            this.textBoxSDVEstado.Size = new System.Drawing.Size(63, 20);
            this.textBoxSDVEstado.TabIndex = 5;
            this.textBoxSDVEstado.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Posición válvula (%)";
            // 
            // timerSDV
            // 
            this.timerSDV.Interval = 700;
            this.timerSDV.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerSH
            // 
            this.timerSH.Interval = 175;
            this.timerSH.Tick += new System.EventHandler(this.timerSH_Tick);
            // 
            // timerSHDecrement
            // 
            this.timerSHDecrement.Interval = 175;
            this.timerSHDecrement.Tick += new System.EventHandler(this.timerSHDecrement_Tick);
            // 
            // timerSDVDecrement
            // 
            this.timerSDVDecrement.Interval = 700;
            this.timerSDVDecrement.Tick += new System.EventHandler(this.timerSDVDecrement_Tick);
            // 
            // timerSL
            // 
            this.timerSL.Interval = 200;
            this.timerSL.Tick += new System.EventHandler(this.timerSL_Tick);
            // 
            // timerSLDecrement
            // 
            this.timerSLDecrement.Interval = 200;
            this.timerSLDecrement.Tick += new System.EventHandler(this.timerSLDecrement_Tick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Location = new System.Drawing.Point(12, 347);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(396, 136);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sistema de Admisión de Vapor";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.buttonSAVStepSize10);
            this.groupBox8.Controls.Add(this.buttonSAVStepSize5);
            this.groupBox8.Controls.Add(this.buttonSAVStepSize1);
            this.groupBox8.Controls.Add(this.buttonSAVStepDown);
            this.groupBox8.Controls.Add(this.buttonSAVStepUp);
            this.groupBox8.Controls.Add(this.textBox1);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.buttonSAVOn);
            this.groupBox8.Controls.Add(this.buttonSAVOff);
            this.groupBox8.Controls.Add(this.textBoxSAVEstado);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Location = new System.Drawing.Point(6, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(384, 111);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Válvula de Admisión Principal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tamaño del paso (step)";
            // 
            // buttonSAVStepSize10
            // 
            this.buttonSAVStepSize10.Location = new System.Drawing.Point(338, 67);
            this.buttonSAVStepSize10.Name = "buttonSAVStepSize10";
            this.buttonSAVStepSize10.Size = new System.Drawing.Size(27, 23);
            this.buttonSAVStepSize10.TabIndex = 14;
            this.buttonSAVStepSize10.Text = "10";
            this.buttonSAVStepSize10.UseVisualStyleBackColor = true;
            this.buttonSAVStepSize10.Click += new System.EventHandler(this.buttonSAVStepSize10_Click);
            // 
            // buttonSAVStepSize5
            // 
            this.buttonSAVStepSize5.Location = new System.Drawing.Point(305, 67);
            this.buttonSAVStepSize5.Name = "buttonSAVStepSize5";
            this.buttonSAVStepSize5.Size = new System.Drawing.Size(27, 23);
            this.buttonSAVStepSize5.TabIndex = 13;
            this.buttonSAVStepSize5.Text = "5";
            this.buttonSAVStepSize5.UseVisualStyleBackColor = true;
            this.buttonSAVStepSize5.Click += new System.EventHandler(this.buttonSAVStepSize5_Click);
            // 
            // buttonSAVStepSize1
            // 
            this.buttonSAVStepSize1.Location = new System.Drawing.Point(272, 67);
            this.buttonSAVStepSize1.Name = "buttonSAVStepSize1";
            this.buttonSAVStepSize1.Size = new System.Drawing.Size(27, 23);
            this.buttonSAVStepSize1.TabIndex = 12;
            this.buttonSAVStepSize1.Text = "1";
            this.buttonSAVStepSize1.UseVisualStyleBackColor = true;
            this.buttonSAVStepSize1.Click += new System.EventHandler(this.buttonSAVStepSize1_Click);
            // 
            // buttonSAVStepDown
            // 
            this.buttonSAVStepDown.Location = new System.Drawing.Point(182, 74);
            this.buttonSAVStepDown.Name = "buttonSAVStepDown";
            this.buttonSAVStepDown.Size = new System.Drawing.Size(75, 23);
            this.buttonSAVStepDown.TabIndex = 11;
            this.buttonSAVStepDown.Text = "Step -";
            this.buttonSAVStepDown.UseVisualStyleBackColor = true;
            this.buttonSAVStepDown.Click += new System.EventHandler(this.buttonSAVStepDown_Click);
            // 
            // buttonSAVStepUp
            // 
            this.buttonSAVStepUp.Location = new System.Drawing.Point(182, 46);
            this.buttonSAVStepUp.Name = "buttonSAVStepUp";
            this.buttonSAVStepUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSAVStepUp.TabIndex = 10;
            this.buttonSAVStepUp.Text = "Step +";
            this.buttonSAVStepUp.UseVisualStyleBackColor = true;
            this.buttonSAVStepUp.Click += new System.EventHandler(this.buttonSAVStepUp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(87, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0,0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Flujo de Vapor";
            // 
            // buttonSAVOn
            // 
            this.buttonSAVOn.Location = new System.Drawing.Point(6, 19);
            this.buttonSAVOn.Name = "buttonSAVOn";
            this.buttonSAVOn.Size = new System.Drawing.Size(101, 23);
            this.buttonSAVOn.TabIndex = 7;
            this.buttonSAVOn.Text = "Apertura Total";
            this.buttonSAVOn.UseVisualStyleBackColor = true;
            this.buttonSAVOn.Click += new System.EventHandler(this.buttonSAVOn_Click);
            // 
            // buttonSAVOff
            // 
            this.buttonSAVOff.Location = new System.Drawing.Point(113, 19);
            this.buttonSAVOff.Name = "buttonSAVOff";
            this.buttonSAVOff.Size = new System.Drawing.Size(95, 23);
            this.buttonSAVOff.TabIndex = 6;
            this.buttonSAVOff.Text = "Cierre Total";
            this.buttonSAVOff.UseVisualStyleBackColor = true;
            this.buttonSAVOff.Click += new System.EventHandler(this.buttonSAVOff_Click);
            // 
            // textBoxSAVEstado
            // 
            this.textBoxSAVEstado.Location = new System.Drawing.Point(113, 48);
            this.textBoxSAVEstado.Name = "textBoxSAVEstado";
            this.textBoxSAVEstado.Size = new System.Drawing.Size(63, 20);
            this.textBoxSAVEstado.TabIndex = 5;
            this.textBoxSAVEstado.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Posición válvula (%)";
            // 
            // timerSAV
            // 
            this.timerSAV.Interval = 700;
            this.timerSAV.Tick += new System.EventHandler(this.timerSAV_Tick);
            // 
            // timerSAVDecrement
            // 
            this.timerSAVDecrement.Interval = 700;
            this.timerSAVDecrement.Tick += new System.EventHandler(this.timerSAVDecrement_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 491);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simulador Turbina";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSHSetpoint;
        private System.Windows.Forms.Button buttonSHMarcha;
        private System.Windows.Forms.Button buttonSHParo;
        private System.Windows.Forms.TextBox textBoxSHValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSLSetpoint;
        private System.Windows.Forms.Button buttonSLMarcha;
        private System.Windows.Forms.Button buttonSLParo;
        private System.Windows.Forms.TextBox textBoxSLValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxSDVFlujo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSDVOn;
        private System.Windows.Forms.Button buttonSDVOff;
        private System.Windows.Forms.TextBox textBoxSDVEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSHAplicarSetpoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSLAplicarSetpoint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timerSDV;
        private System.Windows.Forms.Timer timerSH;
        private System.Windows.Forms.Timer timerSHDecrement;
        private System.Windows.Forms.Timer timerSDVDecrement;
        private System.Windows.Forms.Timer timerSL;
        private System.Windows.Forms.Timer timerSLDecrement;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSAVOn;
        private System.Windows.Forms.Button buttonSAVOff;
        private System.Windows.Forms.TextBox textBoxSAVEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timerSAV;
        private System.Windows.Forms.Timer timerSAVDecrement;
        private System.Windows.Forms.Button buttonSAVStepDown;
        private System.Windows.Forms.Button buttonSAVStepUp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSAVStepSize10;
        private System.Windows.Forms.Button buttonSAVStepSize5;
        private System.Windows.Forms.Button buttonSAVStepSize1;
    }
}


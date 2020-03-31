namespace Sistema_FinanMotors
{
    partial class FormProforma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_p_final = new System.Windows.Forms.Label();
            this.cb_placa = new System.Windows.Forms.CheckBox();
            this.dtg_promo = new System.Windows.Forms.DataGridView();
            this.cb_tarjeta = new System.Windows.Forms.CheckBox();
            this.txt_n_cuotas = new System.Windows.Forms.TextBox();
            this.n_cuotas = new System.Windows.Forms.Label();
            this.txt_cuotas = new System.Windows.Forms.TextBox();
            this.cuotas = new System.Windows.Forms.Label();
            this.inicial = new System.Windows.Forms.Label();
            this.txt_c_inicial = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.Label();
            this.btn_generar_op = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_c_pago_op = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_fecha_op = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_color_op_1 = new System.Windows.Forms.ComboBox();
            this.cb_modelo_op_1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_vendedor_op = new System.Windows.Forms.ComboBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_direccion_op = new System.Windows.Forms.TextBox();
            this.txt_nomb_op = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ruc_dni_op = new System.Windows.Forms.TextBox();
            this.txt_proforma = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_add_op = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_promo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_p_final
            // 
            this.lb_p_final.AutoSize = true;
            this.lb_p_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_p_final.ForeColor = System.Drawing.Color.White;
            this.lb_p_final.Location = new System.Drawing.Point(524, 450);
            this.lb_p_final.Name = "lb_p_final";
            this.lb_p_final.Size = new System.Drawing.Size(60, 25);
            this.lb_p_final.TabIndex = 256;
            this.lb_p_final.Text = "0000";
            // 
            // cb_placa
            // 
            this.cb_placa.AutoSize = true;
            this.cb_placa.ForeColor = System.Drawing.Color.White;
            this.cb_placa.Location = new System.Drawing.Point(374, 400);
            this.cb_placa.Name = "cb_placa";
            this.cb_placa.Size = new System.Drawing.Size(60, 17);
            this.cb_placa.TabIndex = 255;
            this.cb_placa.Text = "PLACA";
            this.cb_placa.UseVisualStyleBackColor = true;
            this.cb_placa.CheckedChanged += new System.EventHandler(this.cb_placa_CheckedChanged);
            // 
            // dtg_promo
            // 
            this.dtg_promo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_promo.Location = new System.Drawing.Point(442, 265);
            this.dtg_promo.Name = "dtg_promo";
            this.dtg_promo.Size = new System.Drawing.Size(190, 91);
            this.dtg_promo.TabIndex = 254;
            // 
            // cb_tarjeta
            // 
            this.cb_tarjeta.AutoSize = true;
            this.cb_tarjeta.ForeColor = System.Drawing.Color.White;
            this.cb_tarjeta.Location = new System.Drawing.Point(453, 400);
            this.cb_tarjeta.Name = "cb_tarjeta";
            this.cb_tarjeta.Size = new System.Drawing.Size(158, 17);
            this.cb_tarjeta.TabIndex = 253;
            this.cb_tarjeta.Text = "TARJETA DE PROPIEDAD";
            this.cb_tarjeta.UseVisualStyleBackColor = true;
            this.cb_tarjeta.CheckedChanged += new System.EventHandler(this.cb_tarjeta_CheckedChanged);
            // 
            // txt_n_cuotas
            // 
            this.txt_n_cuotas.Location = new System.Drawing.Point(226, 488);
            this.txt_n_cuotas.Name = "txt_n_cuotas";
            this.txt_n_cuotas.Size = new System.Drawing.Size(36, 20);
            this.txt_n_cuotas.TabIndex = 252;
            this.txt_n_cuotas.Tag = "";
            this.txt_n_cuotas.Visible = false;
            // 
            // n_cuotas
            // 
            this.n_cuotas.AutoSize = true;
            this.n_cuotas.ForeColor = System.Drawing.Color.White;
            this.n_cuotas.Location = new System.Drawing.Point(42, 495);
            this.n_cuotas.Name = "n_cuotas";
            this.n_cuotas.Size = new System.Drawing.Size(123, 13);
            this.n_cuotas.TabIndex = 251;
            this.n_cuotas.Text = "NUMERO DE CUOTAS:";
            this.n_cuotas.Visible = false;
            // 
            // txt_cuotas
            // 
            this.txt_cuotas.Location = new System.Drawing.Point(171, 452);
            this.txt_cuotas.Name = "txt_cuotas";
            this.txt_cuotas.Size = new System.Drawing.Size(91, 20);
            this.txt_cuotas.TabIndex = 250;
            this.txt_cuotas.Tag = "";
            this.txt_cuotas.Visible = false;
            // 
            // cuotas
            // 
            this.cuotas.AutoSize = true;
            this.cuotas.ForeColor = System.Drawing.Color.White;
            this.cuotas.Location = new System.Drawing.Point(42, 459);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(54, 13);
            this.cuotas.TabIndex = 249;
            this.cuotas.Text = "CUOTAS:";
            this.cuotas.Visible = false;
            // 
            // inicial
            // 
            this.inicial.AutoSize = true;
            this.inicial.ForeColor = System.Drawing.Color.White;
            this.inicial.Location = new System.Drawing.Point(42, 421);
            this.inicial.Name = "inicial";
            this.inicial.Size = new System.Drawing.Size(47, 13);
            this.inicial.TabIndex = 248;
            this.inicial.Text = "INICIAL:";
            this.inicial.Visible = false;
            // 
            // txt_c_inicial
            // 
            this.txt_c_inicial.Location = new System.Drawing.Point(171, 414);
            this.txt_c_inicial.Name = "txt_c_inicial";
            this.txt_c_inicial.Size = new System.Drawing.Size(91, 20);
            this.txt_c_inicial.TabIndex = 247;
            this.txt_c_inicial.Tag = "";
            this.txt_c_inicial.Visible = false;
            // 
            // txt_tc
            // 
            this.txt_tc.AutoSize = true;
            this.txt_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tc.ForeColor = System.Drawing.Color.White;
            this.txt_tc.Location = new System.Drawing.Point(470, 42);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(55, 25);
            this.txt_tc.TabIndex = 246;
            this.txt_tc.Text = "T.C:";
            // 
            // btn_generar_op
            // 
            this.btn_generar_op.BackColor = System.Drawing.Color.Blue;
            this.btn_generar_op.ForeColor = System.Drawing.Color.White;
            this.btn_generar_op.Location = new System.Drawing.Point(420, 513);
            this.btn_generar_op.Name = "btn_generar_op";
            this.btn_generar_op.Size = new System.Drawing.Size(98, 39);
            this.btn_generar_op.TabIndex = 245;
            this.btn_generar_op.Text = "GENERAR";
            this.btn_generar_op.UseVisualStyleBackColor = false;
            this.btn_generar_op.Click += new System.EventHandler(this.btn_generar_op_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(340, 450);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 25);
            this.label14.TabIndex = 244;
            this.label14.Text = "PRECIO FINAL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 243;
            this.label7.Text = "CONDICION  DE PAGO";
            // 
            // cb_c_pago_op
            // 
            this.cb_c_pago_op.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_c_pago_op.FormattingEnabled = true;
            this.cb_c_pago_op.Items.AddRange(new object[] {
            "CREDITO",
            "CONTADO"});
            this.cb_c_pago_op.Location = new System.Drawing.Point(176, 375);
            this.cb_c_pago_op.Name = "cb_c_pago_op";
            this.cb_c_pago_op.Size = new System.Drawing.Size(80, 21);
            this.cb_c_pago_op.TabIndex = 242;
            this.cb_c_pago_op.SelectedIndexChanged += new System.EventHandler(this.cb_c_pago_op_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(417, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 241;
            this.label9.Text = "FECHA:";
            // 
            // dt_fecha_op
            // 
            this.dt_fecha_op.Location = new System.Drawing.Point(468, 87);
            this.dt_fecha_op.Name = "dt_fecha_op";
            this.dt_fecha_op.Size = new System.Drawing.Size(142, 20);
            this.dt_fecha_op.TabIndex = 240;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(265, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 238;
            this.label16.Text = "COLOR";
            // 
            // cb_color_op_1
            // 
            this.cb_color_op_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_color_op_1.FormattingEnabled = true;
            this.cb_color_op_1.Location = new System.Drawing.Point(315, 303);
            this.cb_color_op_1.Name = "cb_color_op_1";
            this.cb_color_op_1.Size = new System.Drawing.Size(90, 21);
            this.cb_color_op_1.TabIndex = 237;
            // 
            // cb_modelo_op_1
            // 
            this.cb_modelo_op_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modelo_op_1.FormattingEnabled = true;
            this.cb_modelo_op_1.Location = new System.Drawing.Point(121, 303);
            this.cb_modelo_op_1.Name = "cb_modelo_op_1";
            this.cb_modelo_op_1.Size = new System.Drawing.Size(122, 21);
            this.cb_modelo_op_1.TabIndex = 236;
            this.cb_modelo_op_1.SelectedIndexChanged += new System.EventHandler(this.cb_modelo_op_1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 235;
            this.label10.Text = "MODELO MOTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 234;
            this.label6.Text = "VENDEDOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(517, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 233;
            this.label4.Text = "TELEFONO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(242, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 232;
            this.label2.Text = "NOMBRER/RAZON SOCIAL";
            // 
            // cb_vendedor_op
            // 
            this.cb_vendedor_op.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_vendedor_op.FormattingEnabled = true;
            this.cb_vendedor_op.Location = new System.Drawing.Point(114, 87);
            this.cb_vendedor_op.Name = "cb_vendedor_op";
            this.cb_vendedor_op.Size = new System.Drawing.Size(165, 21);
            this.cb_vendedor_op.TabIndex = 231;
            this.cb_vendedor_op.SelectedIndexChanged += new System.EventHandler(this.cb_vendedor_op_SelectedIndexChanged);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(496, 150);
            this.txt_telefono.MaxLength = 9;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(105, 20);
            this.txt_telefono.TabIndex = 230;
            this.txt_telefono.Tag = "";
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            // 
            // txt_direccion_op
            // 
            this.txt_direccion_op.Location = new System.Drawing.Point(40, 200);
            this.txt_direccion_op.Name = "txt_direccion_op";
            this.txt_direccion_op.Size = new System.Drawing.Size(372, 20);
            this.txt_direccion_op.TabIndex = 229;
            this.txt_direccion_op.Tag = "";
            this.txt_direccion_op.TextChanged += new System.EventHandler(this.txt_direccion_op_TextChanged);
            // 
            // txt_nomb_op
            // 
            this.txt_nomb_op.Enabled = false;
            this.txt_nomb_op.Location = new System.Drawing.Point(162, 150);
            this.txt_nomb_op.Name = "txt_nomb_op";
            this.txt_nomb_op.Size = new System.Drawing.Size(322, 20);
            this.txt_nomb_op.TabIndex = 228;
            this.txt_nomb_op.Tag = "";
            this.txt_nomb_op.TextChanged += new System.EventHandler(this.txt_nomb_op_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 227;
            this.label1.Text = "DNI/RUC";
            // 
            // txt_ruc_dni_op
            // 
            this.txt_ruc_dni_op.Location = new System.Drawing.Point(40, 150);
            this.txt_ruc_dni_op.MaxLength = 11;
            this.txt_ruc_dni_op.Name = "txt_ruc_dni_op";
            this.txt_ruc_dni_op.Size = new System.Drawing.Size(105, 20);
            this.txt_ruc_dni_op.TabIndex = 226;
            this.txt_ruc_dni_op.Tag = "";
            this.txt_ruc_dni_op.TextChanged += new System.EventHandler(this.txt_ruc_dni_op_TextChanged);
            // 
            // txt_proforma
            // 
            this.txt_proforma.AutoSize = true;
            this.txt_proforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proforma.ForeColor = System.Drawing.Color.White;
            this.txt_proforma.Location = new System.Drawing.Point(221, 42);
            this.txt_proforma.Name = "txt_proforma";
            this.txt_proforma.Size = new System.Drawing.Size(91, 25);
            this.txt_proforma.TabIndex = 225;
            this.txt_proforma.Text = "Proforma";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_add_op);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(27, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 123);
            this.groupBox1.TabIndex = 239;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(6, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 153;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_add_op
            // 
            this.btn_add_op.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_op.BackColor = System.Drawing.Color.Lime;
            this.btn_add_op.ForeColor = System.Drawing.Color.Blue;
            this.btn_add_op.Location = new System.Drawing.Point(414, 70);
            this.btn_add_op.Name = "btn_add_op";
            this.btn_add_op.Size = new System.Drawing.Size(43, 38);
            this.btn_add_op.TabIndex = 180;
            this.btn_add_op.Text = "+";
            this.btn_add_op.UseVisualStyleBackColor = false;
            this.btn_add_op.Visible = false;
            this.btn_add_op.Click += new System.EventHandler(this.btn_add_op_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(176, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 194;
            this.label3.Text = "DIRECCION";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(607, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 257;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(687, 571);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lb_p_final);
            this.Controls.Add(this.cb_placa);
            this.Controls.Add(this.dtg_promo);
            this.Controls.Add(this.cb_tarjeta);
            this.Controls.Add(this.txt_n_cuotas);
            this.Controls.Add(this.n_cuotas);
            this.Controls.Add(this.txt_cuotas);
            this.Controls.Add(this.cuotas);
            this.Controls.Add(this.inicial);
            this.Controls.Add(this.txt_c_inicial);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.btn_generar_op);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_c_pago_op);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dt_fecha_op);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cb_color_op_1);
            this.Controls.Add(this.cb_modelo_op_1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_vendedor_op);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_direccion_op);
            this.Controls.Add(this.txt_nomb_op);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ruc_dni_op);
            this.Controls.Add(this.txt_proforma);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(687, 571);
            this.Name = "FormProforma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProforma";
            this.Load += new System.EventHandler(this.FormProforma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_promo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_p_final;
        private System.Windows.Forms.CheckBox cb_placa;
        private System.Windows.Forms.DataGridView dtg_promo;
        private System.Windows.Forms.CheckBox cb_tarjeta;
        private System.Windows.Forms.TextBox txt_n_cuotas;
        private System.Windows.Forms.Label n_cuotas;
        private System.Windows.Forms.TextBox txt_cuotas;
        private System.Windows.Forms.Label cuotas;
        private System.Windows.Forms.Label inicial;
        private System.Windows.Forms.TextBox txt_c_inicial;
        private System.Windows.Forms.Label txt_tc;
        private System.Windows.Forms.Button btn_generar_op;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_c_pago_op;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt_fecha_op;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_color_op_1;
        private System.Windows.Forms.ComboBox cb_modelo_op_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_vendedor_op;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_direccion_op;
        private System.Windows.Forms.TextBox txt_nomb_op;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ruc_dni_op;
        private System.Windows.Forms.Label txt_proforma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_add_op;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
    }
}
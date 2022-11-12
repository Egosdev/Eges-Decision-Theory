namespace EgesDecisionTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgw_uncertainty = new System.Windows.Forms.DataGridView();
            this.alternatives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.cbx_pessimistic = new System.Windows.Forms.CheckBox();
            this.cbx_optimistic = new System.Windows.Forms.CheckBox();
            this.cbx_realism = new System.Windows.Forms.CheckBox();
            this.cbx_savage = new System.Windows.Forms.CheckBox();
            this.cbx_equallikelihood = new System.Windows.Forms.CheckBox();
            this.tbx_alpha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_alternative = new System.Windows.Forms.Button();
            this.btn_add_natural_state = new System.Windows.Forms.Button();
            this.tbx_add_natural_state = new System.Windows.Forms.TextBox();
            this.tbx_add_alternative = new System.Windows.Forms.TextBox();
            this.btn_meatball_device = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_uncertainty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_uncertainty
            // 
            this.dgw_uncertainty.AllowUserToAddRows = false;
            this.dgw_uncertainty.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_uncertainty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgw_uncertainty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_uncertainty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alternatives});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_uncertainty.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgw_uncertainty.GridColor = System.Drawing.Color.Gainsboro;
            this.dgw_uncertainty.Location = new System.Drawing.Point(12, 201);
            this.dgw_uncertainty.Name = "dgw_uncertainty";
            this.dgw_uncertainty.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgw_uncertainty.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgw_uncertainty.RowTemplate.Height = 40;
            this.dgw_uncertainty.Size = new System.Drawing.Size(736, 264);
            this.dgw_uncertainty.TabIndex = 0;
            this.dgw_uncertainty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // alternatives
            // 
            this.alternatives.HeaderText = "Stratejiler";
            this.alternatives.MinimumWidth = 6;
            this.alternatives.Name = "alternatives";
            this.alternatives.Width = 125;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(654, 471);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(94, 29);
            this.btn_calculate.TabIndex = 1;
            this.btn_calculate.Text = "Hesapla";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_pessimistic
            // 
            this.cbx_pessimistic.AutoSize = true;
            this.cbx_pessimistic.Location = new System.Drawing.Point(21, 28);
            this.cbx_pessimistic.Name = "cbx_pessimistic";
            this.cbx_pessimistic.Size = new System.Drawing.Size(174, 24);
            this.cbx_pessimistic.TabIndex = 2;
            this.cbx_pessimistic.Text = "Kötümserlik Yaklaşımı";
            this.cbx_pessimistic.UseVisualStyleBackColor = true;
            this.cbx_pessimistic.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbx_optimistic
            // 
            this.cbx_optimistic.AutoSize = true;
            this.cbx_optimistic.Location = new System.Drawing.Point(21, 58);
            this.cbx_optimistic.Name = "cbx_optimistic";
            this.cbx_optimistic.Size = new System.Drawing.Size(158, 24);
            this.cbx_optimistic.TabIndex = 2;
            this.cbx_optimistic.Text = "İyimserlik Yaklaşımı";
            this.cbx_optimistic.UseVisualStyleBackColor = true;
            this.cbx_optimistic.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbx_realism
            // 
            this.cbx_realism.AutoSize = true;
            this.cbx_realism.Location = new System.Drawing.Point(21, 88);
            this.cbx_realism.Name = "cbx_realism";
            this.cbx_realism.Size = new System.Drawing.Size(263, 24);
            this.cbx_realism.TabIndex = 2;
            this.cbx_realism.Text = "Genelleştirilmiş İyimserlik Yaklaşımı";
            this.cbx_realism.UseVisualStyleBackColor = true;
            this.cbx_realism.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbx_savage
            // 
            this.cbx_savage.AutoSize = true;
            this.cbx_savage.Location = new System.Drawing.Point(21, 118);
            this.cbx_savage.Name = "cbx_savage";
            this.cbx_savage.Size = new System.Drawing.Size(158, 24);
            this.cbx_savage.TabIndex = 2;
            this.cbx_savage.Text = "Pişmanlık Yaklaşımı";
            this.cbx_savage.UseVisualStyleBackColor = true;
            this.cbx_savage.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbx_equallikelihood
            // 
            this.cbx_equallikelihood.AutoSize = true;
            this.cbx_equallikelihood.Location = new System.Drawing.Point(21, 148);
            this.cbx_equallikelihood.Name = "cbx_equallikelihood";
            this.cbx_equallikelihood.Size = new System.Drawing.Size(175, 24);
            this.cbx_equallikelihood.TabIndex = 2;
            this.cbx_equallikelihood.Text = "Eşit Olasılıklı Yaklaşım";
            this.cbx_equallikelihood.UseVisualStyleBackColor = true;
            this.cbx_equallikelihood.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbx_alpha
            // 
            this.tbx_alpha.AcceptsTab = true;
            this.tbx_alpha.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbx_alpha.Location = new System.Drawing.Point(290, 86);
            this.tbx_alpha.Name = "tbx_alpha";
            this.tbx_alpha.PlaceholderText = "alfa";
            this.tbx_alpha.Size = new System.Drawing.Size(56, 27);
            this.tbx_alpha.TabIndex = 3;
            this.tbx_alpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_alpha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbx_alpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_alpha_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_optimistic);
            this.groupBox1.Controls.Add(this.tbx_alpha);
            this.groupBox1.Controls.Add(this.cbx_pessimistic);
            this.groupBox1.Controls.Add(this.cbx_equallikelihood);
            this.groupBox1.Controls.Add(this.cbx_realism);
            this.groupBox1.Controls.Add(this.cbx_savage);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Belirsizlik Altında";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tabloyu Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(290, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "0 < α < 100";
            // 
            // btn_add_alternative
            // 
            this.btn_add_alternative.Location = new System.Drawing.Point(12, 506);
            this.btn_add_alternative.Name = "btn_add_alternative";
            this.btn_add_alternative.Size = new System.Drawing.Size(152, 29);
            this.btn_add_alternative.TabIndex = 5;
            this.btn_add_alternative.Text = "Yeni Strateji Ekle";
            this.btn_add_alternative.UseVisualStyleBackColor = true;
            this.btn_add_alternative.Click += new System.EventHandler(this.btn_add_alternative_Click);
            // 
            // btn_add_natural_state
            // 
            this.btn_add_natural_state.Location = new System.Drawing.Point(12, 471);
            this.btn_add_natural_state.Name = "btn_add_natural_state";
            this.btn_add_natural_state.Size = new System.Drawing.Size(152, 29);
            this.btn_add_natural_state.TabIndex = 6;
            this.btn_add_natural_state.Text = "Yeni Durum Ekle";
            this.btn_add_natural_state.UseVisualStyleBackColor = true;
            this.btn_add_natural_state.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbx_add_natural_state
            // 
            this.tbx_add_natural_state.Location = new System.Drawing.Point(187, 471);
            this.tbx_add_natural_state.Name = "tbx_add_natural_state";
            this.tbx_add_natural_state.PlaceholderText = "Doğal Durum Giriniz (S)";
            this.tbx_add_natural_state.Size = new System.Drawing.Size(171, 27);
            this.tbx_add_natural_state.TabIndex = 7;
            // 
            // tbx_add_alternative
            // 
            this.tbx_add_alternative.Location = new System.Drawing.Point(187, 507);
            this.tbx_add_alternative.Name = "tbx_add_alternative";
            this.tbx_add_alternative.PlaceholderText = "Strateji Giriniz (a)";
            this.tbx_add_alternative.Size = new System.Drawing.Size(171, 27);
            this.tbx_add_alternative.TabIndex = 8;
            // 
            // btn_meatball_device
            // 
            this.btn_meatball_device.Location = new System.Drawing.Point(562, 507);
            this.btn_meatball_device.Name = "btn_meatball_device";
            this.btn_meatball_device.Size = new System.Drawing.Size(186, 29);
            this.btn_meatball_device.TabIndex = 9;
            this.btn_meatball_device.Text = "Köfte Kızartma Butonu";
            this.btn_meatball_device.UseVisualStyleBackColor = true;
            this.btn_meatball_device.Click += new System.EventHandler(this.btn_meatball_device_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 545);
            this.Controls.Add(this.btn_meatball_device);
            this.Controls.Add(this.tbx_add_alternative);
            this.Controls.Add(this.tbx_add_natural_state);
            this.Controls.Add(this.btn_add_natural_state);
            this.Controls.Add(this.btn_add_alternative);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.dgw_uncertainty);
            this.Name = "Form1";
            this.Text = "Ege\'nin Karar Kuramı Sihirbazı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_uncertainty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgw_uncertainty;
        private DataGridViewTextBoxColumn alternatives;
        private Button btn_calculate;
        private CheckBox cbx_pessimistic;
        private CheckBox cbx_optimistic;
        private CheckBox cbx_realism;
        private CheckBox cbx_savage;
        private CheckBox cbx_equallikelihood;
        private TextBox tbx_alpha;
        private GroupBox groupBox1;
        private Button btn_add_alternative;
        private Button btn_add_natural_state;
        private TextBox tbx_add_natural_state;
        private Label label1;
        private Button button1;
        private TextBox tbx_add_alternative;
        private Button btn_meatball_device;
    }
}
namespace kisiler
{
    partial class KAYIT
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LİSTELEME = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguncel = new System.Windows.Forms.Button();
            this.IDTXTBOX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SİLBTN = new System.Windows.Forms.Button();
            this.KAYDETBUTON = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.GOREVCOMBOX = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.İLCECOMBOX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.İLCOMBOX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SOYADITEXBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ADITEXBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kisilerDataSet = new kisiler.kisilerDataSet();
            this.iLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.İLTableAdapter = new kisiler.kisilerDataSetTableAdapters.İLTableAdapter();
            this.fKİLCEİLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.İLCETableAdapter = new kisiler.kisilerDataSetTableAdapters.İLCETableAdapter();
            this.gOREVLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gOREVLERTableAdapter = new kisiler.kisilerDataSetTableAdapters.GOREVLERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKİLCEİLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOREVLERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // LİSTELEME
            // 
            this.LİSTELEME.BackColor = System.Drawing.SystemColors.Control;
            this.LİSTELEME.Location = new System.Drawing.Point(13, 290);
            this.LİSTELEME.Name = "LİSTELEME";
            this.LİSTELEME.Size = new System.Drawing.Size(84, 31);
            this.LİSTELEME.TabIndex = 1;
            this.LİSTELEME.Text = "LİSTELE";
            this.LİSTELEME.UseVisualStyleBackColor = false;
            this.LİSTELEME.Click += new System.EventHandler(this.LİSTELEME_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnguncel);
            this.groupBox1.Controls.Add(this.IDTXTBOX);
            this.groupBox1.Controls.Add(this.LİSTELEME);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SİLBTN);
            this.groupBox1.Controls.Add(this.KAYDETBUTON);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.GOREVCOMBOX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.İLCECOMBOX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.İLCOMBOX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SOYADITEXBOX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ADITEXBOX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(665, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 334);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnguncel
            // 
            this.btnguncel.Location = new System.Drawing.Point(104, 288);
            this.btnguncel.Name = "btnguncel";
            this.btnguncel.Size = new System.Drawing.Size(85, 33);
            this.btnguncel.TabIndex = 15;
            this.btnguncel.Text = "GÜNCELLE";
            this.btnguncel.UseVisualStyleBackColor = true;
            this.btnguncel.Click += new System.EventHandler(this.btnguncel_Click);
            // 
            // IDTXTBOX
            // 
            this.IDTXTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IDTXTBOX.Location = new System.Drawing.Point(82, 19);
            this.IDTXTBOX.Name = "IDTXTBOX";
            this.IDTXTBOX.Size = new System.Drawing.Size(108, 23);
            this.IDTXTBOX.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(28, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "ID :";
            // 
            // SİLBTN
            // 
            this.SİLBTN.Location = new System.Drawing.Point(105, 250);
            this.SİLBTN.Name = "SİLBTN";
            this.SİLBTN.Size = new System.Drawing.Size(85, 32);
            this.SİLBTN.TabIndex = 14;
            this.SİLBTN.Text = "SİL";
            this.SİLBTN.UseVisualStyleBackColor = true;
            this.SİLBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // KAYDETBUTON
            // 
            this.KAYDETBUTON.Location = new System.Drawing.Point(13, 250);
            this.KAYDETBUTON.Name = "KAYDETBUTON";
            this.KAYDETBUTON.Size = new System.Drawing.Size(85, 32);
            this.KAYDETBUTON.TabIndex = 13;
            this.KAYDETBUTON.Text = "KAYDET";
            this.KAYDETBUTON.UseVisualStyleBackColor = true;
            this.KAYDETBUTON.Click += new System.EventHandler(this.KAYDETBUTON_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "GÖREV :";
            // 
            // GOREVCOMBOX
            // 
            this.GOREVCOMBOX.DataSource = this.gOREVLERBindingSource;
            this.GOREVCOMBOX.DisplayMember = "GOREVADI";
            this.GOREVCOMBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GOREVCOMBOX.FormattingEnabled = true;
            this.GOREVCOMBOX.Location = new System.Drawing.Point(82, 211);
            this.GOREVCOMBOX.Name = "GOREVCOMBOX";
            this.GOREVCOMBOX.Size = new System.Drawing.Size(108, 24);
            this.GOREVCOMBOX.TabIndex = 9;
            this.GOREVCOMBOX.SelectedIndexChanged += new System.EventHandler(this.GOREVCOMBOX_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "İLÇE :";
            // 
            // İLCECOMBOX
            // 
            this.İLCECOMBOX.DataSource = this.fKİLCEİLBindingSource;
            this.İLCECOMBOX.DisplayMember = "İLCELER";
            this.İLCECOMBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İLCECOMBOX.FormattingEnabled = true;
            this.İLCECOMBOX.Location = new System.Drawing.Point(82, 171);
            this.İLCECOMBOX.Name = "İLCECOMBOX";
            this.İLCECOMBOX.Size = new System.Drawing.Size(108, 24);
            this.İLCECOMBOX.TabIndex = 7;
            this.İLCECOMBOX.SelectedIndexChanged += new System.EventHandler(this.İLCECOMBOX_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "İL :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // İLCOMBOX
            // 
            this.İLCOMBOX.DataSource = this.iLBindingSource;
            this.İLCOMBOX.DisplayMember = "İLLER";
            this.İLCOMBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İLCOMBOX.FormattingEnabled = true;
            this.İLCOMBOX.Location = new System.Drawing.Point(82, 133);
            this.İLCOMBOX.Name = "İLCOMBOX";
            this.İLCOMBOX.Size = new System.Drawing.Size(108, 24);
            this.İLCOMBOX.TabIndex = 5;
            this.İLCOMBOX.SelectedIndexChanged += new System.EventHandler(this.İLCOMBOX_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "SOYADI :";
            // 
            // SOYADITEXBOX
            // 
            this.SOYADITEXBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SOYADITEXBOX.Location = new System.Drawing.Point(82, 92);
            this.SOYADITEXBOX.Name = "SOYADITEXBOX";
            this.SOYADITEXBOX.Size = new System.Drawing.Size(108, 23);
            this.SOYADITEXBOX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ADITEXBOX
            // 
            this.ADITEXBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ADITEXBOX.Location = new System.Drawing.Point(82, 52);
            this.ADITEXBOX.Name = "ADITEXBOX";
            this.ADITEXBOX.Size = new System.Drawing.Size(108, 23);
            this.ADITEXBOX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI :";
            // 
            // kisilerDataSet
            // 
            this.kisilerDataSet.DataSetName = "kisilerDataSet";
            this.kisilerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iLBindingSource
            // 
            this.iLBindingSource.DataMember = "İL";
            this.iLBindingSource.DataSource = this.kisilerDataSet;
            // 
            // İLTableAdapter
            // 
            this.İLTableAdapter.ClearBeforeFill = true;
            // 
            // fKİLCEİLBindingSource
            // 
            this.fKİLCEİLBindingSource.DataMember = "FK_İLCE_İL";
            this.fKİLCEİLBindingSource.DataSource = this.iLBindingSource;
            // 
            // İLCETableAdapter
            // 
            this.İLCETableAdapter.ClearBeforeFill = true;
            // 
            // gOREVLERBindingSource
            // 
            this.gOREVLERBindingSource.DataMember = "GOREVLER";
            this.gOREVLERBindingSource.DataSource = this.kisilerDataSet;
            // 
            // gOREVLERTableAdapter
            // 
            this.gOREVLERTableAdapter.ClearBeforeFill = true;
            // 
            // KAYIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(867, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KAYIT";
            this.Text = "KAYIT";
            this.Load += new System.EventHandler(this.KAYIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKİLCEİLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOREVLERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LİSTELEME;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SOYADITEXBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ADITEXBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox İLCOMBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox GOREVCOMBOX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox İLCECOMBOX;
        private System.Windows.Forms.Button KAYDETBUTON;
        private System.Windows.Forms.Button SİLBTN;
        private System.Windows.Forms.TextBox IDTXTBOX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnguncel;
        private kisilerDataSet kisilerDataSet;
        private System.Windows.Forms.BindingSource iLBindingSource;
        private kisilerDataSetTableAdapters.İLTableAdapter İLTableAdapter;
        private System.Windows.Forms.BindingSource fKİLCEİLBindingSource;
        private kisilerDataSetTableAdapters.İLCETableAdapter İLCETableAdapter;
        private System.Windows.Forms.BindingSource gOREVLERBindingSource;
        private kisilerDataSetTableAdapters.GOREVLERTableAdapter gOREVLERTableAdapter;
    }
}


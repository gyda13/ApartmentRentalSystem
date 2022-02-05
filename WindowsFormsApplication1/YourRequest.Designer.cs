namespace WindowsFormsApplication1
{
    partial class YourRequest
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentRentalSystemDataSet6 = new WindowsFormsApplication1.ApartmentRentalSystemDataSet6();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.requestTableAdapter = new WindowsFormsApplication1.ApartmentRentalSystemDataSet6TableAdapters.RequestTableAdapter();
            this.userTableAdapter1 = new WindowsFormsApplication1.ApartmentRentalSystemDataSetTableAdapters.UserTableAdapter();
            this.userTableAdapter2 = new WindowsFormsApplication1.ApartmentRentalSystemDataSetTableAdapters.UserTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentRentalSystemDataSet1 = new WindowsFormsApplication1.ApartmentRentalSystemDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.apartmentRentalSystemDataSet7 = new WindowsFormsApplication1.ApartmentRentalSystemDataSet7();
            this.requestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.requestTableAdapter1 = new WindowsFormsApplication1.ApartmentRentalSystemDataSet7TableAdapters.RequestTableAdapter();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentRentalSystemDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentRentalSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentRentalSystemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(368, 381);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 24);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "reject";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(94, 381);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 24);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "accept";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataMember = "Request";
            this.requestBindingSource.DataSource = this.apartmentRentalSystemDataSet6;
            // 
            // apartmentRentalSystemDataSet6
            // 
            this.apartmentRentalSystemDataSet6.DataSetName = "ApartmentRentalSystemDataSet6";
            this.apartmentRentalSystemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 26);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "select your ID";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(400, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "view your Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // userTableAdapter2
            // 
            this.userTableAdapter2.ClearBeforeFill = true;
            // 
            // apartmentRentalSystemDataSet1
            // 
            this.apartmentRentalSystemDataSet1.DataSetName = "ApartmentRentalSystemDataSet";
            this.apartmentRentalSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.apartmentNoDataGridViewTextBoxColumn,
            this.requestStatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.requestBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(94, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(444, 196);
            this.dataGridView1.TabIndex = 23;
            // 
            // apartmentRentalSystemDataSet7
            // 
            this.apartmentRentalSystemDataSet7.DataSetName = "ApartmentRentalSystemDataSet7";
            this.apartmentRentalSystemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestBindingSource1
            // 
            this.requestBindingSource1.DataMember = "Request";
            this.requestBindingSource1.DataSource = this.apartmentRentalSystemDataSet7;
            // 
            // requestTableAdapter1
            // 
            this.requestTableAdapter1.ClearBeforeFill = true;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // apartmentNoDataGridViewTextBoxColumn
            // 
            this.apartmentNoDataGridViewTextBoxColumn.DataPropertyName = "ApartmentNo";
            this.apartmentNoDataGridViewTextBoxColumn.HeaderText = "ApartmentNo";
            this.apartmentNoDataGridViewTextBoxColumn.Name = "apartmentNoDataGridViewTextBoxColumn";
            // 
            // requestStatusDataGridViewCheckBoxColumn
            // 
            this.requestStatusDataGridViewCheckBoxColumn.DataPropertyName = "RequestStatus";
            this.requestStatusDataGridViewCheckBoxColumn.HeaderText = "RequestStatus";
            this.requestStatusDataGridViewCheckBoxColumn.Name = "requestStatusDataGridViewCheckBoxColumn";
            // 
            // YourRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "YourRequest";
            this.Text = "YourRequest";
            this.Load += new System.EventHandler(this.YourRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentRentalSystemDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentRentalSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentRentalSystemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private ApartmentRentalSystemDataSet6 apartmentRentalSystemDataSet6;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private ApartmentRentalSystemDataSet6TableAdapters.RequestTableAdapter requestTableAdapter;
        private ApartmentRentalSystemDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private ApartmentRentalSystemDataSetTableAdapters.UserTableAdapter userTableAdapter2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.BindingSource bindingSource5;
        private ApartmentRentalSystemDataSet apartmentRentalSystemDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ApartmentRentalSystemDataSet7 apartmentRentalSystemDataSet7;
        private System.Windows.Forms.BindingSource requestBindingSource1;
        private ApartmentRentalSystemDataSet7TableAdapters.RequestTableAdapter requestTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn requestStatusDataGridViewCheckBoxColumn;
    }
}
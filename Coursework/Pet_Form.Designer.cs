namespace Coursework
{
    partial class Pet_Form
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PetTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID_Pet = new System.Windows.Forms.TextBox();
            this.txtName_Pet = new System.Windows.Forms.TextBox();
            this.txtOwnerName_Pet = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSpecies = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 164);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PetTitle
            // 
            this.PetTitle.AutoSize = true;
            this.PetTitle.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetTitle.Location = new System.Drawing.Point(5, 9);
            this.PetTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PetTitle.Name = "PetTitle";
            this.PetTitle.Size = new System.Drawing.Size(244, 52);
            this.PetTitle.TabIndex = 1;
            this.PetTitle.Text = "Pet Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Species";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 429);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Owner name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID";
            // 
            // txtID_Pet
            // 
            this.txtID_Pet.Location = new System.Drawing.Point(166, 238);
            this.txtID_Pet.Name = "txtID_Pet";
            this.txtID_Pet.ReadOnly = true;
            this.txtID_Pet.Size = new System.Drawing.Size(208, 30);
            this.txtID_Pet.TabIndex = 3;
            // 
            // txtName_Pet
            // 
            this.txtName_Pet.Location = new System.Drawing.Point(166, 281);
            this.txtName_Pet.Name = "txtName_Pet";
            this.txtName_Pet.Size = new System.Drawing.Size(208, 30);
            this.txtName_Pet.TabIndex = 3;
            // 
            // txtOwnerName_Pet
            // 
            this.txtOwnerName_Pet.Location = new System.Drawing.Point(166, 430);
            this.txtOwnerName_Pet.Name = "txtOwnerName_Pet";
            this.txtOwnerName_Pet.Size = new System.Drawing.Size(208, 30);
            this.txtOwnerName_Pet.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAdd.Location = new System.Drawing.Point(485, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdate.Location = new System.Drawing.Point(485, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 35);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Location = new System.Drawing.Point(485, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSpecies
            // 
            this.btnSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnSpecies.FormattingEnabled = true;
            this.btnSpecies.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Bird",
            "Exotic"});
            this.btnSpecies.Location = new System.Drawing.Point(166, 330);
            this.btnSpecies.Name = "btnSpecies";
            this.btnSpecies.Size = new System.Drawing.Size(208, 33);
            this.btnSpecies.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 378);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(166, 383);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(208, 30);
            this.txtWeight.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 478);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Status";
            // 
            // btnStatus
            // 
            this.btnStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnStatus.FormattingEnabled = true;
            this.btnStatus.Items.AddRange(new object[] {
            "Healthy",
            "Injured",
            "Disease"});
            this.btnStatus.Location = new System.Drawing.Point(166, 478);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(208, 33);
            this.btnStatus.TabIndex = 5;
            // 
            // Pet_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnSpecies);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtOwnerName_Pet);
            this.Controls.Add(this.txtName_Pet);
            this.Controls.Add(this.txtID_Pet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PetTitle);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Pet_Form";
            this.Size = new System.Drawing.Size(721, 524);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label PetTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID_Pet;
        private System.Windows.Forms.TextBox txtName_Pet;
        private System.Windows.Forms.TextBox txtOwnerName_Pet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox btnSpecies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox btnStatus;
    }
}

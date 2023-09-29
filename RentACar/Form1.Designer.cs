namespace RentACar
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
            lblCarList = new Label();
            lbxCarList = new ListBox();
            btnRemoveCar = new Button();
            lblNewCar = new Label();
            tbxNewCar = new TextBox();
            btnNewCar = new Button();
            SuspendLayout();
            // 
            // lblCarList
            // 
            lblCarList.AutoSize = true;
            lblCarList.Location = new Point(21, 31);
            lblCarList.Name = "lblCarList";
            lblCarList.Size = new Size(44, 15);
            lblCarList.TabIndex = 0;
            lblCarList.Text = "Araçlar";
            // 
            // lbxCarList
            // 
            lbxCarList.FormattingEnabled = true;
            lbxCarList.ItemHeight = 15;
            lbxCarList.Location = new Point(21, 58);
            lbxCarList.Name = "lbxCarList";
            lbxCarList.Size = new Size(120, 229);
            lbxCarList.TabIndex = 1;
            // 
            // btnRemoveCar
            // 
            btnRemoveCar.Location = new Point(39, 293);
            btnRemoveCar.Name = "btnRemoveCar";
            btnRemoveCar.Size = new Size(102, 37);
            btnRemoveCar.TabIndex = 2;
            btnRemoveCar.Text = "Sil";
            btnRemoveCar.UseVisualStyleBackColor = true;
            btnRemoveCar.Click += btnRemoveCar_Click;
            // 
            // lblNewCar
            // 
            lblNewCar.AutoSize = true;
            lblNewCar.Location = new Point(207, 67);
            lblNewCar.Name = "lblNewCar";
            lblNewCar.Size = new Size(75, 15);
            lblNewCar.TabIndex = 3;
            lblNewCar.Text = "Araç Markası";
            // 
            // tbxNewCar
            // 
            tbxNewCar.Location = new Point(300, 67);
            tbxNewCar.Name = "tbxNewCar";
            tbxNewCar.Size = new Size(177, 23);
            tbxNewCar.TabIndex = 4;
            // 
            // btnNewCar
            // 
            btnNewCar.Location = new Point(507, 67);
            btnNewCar.Name = "btnNewCar";
            btnNewCar.Size = new Size(107, 23);
            btnNewCar.TabIndex = 5;
            btnNewCar.Text = "Kaydet";
            btnNewCar.UseVisualStyleBackColor = true;
            btnNewCar.Click += btnNewCar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNewCar);
            Controls.Add(tbxNewCar);
            Controls.Add(lblNewCar);
            Controls.Add(btnRemoveCar);
            Controls.Add(lbxCarList);
            Controls.Add(lblCarList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCarList;
        private ListBox lbxCarList;
        private Button btnRemoveCar;
        private Label lblNewCar;
        private TextBox tbxNewCar;
        private Button btnNewCar;
    }
}
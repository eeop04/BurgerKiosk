namespace BurgerKiosk
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
            btnOrder = new Button();
            label1 = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpMain = new GroupBox();
            grpSuv = new GroupBox();
            grpList = new GroupBox();
            lblTotalCost = new Label();
            btnClear = new Button();
            lstOrder = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpMain.SuspendLayout();
            grpSuv.SuspendLayout();
            grpList.SuspendLayout();
            SuspendLayout();
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(23, 326);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(113, 52);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "주문";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(407, 60);
            label1.TabIndex = 2;
            label1.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 12F);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(19, 60);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(93, 32);
            rdoHamBurger.TabIndex = 3;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 12F);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(19, 168);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(140, 32);
            rdoBulgogiBurger.TabIndex = 4;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기 버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 12F);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(19, 285);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(120, 32);
            rdoChickenBurger.TabIndex = 5;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨 버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ham;
            pictureBox1.Location = new Point(163, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bulgogi;
            pictureBox2.Location = new Point(185, 222);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.chiken;
            pictureBox3.Location = new Point(185, 341);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 97);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 13.8F);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(16, 60);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(128, 35);
            chkPotato.TabIndex = 9;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 13.8F);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(16, 131);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(82, 35);
            chkCola.TabIndex = 10;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 13.8F);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(16, 203);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(136, 35);
            chkCheese.TabIndex = 11;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 13.8F);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(16, 279);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(136, 35);
            chkSauce.TabIndex = 12;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // grpMain
            // 
            grpMain.Controls.Add(pictureBox1);
            grpMain.Controls.Add(rdoHamBurger);
            grpMain.Controls.Add(rdoChickenBurger);
            grpMain.Controls.Add(rdoBulgogiBurger);
            grpMain.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpMain.ForeColor = Color.Red;
            grpMain.Location = new Point(22, 91);
            grpMain.Name = "grpMain";
            grpMain.Size = new Size(298, 396);
            grpMain.TabIndex = 13;
            grpMain.TabStop = false;
            grpMain.Text = "메인 메뉴";
            // 
            // grpSuv
            // 
            grpSuv.Controls.Add(chkPotato);
            grpSuv.Controls.Add(chkSauce);
            grpSuv.Controls.Add(chkCola);
            grpSuv.Controls.Add(chkCheese);
            grpSuv.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpSuv.ForeColor = Color.Red;
            grpSuv.Location = new Point(338, 91);
            grpSuv.Name = "grpSuv";
            grpSuv.Size = new Size(187, 396);
            grpSuv.TabIndex = 14;
            grpSuv.TabStop = false;
            grpSuv.Text = "서브 메뉴";
            // 
            // grpList
            // 
            grpList.Controls.Add(lblTotalCost);
            grpList.Controls.Add(btnClear);
            grpList.Controls.Add(lstOrder);
            grpList.Controls.Add(btnOrder);
            grpList.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grpList.ForeColor = Color.Red;
            grpList.Location = new Point(548, 91);
            grpList.Name = "grpList";
            grpList.Size = new Size(270, 396);
            grpList.TabIndex = 15;
            grpList.TabStop = false;
            grpList.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = Color.Black;
            lblTotalCost.Location = new Point(19, 271);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(117, 38);
            lblTotalCost.TabIndex = 2;
            lblTotalCost.Text = "총 금액:";
            lblTotalCost.Click += lblTotalCost_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(142, 326);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 52);
            btnClear.TabIndex = 1;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(23, 52);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(232, 189);
            lstOrder.TabIndex = 0;
            lstOrder.SelectedIndexChanged += lstOrder_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 515);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(grpMain);
            Controls.Add(grpSuv);
            Controls.Add(grpList);
            Name = "Form1";
            Text = "Buger Kiosk v1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpMain.ResumeLayout(false);
            grpMain.PerformLayout();
            grpSuv.ResumeLayout(false);
            grpSuv.PerformLayout();
            grpList.ResumeLayout(false);
            grpList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrder;
        private Label label1;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpMain;
        private GroupBox grpSuv;
        private GroupBox grpList;
        private Button btnClear;
        private ListBox lstOrder;
        private Label lblTotalCost;
    }
}

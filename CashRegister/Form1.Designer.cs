namespace CashRegister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ShopName = new System.Windows.Forms.Label();
            this.swordLabel = new System.Windows.Forms.Label();
            this.shieldLabel = new System.Windows.Forms.Label();
            this.SoALabel = new System.Windows.Forms.Label();
            this.amountS = new System.Windows.Forms.Label();
            this.amountSH = new System.Windows.Forms.Label();
            this.amountSoA = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Button();
            this.numberS = new System.Windows.Forms.TextBox();
            this.numberSH = new System.Windows.Forms.TextBox();
            this.numberSoA = new System.Windows.Forms.TextBox();
            this.bill = new System.Windows.Forms.Label();
            this.thanks = new System.Windows.Forms.Label();
            this.tenderedAmount = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.reciept = new System.Windows.Forms.Label();
            this.printReciept = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShopName
            // 
            this.ShopName.Font = new System.Drawing.Font("Lydian Csv BT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopName.Location = new System.Drawing.Point(12, 9);
            this.ShopName.Name = "ShopName";
            this.ShopName.Size = new System.Drawing.Size(594, 62);
            this.ShopName.TabIndex = 0;
            this.ShopName.Text = "label1";
            this.ShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // swordLabel
            // 
            this.swordLabel.AutoSize = true;
            this.swordLabel.Font = new System.Drawing.Font("Lydian Csv BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swordLabel.Location = new System.Drawing.Point(18, 80);
            this.swordLabel.Name = "swordLabel";
            this.swordLabel.Size = new System.Drawing.Size(49, 20);
            this.swordLabel.TabIndex = 1;
            this.swordLabel.Text = "label2";
            // 
            // shieldLabel
            // 
            this.shieldLabel.AutoSize = true;
            this.shieldLabel.Font = new System.Drawing.Font("Lydian Csv BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shieldLabel.Location = new System.Drawing.Point(18, 131);
            this.shieldLabel.Name = "shieldLabel";
            this.shieldLabel.Size = new System.Drawing.Size(49, 20);
            this.shieldLabel.TabIndex = 2;
            this.shieldLabel.Text = "label3";
            // 
            // SoALabel
            // 
            this.SoALabel.AutoSize = true;
            this.SoALabel.Font = new System.Drawing.Font("Lydian Csv BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoALabel.Location = new System.Drawing.Point(18, 182);
            this.SoALabel.Name = "SoALabel";
            this.SoALabel.Size = new System.Drawing.Size(49, 20);
            this.SoALabel.TabIndex = 3;
            this.SoALabel.Text = "label4";
            // 
            // amountS
            // 
            this.amountS.AutoSize = true;
            this.amountS.Font = new System.Drawing.Font("Lydian Csv BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountS.Location = new System.Drawing.Point(19, 100);
            this.amountS.Name = "amountS";
            this.amountS.Size = new System.Drawing.Size(35, 16);
            this.amountS.TabIndex = 4;
            this.amountS.Text = "label5";
            // 
            // amountSH
            // 
            this.amountSH.AutoSize = true;
            this.amountSH.Font = new System.Drawing.Font("Lydian Csv BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountSH.Location = new System.Drawing.Point(19, 151);
            this.amountSH.Name = "amountSH";
            this.amountSH.Size = new System.Drawing.Size(35, 16);
            this.amountSH.TabIndex = 5;
            this.amountSH.Text = "label6";
            // 
            // amountSoA
            // 
            this.amountSoA.AutoSize = true;
            this.amountSoA.Font = new System.Drawing.Font("Lydian Csv BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountSoA.Location = new System.Drawing.Point(19, 202);
            this.amountSoA.Name = "amountSoA";
            this.amountSoA.Size = new System.Drawing.Size(35, 16);
            this.amountSoA.TabIndex = 6;
            this.amountSoA.Text = "label7";
            // 
            // totalCost
            // 
            this.totalCost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalCost.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalCost.Font = new System.Drawing.Font("Lydian Csv BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.Location = new System.Drawing.Point(22, 238);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(181, 33);
            this.totalCost.TabIndex = 10;
            this.totalCost.Text = "button4";
            this.totalCost.UseVisualStyleBackColor = true;
            this.totalCost.Click += new System.EventHandler(this.TotalCost_Click);
            // 
            // numberS
            // 
            this.numberS.BackColor = System.Drawing.Color.AntiqueWhite;
            this.numberS.Font = new System.Drawing.Font("Lydian Csv BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberS.Location = new System.Drawing.Point(171, 99);
            this.numberS.Name = "numberS";
            this.numberS.Size = new System.Drawing.Size(33, 21);
            this.numberS.TabIndex = 11;
            // 
            // numberSH
            // 
            this.numberSH.BackColor = System.Drawing.Color.AntiqueWhite;
            this.numberSH.Font = new System.Drawing.Font("Lydian Csv BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSH.Location = new System.Drawing.Point(171, 150);
            this.numberSH.Name = "numberSH";
            this.numberSH.Size = new System.Drawing.Size(33, 21);
            this.numberSH.TabIndex = 12;
            // 
            // numberSoA
            // 
            this.numberSoA.BackColor = System.Drawing.Color.AntiqueWhite;
            this.numberSoA.Font = new System.Drawing.Font("Lydian Csv BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSoA.Location = new System.Drawing.Point(171, 201);
            this.numberSoA.Name = "numberSoA";
            this.numberSoA.Size = new System.Drawing.Size(33, 21);
            this.numberSoA.TabIndex = 13;
            // 
            // bill
            // 
            this.bill.AutoSize = true;
            this.bill.Font = new System.Drawing.Font("Lydian Csv BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.Location = new System.Drawing.Point(24, 274);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(0, 14);
            this.bill.TabIndex = 15;
            // 
            // thanks
            // 
            this.thanks.AutoSize = true;
            this.thanks.Font = new System.Drawing.Font("Lydian Csv BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanks.Location = new System.Drawing.Point(19, 395);
            this.thanks.Name = "thanks";
            this.thanks.Size = new System.Drawing.Size(109, 16);
            this.thanks.TabIndex = 16;
            this.thanks.Text = "Tendered Amount:";
            // 
            // tenderedAmount
            // 
            this.tenderedAmount.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tenderedAmount.Font = new System.Drawing.Font("Lydian Csv BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedAmount.Location = new System.Drawing.Point(166, 394);
            this.tenderedAmount.Name = "tenderedAmount";
            this.tenderedAmount.Size = new System.Drawing.Size(38, 21);
            this.tenderedAmount.TabIndex = 17;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Lydian Csv BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(24, 457);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(0, 14);
            this.changeLabel.TabIndex = 18;
            // 
            // changeButton
            // 
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Lydian Csv BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(22, 421);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(181, 33);
            this.changeButton.TabIndex = 19;
            this.changeButton.Text = "button4";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // reciept
            // 
            this.reciept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reciept.Cursor = System.Windows.Forms.Cursors.Default;
            this.reciept.Font = new System.Drawing.Font("Lydian Csv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciept.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reciept.Location = new System.Drawing.Point(269, 131);
            this.reciept.Name = "reciept";
            this.reciept.Size = new System.Drawing.Size(281, 346);
            this.reciept.TabIndex = 20;
            this.reciept.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // printReciept
            // 
            this.printReciept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printReciept.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printReciept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReciept.Font = new System.Drawing.Font("Lydian Csv BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReciept.Location = new System.Drawing.Point(269, 91);
            this.printReciept.Name = "printReciept";
            this.printReciept.Size = new System.Drawing.Size(181, 33);
            this.printReciept.TabIndex = 21;
            this.printReciept.Text = "button4";
            this.printReciept.UseVisualStyleBackColor = true;
            this.printReciept.Click += new System.EventHandler(this.PrintReciept_Click);
            // 
            // newOrder
            // 
            this.newOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newOrder.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrder.Font = new System.Drawing.Font("Lydian Csv BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrder.Location = new System.Drawing.Point(12, 503);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(594, 33);
            this.newOrder.TabIndex = 22;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 546);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.printReciept);
            this.Controls.Add(this.reciept);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedAmount);
            this.Controls.Add(this.thanks);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.numberSoA);
            this.Controls.Add(this.numberSH);
            this.Controls.Add(this.numberS);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.amountSoA);
            this.Controls.Add(this.amountSH);
            this.Controls.Add(this.amountS);
            this.Controls.Add(this.SoALabel);
            this.Controls.Add(this.shieldLabel);
            this.Controls.Add(this.swordLabel);
            this.Controls.Add(this.ShopName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BlackSmith";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShopName;
        private System.Windows.Forms.Label swordLabel;
        private System.Windows.Forms.Label shieldLabel;
        private System.Windows.Forms.Label SoALabel;
        private System.Windows.Forms.Label amountS;
        private System.Windows.Forms.Label amountSH;
        private System.Windows.Forms.Label amountSoA;
        private System.Windows.Forms.Button totalCost;
        private System.Windows.Forms.TextBox numberS;
        private System.Windows.Forms.TextBox numberSH;
        private System.Windows.Forms.TextBox numberSoA;
        private System.Windows.Forms.Label bill;
        private System.Windows.Forms.Label thanks;
        private System.Windows.Forms.TextBox tenderedAmount;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label reciept;
        private System.Windows.Forms.Button printReciept;
        private System.Windows.Forms.Button newOrder;
    }
}


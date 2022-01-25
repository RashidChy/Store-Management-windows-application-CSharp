namespace StoreManagement.UI
{
    partial class DashForm
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
            this.btnMakeBill = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnaddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.updateItems1 = new StoreManagement.UI.updateItems();
            this.makeBill1 = new StoreManagement.UI.MakeBill();
            this.addItems1 = new StoreManagement.UI.AddItems();
            this.removeItem1 = new StoreManagement.UI.removeItem();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMakeBill
            // 
            this.btnMakeBill.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMakeBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeBill.ForeColor = System.Drawing.Color.Navy;
            this.btnMakeBill.Location = new System.Drawing.Point(45, 30);
            this.btnMakeBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeBill.Name = "btnMakeBill";
            this.btnMakeBill.Size = new System.Drawing.Size(155, 58);
            this.btnMakeBill.TabIndex = 0;
            this.btnMakeBill.Text = "Make Bill";
            this.btnMakeBill.UseVisualStyleBackColor = false;
            this.btnMakeBill.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdateItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdateItem.Location = new System.Drawing.Point(45, 194);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(155, 58);
            this.btnUpdateItem.TabIndex = 1;
            this.btnUpdateItem.Text = "Update Items";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnaddItem
            // 
            this.btnaddItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnaddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddItem.ForeColor = System.Drawing.Color.Navy;
            this.btnaddItem.Location = new System.Drawing.Point(42, 118);
            this.btnaddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddItem.Name = "btnaddItem";
            this.btnaddItem.Size = new System.Drawing.Size(155, 58);
            this.btnaddItem.TabIndex = 2;
            this.btnaddItem.Text = "Add Items";
            this.btnaddItem.UseVisualStyleBackColor = false;
            this.btnaddItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.Navy;
            this.btnRemoveItem.Location = new System.Drawing.Point(44, 272);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(155, 58);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnaddItem);
            this.panel1.Controls.Add(this.btnRemoveItem);
            this.panel1.Controls.Add(this.btnMakeBill);
            this.panel1.Controls.Add(this.btnUpdateItem);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 494);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(205, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 491);
            this.panel2.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Navy;
            this.button5.Location = new System.Drawing.Point(42, 421);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 58);
            this.button5.TabIndex = 5;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // updateItems1
            // 
            this.updateItems1.BackColor = System.Drawing.Color.SkyBlue;
            this.updateItems1.Location = new System.Drawing.Point(221, 3);
            this.updateItems1.Name = "updateItems1";
            this.updateItems1.Size = new System.Drawing.Size(726, 495);
            this.updateItems1.TabIndex = 7;
            // 
            // makeBill1
            // 
            this.makeBill1.BackColor = System.Drawing.Color.SkyBlue;
            this.makeBill1.Location = new System.Drawing.Point(239, 1);
            this.makeBill1.Name = "makeBill1";
            this.makeBill1.Size = new System.Drawing.Size(726, 495);
            this.makeBill1.TabIndex = 6;
            // 
            // addItems1
            // 
            this.addItems1.BackColor = System.Drawing.Color.SkyBlue;
            this.addItems1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItems1.Location = new System.Drawing.Point(209, -5);
            this.addItems1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addItems1.Name = "addItems1";
            this.addItems1.Size = new System.Drawing.Size(728, 495);
            this.addItems1.TabIndex = 5;
            // 
            // removeItem1
            // 
            this.removeItem1.BackColor = System.Drawing.Color.SkyBlue;
            this.removeItem1.Location = new System.Drawing.Point(239, 1);
            this.removeItem1.Name = "removeItem1";
            this.removeItem1.Size = new System.Drawing.Size(726, 495);
            this.removeItem1.TabIndex = 8;
            // 
            // DashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(987, 491);
            this.Controls.Add(this.removeItem1);
            this.Controls.Add(this.updateItems1);
            this.Controls.Add(this.makeBill1);
            this.Controls.Add(this.addItems1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashForm";
            this.Text = "DashForm";
            this.Load += new System.EventHandler(this.DashForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakeBill;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnaddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private AddItems addItems1;
        private MakeBill makeBill1;
        private updateItems updateItems1;
        private System.Windows.Forms.Button button1;
        private removeItem removeItem1;
    }
}
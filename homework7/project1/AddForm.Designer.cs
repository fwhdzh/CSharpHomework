namespace project1
{
    partial class AddForm
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
            this.textProduct = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textClient = new System.Windows.Forms.TextBox();
            this.labProduct = new System.Windows.Forms.Label();
            this.labClient = new System.Windows.Forms.Label();
            this.labNumber = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textProduct
            // 
            this.textProduct.Location = new System.Drawing.Point(224, 106);
            this.textProduct.Name = "textProduct";
            this.textProduct.Size = new System.Drawing.Size(254, 28);
            this.textProduct.TabIndex = 0;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(224, 278);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(254, 28);
            this.textPrice.TabIndex = 1;
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(224, 220);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(254, 28);
            this.textNumber.TabIndex = 2;
            // 
            // textClient
            // 
            this.textClient.Location = new System.Drawing.Point(224, 161);
            this.textClient.Name = "textClient";
            this.textClient.Size = new System.Drawing.Size(254, 28);
            this.textClient.TabIndex = 3;
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.Location = new System.Drawing.Point(126, 109);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(62, 18);
            this.labProduct.TabIndex = 4;
            this.labProduct.Text = "商品名";
            // 
            // labClient
            // 
            this.labClient.AutoSize = true;
            this.labClient.Location = new System.Drawing.Point(126, 171);
            this.labClient.Name = "labClient";
            this.labClient.Size = new System.Drawing.Size(62, 18);
            this.labClient.TabIndex = 5;
            this.labClient.Text = "顾客名";
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Location = new System.Drawing.Point(126, 230);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(44, 18);
            this.labNumber.TabIndex = 6;
            this.labNumber.Text = "数量";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(126, 281);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(44, 18);
            this.labPrice.TabIndex = 7;
            this.labPrice.Text = "单价";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(244, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "添加订单";
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(148, 349);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(127, 47);
            this.butOK.TabIndex = 9;
            this.butOK.Text = "确定";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(351, 349);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(127, 47);
            this.butCancel.TabIndex = 10;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.labClient);
            this.Controls.Add(this.labProduct);
            this.Controls.Add(this.textClient);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textProduct);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

           // butOK.DialogResult = DialogResult.OK;
        }

        #endregion

        private System.Windows.Forms.TextBox textProduct;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textClient;
        private System.Windows.Forms.Label labProduct;
        private System.Windows.Forms.Label labClient;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
    }
}
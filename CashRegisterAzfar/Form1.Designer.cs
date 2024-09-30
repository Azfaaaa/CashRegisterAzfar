namespace CashRegisterAzfar
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.backcolorLabel = new System.Windows.Forms.Label();
            this.shawarmaLabel = new System.Windows.Forms.Label();
            this.poutineLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.wrapInput = new System.Windows.Forms.TextBox();
            this.poutineInput = new System.Windows.Forms.TextBox();
            this.friesInput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.smallLineLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.neworderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Peru;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Location = new System.Drawing.Point(-6, -1);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(579, 112);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Big D\'s  Shawarma";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // backcolorLabel
            // 
            this.backcolorLabel.BackColor = System.Drawing.Color.Peru;
            this.backcolorLabel.Location = new System.Drawing.Point(-10, 111);
            this.backcolorLabel.Name = "backcolorLabel";
            this.backcolorLabel.Size = new System.Drawing.Size(197, 573);
            this.backcolorLabel.TabIndex = 1;
            // 
            // shawarmaLabel
            // 
            this.shawarmaLabel.AutoSize = true;
            this.shawarmaLabel.BackColor = System.Drawing.Color.Peru;
            this.shawarmaLabel.Location = new System.Drawing.Point(12, 123);
            this.shawarmaLabel.Name = "shawarmaLabel";
            this.shawarmaLabel.Size = new System.Drawing.Size(100, 24);
            this.shawarmaLabel.TabIndex = 2;
            this.shawarmaLabel.Text = "# of wraps";
            // 
            // poutineLabel
            // 
            this.poutineLabel.AutoSize = true;
            this.poutineLabel.BackColor = System.Drawing.Color.Peru;
            this.poutineLabel.Location = new System.Drawing.Point(12, 165);
            this.poutineLabel.Name = "poutineLabel";
            this.poutineLabel.Size = new System.Drawing.Size(121, 24);
            this.poutineLabel.TabIndex = 3;
            this.poutineLabel.Text = "# of poutines";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.BackColor = System.Drawing.Color.Peru;
            this.friesLabel.Location = new System.Drawing.Point(12, 207);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(86, 24);
            this.friesLabel.TabIndex = 4;
            this.friesLabel.Text = "# of fries";
            // 
            // wrapInput
            // 
            this.wrapInput.Location = new System.Drawing.Point(139, 120);
            this.wrapInput.Name = "wrapInput";
            this.wrapInput.Size = new System.Drawing.Size(46, 30);
            this.wrapInput.TabIndex = 5;
            // 
            // poutineInput
            // 
            this.poutineInput.Location = new System.Drawing.Point(139, 162);
            this.poutineInput.Name = "poutineInput";
            this.poutineInput.Size = new System.Drawing.Size(46, 30);
            this.poutineInput.TabIndex = 6;
            // 
            // friesInput
            // 
            this.friesInput.Location = new System.Drawing.Point(139, 207);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(46, 30);
            this.friesInput.TabIndex = 7;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(26, 259);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(140, 32);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.Peru;
            this.subtotalLabel.Location = new System.Drawing.Point(12, 335);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(90, 24);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.Peru;
            this.taxLabel.Location = new System.Drawing.Point(12, 373);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(46, 24);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Peru;
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalLabel.Location = new System.Drawing.Point(12, 413);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(60, 24);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total:";
            // 
            // smallLineLabel
            // 
            this.smallLineLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.smallLineLabel.Location = new System.Drawing.Point(22, 455);
            this.smallLineLabel.Name = "smallLineLabel";
            this.smallLineLabel.Size = new System.Drawing.Size(144, 10);
            this.smallLineLabel.TabIndex = 12;
            this.smallLineLabel.Text = "aa";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.BackColor = System.Drawing.Color.Peru;
            this.tenderedLabel.Location = new System.Drawing.Point(12, 490);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(95, 24);
            this.tenderedLabel.TabIndex = 13;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Enabled = false;
            this.tenderedInput.Location = new System.Drawing.Point(128, 487);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(57, 30);
            this.tenderedInput.TabIndex = 14;
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(26, 532);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(140, 50);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Calculate change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.Peru;
            this.changeLabel.Location = new System.Drawing.Point(12, 589);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(115, 24);
            this.changeLabel.TabIndex = 16;
            this.changeLabel.Text = "Change due:";
            // 
            // receiptButton
            // 
            this.receiptButton.Enabled = false;
            this.receiptButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(26, 631);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(140, 32);
            this.receiptButton.TabIndex = 17;
            this.receiptButton.Text = "Print receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.BackColor = System.Drawing.Color.Peru;
            this.subtotalOutput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(112, 338);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(21, 21);
            this.subtotalOutput.TabIndex = 18;
            this.subtotalOutput.Text = "0";
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.BackColor = System.Drawing.Color.Peru;
            this.taxOutput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(112, 376);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(21, 21);
            this.taxOutput.TabIndex = 19;
            this.taxOutput.Text = "0";
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.BackColor = System.Drawing.Color.Peru;
            this.totalOutput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(112, 416);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(21, 21);
            this.totalOutput.TabIndex = 20;
            this.totalOutput.Text = "0";
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.BackColor = System.Drawing.Color.Peru;
            this.changeOutput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(124, 592);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(21, 21);
            this.changeOutput.TabIndex = 21;
            this.changeOutput.Text = "0";
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receiptOutput
            // 
            this.receiptOutput.AutoSize = true;
            this.receiptOutput.BackColor = System.Drawing.Color.White;
            this.receiptOutput.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.Location = new System.Drawing.Point(198, 131);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(19, 19);
            this.receiptOutput.TabIndex = 23;
            this.receiptOutput.Text = ".";
            this.receiptOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // neworderButton
            // 
            this.neworderButton.Enabled = false;
            this.neworderButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neworderButton.Location = new System.Drawing.Point(313, 550);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(140, 32);
            this.neworderButton.TabIndex = 24;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = true;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 672);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.smallLineLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.friesInput);
            this.Controls.Add(this.poutineInput);
            this.Controls.Add(this.wrapInput);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.poutineLabel);
            this.Controls.Add(this.shawarmaLabel);
            this.Controls.Add(this.backcolorLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Big D\'s shawarma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label backcolorLabel;
        private System.Windows.Forms.Label shawarmaLabel;
        private System.Windows.Forms.Label poutineLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.TextBox wrapInput;
        private System.Windows.Forms.TextBox poutineInput;
        private System.Windows.Forms.TextBox friesInput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label smallLineLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Button neworderButton;
    }
}


namespace BitFire
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxOKCoin = new System.Windows.Forms.GroupBox();
            this.labelOKCoinEthTime = new System.Windows.Forms.Label();
            this.labelOKCoinEthSellPrice = new System.Windows.Forms.Label();
            this.labelOKCoinEthSellHint = new System.Windows.Forms.Label();
            this.labelOKCoinEthBuyPrice = new System.Windows.Forms.Label();
            this.labelOKCoinEthBuyHint = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxViabtc = new System.Windows.Forms.GroupBox();
            this.labelViabtcEthTime = new System.Windows.Forms.Label();
            this.labelViabtcEthSellPrice = new System.Windows.Forms.Label();
            this.labelViabtcEthSellHint = new System.Windows.Forms.Label();
            this.labelViabtcEthBuyPrice = new System.Windows.Forms.Label();
            this.labelViabtcEthBuyHint = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelBitfinexEthTime = new System.Windows.Forms.Label();
            this.labelBitfinexEthSellPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBitfinexEthBuyPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUsdExchangeRate = new System.Windows.Forms.TextBox();
            this.groupBoxOKCoin.SuspendLayout();
            this.groupBoxViabtc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOKCoin
            // 
            this.groupBoxOKCoin.Controls.Add(this.labelOKCoinEthTime);
            this.groupBoxOKCoin.Controls.Add(this.labelOKCoinEthSellPrice);
            this.groupBoxOKCoin.Controls.Add(this.labelOKCoinEthSellHint);
            this.groupBoxOKCoin.Controls.Add(this.labelOKCoinEthBuyPrice);
            this.groupBoxOKCoin.Controls.Add(this.labelOKCoinEthBuyHint);
            this.groupBoxOKCoin.Location = new System.Drawing.Point(33, 22);
            this.groupBoxOKCoin.Name = "groupBoxOKCoin";
            this.groupBoxOKCoin.Size = new System.Drawing.Size(497, 173);
            this.groupBoxOKCoin.TabIndex = 0;
            this.groupBoxOKCoin.TabStop = false;
            this.groupBoxOKCoin.Text = "okcoin eth";
            // 
            // labelOKCoinEthTime
            // 
            this.labelOKCoinEthTime.AutoSize = true;
            this.labelOKCoinEthTime.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOKCoinEthTime.Location = new System.Drawing.Point(6, 24);
            this.labelOKCoinEthTime.Name = "labelOKCoinEthTime";
            this.labelOKCoinEthTime.Size = new System.Drawing.Size(96, 28);
            this.labelOKCoinEthTime.TabIndex = 4;
            this.labelOKCoinEthTime.Text = "(Time)";
            // 
            // labelOKCoinEthSellPrice
            // 
            this.labelOKCoinEthSellPrice.AutoSize = true;
            this.labelOKCoinEthSellPrice.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOKCoinEthSellPrice.Location = new System.Drawing.Point(109, 112);
            this.labelOKCoinEthSellPrice.Name = "labelOKCoinEthSellPrice";
            this.labelOKCoinEthSellPrice.Size = new System.Drawing.Size(26, 28);
            this.labelOKCoinEthSellPrice.TabIndex = 3;
            this.labelOKCoinEthSellPrice.Text = "0";
            // 
            // labelOKCoinEthSellHint
            // 
            this.labelOKCoinEthSellHint.AutoSize = true;
            this.labelOKCoinEthSellHint.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOKCoinEthSellHint.Location = new System.Drawing.Point(16, 112);
            this.labelOKCoinEthSellHint.Name = "labelOKCoinEthSellHint";
            this.labelOKCoinEthSellHint.Size = new System.Drawing.Size(82, 28);
            this.labelOKCoinEthSellHint.TabIndex = 2;
            this.labelOKCoinEthSellHint.Text = "Sell:";
            // 
            // labelOKCoinEthBuyPrice
            // 
            this.labelOKCoinEthBuyPrice.AutoSize = true;
            this.labelOKCoinEthBuyPrice.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOKCoinEthBuyPrice.Location = new System.Drawing.Point(109, 65);
            this.labelOKCoinEthBuyPrice.Name = "labelOKCoinEthBuyPrice";
            this.labelOKCoinEthBuyPrice.Size = new System.Drawing.Size(26, 28);
            this.labelOKCoinEthBuyPrice.TabIndex = 1;
            this.labelOKCoinEthBuyPrice.Text = "0";
            // 
            // labelOKCoinEthBuyHint
            // 
            this.labelOKCoinEthBuyHint.AutoSize = true;
            this.labelOKCoinEthBuyHint.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOKCoinEthBuyHint.Location = new System.Drawing.Point(16, 65);
            this.labelOKCoinEthBuyHint.Name = "labelOKCoinEthBuyHint";
            this.labelOKCoinEthBuyHint.Size = new System.Drawing.Size(68, 28);
            this.labelOKCoinEthBuyHint.TabIndex = 0;
            this.labelOKCoinEthBuyHint.Text = "Buy:";
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1438, 22);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(85, 28);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxViabtc
            // 
            this.groupBoxViabtc.Controls.Add(this.labelViabtcEthTime);
            this.groupBoxViabtc.Controls.Add(this.labelViabtcEthSellPrice);
            this.groupBoxViabtc.Controls.Add(this.labelViabtcEthSellHint);
            this.groupBoxViabtc.Controls.Add(this.labelViabtcEthBuyPrice);
            this.groupBoxViabtc.Controls.Add(this.labelViabtcEthBuyHint);
            this.groupBoxViabtc.Location = new System.Drawing.Point(33, 222);
            this.groupBoxViabtc.Name = "groupBoxViabtc";
            this.groupBoxViabtc.Size = new System.Drawing.Size(497, 166);
            this.groupBoxViabtc.TabIndex = 5;
            this.groupBoxViabtc.TabStop = false;
            this.groupBoxViabtc.Text = "viabtc eth";
            // 
            // labelViabtcEthTime
            // 
            this.labelViabtcEthTime.AutoSize = true;
            this.labelViabtcEthTime.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelViabtcEthTime.Location = new System.Drawing.Point(6, 24);
            this.labelViabtcEthTime.Name = "labelViabtcEthTime";
            this.labelViabtcEthTime.Size = new System.Drawing.Size(96, 28);
            this.labelViabtcEthTime.TabIndex = 4;
            this.labelViabtcEthTime.Text = "(Time)";
            // 
            // labelViabtcEthSellPrice
            // 
            this.labelViabtcEthSellPrice.AutoSize = true;
            this.labelViabtcEthSellPrice.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelViabtcEthSellPrice.Location = new System.Drawing.Point(109, 112);
            this.labelViabtcEthSellPrice.Name = "labelViabtcEthSellPrice";
            this.labelViabtcEthSellPrice.Size = new System.Drawing.Size(26, 28);
            this.labelViabtcEthSellPrice.TabIndex = 3;
            this.labelViabtcEthSellPrice.Text = "0";
            // 
            // labelViabtcEthSellHint
            // 
            this.labelViabtcEthSellHint.AutoSize = true;
            this.labelViabtcEthSellHint.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelViabtcEthSellHint.Location = new System.Drawing.Point(16, 112);
            this.labelViabtcEthSellHint.Name = "labelViabtcEthSellHint";
            this.labelViabtcEthSellHint.Size = new System.Drawing.Size(82, 28);
            this.labelViabtcEthSellHint.TabIndex = 2;
            this.labelViabtcEthSellHint.Text = "Sell:";
            // 
            // labelViabtcEthBuyPrice
            // 
            this.labelViabtcEthBuyPrice.AutoSize = true;
            this.labelViabtcEthBuyPrice.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelViabtcEthBuyPrice.Location = new System.Drawing.Point(109, 65);
            this.labelViabtcEthBuyPrice.Name = "labelViabtcEthBuyPrice";
            this.labelViabtcEthBuyPrice.Size = new System.Drawing.Size(26, 28);
            this.labelViabtcEthBuyPrice.TabIndex = 1;
            this.labelViabtcEthBuyPrice.Text = "0";
            // 
            // labelViabtcEthBuyHint
            // 
            this.labelViabtcEthBuyHint.AutoSize = true;
            this.labelViabtcEthBuyHint.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelViabtcEthBuyHint.Location = new System.Drawing.Point(16, 65);
            this.labelViabtcEthBuyHint.Name = "labelViabtcEthBuyHint";
            this.labelViabtcEthBuyHint.Size = new System.Drawing.Size(68, 28);
            this.labelViabtcEthBuyHint.TabIndex = 0;
            this.labelViabtcEthBuyHint.Text = "Buy:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelBitfinexEthTime);
            this.groupBox1.Controls.Add(this.labelBitfinexEthSellPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelBitfinexEthBuyPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(33, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 221);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "bitfinex eth";
            // 
            // labelBitfinexEthTime
            // 
            this.labelBitfinexEthTime.AutoSize = true;
            this.labelBitfinexEthTime.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBitfinexEthTime.Location = new System.Drawing.Point(6, 24);
            this.labelBitfinexEthTime.Name = "labelBitfinexEthTime";
            this.labelBitfinexEthTime.Size = new System.Drawing.Size(96, 28);
            this.labelBitfinexEthTime.TabIndex = 4;
            this.labelBitfinexEthTime.Text = "(Time)";
            // 
            // labelBitfinexEthSellPrice
            // 
            this.labelBitfinexEthSellPrice.AutoSize = true;
            this.labelBitfinexEthSellPrice.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBitfinexEthSellPrice.Location = new System.Drawing.Point(109, 112);
            this.labelBitfinexEthSellPrice.Name = "labelBitfinexEthSellPrice";
            this.labelBitfinexEthSellPrice.Size = new System.Drawing.Size(26, 28);
            this.labelBitfinexEthSellPrice.TabIndex = 3;
            this.labelBitfinexEthSellPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sell:";
            // 
            // labelBitfinexEthBuyPrice
            // 
            this.labelBitfinexEthBuyPrice.AutoSize = true;
            this.labelBitfinexEthBuyPrice.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBitfinexEthBuyPrice.Location = new System.Drawing.Point(109, 65);
            this.labelBitfinexEthBuyPrice.Name = "labelBitfinexEthBuyPrice";
            this.labelBitfinexEthBuyPrice.Size = new System.Drawing.Size(26, 28);
            this.labelBitfinexEthBuyPrice.TabIndex = 1;
            this.labelBitfinexEthBuyPrice.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Buy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1435, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "美元汇率：";
            // 
            // textBoxUsdExchangeRate
            // 
            this.textBoxUsdExchangeRate.Location = new System.Drawing.Point(1433, 112);
            this.textBoxUsdExchangeRate.Name = "textBoxUsdExchangeRate";
            this.textBoxUsdExchangeRate.Size = new System.Drawing.Size(100, 28);
            this.textBoxUsdExchangeRate.TabIndex = 7;
            this.textBoxUsdExchangeRate.Text = "6.55";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 953);
            this.Controls.Add(this.textBoxUsdExchangeRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxViabtc);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxOKCoin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxOKCoin.ResumeLayout(false);
            this.groupBoxOKCoin.PerformLayout();
            this.groupBoxViabtc.ResumeLayout(false);
            this.groupBoxViabtc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOKCoin;
        private System.Windows.Forms.Label labelOKCoinEthBuyPrice;
        private System.Windows.Forms.Label labelOKCoinEthBuyHint;
        private System.Windows.Forms.Label labelOKCoinEthSellHint;
        private System.Windows.Forms.Label labelOKCoinEthTime;
        private System.Windows.Forms.Label labelOKCoinEthSellPrice;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxViabtc;
        private System.Windows.Forms.Label labelViabtcEthTime;
        private System.Windows.Forms.Label labelViabtcEthSellPrice;
        private System.Windows.Forms.Label labelViabtcEthSellHint;
        private System.Windows.Forms.Label labelViabtcEthBuyPrice;
        private System.Windows.Forms.Label labelViabtcEthBuyHint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelBitfinexEthTime;
        private System.Windows.Forms.Label labelBitfinexEthSellPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBitfinexEthBuyPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUsdExchangeRate;
    }
}


namespace ComputerOrder
{
    partial class OrderForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
			this._productGroupBox = new System.Windows.Forms.GroupBox();
			this._backButton = new System.Windows.Forms.Button();
			this._frontButton = new System.Windows.Forms.Button();
			this._pageLabel = new System.Windows.Forms.Label();
			this._addProduct = new System.Windows.Forms.Button();
			this._introductionBox = new System.Windows.Forms.GroupBox();
			this._introductionView = new System.Windows.Forms.RichTextBox();
			this._productPrice = new System.Windows.Forms.Label();
			this._productTab = new System.Windows.Forms.TabControl();
			this._motherBoardPage = new System.Windows.Forms.TabPage();
			this._processorPage = new System.Windows.Forms.TabPage();
			this._memoryPage = new System.Windows.Forms.TabPage();
			this._hardDiskPage = new System.Windows.Forms.TabPage();
			this._graphicsCardPage = new System.Windows.Forms.TabPage();
			this._computerPage = new System.Windows.Forms.TabPage();
			this._orderView = new System.Windows.Forms.DataGridView();
			this._title = new System.Windows.Forms.Label();
			this._totalPrice = new System.Windows.Forms.Label();
			this._buyButton = new System.Windows.Forms.Button();
			this._deleteProduct = new System.Windows.Forms.DataGridViewButtonColumn();
			this._productNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._productCategorys = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._productPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._productGroupBox.SuspendLayout();
			this._introductionBox.SuspendLayout();
			this._productTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._orderView)).BeginInit();
			this.SuspendLayout();
			// 
			// _productGroupBox
			// 
			this._productGroupBox.Controls.Add(this._backButton);
			this._productGroupBox.Controls.Add(this._frontButton);
			this._productGroupBox.Controls.Add(this._pageLabel);
			this._productGroupBox.Controls.Add(this._addProduct);
			this._productGroupBox.Controls.Add(this._introductionBox);
			this._productGroupBox.Controls.Add(this._productTab);
			this._productGroupBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this._productGroupBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this._productGroupBox.Location = new System.Drawing.Point(12, 12);
			this._productGroupBox.Name = "_productGroupBox";
			this._productGroupBox.Size = new System.Drawing.Size(400, 457);
			this._productGroupBox.TabIndex = 0;
			this._productGroupBox.TabStop = false;
			this._productGroupBox.Text = "商品";
			// 
			// _backButton
			// 
			this._backButton.Image = ((System.Drawing.Image)(resources.GetObject("_backButton.Image")));
			this._backButton.Location = new System.Drawing.Point(184, 419);
			this._backButton.Name = "_backButton";
			this._backButton.Size = new System.Drawing.Size(48, 30);
			this._backButton.TabIndex = 5;
			this._backButton.UseVisualStyleBackColor = true;
			this._backButton.Click += new System.EventHandler(this.ClickBackButton);
			// 
			// _frontButton
			// 
			this._frontButton.Enabled = false;
			this._frontButton.Image = ((System.Drawing.Image)(resources.GetObject("_frontButton.Image")));
			this._frontButton.Location = new System.Drawing.Point(130, 420);
			this._frontButton.Name = "_frontButton";
			this._frontButton.Size = new System.Drawing.Size(48, 30);
			this._frontButton.TabIndex = 4;
			this._frontButton.UseVisualStyleBackColor = true;
			this._frontButton.Click += new System.EventHandler(this.ClickFrontButton);
			// 
			// _pageLabel
			// 
			this._pageLabel.AutoSize = true;
			this._pageLabel.Location = new System.Drawing.Point(6, 427);
			this._pageLabel.Name = "_pageLabel";
			this._pageLabel.Size = new System.Drawing.Size(103, 24);
			this._pageLabel.TabIndex = 3;
			this._pageLabel.Text = "Page：1/2";
			// 
			// _addProduct
			// 
			this._addProduct.Enabled = false;
			this._addProduct.Font = new System.Drawing.Font("微軟正黑體", 12F);
			this._addProduct.Image = ((System.Drawing.Image)(resources.GetObject("_addProduct.Image")));
			this._addProduct.Location = new System.Drawing.Point(320, 420);
			this._addProduct.Name = "_addProduct";
			this._addProduct.Size = new System.Drawing.Size(70, 30);
			this._addProduct.TabIndex = 2;
			this._addProduct.UseVisualStyleBackColor = true;
			this._addProduct.Click += new System.EventHandler(this.ClickAddProduct);
			// 
			// _introductionBox
			// 
			this._introductionBox.Controls.Add(this._introductionView);
			this._introductionBox.Controls.Add(this._productPrice);
			this._introductionBox.Font = new System.Drawing.Font("微軟正黑體", 12F);
			this._introductionBox.Location = new System.Drawing.Point(10, 288);
			this._introductionBox.Name = "_introductionBox";
			this._introductionBox.Size = new System.Drawing.Size(380, 108);
			this._introductionBox.TabIndex = 1;
			this._introductionBox.TabStop = false;
			this._introductionBox.Text = "商品介紹";
			// 
			// _introductionView
			// 
			this._introductionView.Font = new System.Drawing.Font("微軟正黑體", 9F);
			this._introductionView.Location = new System.Drawing.Point(6, 28);
			this._introductionView.Name = "_introductionView";
			this._introductionView.Size = new System.Drawing.Size(236, 73);
			this._introductionView.TabIndex = 1;
			this._introductionView.Text = "";
			this._introductionView.Visible = false;
			// 
			// _productPrice
			// 
			this._productPrice.Location = new System.Drawing.Point(255, 77);
			this._productPrice.Name = "_productPrice";
			this._productPrice.Size = new System.Drawing.Size(119, 24);
			this._productPrice.TabIndex = 0;
			this._productPrice.Text = "單價：0";
			this._productPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._productPrice.Visible = false;
			// 
			// _productTab
			// 
			this._productTab.Controls.Add(this._motherBoardPage);
			this._productTab.Controls.Add(this._processorPage);
			this._productTab.Controls.Add(this._memoryPage);
			this._productTab.Controls.Add(this._hardDiskPage);
			this._productTab.Controls.Add(this._graphicsCardPage);
			this._productTab.Controls.Add(this._computerPage);
			this._productTab.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this._productTab.Location = new System.Drawing.Point(6, 29);
			this._productTab.Name = "_productTab";
			this._productTab.SelectedIndex = 0;
			this._productTab.Size = new System.Drawing.Size(388, 253);
			this._productTab.TabIndex = 0;
			this._productTab.Click += new System.EventHandler(this.ClickProductTab);
			// 
			// _motherBoardPage
			// 
			this._motherBoardPage.Font = new System.Drawing.Font("微軟正黑體", 9F);
			this._motherBoardPage.Location = new System.Drawing.Point(4, 25);
			this._motherBoardPage.Name = "_motherBoardPage";
			this._motherBoardPage.Padding = new System.Windows.Forms.Padding(3);
			this._motherBoardPage.Size = new System.Drawing.Size(380, 224);
			this._motherBoardPage.TabIndex = 0;
			this._motherBoardPage.Text = "主機板";
			this._motherBoardPage.UseVisualStyleBackColor = true;
			// 
			// _processorPage
			// 
			this._processorPage.Location = new System.Drawing.Point(4, 25);
			this._processorPage.Name = "_processorPage";
			this._processorPage.Padding = new System.Windows.Forms.Padding(3);
			this._processorPage.Size = new System.Drawing.Size(380, 224);
			this._processorPage.TabIndex = 1;
			this._processorPage.Text = "CPU";
			this._processorPage.UseVisualStyleBackColor = true;
			// 
			// _memoryPage
			// 
			this._memoryPage.Location = new System.Drawing.Point(4, 25);
			this._memoryPage.Name = "_memoryPage";
			this._memoryPage.Padding = new System.Windows.Forms.Padding(3);
			this._memoryPage.Size = new System.Drawing.Size(380, 224);
			this._memoryPage.TabIndex = 2;
			this._memoryPage.Text = "記憶體";
			this._memoryPage.UseVisualStyleBackColor = true;
			// 
			// _hardDiskPage
			// 
			this._hardDiskPage.Location = new System.Drawing.Point(4, 25);
			this._hardDiskPage.Name = "_hardDiskPage";
			this._hardDiskPage.Padding = new System.Windows.Forms.Padding(3);
			this._hardDiskPage.Size = new System.Drawing.Size(380, 224);
			this._hardDiskPage.TabIndex = 3;
			this._hardDiskPage.Text = "硬碟";
			this._hardDiskPage.UseVisualStyleBackColor = true;
			// 
			// _graphicsCardPage
			// 
			this._graphicsCardPage.Location = new System.Drawing.Point(4, 25);
			this._graphicsCardPage.Name = "_graphicsCardPage";
			this._graphicsCardPage.Padding = new System.Windows.Forms.Padding(3);
			this._graphicsCardPage.Size = new System.Drawing.Size(380, 224);
			this._graphicsCardPage.TabIndex = 4;
			this._graphicsCardPage.Text = "顯卡";
			this._graphicsCardPage.UseVisualStyleBackColor = true;
			// 
			// _computerPage
			// 
			this._computerPage.Location = new System.Drawing.Point(4, 25);
			this._computerPage.Name = "_computerPage";
			this._computerPage.Padding = new System.Windows.Forms.Padding(3);
			this._computerPage.Size = new System.Drawing.Size(380, 224);
			this._computerPage.TabIndex = 5;
			this._computerPage.Text = "套裝電腦";
			this._computerPage.UseVisualStyleBackColor = true;
			// 
			// _orderView
			// 
			this._orderView.AllowUserToAddRows = false;
			this._orderView.AllowUserToDeleteRows = false;
			this._orderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._orderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._deleteProduct,
            this._productNames,
            this._productCategorys,
            this._productPrices});
			this._orderView.Location = new System.Drawing.Point(419, 66);
			this._orderView.Name = "_orderView";
			this._orderView.ReadOnly = true;
			this._orderView.RowHeadersVisible = false;
			this._orderView.RowTemplate.Height = 24;
			this._orderView.Size = new System.Drawing.Size(353, 342);
			this._orderView.TabIndex = 1;
			// 
			// _title
			// 
			this._title.AutoSize = true;
			this._title.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this._title.Location = new System.Drawing.Point(551, 37);
			this._title.Name = "_title";
			this._title.Size = new System.Drawing.Size(96, 26);
			this._title.TabIndex = 2;
			this._title.Text = "我的訂單";
			// 
			// _totalPrice
			// 
			this._totalPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this._totalPrice.Location = new System.Drawing.Point(419, 432);
			this._totalPrice.Name = "_totalPrice";
			this._totalPrice.Size = new System.Drawing.Size(221, 38);
			this._totalPrice.TabIndex = 3;
			this._totalPrice.Text = "總金額：";
			this._totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _buyButton
			// 
			this._buyButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this._buyButton.Location = new System.Drawing.Point(646, 431);
			this._buyButton.Name = "_buyButton";
			this._buyButton.Size = new System.Drawing.Size(125, 38);
			this._buyButton.TabIndex = 4;
			this._buyButton.Text = "訂購";
			this._buyButton.UseVisualStyleBackColor = true;
			this._buyButton.Click += new System.EventHandler(this.ClickBuyButton);
			// 
			// _deleteProduct
			// 
			this._deleteProduct.HeaderText = "刪除";
			this._deleteProduct.Name = "_deleteProduct";
			this._deleteProduct.ReadOnly = true;
			this._deleteProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this._deleteProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this._deleteProduct.Width = 40;
			// 
			// _productNames
			// 
			this._productNames.HeaderText = "商品名稱";
			this._productNames.Name = "_productNames";
			this._productNames.ReadOnly = true;
			this._productNames.Width = 130;
			// 
			// _productCategorys
			// 
			this._productCategorys.HeaderText = "商品類別";
			this._productCategorys.Name = "_productCategorys";
			this._productCategorys.ReadOnly = true;
			this._productCategorys.Width = 80;
			// 
			// _productPrices
			// 
			this._productPrices.HeaderText = "單價";
			this._productPrices.Name = "_productPrices";
			this._productPrices.ReadOnly = true;
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 481);
			this.Controls.Add(this._buyButton);
			this.Controls.Add(this._totalPrice);
			this.Controls.Add(this._title);
			this.Controls.Add(this._orderView);
			this.Controls.Add(this._productGroupBox);
			this.Name = "OrderForm";
			this.Text = "訂購";
			this._productGroupBox.ResumeLayout(false);
			this._productGroupBox.PerformLayout();
			this._introductionBox.ResumeLayout(false);
			this._productTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._orderView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _productGroupBox;
        private System.Windows.Forms.Button _addProduct;
        private System.Windows.Forms.GroupBox _introductionBox;
        private System.Windows.Forms.RichTextBox _introductionView;
        private System.Windows.Forms.Label _productPrice;
        private System.Windows.Forms.TabControl _productTab;
        private System.Windows.Forms.TabPage _motherBoardPage;
        private System.Windows.Forms.TabPage _processorPage;
        private System.Windows.Forms.TabPage _memoryPage;
        private System.Windows.Forms.TabPage _hardDiskPage;
        private System.Windows.Forms.TabPage _graphicsCardPage;
        private System.Windows.Forms.TabPage _computerPage;
        private System.Windows.Forms.DataGridView _orderView;
        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.Label _totalPrice;
        private System.Windows.Forms.Button _backButton;
        private System.Windows.Forms.Button _frontButton;
        private System.Windows.Forms.Label _pageLabel;
        private System.Windows.Forms.Button _buyButton;
		private System.Windows.Forms.DataGridViewButtonColumn _deleteProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn _productNames;
		private System.Windows.Forms.DataGridViewTextBoxColumn _productCategorys;
		private System.Windows.Forms.DataGridViewTextBoxColumn _productPrices;
	}
}


namespace ComputerOrder
{
    partial class MenuForm
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
            this._orderButton = new System.Windows.Forms.Button();
            this._inventoryButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _orderButton
            // 
            this._orderButton.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderButton.Location = new System.Drawing.Point(12, 12);
            this._orderButton.Name = "_orderButton";
            this._orderButton.Size = new System.Drawing.Size(776, 86);
            this._orderButton.TabIndex = 0;
            this._orderButton.Text = "Order System";
            this._orderButton.UseVisualStyleBackColor = true;
            this._orderButton.Click += new System.EventHandler(this.ClickOrderButtonClicked);
            // 
            // _inventoryButton
            // 
            this._inventoryButton.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._inventoryButton.Location = new System.Drawing.Point(12, 104);
            this._inventoryButton.Name = "_inventoryButton";
            this._inventoryButton.Size = new System.Drawing.Size(776, 90);
            this._inventoryButton.TabIndex = 1;
            this._inventoryButton.Text = "Inventory System";
            this._inventoryButton.UseVisualStyleBackColor = true;
            this._inventoryButton.Click += new System.EventHandler(this.ClickInventoryButton);
            // 
            // _exitButton
            // 
            this._exitButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._exitButton.Location = new System.Drawing.Point(533, 200);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(255, 51);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ExitButtonClicked);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._inventoryButton);
            this.Controls.Add(this._orderButton);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _orderButton;
        private System.Windows.Forms.Button _inventoryButton;
        private System.Windows.Forms.Button _exitButton;
    }
}
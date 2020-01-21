namespace WindowsFormsApp1
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.store = new System.Windows.Forms.Label();
            this.addtoCard = new System.Windows.Forms.Button();
            this.shopping = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorsListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(12, 9);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(179, 39);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Be the Flower";
            this.headerText.Click += new System.EventHandler(this.headerText_Click);
            // 
            // itemsListbox
            // 
            this.itemsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 16;
            this.itemsListbox.Location = new System.Drawing.Point(15, 75);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(176, 132);
            this.itemsListbox.TabIndex = 1;
            this.itemsListbox.SelectedIndexChanged += new System.EventHandler(this.itemsListbox_SelectedIndexChanged);
            // 
            // store
            // 
            this.store.AutoSize = true;
            this.store.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.store.Location = new System.Drawing.Point(16, 57);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(86, 16);
            this.store.TabIndex = 2;
            this.store.Text = "Store Items";
            this.store.Click += new System.EventHandler(this.label1_Click);
            // 
            // addtoCard
            // 
            this.addtoCard.Location = new System.Drawing.Point(197, 111);
            this.addtoCard.Name = "addtoCard";
            this.addtoCard.Size = new System.Drawing.Size(140, 40);
            this.addtoCard.TabIndex = 3;
            this.addtoCard.Text = "Add To Card->";
            this.addtoCard.UseVisualStyleBackColor = true;
            this.addtoCard.Click += new System.EventHandler(this.addtoCard_Click);
            // 
            // shopping
            // 
            this.shopping.AutoSize = true;
            this.shopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopping.Location = new System.Drawing.Point(340, 57);
            this.shopping.Name = "shopping";
            this.shopping.Size = new System.Drawing.Size(106, 16);
            this.shopping.TabIndex = 6;
            this.shopping.Text = "Shopping Cart";
            this.shopping.Click += new System.EventHandler(this.label2_Click);
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 16;
            this.shoppingCartListbox.Location = new System.Drawing.Point(343, 75);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(179, 132);
            this.shoppingCartListbox.TabIndex = 5;
            this.shoppingCartListbox.SelectedIndexChanged += new System.EventHandler(this.shoppingCartListbox_SelectedIndexChanged);
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(528, 123);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(140, 40);
            this.makePurchase.TabIndex = 7;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click_1);
            // 
            // vendorsListbox
            // 
            this.vendorsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorsListbox.FormattingEnabled = true;
            this.vendorsListbox.ItemHeight = 16;
            this.vendorsListbox.Location = new System.Drawing.Point(12, 264);
            this.vendorsListbox.Name = "vendorsListbox";
            this.vendorsListbox.Size = new System.Drawing.Size(176, 132);
            this.vendorsListbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vendors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Store Profit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "$0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vendorsListbox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shopping);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.addtoCard);
            this.Controls.Add(this.store);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label store;
        private System.Windows.Forms.Button addtoCard;
        private System.Windows.Forms.Label shopping;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.ListBox vendorsListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


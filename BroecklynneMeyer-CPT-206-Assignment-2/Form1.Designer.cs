
namespace BroecklynneMeyer_CPT_206_Assignment_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productButton = new System.Windows.Forms.Button();
            this.productNumTextBox = new System.Windows.Forms.TextBox();
            this.productNumRadioButton = new System.Windows.Forms.RadioButton();
            this.productDescriptionRadioButton = new System.Windows.Forms.RadioButton();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.unitsButton = new System.Windows.Forms.Button();
            this.moreThanRadioButton = new System.Windows.Forms.RadioButton();
            this.lessThanRadioButton = new System.Windows.Forms.RadioButton();
            this.moreNumTextBox = new System.Windows.Forms.TextBox();
            this.lessNumTextBox = new System.Windows.Forms.TextBox();
            this.priceRangeButton = new System.Windows.Forms.Button();
            this.maxPriceLabel = new System.Windows.Forms.Label();
            this.minPriceLabel = new System.Windows.Forms.Label();
            this.maxPriceTextBox = new System.Windows.Forms.TextBox();
            this.minPriceTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(BroecklynneMeyer_CPT_206_Assignment_2.Product);
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(578, 25);
            this.productBindingNavigator.TabIndex = 0;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Enabled = false;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(64, 28);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(442, 182);
            this.productDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(12, 241);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(115, 23);
            this.productButton.TabIndex = 2;
            this.productButton.Text = "Find Product";
            this.toolTip1.SetToolTip(this.productButton, "Click to use product number or description to search products.");
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productSearchButton_Click);
            // 
            // productNumTextBox
            // 
            this.productNumTextBox.Location = new System.Drawing.Point(158, 269);
            this.productNumTextBox.Name = "productNumTextBox";
            this.productNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.productNumTextBox.TabIndex = 10;
            this.productNumTextBox.Visible = false;
            // 
            // productNumRadioButton
            // 
            this.productNumRadioButton.AutoSize = true;
            this.productNumRadioButton.Location = new System.Drawing.Point(50, 270);
            this.productNumRadioButton.Name = "productNumRadioButton";
            this.productNumRadioButton.Size = new System.Drawing.Size(102, 17);
            this.productNumRadioButton.TabIndex = 9;
            this.productNumRadioButton.TabStop = true;
            this.productNumRadioButton.Text = "Product Number";
            this.productNumRadioButton.UseVisualStyleBackColor = true;
            this.productNumRadioButton.Visible = false;
            this.productNumRadioButton.CheckedChanged += new System.EventHandler(this.productNumRadioButton_CheckedChanged);
            // 
            // productDescriptionRadioButton
            // 
            this.productDescriptionRadioButton.AutoSize = true;
            this.productDescriptionRadioButton.Location = new System.Drawing.Point(274, 271);
            this.productDescriptionRadioButton.Name = "productDescriptionRadioButton";
            this.productDescriptionRadioButton.Size = new System.Drawing.Size(118, 17);
            this.productDescriptionRadioButton.TabIndex = 11;
            this.productDescriptionRadioButton.TabStop = true;
            this.productDescriptionRadioButton.Text = "Product Description";
            this.productDescriptionRadioButton.UseVisualStyleBackColor = true;
            this.productDescriptionRadioButton.Visible = false;
            this.productDescriptionRadioButton.CheckedChanged += new System.EventHandler(this.productDescriptionRadioButton_CheckedChanged);
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(398, 269);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(108, 20);
            this.productDescriptionTextBox.TabIndex = 12;
            this.productDescriptionTextBox.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(126, 415);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "&Search";
            this.toolTip1.SetToolTip(this.searchButton, "Click to search products.");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(261, 415);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.clearButton, "Click to clear search.");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(398, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "&Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Click to exit form.");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // unitsButton
            // 
            this.unitsButton.Location = new System.Drawing.Point(12, 293);
            this.unitsButton.Name = "unitsButton";
            this.unitsButton.Size = new System.Drawing.Size(115, 23);
            this.unitsButton.TabIndex = 3;
            this.unitsButton.Text = "Find Units On Hand";
            this.toolTip1.SetToolTip(this.unitsButton, "Click to search products by units on hand.");
            this.unitsButton.UseVisualStyleBackColor = true;
            this.unitsButton.Click += new System.EventHandler(this.unitsButton_Click);
            // 
            // moreThanRadioButton
            // 
            this.moreThanRadioButton.AutoSize = true;
            this.moreThanRadioButton.Location = new System.Drawing.Point(71, 322);
            this.moreThanRadioButton.Name = "moreThanRadioButton";
            this.moreThanRadioButton.Size = new System.Drawing.Size(77, 17);
            this.moreThanRadioButton.TabIndex = 13;
            this.moreThanRadioButton.TabStop = true;
            this.moreThanRadioButton.Text = "More Than";
            this.moreThanRadioButton.UseVisualStyleBackColor = true;
            this.moreThanRadioButton.Visible = false;
            this.moreThanRadioButton.CheckedChanged += new System.EventHandler(this.moreThanRadioButton_CheckedChanged);
            // 
            // lessThanRadioButton
            // 
            this.lessThanRadioButton.AutoSize = true;
            this.lessThanRadioButton.Location = new System.Drawing.Point(314, 322);
            this.lessThanRadioButton.Name = "lessThanRadioButton";
            this.lessThanRadioButton.Size = new System.Drawing.Size(75, 17);
            this.lessThanRadioButton.TabIndex = 16;
            this.lessThanRadioButton.TabStop = true;
            this.lessThanRadioButton.Text = "Less Than";
            this.lessThanRadioButton.UseVisualStyleBackColor = true;
            this.lessThanRadioButton.Visible = false;
            this.lessThanRadioButton.CheckedChanged += new System.EventHandler(this.lessThanRadioButton_CheckedChanged);
            // 
            // moreNumTextBox
            // 
            this.moreNumTextBox.Location = new System.Drawing.Point(158, 319);
            this.moreNumTextBox.Name = "moreNumTextBox";
            this.moreNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.moreNumTextBox.TabIndex = 15;
            this.moreNumTextBox.Visible = false;
            // 
            // lessNumTextBox
            // 
            this.lessNumTextBox.Location = new System.Drawing.Point(398, 322);
            this.lessNumTextBox.Name = "lessNumTextBox";
            this.lessNumTextBox.Size = new System.Drawing.Size(108, 20);
            this.lessNumTextBox.TabIndex = 17;
            this.lessNumTextBox.Visible = false;
            // 
            // priceRangeButton
            // 
            this.priceRangeButton.Location = new System.Drawing.Point(12, 345);
            this.priceRangeButton.Name = "priceRangeButton";
            this.priceRangeButton.Size = new System.Drawing.Size(115, 23);
            this.priceRangeButton.TabIndex = 4;
            this.priceRangeButton.Text = "Find Price Range";
            this.toolTip1.SetToolTip(this.priceRangeButton, "Click to search products using a price range.");
            this.priceRangeButton.UseVisualStyleBackColor = true;
            this.priceRangeButton.Click += new System.EventHandler(this.priceRangeButton_Click);
            // 
            // maxPriceLabel
            // 
            this.maxPriceLabel.AutoSize = true;
            this.maxPriceLabel.Location = new System.Drawing.Point(90, 371);
            this.maxPriceLabel.Name = "maxPriceLabel";
            this.maxPriceLabel.Size = new System.Drawing.Size(54, 13);
            this.maxPriceLabel.TabIndex = 18;
            this.maxPriceLabel.Text = "Max Price";
            this.maxPriceLabel.Visible = false;
            // 
            // minPriceLabel
            // 
            this.minPriceLabel.AutoSize = true;
            this.minPriceLabel.Location = new System.Drawing.Point(335, 371);
            this.minPriceLabel.Name = "minPriceLabel";
            this.minPriceLabel.Size = new System.Drawing.Size(51, 13);
            this.minPriceLabel.TabIndex = 1;
            this.minPriceLabel.Text = "Min Price";
            this.minPriceLabel.Visible = false;
            // 
            // maxPriceTextBox
            // 
            this.maxPriceTextBox.Location = new System.Drawing.Point(158, 367);
            this.maxPriceTextBox.Name = "maxPriceTextBox";
            this.maxPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxPriceTextBox.TabIndex = 0;
            this.maxPriceTextBox.Visible = false;
            // 
            // minPriceTextBox
            // 
            this.minPriceTextBox.Location = new System.Drawing.Point(398, 368);
            this.minPriceTextBox.Name = "minPriceTextBox";
            this.minPriceTextBox.Size = new System.Drawing.Size(108, 20);
            this.minPriceTextBox.TabIndex = 2;
            this.minPriceTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.minPriceTextBox);
            this.Controls.Add(this.maxPriceTextBox);
            this.Controls.Add(this.minPriceLabel);
            this.Controls.Add(this.maxPriceLabel);
            this.Controls.Add(this.priceRangeButton);
            this.Controls.Add(this.lessNumTextBox);
            this.Controls.Add(this.moreNumTextBox);
            this.Controls.Add(this.lessThanRadioButton);
            this.Controls.Add(this.moreThanRadioButton);
            this.Controls.Add(this.unitsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(this.productDescriptionRadioButton);
            this.Controls.Add(this.productNumRadioButton);
            this.Controls.Add(this.productNumTextBox);
            this.Controls.Add(this.productButton);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.productBindingNavigator);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.TextBox productNumTextBox;
        private System.Windows.Forms.RadioButton productNumRadioButton;
        private System.Windows.Forms.RadioButton productDescriptionRadioButton;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button unitsButton;
        private System.Windows.Forms.RadioButton moreThanRadioButton;
        private System.Windows.Forms.RadioButton lessThanRadioButton;
        private System.Windows.Forms.TextBox moreNumTextBox;
        private System.Windows.Forms.TextBox lessNumTextBox;
        private System.Windows.Forms.Button priceRangeButton;
        private System.Windows.Forms.Label maxPriceLabel;
        private System.Windows.Forms.Label minPriceLabel;
        private System.Windows.Forms.TextBox maxPriceTextBox;
        private System.Windows.Forms.TextBox minPriceTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


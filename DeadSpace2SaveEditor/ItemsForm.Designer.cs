namespace DeadSpace2SaveEditor
{
    partial class ItemsForm
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
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpInventory = new System.Windows.Forms.TabPage();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.colInventorySlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInventoryName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colInventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcWeapons = new System.Windows.Forms.TabPage();
            this.dgvWeapons = new System.Windows.Forms.DataGridView();
            this.colWeaponsSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeaponsName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colWeaponsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpSafe = new System.Windows.Forms.TabPage();
            this.btnAddSuitsWeapons = new System.Windows.Forms.Button();
            this.dgvSafe = new System.Windows.Forms.DataGridView();
            this.colSafeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSafeName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSafeQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpShop = new System.Windows.Forms.TabPage();
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.colShopName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.tcTabs.SuspendLayout();
            this.tpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.tcWeapons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeapons)).BeginInit();
            this.tpSafe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSafe)).BeginInit();
            this.tpShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTabs
            // 
            this.tcTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTabs.Controls.Add(this.tpInventory);
            this.tcTabs.Controls.Add(this.tcWeapons);
            this.tcTabs.Controls.Add(this.tpSafe);
            this.tcTabs.Controls.Add(this.tpShop);
            this.tcTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(684, 531);
            this.tcTabs.TabIndex = 0;
            // 
            // tpInventory
            // 
            this.tpInventory.Controls.Add(this.dgvInventory);
            this.tpInventory.Location = new System.Drawing.Point(4, 27);
            this.tpInventory.Name = "tpInventory";
            this.tpInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tpInventory.Size = new System.Drawing.Size(676, 500);
            this.tpInventory.TabIndex = 0;
            this.tpInventory.Text = "Inventory";
            this.tpInventory.UseVisualStyleBackColor = true;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInventorySlot,
            this.colInventoryName,
            this.colInventoryQuantity});
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.Location = new System.Drawing.Point(3, 3);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvInventory.RowTemplate.Height = 25;
            this.dgvInventory.Size = new System.Drawing.Size(670, 494);
            this.dgvInventory.TabIndex = 0;
            this.dgvInventory.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvInventory_DefaultValuesNeeded);
            // 
            // colInventorySlot
            // 
            this.colInventorySlot.HeaderText = "Slot";
            this.colInventorySlot.MinimumWidth = 40;
            this.colInventorySlot.Name = "colInventorySlot";
            this.colInventorySlot.ReadOnly = true;
            this.colInventorySlot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colInventorySlot.Width = 40;
            // 
            // colInventoryName
            // 
            this.colInventoryName.HeaderText = "Name";
            this.colInventoryName.MinimumWidth = 250;
            this.colInventoryName.Name = "colInventoryName";
            this.colInventoryName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInventoryName.Width = 250;
            // 
            // colInventoryQuantity
            // 
            this.colInventoryQuantity.HeaderText = "Quantity";
            this.colInventoryQuantity.MinimumWidth = 70;
            this.colInventoryQuantity.Name = "colInventoryQuantity";
            this.colInventoryQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colInventoryQuantity.Width = 70;
            // 
            // tcWeapons
            // 
            this.tcWeapons.Controls.Add(this.dgvWeapons);
            this.tcWeapons.Location = new System.Drawing.Point(4, 27);
            this.tcWeapons.Name = "tcWeapons";
            this.tcWeapons.Padding = new System.Windows.Forms.Padding(3);
            this.tcWeapons.Size = new System.Drawing.Size(676, 500);
            this.tcWeapons.TabIndex = 3;
            this.tcWeapons.Text = "Weapons";
            this.tcWeapons.UseVisualStyleBackColor = true;
            // 
            // dgvWeapons
            // 
            this.dgvWeapons.AllowUserToAddRows = false;
            this.dgvWeapons.AllowUserToDeleteRows = false;
            this.dgvWeapons.AllowUserToResizeRows = false;
            this.dgvWeapons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvWeapons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWeapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeapons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWeaponsSlot,
            this.colWeaponsName,
            this.colWeaponsQuantity});
            this.dgvWeapons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWeapons.Location = new System.Drawing.Point(3, 3);
            this.dgvWeapons.Name = "dgvWeapons";
            this.dgvWeapons.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvWeapons.RowTemplate.Height = 25;
            this.dgvWeapons.Size = new System.Drawing.Size(670, 494);
            this.dgvWeapons.TabIndex = 0;
            // 
            // colWeaponsSlot
            // 
            this.colWeaponsSlot.HeaderText = "Slot";
            this.colWeaponsSlot.MinimumWidth = 40;
            this.colWeaponsSlot.Name = "colWeaponsSlot";
            this.colWeaponsSlot.ReadOnly = true;
            this.colWeaponsSlot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colWeaponsSlot.Width = 40;
            // 
            // colWeaponsName
            // 
            this.colWeaponsName.HeaderText = "Name";
            this.colWeaponsName.MinimumWidth = 250;
            this.colWeaponsName.Name = "colWeaponsName";
            this.colWeaponsName.Width = 250;
            // 
            // colWeaponsQuantity
            // 
            this.colWeaponsQuantity.HeaderText = "Ammo";
            this.colWeaponsQuantity.MinimumWidth = 70;
            this.colWeaponsQuantity.Name = "colWeaponsQuantity";
            this.colWeaponsQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colWeaponsQuantity.Width = 70;
            // 
            // tpSafe
            // 
            this.tpSafe.Controls.Add(this.btnAddSuitsWeapons);
            this.tpSafe.Controls.Add(this.dgvSafe);
            this.tpSafe.Location = new System.Drawing.Point(4, 27);
            this.tpSafe.Name = "tpSafe";
            this.tpSafe.Padding = new System.Windows.Forms.Padding(3);
            this.tpSafe.Size = new System.Drawing.Size(676, 500);
            this.tpSafe.TabIndex = 1;
            this.tpSafe.Text = "Safe";
            this.tpSafe.UseVisualStyleBackColor = true;
            // 
            // btnAddSuitsWeapons
            // 
            this.btnAddSuitsWeapons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddSuitsWeapons.ForeColor = System.Drawing.Color.Crimson;
            this.btnAddSuitsWeapons.Location = new System.Drawing.Point(6, 466);
            this.btnAddSuitsWeapons.Name = "btnAddSuitsWeapons";
            this.btnAddSuitsWeapons.Size = new System.Drawing.Size(190, 28);
            this.btnAddSuitsWeapons.TabIndex = 1;
            this.btnAddSuitsWeapons.Text = "Add Every Suit && Weapon";
            this.btnAddSuitsWeapons.UseVisualStyleBackColor = true;
            this.btnAddSuitsWeapons.Click += new System.EventHandler(this.btnAddSuitsWeapons_Click);
            // 
            // dgvSafe
            // 
            this.dgvSafe.AllowUserToResizeRows = false;
            this.dgvSafe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSafe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSafe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSafe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSafe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSafeSlot,
            this.colSafeName,
            this.colSafeQuantity});
            this.dgvSafe.Location = new System.Drawing.Point(3, 3);
            this.dgvSafe.Name = "dgvSafe";
            this.dgvSafe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSafe.RowTemplate.Height = 25;
            this.dgvSafe.Size = new System.Drawing.Size(670, 457);
            this.dgvSafe.TabIndex = 0;
            this.dgvSafe.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvSafe_DefaultValuesNeeded);
            // 
            // colSafeSlot
            // 
            this.colSafeSlot.HeaderText = "Slot";
            this.colSafeSlot.MinimumWidth = 40;
            this.colSafeSlot.Name = "colSafeSlot";
            this.colSafeSlot.ReadOnly = true;
            this.colSafeSlot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSafeSlot.Width = 40;
            // 
            // colSafeName
            // 
            this.colSafeName.HeaderText = "Name";
            this.colSafeName.MinimumWidth = 250;
            this.colSafeName.Name = "colSafeName";
            this.colSafeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSafeName.Width = 250;
            // 
            // colSafeQuantity
            // 
            this.colSafeQuantity.HeaderText = "Quantity";
            this.colSafeQuantity.MinimumWidth = 70;
            this.colSafeQuantity.Name = "colSafeQuantity";
            this.colSafeQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSafeQuantity.Width = 70;
            // 
            // tpShop
            // 
            this.tpShop.Controls.Add(this.dgvShop);
            this.tpShop.Location = new System.Drawing.Point(4, 27);
            this.tpShop.Name = "tpShop";
            this.tpShop.Padding = new System.Windows.Forms.Padding(3);
            this.tpShop.Size = new System.Drawing.Size(676, 500);
            this.tpShop.TabIndex = 2;
            this.tpShop.Text = "Shop";
            this.tpShop.UseVisualStyleBackColor = true;
            // 
            // dgvShop
            // 
            this.dgvShop.AllowUserToResizeRows = false;
            this.dgvShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShopName});
            this.dgvShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShop.Location = new System.Drawing.Point(3, 3);
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvShop.RowTemplate.Height = 25;
            this.dgvShop.Size = new System.Drawing.Size(670, 494);
            this.dgvShop.TabIndex = 0;
            this.dgvShop.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvShop_DefaultValuesNeeded);
            // 
            // colShopName
            // 
            this.colShopName.HeaderText = "Name";
            this.colShopName.MinimumWidth = 250;
            this.colShopName.Name = "colShopName";
            this.colShopName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colShopName.Width = 250;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(597, 537);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.Location = new System.Drawing.Point(516, 537);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 28);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ItemsForm
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(684, 577);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tcTabs);
            this.MinimizeBox = false;
            this.Name = "ItemsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Items Editor";
            this.tcTabs.ResumeLayout(false);
            this.tpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.tcWeapons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeapons)).EndInit();
            this.tpSafe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSafe)).EndInit();
            this.tpShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tpInventory;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TabPage tpSafe;
        private System.Windows.Forms.TabPage tpShop;
        private System.Windows.Forms.DataGridView dgvSafe;
        private System.Windows.Forms.DataGridView dgvShop;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TabPage tcWeapons;
        private System.Windows.Forms.DataGridView dgvWeapons;
        private System.Windows.Forms.DataGridViewComboBoxColumn colShopName;
        private System.Windows.Forms.Button btnAddSuitsWeapons;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInventorySlot;
        private System.Windows.Forms.DataGridViewComboBoxColumn colInventoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInventoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeaponsSlot;
        private System.Windows.Forms.DataGridViewComboBoxColumn colWeaponsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeaponsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSafeSlot;
        private System.Windows.Forms.DataGridViewComboBoxColumn colSafeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSafeQuantity;
    }
}
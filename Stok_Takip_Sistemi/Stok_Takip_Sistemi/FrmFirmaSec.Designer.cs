namespace Stok_Takip_Sistemi
{
    partial class FrmFirmaSec
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
            this.gridControlfirmasec = new DevExpress.XtraGrid.GridControl();
            this.stokveritabaniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_veritabaniDataSet = new Stok_Takip_Sistemi.stok_veritabaniDataSet();
            this.gridViewfirmasec = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlfirmasec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokveritabaniDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_veritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewfirmasec)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlfirmasec
            // 
            this.gridControlfirmasec.DataSource = this.stokveritabaniDataSetBindingSource;
            this.gridControlfirmasec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlfirmasec.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlfirmasec.Location = new System.Drawing.Point(0, 0);
            this.gridControlfirmasec.MainView = this.gridViewfirmasec;
            this.gridControlfirmasec.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlfirmasec.Name = "gridControlfirmasec";
            this.gridControlfirmasec.Size = new System.Drawing.Size(444, 386);
            this.gridControlfirmasec.TabIndex = 0;
            this.gridControlfirmasec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewfirmasec});
            // 
            // stokveritabaniDataSetBindingSource
            // 
            this.stokveritabaniDataSetBindingSource.DataSource = this.stok_veritabaniDataSet;
            this.stokveritabaniDataSetBindingSource.Position = 0;
            // 
            // stok_veritabaniDataSet
            // 
            this.stok_veritabaniDataSet.DataSetName = "stok_veritabaniDataSet";
            this.stok_veritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewfirmasec
            // 
            this.gridViewfirmasec.DetailHeight = 431;
            this.gridViewfirmasec.GridControl = this.gridControlfirmasec;
            this.gridViewfirmasec.Name = "gridViewfirmasec";
            this.gridViewfirmasec.OptionsView.ShowGroupPanel = false;
//            this.gridViewfirmasec.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridViewfirmasec_FocusedRowObjectChanged);
            // 
            // FrmFirmaSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 386);
            this.Controls.Add(this.gridControlfirmasec);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFirmaSec";
            this.Text = "Firma Seçiniz";
            this.Load += new System.EventHandler(this.FrmFirmaSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlfirmasec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokveritabaniDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_veritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewfirmasec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlfirmasec;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewfirmasec;
        private System.Windows.Forms.BindingSource stokveritabaniDataSetBindingSource;
        private stok_veritabaniDataSet stok_veritabaniDataSet;
    }
}
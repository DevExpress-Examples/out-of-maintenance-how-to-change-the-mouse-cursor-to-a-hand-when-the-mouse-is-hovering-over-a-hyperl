using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace WindowsApplication7
{
  /// <summary>
  /// Summary description for Form1.
  /// </summary>
  public class Form1 : System.Windows.Forms.Form
  {
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colCyl;
        private DevExpress.XtraGrid.Columns.GridColumn colHP;
        private DevExpress.XtraGrid.Columns.GridColumn colHyperlink;
        private DevExpress.XtraGrid.Columns.GridColumn colLiter;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTrademark;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
      private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
      private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
      private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
      private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
      private System.Data.OleDb.OleDbConnection oleDbConnection1;
      private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
      private WindowsApplication7.DataSet1 dataSet11;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    public Form1()
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      //
      // TODO: Add any constructor code after InitializeComponent call
      //
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if (components != null) 
        {
          components.Dispose();
        }
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        this.gridControl1 = new DevExpress.XtraGrid.GridControl();
        this.dataSet11 = new WindowsApplication7.DataSet1();
        this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
        this.colTrademark = new DevExpress.XtraGrid.Columns.GridColumn();
        this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
        this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
        this.colHyperlink = new DevExpress.XtraGrid.Columns.GridColumn();
        this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
        this.colCyl = new DevExpress.XtraGrid.Columns.GridColumn();
        this.colHP = new DevExpress.XtraGrid.Columns.GridColumn();
        this.colLiter = new DevExpress.XtraGrid.Columns.GridColumn();
        this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
        this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
        this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
        this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
        this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
        this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
        this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
        ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
        this.SuspendLayout();
        // 
        // gridControl1
        // 
        this.gridControl1.DataSource = this.dataSet11.Cars;
        this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.gridControl1.EmbeddedNavigator.Name = "";
        this.gridControl1.Location = new System.Drawing.Point(0, 0);
        this.gridControl1.MainView = this.gridView1;
        this.gridControl1.Name = "gridControl1";
        this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
        this.gridControl1.Size = new System.Drawing.Size(696, 422);
        this.gridControl1.TabIndex = 0;
        this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
        this.gridControl1.MouseLeave += new System.EventHandler(this.gridControl1_MouseLeave);
        // 
        // dataSet11
        // 
        this.dataSet11.DataSetName = "DataSet1";
        this.dataSet11.Locale = new System.Globalization.CultureInfo("en-NZ");
        this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // gridView1
        // 
        this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrademark,
            this.colModel,
            this.colCategory,
            this.colHyperlink,
            this.colCyl,
            this.colHP,
            this.colLiter,
            this.colPrice});
        this.gridView1.GridControl = this.gridControl1;
        this.gridView1.Name = "gridView1";
        this.gridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseMove);
        // 
        // colTrademark
        // 
        this.colTrademark.Caption = "Trademark";
        this.colTrademark.FieldName = "Trademark";
        this.colTrademark.Name = "colTrademark";
        this.colTrademark.Visible = true;
        this.colTrademark.VisibleIndex = 7;
        // 
        // colModel
        // 
        this.colModel.Caption = "Model";
        this.colModel.FieldName = "Model";
        this.colModel.Name = "colModel";
        this.colModel.Visible = true;
        this.colModel.VisibleIndex = 5;
        // 
        // colCategory
        // 
        this.colCategory.Caption = "Category";
        this.colCategory.FieldName = "Category";
        this.colCategory.Name = "colCategory";
        this.colCategory.Visible = true;
        this.colCategory.VisibleIndex = 0;
        // 
        // colHyperlink
        // 
        this.colHyperlink.Caption = "Hyperlink";
        this.colHyperlink.ColumnEdit = this.repositoryItemHyperLinkEdit1;
        this.colHyperlink.FieldName = "Hyperlink";
        this.colHyperlink.Name = "colHyperlink";
        this.colHyperlink.Visible = true;
        this.colHyperlink.VisibleIndex = 3;
        // 
        // repositoryItemHyperLinkEdit1
        // 
        this.repositoryItemHyperLinkEdit1.AutoHeight = false;
        this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
        // 
        // colCyl
        // 
        this.colCyl.Caption = "Cyl";
        this.colCyl.FieldName = "Cyl";
        this.colCyl.Name = "colCyl";
        this.colCyl.Visible = true;
        this.colCyl.VisibleIndex = 1;
        // 
        // colHP
        // 
        this.colHP.Caption = "HP";
        this.colHP.FieldName = "HP";
        this.colHP.Name = "colHP";
        this.colHP.Visible = true;
        this.colHP.VisibleIndex = 2;
        // 
        // colLiter
        // 
        this.colLiter.Caption = "Liter";
        this.colLiter.FieldName = "Liter";
        this.colLiter.Name = "colLiter";
        this.colLiter.Visible = true;
        this.colLiter.VisibleIndex = 4;
        // 
        // colPrice
        // 
        this.colPrice.Caption = "Price";
        this.colPrice.FieldName = "Price";
        this.colPrice.Name = "colPrice";
        this.colPrice.Visible = true;
        this.colPrice.VisibleIndex = 6;
        // 
        // oleDbSelectCommand1
        // 
        this.oleDbSelectCommand1.CommandText = "SELECT Category, Cyl, Description, HP, Hyperlink, ID, Liter, Model, MPG_City, MPG" +
            "_Highway, Picture, Price, Trademark, TransmissAutomatic, TransmissSpeedCount FRO" +
            "M Cars";
        this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
        // 
        // oleDbConnection1
        // 
        this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
        // 
        // oleDbInsertCommand1
        // 
        this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
        this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
        this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Category", System.Data.OleDb.OleDbType.VarWChar, 7, "Category"),
            new System.Data.OleDb.OleDbParameter("Cyl", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Cyl"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("HP", System.Data.OleDb.OleDbType.SmallInt, 0, "HP"),
            new System.Data.OleDb.OleDbParameter("Hyperlink", System.Data.OleDb.OleDbType.VarWChar, 50, "Hyperlink"),
            new System.Data.OleDb.OleDbParameter("Liter", System.Data.OleDb.OleDbType.Double, 0, "Liter"),
            new System.Data.OleDb.OleDbParameter("Model", System.Data.OleDb.OleDbType.VarWChar, 50, "Model"),
            new System.Data.OleDb.OleDbParameter("MPG_City", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "MPG_City"),
            new System.Data.OleDb.OleDbParameter("MPG_Highway", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "MPG_Highway"),
            new System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.VarBinary, 0, "Picture"),
            new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"),
            new System.Data.OleDb.OleDbParameter("Trademark", System.Data.OleDb.OleDbType.VarWChar, 50, "Trademark"),
            new System.Data.OleDb.OleDbParameter("TransmissAutomatic", System.Data.OleDb.OleDbType.VarWChar, 3, "TransmissAutomatic"),
            new System.Data.OleDb.OleDbParameter("TransmissSpeedCount", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "TransmissSpeedCount")});
        // 
        // oleDbUpdateCommand1
        // 
        this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
        this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
        this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Category", System.Data.OleDb.OleDbType.VarWChar, 7, "Category"),
            new System.Data.OleDb.OleDbParameter("Cyl", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Cyl"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("HP", System.Data.OleDb.OleDbType.SmallInt, 0, "HP"),
            new System.Data.OleDb.OleDbParameter("Hyperlink", System.Data.OleDb.OleDbType.VarWChar, 50, "Hyperlink"),
            new System.Data.OleDb.OleDbParameter("Liter", System.Data.OleDb.OleDbType.Double, 0, "Liter"),
            new System.Data.OleDb.OleDbParameter("Model", System.Data.OleDb.OleDbType.VarWChar, 50, "Model"),
            new System.Data.OleDb.OleDbParameter("MPG_City", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "MPG_City"),
            new System.Data.OleDb.OleDbParameter("MPG_Highway", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "MPG_Highway"),
            new System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.VarBinary, 0, "Picture"),
            new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"),
            new System.Data.OleDb.OleDbParameter("Trademark", System.Data.OleDb.OleDbType.VarWChar, 50, "Trademark"),
            new System.Data.OleDb.OleDbParameter("TransmissAutomatic", System.Data.OleDb.OleDbType.VarWChar, 3, "TransmissAutomatic"),
            new System.Data.OleDb.OleDbParameter("TransmissSpeedCount", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "TransmissSpeedCount"),
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Category", System.Data.OleDb.OleDbType.VarWChar, 7, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Category", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Category1", System.Data.OleDb.OleDbType.VarWChar, 7, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Category", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cyl", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cyl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cyl1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cyl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_HP", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HP", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_HP1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HP", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Hyperlink", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hyperlink", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Hyperlink1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hyperlink", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Liter", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Liter", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Liter1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Liter", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_MPG_City", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MPG_City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_MPG_City1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MPG_City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_MPG_Highway", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MPG_Highway", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_MPG_Highway1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MPG_Highway", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Model", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Model", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Model1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Model", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Price1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Trademark", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Trademark", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Trademark1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Trademark", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_TransmissAutomatic", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TransmissAutomatic", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_TransmissAutomatic1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TransmissAutomatic", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_TransmissSpeedCount", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TransmissSpeedCount", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_TransmissSpeedCount1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TransmissSpeedCount", System.Data.DataRowVersion.Original, null)});
        // 
        // oleDbDeleteCommand1
        // 
        this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
        this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
        this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Category", System.Data.OleDb.OleDbType.VarWChar, 7, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Category", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Category1", System.Data.OleDb.OleDbType.VarWChar, 7, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Category", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cyl", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cyl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cyl1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cyl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_HP", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HP", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_HP1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HP", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Hyperlink", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hyperlink", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Hyperlink1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hyperlink", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Liter", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Liter", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Liter1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Liter", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_MPG_City", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MPG_City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_MPG_City1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MPG_City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_MPG_Highway", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MPG_Highway", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_MPG_Highway1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MPG_Highway", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Model", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Model", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Model1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Model", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Price1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Price", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Trademark", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Trademark", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Trademark1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Trademark", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_TransmissAutomatic", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TransmissAutomatic", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_TransmissAutomatic1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TransmissAutomatic", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_TransmissSpeedCount", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TransmissSpeedCount", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_TransmissSpeedCount1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TransmissSpeedCount", System.Data.DataRowVersion.Original, null)});
        // 
        // oleDbDataAdapter1
        // 
        this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
        this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
        this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
        this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Cars", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Category", "Category"),
                        new System.Data.Common.DataColumnMapping("Cyl", "Cyl"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("HP", "HP"),
                        new System.Data.Common.DataColumnMapping("Hyperlink", "Hyperlink"),
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Liter", "Liter"),
                        new System.Data.Common.DataColumnMapping("Model", "Model"),
                        new System.Data.Common.DataColumnMapping("MPG_City", "MPG_City"),
                        new System.Data.Common.DataColumnMapping("MPG_Highway", "MPG_Highway"),
                        new System.Data.Common.DataColumnMapping("Picture", "Picture"),
                        new System.Data.Common.DataColumnMapping("Price", "Price"),
                        new System.Data.Common.DataColumnMapping("Trademark", "Trademark"),
                        new System.Data.Common.DataColumnMapping("TransmissAutomatic", "TransmissAutomatic"),
                        new System.Data.Common.DataColumnMapping("TransmissSpeedCount", "TransmissSpeedCount")})});
        this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
        // 
        // Form1
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.ClientSize = new System.Drawing.Size(696, 422);
        this.Controls.Add(this.gridControl1);
        this.Name = "Form1";
        this.Text = "Form1";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
        this.ResumeLayout(false);

    }
    #endregion

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() 
    {
      Application.Run(new Form1());
    }

        private void Form1_Load(object sender, System.EventArgs e) {
            oleDbDataAdapter1.Fill(dataSet11);
        }

        private void gridView1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            GridHitInfo hi = (sender as GridView).CalcHitInfo(new Point(e.X, e.Y));
            if (hi.InRowCell && hi.Column.ColumnEdit is DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit) {
                Cursor = System.Windows.Forms.Cursors.Hand;
            }
            else
                Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void gridControl1_MouseLeave(object sender, System.EventArgs e) {
            Cursor = System.Windows.Forms.Cursors.Default;
        }

    }
}

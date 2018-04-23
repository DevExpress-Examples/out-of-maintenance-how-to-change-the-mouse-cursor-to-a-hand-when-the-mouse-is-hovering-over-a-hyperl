Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace WindowsApplication7
  ''' <summary>
  ''' Summary description for Form1.
  ''' </summary>
  Public Class Form1
	  Inherits System.Windows.Forms.Form
		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCategory As DevExpress.XtraGrid.Columns.GridColumn
		Private colCyl As DevExpress.XtraGrid.Columns.GridColumn
		Private colHP As DevExpress.XtraGrid.Columns.GridColumn
		Private colHyperlink As DevExpress.XtraGrid.Columns.GridColumn
		Private colLiter As DevExpress.XtraGrid.Columns.GridColumn
		Private colModel As DevExpress.XtraGrid.Columns.GridColumn
		Private colPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colTrademark As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
	  Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
	  Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
	  Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
	  Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
	  Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
	  Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
	  Private dataSet11 As WindowsApplication7.DataSet1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.Container = Nothing

	Public Sub New()
	  '
	  ' Required for Windows Form Designer support
	  '
	  InitializeComponent()

	  '
	  ' TODO: Add any constructor code after InitializeComponent call
	  '
	End Sub

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
	  If disposing Then
		If components IsNot Nothing Then
		  components.Dispose()
		End If
	  End If
	  MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"
	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
		Me.dataSet11 = New WindowsApplication7.DataSet1()
		Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHyperlink = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.repositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
		Me.colCyl = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colHP = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colLiter = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
		Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
		Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
		Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
		Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
		Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
		CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' gridControl1
		' 
		Me.gridControl1.DataSource = Me.dataSet11.Cars
		Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.gridControl1.EmbeddedNavigator.Name = ""
		Me.gridControl1.Location = New System.Drawing.Point(0, 0)
		Me.gridControl1.MainView = Me.gridView1
		Me.gridControl1.Name = "gridControl1"
		Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemHyperLinkEdit1})
		Me.gridControl1.Size = New System.Drawing.Size(696, 422)
		Me.gridControl1.TabIndex = 0
		Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
'		Me.gridControl1.MouseLeave += New System.EventHandler(Me.gridControl1_MouseLeave);
		' 
		' dataSet11
		' 
		Me.dataSet11.DataSetName = "DataSet1"
		Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-NZ")
		Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		' 
		' gridView1
		' 
		Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colTrademark, Me.colModel, Me.colCategory, Me.colHyperlink, Me.colCyl, Me.colHP, Me.colLiter, Me.colPrice})
		Me.gridView1.GridControl = Me.gridControl1
		Me.gridView1.Name = "gridView1"
'		Me.gridView1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.gridView1_MouseMove);
		' 
		' colTrademark
		' 
		Me.colTrademark.Caption = "Trademark"
		Me.colTrademark.FieldName = "Trademark"
		Me.colTrademark.Name = "colTrademark"
		Me.colTrademark.Visible = True
		Me.colTrademark.VisibleIndex = 7
		' 
		' colModel
		' 
		Me.colModel.Caption = "Model"
		Me.colModel.FieldName = "Model"
		Me.colModel.Name = "colModel"
		Me.colModel.Visible = True
		Me.colModel.VisibleIndex = 5
		' 
		' colCategory
		' 
		Me.colCategory.Caption = "Category"
		Me.colCategory.FieldName = "Category"
		Me.colCategory.Name = "colCategory"
		Me.colCategory.Visible = True
		Me.colCategory.VisibleIndex = 0
		' 
		' colHyperlink
		' 
		Me.colHyperlink.Caption = "Hyperlink"
		Me.colHyperlink.ColumnEdit = Me.repositoryItemHyperLinkEdit1
		Me.colHyperlink.FieldName = "Hyperlink"
		Me.colHyperlink.Name = "colHyperlink"
		Me.colHyperlink.Visible = True
		Me.colHyperlink.VisibleIndex = 3
		' 
		' repositoryItemHyperLinkEdit1
		' 
		Me.repositoryItemHyperLinkEdit1.AutoHeight = False
		Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
		' 
		' colCyl
		' 
		Me.colCyl.Caption = "Cyl"
		Me.colCyl.FieldName = "Cyl"
		Me.colCyl.Name = "colCyl"
		Me.colCyl.Visible = True
		Me.colCyl.VisibleIndex = 1
		' 
		' colHP
		' 
		Me.colHP.Caption = "HP"
		Me.colHP.FieldName = "HP"
		Me.colHP.Name = "colHP"
		Me.colHP.Visible = True
		Me.colHP.VisibleIndex = 2
		' 
		' colLiter
		' 
		Me.colLiter.Caption = "Liter"
		Me.colLiter.FieldName = "Liter"
		Me.colLiter.Name = "colLiter"
		Me.colLiter.Visible = True
		Me.colLiter.VisibleIndex = 4
		' 
		' colPrice
		' 
		Me.colPrice.Caption = "Price"
		Me.colPrice.FieldName = "Price"
		Me.colPrice.Name = "colPrice"
		Me.colPrice.Visible = True
		Me.colPrice.VisibleIndex = 6
		' 
		' oleDbSelectCommand1
		' 
		Me.oleDbSelectCommand1.CommandText = "SELECT Category, Cyl, Description, HP, Hyperlink, ID, Liter, Model, MPG_City, MPG" & "_Highway, Picture, Price, Trademark, TransmissAutomatic, TransmissSpeedCount FRO" & "M Cars"
		Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
		' 
		' oleDbConnection1
		' 
		Me.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString")
		' 
		' oleDbInsertCommand1
		' 
		Me.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText")
		Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
		Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Category", System.Data.OleDb.OleDbType.VarWChar, 7, "Category"), New System.Data.OleDb.OleDbParameter("Cyl", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Cyl"), New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"), New System.Data.OleDb.OleDbParameter("HP", System.Data.OleDb.OleDbType.SmallInt, 0, "HP"), New System.Data.OleDb.OleDbParameter("Hyperlink", System.Data.OleDb.OleDbType.VarWChar, 50, "Hyperlink"), New System.Data.OleDb.OleDbParameter("Liter", System.Data.OleDb.OleDbType.Double, 0, "Liter"), New System.Data.OleDb.OleDbParameter("Model", System.Data.OleDb.OleDbType.VarWChar, 50, "Model"), New System.Data.OleDb.OleDbParameter("MPG_City", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "MPG_City"), New System.Data.OleDb.OleDbParameter("MPG_Highway", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "MPG_Highway"), New System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.VarBinary, 0, "Picture"), New System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"), New System.Data.OleDb.OleDbParameter("Trademark", System.Data.OleDb.OleDbType.VarWChar, 50, "Trademark"), New System.Data.OleDb.OleDbParameter("TransmissAutomatic", System.Data.OleDb.OleDbType.VarWChar, 3, "TransmissAutomatic"), New System.Data.OleDb.OleDbParameter("TransmissSpeedCount", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "TransmissSpeedCount")})
		' 
		' oleDbUpdateCommand1
		' 
		Me.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText")
		Me.oleDbUpdateCommand1.Connection = Me.oleDbConnection1
		Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Category", System.Data.OleDb.OleDbType.VarWChar, 7, "Category"), New System.Data.OleDb.OleDbParameter("Cyl", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Cyl"), New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"), New System.Data.OleDb.OleDbParameter("HP", System.Data.OleDb.OleDbType.SmallInt, 0, "HP"), New System.Data.OleDb.OleDbParameter("Hyperlink", System.Data.OleDb.OleDbType.VarWChar, 50, "Hyperlink"), New System.Data.OleDb.OleDbParameter("Liter", System.Data.OleDb.OleDbType.Double, 0, "Liter"), New System.Data.OleDb.OleDbParameter("Model", System.Data.OleDb.OleDbType.VarWChar, 50, "Model"), New System.Data.OleDb.OleDbParameter("MPG_City", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "MPG_City"), New System.Data.OleDb.OleDbParameter("MPG_Highway", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "MPG_Highway"), New System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.VarBinary, 0, "Picture"), New System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"), New System.Data.OleDb.OleDbParameter("Trademark", System.Data.OleDb.OleDbType.VarWChar, 50, "Trademark"), New System.Data.OleDb.OleDbParameter("TransmissAutomatic", System.Data.OleDb.OleDbType.VarWChar, 3, "TransmissAutomatic"), New System.Data.OleDb.OleDbParameter("TransmissSpeedCount", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "TransmissSpeedCount"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Category", System.Data.OleDb.OleDbType.VarWChar, 7, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Category", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Category1", System.Data.OleDb.OleDbType.VarWChar, 7, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Category", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Cyl", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Cyl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Cyl1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Cyl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HP", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HP1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Hyperlink", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Hyperlink", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Hyperlink1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Hyperlink", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Liter", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Liter", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Liter1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Liter", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MPG_City", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "MPG_City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MPG_City1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "MPG_City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MPG_Highway", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "MPG_Highway", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MPG_Highway1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "MPG_Highway", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Model", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Model", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Model1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Model", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Price", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Price1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Price", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Trademark", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Trademark", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Trademark1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Trademark", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TransmissAutomatic", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TransmissAutomatic", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TransmissAutomatic1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TransmissAutomatic", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TransmissSpeedCount", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TransmissSpeedCount", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TransmissSpeedCount1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TransmissSpeedCount", System.Data.DataRowVersion.Original, Nothing)})
		' 
		' oleDbDeleteCommand1
		' 
		Me.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText")
		Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
		Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Category", System.Data.OleDb.OleDbType.VarWChar, 7, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Category", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Category1", System.Data.OleDb.OleDbType.VarWChar, 7, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Category", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Cyl", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Cyl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Cyl1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Cyl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HP", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HP1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Hyperlink", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Hyperlink", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Hyperlink1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Hyperlink", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Liter", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Liter", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Liter1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Liter", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MPG_City", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "MPG_City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MPG_City1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "MPG_City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MPG_Highway", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "MPG_Highway", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MPG_Highway1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "MPG_Highway", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Model", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Model", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Model1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Model", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Price", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Price1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Price", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Trademark", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Trademark", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Trademark1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Trademark", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TransmissAutomatic", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TransmissAutomatic", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TransmissAutomatic1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TransmissAutomatic", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TransmissSpeedCount", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TransmissSpeedCount", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TransmissSpeedCount1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TransmissSpeedCount", System.Data.DataRowVersion.Original, Nothing)})
		' 
		' oleDbDataAdapter1
		' 
		Me.oleDbDataAdapter1.DeleteCommand = Me.oleDbDeleteCommand1
		Me.oleDbDataAdapter1.InsertCommand = Me.oleDbInsertCommand1
		Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
		Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Cars", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("Category", "Category"), New System.Data.Common.DataColumnMapping("Cyl", "Cyl"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("HP", "HP"), New System.Data.Common.DataColumnMapping("Hyperlink", "Hyperlink"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Liter", "Liter"), New System.Data.Common.DataColumnMapping("Model", "Model"), New System.Data.Common.DataColumnMapping("MPG_City", "MPG_City"), New System.Data.Common.DataColumnMapping("MPG_Highway", "MPG_Highway"), New System.Data.Common.DataColumnMapping("Picture", "Picture"), New System.Data.Common.DataColumnMapping("Price", "Price"), New System.Data.Common.DataColumnMapping("Trademark", "Trademark"), New System.Data.Common.DataColumnMapping("TransmissAutomatic", "TransmissAutomatic"), New System.Data.Common.DataColumnMapping("TransmissSpeedCount", "TransmissSpeedCount")})})
		Me.oleDbDataAdapter1.UpdateCommand = Me.oleDbUpdateCommand1
		' 
		' Form1
		' 
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(696, 422)
		Me.Controls.Add(Me.gridControl1)
		Me.Name = "Form1"
		Me.Text = "Form1"
'		Me.Load += New System.EventHandler(Me.Form1_Load);
		CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	#End Region

	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	<STAThread> _
	Shared Sub Main()
	  Application.Run(New Form1())
	End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			oleDbDataAdapter1.Fill(dataSet11)
		End Sub

		Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView1.MouseMove
			Dim hi As GridHitInfo = (TryCast(sender, GridView)).CalcHitInfo(New Point(e.X, e.Y))
			If hi.InRowCell AndAlso TypeOf hi.Column.ColumnEdit Is DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Then
				Cursor = System.Windows.Forms.Cursors.Hand
			Else
				Cursor = System.Windows.Forms.Cursors.Default
			End If
		End Sub

		Private Sub gridControl1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridControl1.MouseLeave
			Cursor = System.Windows.Forms.Cursors.Default
		End Sub

  End Class
End Namespace

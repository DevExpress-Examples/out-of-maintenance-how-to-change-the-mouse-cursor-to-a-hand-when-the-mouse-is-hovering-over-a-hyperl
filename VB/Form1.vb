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
		Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit

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
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.repositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemHyperLinkEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(696, 422)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.gridControl1.MouseLeave += new System.EventHandler(this.gridControl1_MouseLeave);
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.gridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseMove);
			' 
			' repositoryItemHyperLinkEdit1
			' 
			Me.repositoryItemHyperLinkEdit1.AutoHeight = False
			Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
			' 
			' oleDbInsertCommand1
			' 

			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(696, 422)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

	End Sub
	#End Region

	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	<STAThread>
	Shared Sub Main()
	  Application.Run(New Form1())
	End Sub

		Private Function CreateTable() As DataTable
			Dim table As New DataTable()
			Dim dataRow As DataRow

			table.Columns.Add("Prod_NO", GetType(String))
			table.Columns.Add("Prod_Name", GetType(String))
			table.Columns.Add("Order_Date", GetType(String))
			table.Columns.Add("Quantity", GetType(String))

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "101"
			dataRow("Prod_Name") = "Product1"
			dataRow("Order_Date") = "12/06/2012"
			dataRow("Quantity") = "50"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "102"
			dataRow("Prod_Name") = "Product2"
			dataRow("Order_Date") = "15/06/2012"
			dataRow("Quantity") = "70"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "102"
			dataRow("Prod_Name") = "Product2"
			dataRow("Order_Date") = "15/06/2012"
			dataRow("Quantity") = "70"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "103"
			dataRow("Prod_Name") = "Product3"
			dataRow("Order_Date") = "18/06/2012"
			dataRow("Quantity") = "30"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "104"
			dataRow("Prod_Name") = "Product4"
			dataRow("Order_Date") = "25/06/2012"
			dataRow("Quantity") = "20"
			table.Rows.Add(dataRow)

			Return table
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
			gridControl1.DataSource = CreateTable()
			gridView1.Columns(0).ColumnEdit = repositoryItemHyperLinkEdit1
			gridControl1.RepositoryItems.Add(repositoryItemHyperLinkEdit1)
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

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Windows.Data
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Core

Namespace CustomRibbonSLTheme
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			'ThemeManager.ApplicationTheme = Theme.Office2007Silver;
			Dim theme As New Theme("Office2007SilverExtension") With {.IsStandard = False}
			ThemeManager.ApplicationTheme = theme
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			DXVisualizer.DXVisualTreeVisualizer.Show()
		End Sub

	End Class


End Namespace

Imports Scout.BusinessLogic.Interfaces
Imports Carrick.DataModel


Public Class BadgeUserControl

    Private _Badge As Badge

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub LoadData(b As Badge)
        _Badge = b
        Me.PictureBox1.Image = (New ImageHelper).Convert(b.BadgeImage)
        Me.NameTextBox.Text = b.BadgeName
        Me.LabelID.Text = b.Id.ToString

        With Me.StockTextBox
            .Text = b.Stock.ToString()
            AddHandler .LostFocus, Sub()
                                       If IsNumeric(Me.StockTextBox.Text) Then
                                           If CInt(Me.StockTextBox.Text) > 0 Then
                                               _Badge.Stock = CInt(Me.StockTextBox.Text)
                                           Else
                                               _Badge.Stock = 0
                                           End If
                                       Else
                                           Me.StockTextBox.Text = _Badge.Stock.ToString
                                       End If
                                   End Sub
        End With


        With Me.TargetStockTextBox
            .Text = b.TargetStock.ToString
            AddHandler .LostFocus, Sub()
                                       If IsNumeric(Me.TargetStockTextBox.Text) Then
                                           If CInt(Me.TargetStockTextBox.Text) > 0 Then
                                               _Badge.TargetStock = CInt(Me.TargetStockTextBox.Text)
                                           Else
                                               _Badge.TargetStock = 0
                                           End If
                                       Else
                                           Me.TargetStockTextBox.Text = _Badge.TargetStock.ToString
                                       End If
                                   End Sub
        End With

        'With Me.ToPresentTextBox
        '    DataRepository.Singleton.BL.BadgeBL.Ba(itm)

        '    .Text = b.BadgesToPresent
        'End With

        With Me.EnabledCheckBox
            .Checked = b.BadgeEnabled
            AddHandler .CheckedChanged, Sub()
                                            _Badge.BadgeEnabled = CBool(Me.EnabledCheckBox.Checked)
                                        End Sub
        End With
    End Sub


End Class

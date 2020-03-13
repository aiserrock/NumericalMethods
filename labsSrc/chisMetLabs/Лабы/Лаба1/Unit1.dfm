object FormMain: TFormMain
  Left = 251
  Top = 79
  Width = 813
  Height = 677
  Caption = #1051#1072#1073#1086#1088#1072#1090#1086#1088#1085#1072#1103' '#8470'1'
  Color = clScrollBar
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Chart1: TChart
    Left = 0
    Top = 161
    Width = 805
    Height = 482
    BackWall.Brush.Color = clWhite
    BackWall.Brush.Style = bsClear
    Title.Font.Charset = RUSSIAN_CHARSET
    Title.Font.Color = clRed
    Title.Font.Height = -11
    Title.Font.Name = 'Arial'
    Title.Font.Style = [fsBold, fsUnderline]
    Title.Text.Strings = (
      #1040#1083#1100#1092#1072'*sin('#1041#1077#1090#1072'/(x - '#1043#1072#1084#1084#1072')^2) + '#1044#1077#1083#1100#1090#1072'*cos('#1069#1087#1089#1080#1083#1086#1085'*x)'
      ' '#1042#1099#1087#1086#1083#1085#1080#1083#1072': '#1064#1072#1088#1072#1096#1086#1074#1072' '#1045#1082#1072#1090#1077#1088#1080#1085#1072', '#1089#1090#1091#1076#1077#1085#1090#1082#1072' '#1075#1088#1091#1087#1087#1099' '#1048#1058'-31'#1041#1054)
    BottomAxis.Automatic = False
    BottomAxis.AutomaticMaximum = False
    BottomAxis.AutomaticMinimum = False
    BottomAxis.Maximum = 10
    BottomAxis.Minimum = -10
    BottomAxis.Title.Caption = 'X'
    LeftAxis.Automatic = False
    LeftAxis.AutomaticMaximum = False
    LeftAxis.AutomaticMinimum = False
    LeftAxis.Maximum = 5
    LeftAxis.Minimum = -5
    LeftAxis.Title.Angle = 0
    LeftAxis.Title.Caption = 'Y'
    Legend.Visible = False
    View3D = False
    Align = alClient
    TabOrder = 0
    object Series1: TLineSeries
      Marks.ArrowLength = 8
      Marks.Visible = False
      SeriesColor = clBlack
      Title = 'f(x)'
      Pointer.InflateMargins = True
      Pointer.Style = psRectangle
      Pointer.Visible = False
      XValues.DateTime = False
      XValues.Name = 'X'
      XValues.Multiplier = 1
      XValues.Order = loAscending
      YValues.DateTime = False
      YValues.Name = 'Y'
      YValues.Multiplier = 1
      YValues.Order = loNone
    end
    object Series2: TLineSeries
      Marks.ArrowLength = 8
      Marks.Visible = False
      SeriesColor = clRed
      Title = 'Pn(x)'
      Pointer.InflateMargins = True
      Pointer.Style = psRectangle
      Pointer.Visible = False
      XValues.DateTime = False
      XValues.Name = 'X'
      XValues.Multiplier = 1
      XValues.Order = loAscending
      YValues.DateTime = False
      YValues.Name = 'Y'
      YValues.Multiplier = 1
      YValues.Order = loNone
    end
    object Series3: TLineSeries
      Marks.ArrowLength = 8
      Marks.Visible = False
      SeriesColor = clGreen
      Title = 'rn(x)'
      Pointer.InflateMargins = True
      Pointer.Style = psRectangle
      Pointer.Visible = False
      XValues.DateTime = False
      XValues.Name = 'X'
      XValues.Multiplier = 1
      XValues.Order = loAscending
      YValues.DateTime = False
      YValues.Name = 'Y'
      YValues.Multiplier = 1
      YValues.Order = loNone
    end
    object Series4: TLineSeries
      Marks.ArrowLength = 8
      Marks.Visible = False
      SeriesColor = clMaroon
      Title = 'df(x)'
      Pointer.InflateMargins = True
      Pointer.Style = psRectangle
      Pointer.Visible = False
      XValues.DateTime = False
      XValues.Name = 'X'
      XValues.Multiplier = 1
      XValues.Order = loAscending
      YValues.DateTime = False
      YValues.Name = 'Y'
      YValues.Multiplier = 1
      YValues.Order = loNone
    end
    object Series5: TLineSeries
      Marks.ArrowLength = 8
      Marks.Visible = False
      SeriesColor = clBlue
      Title = 'dPn(x)'
      Pointer.InflateMargins = True
      Pointer.Style = psRectangle
      Pointer.Visible = False
      XValues.DateTime = False
      XValues.Name = 'X'
      XValues.Multiplier = 1
      XValues.Order = loAscending
      YValues.DateTime = False
      YValues.Name = 'Y'
      YValues.Multiplier = 1
      YValues.Order = loNone
    end
  end
  object GroupBox1: TGroupBox
    Left = 0
    Top = 0
    Width = 805
    Height = 161
    Align = alTop
    Caption = #1055#1072#1088#1072#1084#1077#1090#1088#1099
    TabOrder = 1
    object Label1: TLabel
      Left = 15
      Top = 28
      Width = 36
      Height = 13
      Caption = #1040#1083#1100#1092#1072':'
    end
    object Label2: TLabel
      Left = 24
      Top = 52
      Width = 27
      Height = 13
      Caption = #1041#1077#1090#1072':'
    end
    object Label3: TLabel
      Left = 14
      Top = 76
      Width = 37
      Height = 13
      Caption = #1043#1072#1084#1084#1072':'
    end
    object Label4: TLabel
      Left = 10
      Top = 100
      Width = 41
      Height = 13
      Caption = #1044#1077#1083#1100#1090#1072':'
    end
    object Label5: TLabel
      Left = 160
      Top = 36
      Width = 10
      Height = 13
      Caption = 'A:'
    end
    object Label6: TLabel
      Left = 160
      Top = 60
      Width = 10
      Height = 13
      Caption = 'B:'
    end
    object Label7: TLabel
      Left = 160
      Top = 84
      Width = 10
      Height = 13
      Caption = 'C:'
    end
    object Label8: TLabel
      Left = 160
      Top = 108
      Width = 11
      Height = 13
      Caption = 'D:'
    end
    object Label9: TLabel
      Left = 304
      Top = 36
      Width = 9
      Height = 13
      Caption = 'n:'
    end
    object Label10: TLabel
      Left = 264
      Top = 76
      Width = 68
      Height = 13
      Caption = #1055#1088#1080#1088#1072#1097#1077#1085#1080#1077':'
      WordWrap = True
    end
    object Label11: TLabel
      Left = 592
      Top = 32
      Width = 149
      Height = 13
      Caption = #1052#1072#1082#1089#1080#1084#1072#1083#1100#1085#1072#1103' '#1087#1086#1075#1088#1077#1096#1085#1086#1089#1090#1100':'
    end
    object Label12: TLabel
      Left = 576
      Top = 88
      Width = 211
      Height = 13
      Caption = #1050#1086#1086#1088#1076#1080#1085#1072#1090#1072' '#1084#1072#1082#1089#1080#1084#1072#1083#1100#1085#1086#1081' '#1087#1086#1075#1088#1077#1096#1085#1086#1089#1090#1080':'
    end
    object Label13: TLabel
      Left = 4
      Top = 120
      Width = 46
      Height = 13
      Caption = #1069#1087#1089#1080#1083#1086#1085':'
    end
    object AlphaEdit: TEdit
      Left = 56
      Top = 24
      Width = 81
      Height = 21
      TabOrder = 0
      Text = '1'
    end
    object BetaEdit: TEdit
      Left = 56
      Top = 48
      Width = 81
      Height = 21
      TabOrder = 1
      Text = '1'
    end
    object GammaEdit: TEdit
      Left = 56
      Top = 72
      Width = 81
      Height = 21
      TabOrder = 2
      Text = '1'
    end
    object DeltaEdit: TEdit
      Left = 56
      Top = 96
      Width = 81
      Height = 21
      TabOrder = 3
      Text = '1'
    end
    object AEdit: TEdit
      Left = 176
      Top = 32
      Width = 81
      Height = 21
      TabOrder = 4
      Text = '-10'
    end
    object BEdit: TEdit
      Left = 176
      Top = 56
      Width = 81
      Height = 21
      TabOrder = 5
      Text = '10'
    end
    object CEdit: TEdit
      Left = 176
      Top = 80
      Width = 81
      Height = 21
      TabOrder = 6
      Text = '-5'
    end
    object DEdit: TEdit
      Left = 176
      Top = 104
      Width = 81
      Height = 21
      TabOrder = 7
      Text = '5'
    end
    object nEdit: TEdit
      Left = 344
      Top = 32
      Width = 97
      Height = 21
      TabOrder = 8
      Text = '10'
    end
    object ComboBox1: TComboBox
      Left = 344
      Top = 72
      Width = 97
      Height = 21
      ItemHeight = 13
      TabOrder = 9
      Text = '0,0001'
      Items.Strings = (
        '0,0001'
        '0,001'
        '0,01'
        '0,1'
        '1')
    end
    object CheckBoxf: TCheckBox
      Left = 496
      Top = 32
      Width = 65
      Height = 17
      Caption = 'f(x)'
      Checked = True
      Color = clWindowText
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWhite
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentColor = False
      ParentFont = False
      State = cbChecked
      TabOrder = 10
    end
    object CheckBoxPn: TCheckBox
      Left = 496
      Top = 48
      Width = 65
      Height = 17
      Caption = 'Pn(x)'
      Checked = True
      Color = clRed
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentColor = False
      ParentFont = False
      State = cbChecked
      TabOrder = 11
    end
    object CheckBoxrn: TCheckBox
      Left = 496
      Top = 64
      Width = 65
      Height = 17
      Caption = 'rn(x)'
      Color = clGreen
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentColor = False
      ParentFont = False
      TabOrder = 12
    end
    object CheckBoxdf: TCheckBox
      Left = 496
      Top = 80
      Width = 65
      Height = 17
      Caption = 'df(x)'
      Color = clMaroon
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentColor = False
      ParentFont = False
      TabOrder = 13
    end
    object CheckBoxdPn: TCheckBox
      Left = 496
      Top = 96
      Width = 65
      Height = 17
      Caption = 'dPn(x)'
      Color = clBlue
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentColor = False
      ParentFont = False
      TabOrder = 14
    end
    object Button1: TButton
      Left = 288
      Top = 112
      Width = 169
      Height = 33
      Caption = #1055#1086#1089#1090#1088#1086#1080#1090#1100
      TabOrder = 15
      OnClick = Button1Click
    end
    object maxrEdit: TEdit
      Left = 608
      Top = 56
      Width = 121
      Height = 21
      BorderStyle = bsNone
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 16
    end
    object maxrxEdit: TEdit
      Left = 608
      Top = 112
      Width = 121
      Height = 21
      BorderStyle = bsNone
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 17
    end
    object EpsilonEdit: TEdit
      Left = 56
      Top = 120
      Width = 81
      Height = 21
      TabOrder = 18
      Text = '1'
    end
  end
  object MainMenu1: TMainMenu
    Left = 456
  end
end

object FormMain: TFormMain
  Left = 256
  Top = 0
  Width = 878
  Height = 732
  Caption = #1051#1072#1073#1086#1088#1072#1090#1086#1088#1085#1072#1103' '#8470'1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  OnClose = FormClose
  PixelsPerInch = 96
  TextHeight = 13
  object Chart1: TChart
    Left = 0
    Top = 217
    Width = 862
    Height = 459
    BackWall.Brush.Color = clWhite
    BackWall.Brush.Style = bsClear
    Title.Font.Charset = DEFAULT_CHARSET
    Title.Font.Color = clGreen
    Title.Font.Height = -11
    Title.Font.Name = 'Arial'
    Title.Font.Style = []
    Title.Text.Strings = (
      
        ' '#1048#1085#1090#1077#1075#1088#1072#1083#1083' '#1092#1091#1085#1082#1094#1080#1080' '#1040#1083#1100#1092#1072'*sin('#1041#1077#1090#1072'/(x - '#1043#1072#1084#1084#1072')^2) + '#1044#1077#1083#1100#1090#1072'*cos('#1069#1087 +
        #1089#1080#1083#1086#1085'*x)')
    BottomAxis.Automatic = False
    BottomAxis.AutomaticMaximum = False
    BottomAxis.AutomaticMinimum = False
    BottomAxis.Maximum = 10
    BottomAxis.Minimum = -10
    BottomAxis.Title.Caption = #1055#1072#1088#1072#1084#1077#1090#1088
    BottomAxis.Title.Font.Charset = RUSSIAN_CHARSET
    BottomAxis.Title.Font.Color = clGreen
    BottomAxis.Title.Font.Height = -12
    BottomAxis.Title.Font.Name = 'Times New Roman'
    BottomAxis.Title.Font.Style = [fsBold, fsItalic]
    LeftAxis.Automatic = False
    LeftAxis.AutomaticMaximum = False
    LeftAxis.AutomaticMinimum = False
    LeftAxis.Maximum = 5
    LeftAxis.Minimum = -5
    LeftAxis.Title.Caption = 'I'
    LeftAxis.Title.Font.Charset = RUSSIAN_CHARSET
    LeftAxis.Title.Font.Color = clGreen
    LeftAxis.Title.Font.Height = -12
    LeftAxis.Title.Font.Name = 'Times New Roman'
    LeftAxis.Title.Font.Style = [fsBold, fsItalic]
    Legend.Visible = False
    View3D = False
    Align = alClient
    TabOrder = 0
    object Series1: TLineSeries
      Marks.ArrowLength = 8
      Marks.Visible = False
      SeriesColor = clGreen
      Title = 'integral'
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
    Width = 862
    Height = 217
    Align = alTop
    Caption = #1055#1072#1088#1072#1084#1077#1090#1088#1099
    TabOrder = 1
    object Label1: TLabel
      Left = 213
      Top = 92
      Width = 36
      Height = 13
      Caption = #1040#1083#1100#1092#1072':'
    end
    object Label2: TLabel
      Left = 222
      Top = 116
      Width = 27
      Height = 13
      Caption = #1041#1077#1090#1072':'
    end
    object Label3: TLabel
      Left = 212
      Top = 140
      Width = 37
      Height = 13
      Caption = #1043#1072#1084#1084#1072':'
    end
    object Label4: TLabel
      Left = 208
      Top = 164
      Width = 41
      Height = 13
      Caption = #1044#1077#1083#1100#1090#1072':'
    end
    object Label5: TLabel
      Left = 392
      Top = 60
      Width = 10
      Height = 13
      Caption = 'A:'
    end
    object Label6: TLabel
      Left = 392
      Top = 92
      Width = 10
      Height = 13
      Caption = 'B:'
    end
    object Label7: TLabel
      Left = 392
      Top = 124
      Width = 10
      Height = 13
      Caption = 'C:'
    end
    object Label8: TLabel
      Left = 392
      Top = 156
      Width = 11
      Height = 13
      Caption = 'D:'
    end
    object Label9: TLabel
      Left = 568
      Top = 108
      Width = 15
      Height = 13
      Caption = 'n0:'
    end
    object Label10: TLabel
      Left = 544
      Top = 68
      Width = 50
      Height = 13
      Caption = #1058#1086#1095#1085#1086#1089#1090#1100':'
      WordWrap = True
    end
    object Label11: TLabel
      Left = 560
      Top = 144
      Width = 31
      Height = 13
      Caption = 'n max:'
    end
    object Label12: TLabel
      Left = 368
      Top = 16
      Width = 166
      Height = 13
      Caption = #1044#1077#1081#1089#1090#1074#1080#1090#1077#1083#1100#1085#1099#1077' '#1088#1072#1079#1084#1077#1088#1099' '#1086#1082#1085#1072':'
    end
    object Label13: TLabel
      Left = 232
      Top = 40
      Width = 9
      Height = 13
      Caption = 'a:'
    end
    object Label14: TLabel
      Left = 232
      Top = 64
      Width = 9
      Height = 13
      Caption = 'b:'
    end
    object Label15: TLabel
      Left = 200
      Top = 16
      Width = 150
      Height = 13
      Caption = #1044#1077#1081#1089#1090#1074#1080#1090#1077#1083#1100#1085#1099#1077' '#1087#1072#1088#1072#1084#1077#1090#1088#1099':'
    end
    object Label16: TLabel
      Left = 728
      Top = 56
      Width = 120
      Height = 13
      Caption = #1042#1099#1076#1077#1083#1077#1085#1085#1099#1081' '#1087#1072#1088#1072#1084#1077#1090#1088':'
    end
    object CGauge1: TCGauge
      Left = 8
      Top = 168
      Width = 169
      Height = 25
      ShowText = False
      ForeColor = clGreen
      BackColor = clBtnFace
    end
    object Label17: TLabel
      Left = 64
      Top = 136
      Width = 52
      Height = 13
      Caption = #1055#1088#1086#1075#1088#1077#1089#1089':'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
    end
    object Label18: TLabel
      Left = 203
      Top = 187
      Width = 46
      Height = 13
      Caption = #1069#1087#1089#1080#1083#1086#1085':'
    end
    object AlphaEdit: TEdit
      Left = 256
      Top = 88
      Width = 65
      Height = 21
      TabOrder = 0
      Text = '1'
    end
    object BetaEdit: TEdit
      Left = 256
      Top = 112
      Width = 65
      Height = 21
      TabOrder = 1
      Text = '1'
    end
    object GammaEdit: TEdit
      Left = 256
      Top = 136
      Width = 65
      Height = 21
      TabOrder = 2
      Text = '1'
    end
    object DeltaEdit: TEdit
      Left = 256
      Top = 160
      Width = 65
      Height = 21
      TabOrder = 3
      Text = '1'
    end
    object AEdit: TEdit
      Left = 424
      Top = 56
      Width = 65
      Height = 21
      TabOrder = 4
      Text = '-10'
    end
    object BEdit: TEdit
      Left = 424
      Top = 88
      Width = 65
      Height = 21
      TabOrder = 5
      Text = '10'
    end
    object CEdit: TEdit
      Left = 424
      Top = 120
      Width = 65
      Height = 21
      TabOrder = 6
      Text = '-5'
    end
    object DEdit: TEdit
      Left = 424
      Top = 152
      Width = 65
      Height = 21
      TabOrder = 7
      Text = '5'
    end
    object nEdit: TEdit
      Left = 608
      Top = 104
      Width = 65
      Height = 21
      TabOrder = 8
      Text = '100'
    end
    object ComboBox1: TComboBox
      Left = 608
      Top = 64
      Width = 89
      Height = 21
      ItemHeight = 13
      TabOrder = 9
      Text = '0,01'
      Items.Strings = (
        '0,0001'
        '0,001'
        '0,01'
        '0,1'
        '1')
    end
    object Button1: TButton
      Left = 16
      Top = 32
      Width = 145
      Height = 33
      Caption = #1055#1086#1089#1090#1088#1086#1080#1090#1100
      TabOrder = 10
      OnClick = Button1Click
    end
    object maxrEdit: TEdit
      Left = 608
      Top = 144
      Width = 97
      Height = 21
      BorderStyle = bsNone
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 11
      Text = '1111'
    end
    object a_Edit: TEdit
      Left = 256
      Top = 40
      Width = 65
      Height = 21
      TabOrder = 12
      Text = '0'
    end
    object b_Edit: TEdit
      Left = 256
      Top = 64
      Width = 65
      Height = 21
      TabOrder = 13
      Text = '10'
    end
    object RadioButtonAlpha: TRadioButton
      Left = 752
      Top = 80
      Width = 65
      Height = 17
      Caption = #1040#1083#1100#1092#1072
      Checked = True
      TabOrder = 14
      TabStop = True
    end
    object RadioButtonBeta: TRadioButton
      Left = 752
      Top = 96
      Width = 65
      Height = 17
      Caption = #1041#1077#1090#1072
      TabOrder = 15
    end
    object RadioButtonGamma: TRadioButton
      Left = 752
      Top = 112
      Width = 65
      Height = 17
      Caption = #1043#1072#1084#1084#1072
      TabOrder = 16
    end
    object RadioButtonDelta: TRadioButton
      Left = 752
      Top = 128
      Width = 65
      Height = 17
      Caption = #1044#1077#1083#1100#1090#1072
      TabOrder = 17
    end
    object Button2: TButton
      Left = 16
      Top = 72
      Width = 145
      Height = 33
      Caption = #1054#1090#1084#1077#1085#1072
      TabOrder = 18
      OnClick = Button2Click
    end
    object EpsilonEdit: TEdit
      Left = 256
      Top = 184
      Width = 65
      Height = 21
      TabOrder = 19
      Text = '1'
    end
    object RadioButtonEpsilon: TRadioButton
      Left = 752
      Top = 144
      Width = 65
      Height = 17
      Caption = #1069#1087#1089#1080#1083#1086#1085
      TabOrder = 20
    end
  end
  object MainMenu1: TMainMenu
    Left = 456
    object N1: TMenuItem
      Caption = #1060#1072#1081#1083
      object N4: TMenuItem
        Caption = #1055#1086#1089#1090#1088#1086#1080#1090#1100
        OnClick = N4Click
      end
      object N5: TMenuItem
        Caption = #1042#1099#1093#1086#1076
        OnClick = N5Click
      end
    end
    object N2: TMenuItem
      Caption = #1057#1087#1088#1072#1074#1082#1072
      object N3: TMenuItem
        Caption = #1054' '#1087#1088#1086#1075#1088#1072#1084#1084#1077
        OnClick = N3Click
      end
    end
  end
end

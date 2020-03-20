object Form1: TForm1
  Left = -2
  Top = -1
  Caption = #1048#1085#1090#1077#1088#1087#1086#1083#1080#1088#1086#1074#1072#1085#1080#1077' '#1092#1091#1085#1082#1094#1080#1080
  ClientHeight = 647
  ClientWidth = 1074
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Panel1: TPanel
    Left = 0
    Top = 0
    Width = 1074
    Height = 647
    Align = alClient
    Caption = 'Panel1'
    TabOrder = 0
    object Image1: TImage
      Left = 168
      Top = 192
      Width = 105
      Height = 105
    end
    object Chart1: TChart
      Left = -5
      Top = 0
      Width = 808
      Height = 647
      BackWall.Brush.Color = clWhite
      BackWall.Brush.Style = bsClear
      Title.AdjustFrame = False
      Title.Font.Height = -13
      Title.Font.Style = [fsBold]
      Title.Text.Strings = (
        'F(x)=a*cos (tg (b/x-y))+g*sin (e*x)')
      BottomAxis.Automatic = False
      BottomAxis.AutomaticMaximum = False
      BottomAxis.AutomaticMinimum = False
      BottomAxis.Maximum = 10.000000000000000000
      BottomAxis.Minimum = -10.000000000000000000
      LeftAxis.Automatic = False
      LeftAxis.AutomaticMaximum = False
      LeftAxis.AutomaticMinimum = False
      LeftAxis.Maximum = 10.000000000000000000
      LeftAxis.Minimum = -10.000000000000000000
      RightAxis.Automatic = False
      RightAxis.AutomaticMaximum = False
      RightAxis.AutomaticMinimum = False
      RightAxis.Maximum = 10.000000000000000000
      RightAxis.Minimum = -10.000000000000000000
      View3D = False
      TabOrder = 0
      object Series1: TFastLineSeries
        Marks.Arrow.Visible = True
        Marks.Callout.Brush.Color = clBlack
        Marks.Callout.Arrow.Visible = True
        Marks.Visible = False
        Title = 'F(x)'
        LinePen.Color = clRed
        XValues.Name = 'X'
        XValues.Order = loAscending
        YValues.Name = 'Y'
        YValues.Order = loNone
      end
      object Series2: TFastLineSeries
        Marks.Arrow.Visible = True
        Marks.Callout.Brush.Color = clBlack
        Marks.Callout.Arrow.Visible = True
        Marks.Visible = False
        Title = 'F'#39'(x)'
        LinePen.Color = clGreen
        XValues.Name = 'X'
        XValues.Order = loAscending
        YValues.Name = 'Y'
        YValues.Order = loNone
      end
      object Series3: TFastLineSeries
        Marks.Arrow.Visible = True
        Marks.Callout.Brush.Color = clBlack
        Marks.Callout.Arrow.Visible = True
        Marks.Visible = False
        SeriesColor = -1
        Title = 'Pn(x)'
        LinePen.Color = -1
        XValues.Name = 'X'
        XValues.Order = loAscending
        YValues.Name = 'Y'
        YValues.Order = loNone
      end
      object Series4: TFastLineSeries
        Marks.Arrow.Visible = True
        Marks.Callout.Brush.Color = clBlack
        Marks.Callout.Arrow.Visible = True
        Marks.Visible = False
        SeriesColor = clBlue
        Title = 'Pn'#39'(x)'
        LinePen.Color = clBlue
        XValues.Name = 'X'
        XValues.Order = loAscending
        YValues.Name = 'Y'
        YValues.Order = loNone
      end
      object Series5: TFastLineSeries
        Marks.Arrow.Visible = True
        Marks.Callout.Brush.Color = clBlack
        Marks.Callout.Arrow.Visible = True
        Marks.Visible = False
        SeriesColor = clFuchsia
        Title = 'Rn(x)'
        LinePen.Color = clFuchsia
        XValues.Name = 'X'
        XValues.Order = loAscending
        YValues.Name = 'Y'
        YValues.Order = loNone
      end
      object Series6: TFastLineSeries
        Active = False
        Marks.Arrow.Visible = True
        Marks.Callout.Brush.Color = clBlack
        Marks.Callout.Arrow.Visible = True
        Marks.Visible = False
        SeriesColor = clBlack
        Title = 'max | Rn(x) |'
        XValues.Name = 'X'
        XValues.Order = loAscending
        YValues.Name = 'Y'
        YValues.Order = loNone
      end
    end
  end
  object Panel2: TPanel
    Left = 800
    Top = 0
    Width = 276
    Height = 647
    TabOrder = 1
    object Label12: TLabel
      Left = 129
      Top = 618
      Width = 120
      Height = 13
      Caption = ' '#1062#1072#1088#1077#1074#1072' '#1040#1085#1085#1072' '#1048#1058'-31 '#1041#1054
    end
    object GroupBox1: TGroupBox
      Left = 16
      Top = 17
      Width = 225
      Height = 225
      Caption = #1055#1072#1088#1072#1084#1077#1090#1088#1099' '#1079#1072#1076#1072#1095#1080':'
      TabOrder = 0
      object Label1: TLabel
        Left = 8
        Top = 118
        Width = 9
        Height = 13
        Caption = 'e:'
      end
      object Label2: TLabel
        Left = 8
        Top = 24
        Width = 9
        Height = 13
        Caption = 'a:'
      end
      object Label3: TLabel
        Left = 8
        Top = 48
        Width = 9
        Height = 13
        Caption = 'b:'
      end
      object Label4: TLabel
        Left = 10
        Top = 67
        Width = 8
        Height = 13
        Caption = 'y:'
      end
      object Label5: TLabel
        Left = 9
        Top = 92
        Width = 9
        Height = 13
        Caption = 'g:'
      end
      object Label6: TLabel
        Left = 112
        Top = 40
        Width = 10
        Height = 13
        Caption = 'A:'
      end
      object Label7: TLabel
        Left = 112
        Top = 64
        Width = 10
        Height = 13
        Caption = 'B:'
      end
      object Label8: TLabel
        Left = 112
        Top = 88
        Width = 10
        Height = 13
        Caption = 'C:'
      end
      object Label9: TLabel
        Left = 112
        Top = 112
        Width = 11
        Height = 13
        Caption = 'D:'
      end
      object Label10: TLabel
        Left = 8
        Top = 160
        Width = 9
        Height = 13
        Caption = 'n:'
      end
      object Label11: TLabel
        Left = 8
        Top = 184
        Width = 9
        Height = 13
        Caption = 'h:'
      end
      object Ed_E: TEdit
        Left = 23
        Top = 115
        Width = 73
        Height = 21
        TabOrder = 0
        Text = '1'
      end
      object Ed_a: TEdit
        Left = 24
        Top = 16
        Width = 73
        Height = 21
        TabOrder = 1
        Text = '1'
      end
      object Ed_b: TEdit
        Left = 24
        Top = 40
        Width = 73
        Height = 21
        TabOrder = 2
        Text = '1'
      end
      object Ed_c: TEdit
        Left = 24
        Top = 61
        Width = 73
        Height = 21
        TabOrder = 3
        Text = '1'
      end
      object Ed_d: TEdit
        Left = 24
        Top = 88
        Width = 73
        Height = 21
        TabOrder = 4
        Text = '1'
      end
      object EdkA: TEdit
        Left = 128
        Top = 32
        Width = 73
        Height = 21
        TabOrder = 5
        Text = '-10'
      end
      object EdkB: TEdit
        Left = 128
        Top = 56
        Width = 73
        Height = 21
        TabOrder = 6
        Text = '10'
      end
      object EdkC: TEdit
        Left = 128
        Top = 80
        Width = 73
        Height = 21
        TabOrder = 7
        Text = '-10'
      end
      object EdkD: TEdit
        Left = 128
        Top = 104
        Width = 73
        Height = 21
        TabOrder = 8
        Text = '10'
      end
      object Ed_n: TEdit
        Left = 24
        Top = 152
        Width = 73
        Height = 21
        TabOrder = 9
        Text = '17'
      end
      object BitBtn1: TBitBtn
        Left = 120
        Top = 152
        Width = 91
        Height = 41
        Caption = #1054#1050
        Default = True
        DoubleBuffered = True
        ModalResult = 6
        NumGlyphs = 2
        ParentDoubleBuffered = False
        TabOrder = 10
        OnClick = BitBtn1Click
      end
      object Ed_h: TComboBox
        Left = 24
        Top = 176
        Width = 73
        Height = 21
        Style = csDropDownList
        ItemHeight = 13
        ItemIndex = 1
        TabOrder = 11
        Text = '0,1'
        Items.Strings = (
          '1'
          '0,1'
          '0,01'
          '0,001'
          '0,0001')
      end
    end
    object GroupBox2: TGroupBox
      Left = 24
      Top = 248
      Width = 225
      Height = 137
      Caption = #1043#1088#1072#1092#1080#1082#1080':'
      TabOrder = 1
      object SpeedButton2: TSpeedButton
        Left = 16
        Top = 64
        Width = 65
        Height = 22
        AllowAllUp = True
        GroupIndex = 2
        Caption = 'Pn(x)'
        OnClick = SpeedButton2Click
      end
      object SpeedButton3: TSpeedButton
        Left = 16
        Top = 96
        Width = 65
        Height = 22
        AllowAllUp = True
        GroupIndex = 3
        Caption = 'Rn(x)'
        OnClick = SpeedButton3Click
      end
      object SpeedButton4: TSpeedButton
        Left = 128
        Top = 32
        Width = 65
        Height = 22
        AllowAllUp = True
        GroupIndex = 4
        Caption = 'F'#39'(x)'
        OnClick = SpeedButton4Click
      end
      object SpeedButton5: TSpeedButton
        Left = 128
        Top = 64
        Width = 65
        Height = 22
        AllowAllUp = True
        GroupIndex = 5
        Caption = 'Pn'#39'(x)'
        OnClick = SpeedButton5Click
      end
      object SpeedButton1: TSpeedButton
        Left = 16
        Top = 32
        Width = 65
        Height = 22
        AllowAllUp = True
        GroupIndex = 1
        Down = True
        Caption = 'F(x)'
        OnClick = SpeedButton1Click
      end
    end
    object BitBtn2: TBitBtn
      Left = 160
      Top = 391
      Width = 89
      Height = 41
      Caption = 'Exit'
      DoubleBuffered = True
      NumGlyphs = 2
      ParentDoubleBuffered = False
      TabOrder = 2
      OnClick = BitBtn2Click
    end
    object BitBtn3: TBitBtn
      Left = 24
      Top = 391
      Width = 89
      Height = 41
      Caption = 'Erase all'
      DoubleBuffered = True
      NumGlyphs = 2
      ParentDoubleBuffered = False
      TabOrder = 3
      OnClick = BitBtn3Click
    end
  end
  object MainMenu1: TMainMenu
    Left = 184
    object N1: TMenuItem
      Caption = #1052#1077#1085#1102
      object N3: TMenuItem
        Caption = #1054#1095#1080#1089#1090#1080#1090#1100' '#1074#1089#1077
        OnClick = N3Click
      end
      object N4: TMenuItem
        Caption = #1042#1099#1093#1086#1076
        OnClick = N4Click
      end
    end
  end
end

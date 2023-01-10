object frmOperacoesBooleanas: TfrmOperacoesBooleanas
  Left = 0
  Top = 0
  Caption = 'Opera'#231#245'es Booleanas'
  ClientHeight = 103
  ClientWidth = 524
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 8
    Top = 8
    Width = 69
    Height = 13
    Caption = 'Primeiro Valor:'
  end
  object Label2: TLabel
    Left = 8
    Top = 52
    Width = 73
    Height = 13
    Caption = 'Segundo Valor:'
  end
  object Label3: TLabel
    Left = 354
    Top = 8
    Width = 99
    Height = 13
    Caption = 'Resultado Booleano:'
  end
  object lblBooleanResult: TLabel
    Left = 354
    Top = 25
    Width = 162
    Height = 70
    Alignment = taCenter
    AutoSize = False
    Caption = '...'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -37
    Font.Name = 'Yu Gothic UI'
    Font.Style = []
    ParentFont = False
  end
  object stcResultadoBooleano: TStaticText
    Left = 8
    Top = 131
    Width = 4
    Height = 4
    TabOrder = 0
  end
  object GroupBox1: TGroupBox
    Left = 181
    Top = 8
    Width = 167
    Height = 87
    Caption = 'Opera'#231#245'es Booleanas'
    TabOrder = 1
    object btnNot: TButton
      Left = 3
      Top = 16
      Width = 75
      Height = 25
      Hint = 
        'O operador l'#243'gico '#39'NOT'#39' realiza a invers'#227'o do resultado l'#243'gico. ' +
        'Ou seja, se o resultado for true, ele mostrar'#225' como false e vice' +
        '-versa. '
      Caption = 'NOT'
      ParentShowHint = False
      ShowHint = True
      TabOrder = 0
      OnClick = btnNotClick
    end
    object btnAnd: TButton
      Left = 84
      Top = 16
      Width = 75
      Height = 25
      Hint = 
        'O operador l'#243'gico '#39'AND'#39' analisa as express'#245'es l'#243'gicas e retorna ' +
        #39'TRUE'#39' caso todas elas sejam verdadeiras, caso contr'#225'rio o resul' +
        'tado ser'#225' '#39'FALSE'#39'.'
      Caption = 'AND'
      ParentShowHint = False
      ShowHint = True
      TabOrder = 1
      OnClick = btnAndClick
    end
    object btnOr: TButton
      Left = 3
      Top = 47
      Width = 75
      Height = 25
      Caption = 'OR'
      TabOrder = 2
      OnClick = btnOrClick
    end
    object btnXor: TButton
      Left = 84
      Top = 47
      Width = 75
      Height = 25
      Caption = 'XOR'
      TabOrder = 3
    end
  end
  object cbFirstOption: TComboBox
    Left = 8
    Top = 25
    Width = 145
    Height = 21
    Style = csDropDownList
    TabOrder = 2
    Items.Strings = (
      'TRUE'
      'FALSE')
  end
  object cbSecondOption: TComboBox
    Left = 8
    Top = 71
    Width = 145
    Height = 21
    Style = csDropDownList
    TabOrder = 3
    Items.Strings = (
      'TRUE'
      'FALSE')
  end
end

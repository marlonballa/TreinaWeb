object frmOperadoresRelacionais: TfrmOperadoresRelacionais
  Left = 0
  Top = 0
  Caption = 'Operadores Relacionais'
  ClientHeight = 173
  ClientWidth = 696
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 8
    Top = 8
    Width = 65
    Height = 13
    Caption = 'Primeiro Valor'
  end
  object Label2: TLabel
    Left = 135
    Top = 8
    Width = 73
    Height = 13
    Caption = 'Segundo Valor:'
  end
  object Label3: TLabel
    Left = 408
    Top = 8
    Width = 248
    Height = 13
    Caption = 'Neste exerc'#237'cio acontece a compara'#231#227'o dos valores'
  end
  object Label4: TLabel
    Left = 408
    Top = 27
    Width = 220
    Height = 13
    Caption = 'O primeiro valor '#233' comparado com o segundo,'
  end
  object Label5: TLabel
    Left = 408
    Top = 46
    Width = 224
    Height = 13
    Caption = 'De acordo com a op'#231#227'o escolhida pelo usu'#225'rio.'
  end
  object spedtFirst: TSpinEdit
    Left = 8
    Top = 24
    Width = 121
    Height = 22
    MaxValue = 0
    MinValue = 0
    TabOrder = 0
    Value = 0
  end
  object spedtSecond: TSpinEdit
    Left = 135
    Top = 24
    Width = 121
    Height = 22
    MaxValue = 0
    MinValue = 0
    TabOrder = 1
    Value = 0
  end
  object gbOperadoresRelacionais: TGroupBox
    Left = 8
    Top = 79
    Width = 394
    Height = 86
    Caption = 'Operadores Relacionais'
    TabOrder = 2
    object rbIgual: TRadioButton
      Left = 8
      Top = 16
      Width = 113
      Height = 17
      Caption = '='
      TabOrder = 0
      OnClick = rbIgualClick
    end
    object rbMaior: TRadioButton
      Left = 8
      Top = 39
      Width = 113
      Height = 17
      Caption = '>'
      TabOrder = 1
      OnClick = rbMaiorClick
    end
    object rbMenor: TRadioButton
      Left = 8
      Top = 62
      Width = 113
      Height = 17
      Caption = '<'
      TabOrder = 2
      OnClick = rbMenorClick
    end
    object btnReset: TButton
      Left = 256
      Top = 32
      Width = 75
      Height = 25
      Caption = 'Reset'
      TabOrder = 3
      OnClick = btnResetClick
    end
  end
  object resultAnswer: TPanel
    Left = 408
    Top = 79
    Width = 280
    Height = 86
    TabOrder = 3
  end
  object rbMaiorIgual: TRadioButton
    Left = 119
    Top = 95
    Width = 113
    Height = 17
    Caption = '>='
    TabOrder = 4
    OnClick = rbMaiorIgualClick
  end
  object rbMenorIgual: TRadioButton
    Left = 119
    Top = 118
    Width = 113
    Height = 17
    Caption = '<='
    TabOrder = 5
    OnClick = rbMenorIgualClick
  end
  object rbDiferente: TRadioButton
    Left = 119
    Top = 141
    Width = 113
    Height = 17
    Caption = '<>'
    TabOrder = 6
    OnClick = rbDiferenteClick
  end
end

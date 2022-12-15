object frmPrincipal: TfrmPrincipal
  Left = 0
  Top = 0
  Caption = 'Minha Primeira Aplica'#231#227'o com Delphi'
  ClientHeight = 201
  ClientWidth = 447
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object lblNomeCliente: TLabel
    Left = 16
    Top = 16
    Width = 130
    Height = 13
    Caption = 'Qual o seu nome completo:'
  end
  object lblIdade: TLabel
    Left = 16
    Top = 62
    Width = 85
    Height = 13
    Caption = 'Qual a sua idade?'
  end
  object btnShowMessage: TButton
    Left = 16
    Top = 116
    Width = 75
    Height = 25
    Caption = 'OK'
    TabOrder = 0
    OnClick = btnShowMessageClick
  end
  object edtNomeCompleto: TEdit
    Left = 16
    Top = 35
    Width = 342
    Height = 21
    TabOrder = 1
  end
  object edtIdade: TNumberBox
    Left = 16
    Top = 81
    Width = 121
    Height = 21
    TabOrder = 2
  end
  object Edit1: TEdit
    Left = 16
    Top = 81
    Width = 342
    Height = 21
    TabOrder = 3
  end
end

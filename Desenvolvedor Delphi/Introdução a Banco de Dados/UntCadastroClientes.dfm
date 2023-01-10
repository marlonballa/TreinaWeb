object frmBancoDadosComDelphi: TfrmBancoDadosComDelphi
  Left = 0
  Top = 0
  Caption = 'Banco de Dados com Delphi'
  ClientHeight = 465
  ClientWidth = 779
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
    Width = 78
    Height = 13
    Caption = 'Nome do Cliente'
    FocusControl = DBEdit1
  end
  object Label2: TLabel
    Left = 391
    Top = 8
    Width = 60
    Height = 13
    Caption = 'Raz'#227'o Social'
    FocusControl = DBEdit2
  end
  object Label3: TLabel
    Left = 8
    Top = 54
    Width = 85
    Height = 13
    Caption = 'Data de Cadastro'
    FocusControl = DBEdit3
  end
  object Label4: TLabel
    Left = 176
    Top = 54
    Width = 48
    Height = 13
    Caption = 'CPF/CNPJ'
    FocusControl = DBEdit4
  end
  object Label5: TLabel
    Left = 391
    Top = 54
    Width = 45
    Height = 13
    Caption = 'Endere'#231'o'
    FocusControl = DBEdit5
  end
  object Label6: TLabel
    Left = 647
    Top = 54
    Width = 19
    Height = 13
    Caption = 'CEP'
    FocusControl = DBEdit6
  end
  object DBEdit1: TDBEdit
    Left = 8
    Top = 27
    Width = 377
    Height = 21
    DataField = 'NomeCliente'
    DataSource = dtsClientes
    TabOrder = 0
  end
  object DBEdit2: TDBEdit
    Left = 391
    Top = 27
    Width = 377
    Height = 21
    DataField = 'RazaoSocial'
    DataSource = dtsClientes
    TabOrder = 1
  end
  object DBEdit3: TDBEdit
    Left = 8
    Top = 73
    Width = 162
    Height = 21
    DataField = 'DataCadastro'
    DataSource = dtsClientes
    TabOrder = 2
  end
  object DBEdit4: TDBEdit
    Left = 176
    Top = 73
    Width = 209
    Height = 21
    DataField = 'CPFCNPJ'
    DataSource = dtsClientes
    TabOrder = 3
  end
  object DBEdit5: TDBEdit
    Left = 391
    Top = 73
    Width = 250
    Height = 21
    DataField = 'Endereco'
    DataSource = dtsClientes
    TabOrder = 4
  end
  object DBEdit6: TDBEdit
    Left = 647
    Top = 73
    Width = 121
    Height = 21
    DataField = 'CEP'
    DataSource = dtsClientes
    TabOrder = 5
  end
  object DBNavigator1: TDBNavigator
    Left = 0
    Top = 440
    Width = 779
    Height = 25
    DataSource = dtsClientes
    Align = alBottom
    TabOrder = 6
    ExplicitLeft = 464
    ExplicitTop = 464
    ExplicitWidth = 240
  end
  object DBGrid1: TDBGrid
    Left = 8
    Top = 100
    Width = 760
    Height = 334
    DataSource = dtsClientes
    ReadOnly = True
    TabOrder = 7
    TitleFont.Charset = DEFAULT_CHARSET
    TitleFont.Color = clWindowText
    TitleFont.Height = -11
    TitleFont.Name = 'Tahoma'
    TitleFont.Style = []
    Columns = <
      item
        Expanded = False
        FieldName = 'NomeCliente'
        Title.Caption = 'Nome do Cliente'
        Width = 180
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'RazaoSocial'
        Title.Caption = 'Raz'#227'o Social'
        Width = 180
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'DataCadastro'
        Title.Caption = 'Cadastro'
        Width = 60
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'CPFCNPJ'
        Title.Caption = 'CPF/CNPJ'
        Width = 100
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'Endereco'
        Title.Caption = 'Endere'#231'o'
        Width = 150
        Visible = True
      end
      item
        Expanded = False
        FieldName = 'CEP'
        Width = 80
        Visible = True
      end>
  end
  object cdsClientes: TClientDataSet
    PersistDataPacket.Data = {
      C00000009619E0BD010000001800000006000000000003000000C0000B4E6F6D
      65436C69656E746501004900000001000557494454480200020028000B52617A
      616F536F6369616C01004900000001000557494454480200020032000C446174
      61436164617374726F080008000000000007435046434E504A01004900000001
      0005574944544802000200140008456E64657265636F01004900000001000557
      4944544802000200C80003434550010049000000010005574944544802000200
      09000000}
    Active = True
    Aggregates = <>
    Params = <>
    Left = 336
    Top = 8
    object cdsClientesNomeCliente: TStringField
      FieldName = 'NomeCliente'
      Size = 40
    end
    object cdsClientesRazaoSocial: TStringField
      FieldName = 'RazaoSocial'
      Size = 50
    end
    object cdsClientesDataCadastro: TDateTimeField
      FieldName = 'DataCadastro'
    end
    object cdsClientesCPFCNPJ: TStringField
      FieldName = 'CPFCNPJ'
    end
    object cdsClientesEndereco: TStringField
      FieldName = 'Endereco'
      Size = 200
    end
    object cdsClientesCEP: TStringField
      FieldName = 'CEP'
      Size = 9
    end
  end
  object dtsClientes: TDataSource
    DataSet = cdsClientes
    Left = 336
    Top = 56
  end
end

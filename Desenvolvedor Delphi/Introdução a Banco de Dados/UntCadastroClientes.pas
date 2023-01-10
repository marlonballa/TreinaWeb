unit UntCadastroClientes;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Data.DB, Datasnap.DBClient, Vcl.Grids,
  Vcl.DBGrids, Vcl.ExtCtrls, Vcl.DBCtrls, Vcl.StdCtrls, Vcl.Mask;

type
  TfrmBancoDadosComDelphi = class(TForm)
    cdsClientes: TClientDataSet;
    cdsClientesNomeCliente: TStringField;
    cdsClientesRazaoSocial: TStringField;
    cdsClientesDataCadastro: TDateTimeField;
    cdsClientesCPFCNPJ: TStringField;
    cdsClientesEndereco: TStringField;
    cdsClientesCEP: TStringField;
    Label1: TLabel;
    DBEdit1: TDBEdit;
    dtsClientes: TDataSource;
    Label2: TLabel;
    DBEdit2: TDBEdit;
    Label3: TLabel;
    DBEdit3: TDBEdit;
    Label4: TLabel;
    DBEdit4: TDBEdit;
    Label5: TLabel;
    DBEdit5: TDBEdit;
    Label6: TLabel;
    DBEdit6: TDBEdit;
    DBNavigator1: TDBNavigator;
    DBGrid1: TDBGrid;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmBancoDadosComDelphi: TfrmBancoDadosComDelphi;

implementation

{$R *.dfm}

end.

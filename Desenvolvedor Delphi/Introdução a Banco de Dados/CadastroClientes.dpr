program CadastroClientes;

uses
  Vcl.Forms,
  UntCadastroClientes in 'UntCadastroClientes.pas' {frmBancoDadosComDelphi};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TfrmBancoDadosComDelphi, frmBancoDadosComDelphi);
  Application.Run;
end.

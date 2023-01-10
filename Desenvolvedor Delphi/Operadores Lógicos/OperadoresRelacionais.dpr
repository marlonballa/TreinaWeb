program OperadoresRelacionais;

uses
  Vcl.Forms,
  UntOperadoresRelacionais in 'UntOperadoresRelacionais.pas' {frmOperacoesBooleanas};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TfrmOperacoesBooleanas, frmOperacoesBooleanas);
  Application.Run;
end.

program OperadoresRelacionais;

uses
  Vcl.Forms,
  untOperadoresRelacionais in 'untOperadoresRelacionais.pas' {frmOperadoresRelacionais};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TfrmOperadoresRelacionais, frmOperadoresRelacionais);
  Application.Run;
end.

program OperadoresAritmeticos;

uses
  Vcl.Forms,
  UntOperadoresAritmeticos in 'UntOperadoresAritmeticos.pas' {frmOperadoresAritmeticos};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TfrmOperadoresAritmeticos, frmOperadoresAritmeticos);
  Application.Run;
end.

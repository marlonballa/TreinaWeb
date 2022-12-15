program DesenvolvedorDelphiPrimeiroExemplo;

uses
  Vcl.Forms,
  PrimeiroProjetoDelphi in 'PrimeiroProjetoDelphi.pas' {frmPrincipal};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TfrmPrincipal, frmPrincipal);
  Application.Run;
end.

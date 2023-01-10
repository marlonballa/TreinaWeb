unit UntOperadoresRelacionais;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Samples.Spin;

type
  TfrmOperacoesBooleanas = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    stcResultadoBooleano: TStaticText;
    GroupBox1: TGroupBox;
    btnNot: TButton;
    btnAnd: TButton;
    btnOr: TButton;
    btnXor: TButton;
    lblBooleanResult: TLabel;
    cbFirstOption: TComboBox;
    cbSecondOption: TComboBox;
    procedure btnNotClick(Sender: TObject);
    procedure btnAndClick(Sender: TObject);
    procedure btnOrClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmOperacoesBooleanas: TfrmOperacoesBooleanas;

implementation

{$R *.dfm}

procedure TfrmOperacoesBooleanas.btnAndClick(Sender: TObject);
begin
    if (cbFirstOption.Text = 'TRUE') and (cbSecondOption.Text = 'TRUE') then
      lblBooleanResult.Caption := 'TRUE'
    else if (cbFirstOption.Text = 'FALSE') and (cbSecondOption.Text = 'FALSE') then
      lblBooleanResult.Caption := 'TRUE'
    else
   lblBooleanResult.Caption := 'FALSE';
end;

procedure TfrmOperacoesBooleanas.btnNotClick(Sender: TObject);
begin

  if not (cbFirstOption.Text = cbSecondOption.Text) then
    lblBooleanResult.Caption := 'TRUE'
  else
   lblBooleanResult.Caption := 'FALSE';

end;

procedure TfrmOperacoesBooleanas.btnOrClick(Sender: TObject);
begin
    if (cbFirstOption.Text = 'TRUE') or (cbSecondOption.Text = 'TRUE') then
      lblBooleanResult.Caption := 'TRUE'
    else
   lblBooleanResult.Caption := 'FALSE';
end;

end.

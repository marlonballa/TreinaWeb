unit untOperadoresRelacionais;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.ExtCtrls,
  Vcl.Samples.Spin;

type
  TfrmOperadoresRelacionais = class(TForm)
    spedtFirst: TSpinEdit;
    Label1: TLabel;
    spedtSecond: TSpinEdit;
    Label2: TLabel;
    gbOperadoresRelacionais: TGroupBox;
    resultAnswer: TPanel;
    rbIgual: TRadioButton;
    rbMaior: TRadioButton;
    rbMenor: TRadioButton;
    rbMaiorIgual: TRadioButton;
    rbMenorIgual: TRadioButton;
    rbDiferente: TRadioButton;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    btnReset: TButton;
    procedure rbIgualClick(Sender: TObject);
    procedure btnResetClick(Sender: TObject);
    procedure rbMaiorClick(Sender: TObject);
    procedure rbMenorClick(Sender: TObject);
    procedure rbMaiorIgualClick(Sender: TObject);
    procedure rbMenorIgualClick(Sender: TObject);
    procedure rbDiferenteClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmOperadoresRelacionais: TfrmOperadoresRelacionais;
    firstNumber, secondNumber : integer;

implementation

{$R *.dfm}

procedure TfrmOperadoresRelacionais.btnResetClick(Sender: TObject);
begin
  resultAnswer.Caption := '';
  rbIgual.Checked := false;
  rbMaior.Checked := false;
  rbMenor.Checked := false;
  rbDiferente.Checked := false;
  rbMaiorIgual.Checked := false;
  rbMenorIgual.Checked := false;
end;

procedure TfrmOperadoresRelacionais.rbDiferenteClick(Sender: TObject);
begin
  firstNumber := spedtFirst.Value;
  secondNumber := spedtSecond.Value;
  if rbDiferente.Checked then
    if (firstNumber <> secondNumber) then
      resultAnswer.Caption := 'Os valores informados são diferentes'
    else
      resultAnswer.Caption := 'Os valores informados são iguais';
end;

procedure TfrmOperadoresRelacionais.rbIgualClick(Sender: TObject);
begin
  firstNumber := spedtFirst.Value;
  secondNumber := spedtSecond.Value;
  if rbIgual.Checked then
    if (firstNumber = secondNumber) then
      resultAnswer.Caption := 'Os valores informados são iguais'
    else
      resultAnswer.Caption := 'Os valores informados não são iguais';
end;

procedure TfrmOperadoresRelacionais.rbMaiorClick(Sender: TObject);
begin
  firstNumber := spedtFirst.Value;
  secondNumber := spedtSecond.Value;
  if rbMaior.Checked then
    if (firstNumber > secondNumber) then
      resultAnswer.Caption := 'O primeiro valor é maior que o segundo'
    else
      resultAnswer.Caption := 'O segundo valor é maior que o primeiro';
end;

procedure TfrmOperadoresRelacionais.rbMaiorIgualClick(Sender: TObject);
begin
  firstNumber := spedtFirst.Value;
  secondNumber := spedtSecond.Value;
  if rbMaiorIgual.Checked then
    if (firstNumber >= secondNumber) then
      resultAnswer.Caption := 'O primeiro valor é maior ou igual ao segundo'
    else
      resultAnswer.Caption := 'O segundo valor é maior ou igual ao primeiro';
end;

procedure TfrmOperadoresRelacionais.rbMenorClick(Sender: TObject);
begin
  firstNumber := spedtFirst.Value;
  secondNumber := spedtSecond.Value;
  if rbMenor.Checked then
    if (firstNumber < secondNumber) then
      resultAnswer.Caption := 'O primeiro valor é menor que o segundo'
    else
      resultAnswer.Caption := 'O segundo valor é menor que o primeiro';
end;

procedure TfrmOperadoresRelacionais.rbMenorIgualClick(Sender: TObject);
begin
    firstNumber := spedtFirst.Value;
  secondNumber := spedtSecond.Value;
  if rbMenorIgual.Checked then
    if (firstNumber >= secondNumber) then
      resultAnswer.Caption := 'O primeiro valor é menor ou igual ao segundo'
    else
      resultAnswer.Caption := 'O segundo valor é menor ou igual ao primeiro';
end;

end.

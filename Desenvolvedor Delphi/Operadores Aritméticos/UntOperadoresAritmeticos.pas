unit UntOperadoresAritmeticos;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Samples.Spin;

type
  TfrmOperadoresAritmeticos = class(TForm)
    spedtResult: TSpinEdit;
    spedtSecondNumber: TSpinEdit;
    spedtFirstNumber: TSpinEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    btnSomar: TButton;
    btnDivisaoReal: TButton;
    btnResult: TButton;
    btnSubtrair: TButton;
    btnMultiplicar: TButton;
    Button6: TButton;
    btnDivisaoInteira: TButton;
    btnReset: TButton;
    procedure btnSomarClick(Sender: TObject);
    procedure btnResultClick(Sender: TObject);
    procedure btnSubtrairClick(Sender: TObject);
    procedure btnResetClick(Sender: TObject);
    procedure btnMultiplicarClick(Sender: TObject);
    procedure btnDivisaoRealClick(Sender: TObject);
    procedure btnDivisaoInteiraClick(Sender: TObject);
    procedure Button6Click(Sender: TObject);
  private
    { Private declarations }
      function Operations (firstNumber, secondNumber, operation : Double) : Double;
  public
    { Public declarations }
  end;

  function TfrmOperadoresAritmeticos.Operations(firstNumber, secondNumber, operation : Double) : Double;
    var result : Double;
    begin
        case operation of
          1: result := firstNumber + secondNumber;
          2: result := firstNumber - secondNumber;
          3: result := firstNumber * secondNumber;
          5: result := firstNumber div secondNumber;
          6: result := firstNumber mod secondNumber;
        end;
    end;

var
  frmOperadoresAritmeticos: TfrmOperadoresAritmeticos;
  operacaoEscolhida: Integer;
implementation

{$R *.dfm}

procedure TfrmOperadoresAritmeticos.btnDivisaoInteiraClick(Sender: TObject);
begin
  spedtSecondNumber.Enabled := true;
  operacaoEscolhida := 5;
end;

procedure TfrmOperadoresAritmeticos.btnDivisaoRealClick(Sender: TObject);
begin
  spedtSecondNumber.Enabled := true;
  spedtResult.Value := firstNumber / secondNumber;
end;

procedure TfrmOperadoresAritmeticos.btnMultiplicarClick(Sender: TObject);
begin
  spedtSecondNumber.Enabled := true;
  operacaoEscolhida := 3;
end;

procedure TfrmOperadoresAritmeticos.btnResetClick(Sender: TObject);
begin
  spedtSecondNumber.Enabled := false;

  spedtFirstNumber.Value := 0;
  spedtSecondNumber.Value := 0;
  spedtResult.Value := 0;
end;

procedure TfrmOperadoresAritmeticos.btnSomarClick(Sender: TObject);
begin
  spedtSecondNumber.Enabled := true;
  operacaoEscolhida := 1;
end;
procedure TfrmOperadoresAritmeticos.btnSubtrairClick(Sender: TObject);
begin
  spedtSecondNumber.Enabled := true;
  operacaoEscolhida := 2;
end;

procedure TfrmOperadoresAritmeticos.Button6Click(Sender: TObject);
begin
  spedtSecondNumber.Enabled := true;
  operacaoEscolhida := 6;
end;

procedure TfrmOperadoresAritmeticos.btnResultClick(Sender: TObject);
begin
   spedtResult.Value := Operations(spedtFirstNumber.Value, spedtSecondNumber.Value, operacaoEscolhida);
end;

end.





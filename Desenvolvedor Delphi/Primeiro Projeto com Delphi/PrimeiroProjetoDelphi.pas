unit PrimeiroProjetoDelphi;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.NumberBox;

type
  TfrmPrincipal = class(TForm)
    lblNomeCliente: TLabel;
    btnShowMessage: TButton;
    edtNomeCompleto: TEdit;
    lblIdade: TLabel;
    edtIdade: TNumberBox;
    Edit1: TEdit;
    procedure btnShowMessageClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmPrincipal: TfrmPrincipal;

implementation

{$R *.dfm}

procedure TfrmPrincipal.btnShowMessageClick(Sender: TObject);
//Criando identificadores

//Nunca devemos declarar as constantes após as variáveis.
//Constantes possuem inferência de tipo, por isso não é necessário indicar o seu tipo.
const
  NomeDoTreinamento = 'Desenvolvimento Utilizando Delphi: TreinaWeb';
  DiasDeCurso = 10;

var
  NomeCompleto : String;
  Idade: String;
  DataNascimento: TDateTime;

begin

  NomeCompleto := edtNomeCompleto.Text;
  Idade := edtIdade.Text;

  ShowMessage('Seja bem-vindo, ' + NomeCompleto + '. Você tem: ' + Idade + ' anos.');
end;

end.

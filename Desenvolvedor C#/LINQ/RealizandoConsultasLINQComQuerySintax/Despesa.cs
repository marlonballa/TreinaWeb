using System;

namespace RealizandoConsultasLINQComQuerySintax
{
    public class Despesa
    {
        public string Descricao { get; set; } = string.Empty;
        public double Valor { get; set; }
        public DateTime Vencimento { get; set; }

        public override string ToString() => $"{Descricao.PadRight(20, ' ')} - {Vencimento.ToString("dd/MM/yyyy")} - {Valor.ToString("C")}";
    }
}
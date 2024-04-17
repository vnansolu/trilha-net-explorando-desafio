namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Implementado
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("A capacidade excedeu o número de hóspedes. Não é possível fazer a reserva");// TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // Implementado
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Implementado
            if (DiasReservados >= 10)
            {
                decimal desconto = valor * 0.1m;
                valor = valor - desconto;
            }

            return valor;
            
        }
    }
}
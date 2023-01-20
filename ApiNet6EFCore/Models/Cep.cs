namespace ApiNet6EFCore.Controllers
{
    public class Cep
    {
        //obrigatorio para o Entity Framework Core
        public int Id { get; set; }

        // campo obrigatório
        public string Numero { get; set; }

        // campo opcional. Uso do ponto de interrogação após o tipo
        public string? Estado { get; set; } 

        public Cep(string numero)
        {
            Numero = numero;
        }

        public string ObterEstado()
        {
            string estado = "INDEFINIDO";

            if (Numero.StartsWith("0") || Numero.StartsWith("1"))
            {
                estado = "SP";
            }
            else if (Numero.StartsWith("2"))
            {
                estado = "RJ";
            }

            return estado;
        }
    }
}
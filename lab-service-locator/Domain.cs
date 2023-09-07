namespace lab_service_locator
{
    public class Domain
    {
        public String? Nome { get; set; }
    }

    public interface IServico
    {
        public void facaAlgo(Domain domain);
    }

    public class Servico : IServico
    {
        public void facaAlgo(Domain domain)
        {
            Console.WriteLine("Serviço A: " + domain.Nome);
        }
    }

    public class ServicoB : IServico
    {
        public void facaAlgo(Domain domain)
        {
            Console.WriteLine("Serviço B: " + domain.Nome);
        }
    }
}

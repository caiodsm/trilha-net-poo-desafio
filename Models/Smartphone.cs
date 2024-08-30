namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }


        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected List<string> aplicativos;

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            aplicativos = new List<string>();
        }

        public void AdicionarAplicativo(string nomeApp)
        {
            aplicativos.Add(nomeApp);
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }



        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
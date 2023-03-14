using Builder.Soldados;

namespace Builder.Builders
{
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadoDeInfantariaLeve();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Ataque aéreo.");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Resposta rápida aérea.");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Helicóptero de ataque do Exército.");
        }
    }
}

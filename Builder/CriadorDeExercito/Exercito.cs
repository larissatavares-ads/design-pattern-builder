using Builder.Builders;

namespace Builder.CriadorDeExercito
{
    public class Exercito
    {
        public void ConstruirSoldado(CriadorDeSoldado criadorDeSoldado)
        {
            criadorDeSoldado.Arma();
            criadorDeSoldado.Transporte();
            criadorDeSoldado.Foco();
        }
    }
}

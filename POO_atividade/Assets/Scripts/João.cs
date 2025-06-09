using UnityEngine;

public class João : Personagem
{

    private enum tipoClasse
    {
        Viking
    }

    public enum Habilidade_especial
    {
        Fúria_do_Norte
    }
public enum tipoArma
    {
        Machado_duplo
    }
    
    public enum tipoPassiva
    {
        resistência
    }
    
    [SerializeField]
    private Habilidade_especial habilidade;
    [ SerializeField ]
    private tipoClasse Classe;
    [ SerializeField ]
    private tipoArma arma;
    [ SerializeField ]
    private tipoPassiva passiva;
    
    public void AtribuirArma(tipoArma arma)
    {
        this.arma = arma;
    }

    public tipoArma Arma()
    {
        return this.arma;
    }

    public void AtribuirPassiva(tipoPassiva passiva)
    {
        this.passiva = passiva;
    }

    public tipoPassiva Passiva()
    {
        return this.passiva;
    }
    
    public void AtribuirHabilidade(Habilidade_especial habilidade)
    {
        this.habilidade = habilidade;
    }

    public Habilidade_especial Habilidade()
    {
        return this.habilidade;
    }
    
}   


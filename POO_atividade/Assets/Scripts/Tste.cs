using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    void Start()
    {
        
        Personagem personagem1 = gameObject.AddComponent<Personagem>();
        personagem1.AtribuirNome("Filipe gosta do Negão");
        personagem1.AtribuirEnergia(100);
        personagem1.AtribuirForca_Ataque(30);
        personagem1.AtribuirForca_do_pulo(5.5f);
        personagem1.AtribuirVelocidade(2.0f);
        personagem1.AtribuitNumero_de_pes(2);
        personagem1.AtribuitNumero_de_maos(2);

        
        João joaoViking = gameObject.AddComponent<João>();
        joaoViking.AtribuirNome("João, o Viking");
        joaoViking.AtribuirEnergia(150);
        joaoViking.AtribuirForca_Ataque(45);
        joaoViking.AtribuirForca_do_pulo(7.0f);
        joaoViking.AtribuirVelocidade(2.5f);
        joaoViking.AtribuitNumero_de_pes(2);
        joaoViking.AtribuitNumero_de_maos(2);
        joaoViking.AtribuirArma(João.tipoArma.Machado_duplo);
        joaoViking.AtribuirHabilidade(João.Habilidade_especial.Fúria_do_Norte);
        joaoViking.AtribuirPassiva(João.tipoPassiva.resistência);

        
        Debug.Log("==filipe gosta do Negão"==);
        Debug.Log("Nome: " + personagemGenerico.Nome());
        Debug.Log("Energia: " + personagemGenerico.Energia());
        Debug.Log("Força de Ataque: " + personagemGenerico.Forca_Ataque());
        Debug.Log("Força do Pulo: " + personagemGenerico.Forca_do_pulo());
        Debug.Log("Velocidade: " + personagemGenerico.Velocidade());
        Debug.Log("Pés: " + personagemGenerico.Numero_de_pes());
        Debug.Log("Mãos: " + personagemGenerico.Numero_de_maos());

        Debug.Log("==JOÃO O VIKING masi forte da atualidade==);
        Debug.Log("Nome: " + joaoViking.Nome());
        Debug.Log("Energia: " + joaoViking.Energia());
        Debug.Log("Força de Ataque: " + joaoViking.Forca_Ataque());
        Debug.Log("Força do Pulo: " + joaoViking.Forca_do_pulo());
        Debug.Log("Velocidade: " + joaoViking.Velocidade());
        Debug.Log("Pés: " + joaoViking.Numero_de_pes());
        Debug.Log("Mãos: " + joaoViking.Numero_de_maos());
        Debug.Log("Arma: " + joaoViking.Arma());
        Debug.Log("Habilidade Especial: " + joaoViking.Habilidade());
        Debug.Log("Passiva: " + joaoViking.Passiva());

        
        bool joaoMaisForte = joaoViking.CompararForca(personagem1);
        if (joaoMaisForte)
        {
            Debug.Log($"{joaoViking.Nome()} é mais forte que {personagem1.Nome()}.");
        }
        else
        {
            Debug.Log($"{personagem1.Nome()} é mais forte que {joaoViking.Nome()}.");
        }
    }
}

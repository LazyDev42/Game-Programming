using Unity.VisualScripting;
using UnityEditor.Media;
using UnityEngine;

public class Desafio3 : MonoBehaviour
{
    [SerializeField] private int vida;
    [SerializeField] private int ataque;
    [SerializeField] private int defesa;
    bool jogador; 
    void Start()
    {
        if (vida == 0 || ataque == 0 || defesa == 0)
        {
            jogador = false;
            print("O valor necessita ser no minimo um");
        }
        if (vida + defesa + ataque > 10)
        {
            print("O Valor não pode Exceder 10 pontos");
            jogador = false;
        }
        else
            jogador = true;
    }
    void Update()
    {
      if(jogador == true)
      { 
            int index = 1;
            int vidaCPU = 1;
            int ataqueCPU = 1;
            int defesaCPU = 1;
            if (index <= 7)
            {
                int aleatorio = Random.Range(1, 4);

                if (aleatorio == 1)
                {
                    vidaCPU++;
                }
                else if (aleatorio == 2)
                {
                    defesaCPU++;
                }
                else
                {
                    ataqueCPU++;
                }
                index++;
            }
            if (Input.anyKeyDown)
            {
                int dado1 = (Random.Range(1, 7));
                int dado2 = (Random.Range(1, 7));
                int dado3 = (Random.Range(1, 7));
                if (dado1 % 2 == 0)
                {
                    int AtaquePlayer = ataque + dado2;

                    if (AtaquePlayer > defesaCPU)
                    {
                        print("Turno de Ataque!!!");
                        int dano = AtaquePlayer - defesaCPU;
                        vidaCPU -= dano;
                        print("O Bot de tomou " + dano + " de dano");
                    }
                    else
                    {
                        print("Não conseguiu passar a defesa do bot KKKKKKK");
                    }
                }
                else if (dado1 % 2 != 0)
                {
                    int AtaqueTempCPU = ataqueCPU + dado3;
                    if (AtaqueTempCPU > defesa)
                    {
                        print("Vez do Bot!!!");
                        int danoCPU = AtaqueTempCPU - defesa;
                        vida -= danoCPU;
                        print("O Bot deu" + danoCPU + " de Dano");
                    }
                    else
                    {
                        print("Moggou o Bot, ele não te deu dano");
                    }
                }
                if (vida == 0)
                {
                    print("Você perdeu pra uma lata com cerebro KKKKKKKKK");
                }
                else if (vidaCPU == 0)
                {
                    print("Você moggou a lata velha");
                }
            }
      }        
    }
}

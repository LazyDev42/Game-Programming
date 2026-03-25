using UnityEngine;

public class Desafio2 : MonoBehaviour
{
    [Header("Selecione um número aleátorio com base na dificuldade")]
    [SerializeField] private int numero;
    [Header("Escolha a Dificuldade entre 1 e 3")]
    [Header("A dificuldade 1 é um número de 1 à 50")]
    [Header("A dificuldade 2 é um número de 1 à 100")]
    [Header("A dificuldade 2 é um número de 1 à 500")]
    [SerializeField] private int Dificuldade;
    private int tentativas;
    private int valor;
    private void Start()
    {
        switch (Dificuldade)
        {
            case 1:
                valor = Random.Range(1, 51);
                break;
            case 2:
                valor = Random.Range(1, 101);
                break;
            case 3:
                valor = Random.Range(1, 501);
                break;
            default:
                print("Valor inválido!!!");
                break;    
        } 
    }
    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            tentativas++;
            if (tentativas > 3)
            {
                print("As tentativas acabaram!");
            }
            else
            {
                if (valor > numero)
                {
                    print("Muito baixo!!!");
                }
                else
                {
                    if (valor < numero)
                    {
                        print("Muito alto!!!");
                    }
                    else
                    {
                        if (valor == numero)
                        {
                            print("Acertou!!!");
                        }
                    }
                }   
            }
            print("O numero de tentativas é: " + tentativas);
        }
    }
}

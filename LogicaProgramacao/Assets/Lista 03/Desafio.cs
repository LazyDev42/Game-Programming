using Unity.Android.Types;
using UnityEngine;

public class Desafio : MonoBehaviour
{
    int jogador1;
    int jogador2;
    int dado1;
    int dado2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            dado1 = Random.Range(1, 7);
            dado2 = Random.Range(1, 7);

            print("O dado do jogador um é: " + dado1);
            print("O dado do jogador dois é: " + dado2);
            if (dado1 > dado2)
            {
                jogador1 += 1;
                print("Jogador um pontuou!");
            }
            if (dado1 < dado2)
            {
                jogador2 += 1;
                print("Jogador dois pontuou!");
            }
            if (jogador1 >= 3)
            {
                print("Jogador Um Venceu!");
            }
            if (jogador2 >= 3)
            {
                print("Jogador Dois Venceu!");
            }
        }
    }
}

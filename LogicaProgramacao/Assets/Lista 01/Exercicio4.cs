using Unity.VisualScripting;
using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    [SerializeField] private float moedas;
    [SerializeField] private float grupo;

    void Start()
    {
        print(moedas + " moedas foram dividas ao grupo que contém: " + grupo + " Jogadores");

        float divisao = moedas / grupo;

        print("Foram dividas " + divisao + " moedas para cada jogador");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

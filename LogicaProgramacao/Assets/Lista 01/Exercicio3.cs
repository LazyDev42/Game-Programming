using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    [SerializeField] private int ponto;
    [SerializeField] private int multiplicador;

    void Start()
    {
        print("O Player conseguiu " + ponto + "pontos, seu multiplicador é " + multiplicador + "X contabilizando um total de " + (ponto * multiplicador));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

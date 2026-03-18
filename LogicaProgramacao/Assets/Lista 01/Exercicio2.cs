using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    [SerializeField] private int vida;
    [SerializeField] private int dano;

    void Start()
    {
        print("O Player tem: " + vida + " de vida");
        print("Cuidado! O player levou " + dano + " de dano");

        int danoTomado = vida - dano;

        print("A vida atual do player é " + danoTomado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class ex3_lista2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int mana = 100;
        int manaUsada = 30 + 20 + 25;
        int gasto = mana - manaUsada;
        print("A quantidade de mana restante é: " + gasto);
    }


}
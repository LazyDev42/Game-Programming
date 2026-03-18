using UnityEngine;

public class ex7_lista2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    


    void Start()
    {
        int vida = 150;
        int dano = 20 + 35 + 15;
        print("vida restante do personagem é: " + (vida - dano));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

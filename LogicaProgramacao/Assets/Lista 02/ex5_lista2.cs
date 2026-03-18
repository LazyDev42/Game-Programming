using UnityEngine;

public class ex5_lista2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int bronze = 12 * 1;
    int prata = 8 * 5;
    int ouro = 3 * 10;


    void Start()
    {
       int valor = bronze + prata + ouro;
        print("a quantidade de total das moedas é: " + valor + "$");
    }

   
}

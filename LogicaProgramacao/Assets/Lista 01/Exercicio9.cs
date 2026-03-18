using UnityEngine;

public class Exercicio9 : MonoBehaviour
{
    [SerializeField] private float numero;

    void Start()
    {
        print("O dobro de " +  numero + " é: " + (numero * 2));
        print("A metade de " +  numero + " é: " + (numero / 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    [SerializeField] private int a;
    [SerializeField] private int b;



    void Start()
    {
        print("A soma de a + b é: " + (a + b));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

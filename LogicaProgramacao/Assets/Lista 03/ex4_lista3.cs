using UnityEngine;

public class ex4_lista3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float numero1;
    [SerializeField] private float numero2;

    void Start()
    {
        if (numero1 == numero2)
        {

            print("São iguais");

        }

        else
        {
            print("São Diferentes");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class ex3_lista3 : MonoBehaviour
{
    [SerializeField] private int numero;
    void Start()
    {
        if ( numero%2 == 0)
        {
            print("é par");
        }
        else
        {
            print("impar");
        }
    }
}

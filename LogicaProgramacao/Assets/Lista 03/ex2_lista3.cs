using UnityEngine;
public class ex2_lista3 : MonoBehaviour
{
    [SerializeField] private int idade;   
    void Start()
    {
        if (idade >= 18)
        {
            print("É maior de idade");
        }
        else
        { 
            print("É menor de idade");
        }
    }
}
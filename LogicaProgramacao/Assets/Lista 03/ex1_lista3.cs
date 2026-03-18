using UnityEditor.Experimental.GraphView;
using UnityEngine;
public class ex1_lista3 : MonoBehaviour
{
    [SerializeField] private float valor1;
    [SerializeField] private float valor2;
    void Start()
    {
        if (valor1 > valor2)
        {
            print("O valor é maior");
        }
        else if (valor1 < valor2)
        {
            print("O valor é menor");
        }
        else
        {
            print("O valor é igual");
        }
    }
}

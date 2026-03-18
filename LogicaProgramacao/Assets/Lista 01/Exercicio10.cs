using UnityEngine;

public class Exercicio10 : MonoBehaviour
{
    [SerializeField] private float salario = 1000f;

    void Start()
    {
        float aumento = salario + (salario * 0.10f);

        print(aumento);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

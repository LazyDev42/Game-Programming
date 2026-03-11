using UnityEngine;

public class Aula2 : MonoBehaviour
{
    [SerializeField] private string produto;
    [SerializeField] private float valorProduto;
    [SerializeField] private float desconto;
    
    void Start()
    {
        
        print(produto + " seu valor é: " + valorProduto);

        float valorDesconto = valorProduto * (desconto / 100);

        valorProduto = valorProduto - valorDesconto;

        print(produto + "com desconto fica: " + valorProduto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

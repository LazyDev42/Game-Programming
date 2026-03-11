using UnityEngine;

public class Exercicio12 : MonoBehaviour
{
    public int pontoBase;
    public int inimgosDerrotados;
    public int bonus;
    
    void Start()
    {
        int pontuacaoFinal = (pontoBase * inimgosDerrotados) + bonus;
        
        print(pontuacaoFinal);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

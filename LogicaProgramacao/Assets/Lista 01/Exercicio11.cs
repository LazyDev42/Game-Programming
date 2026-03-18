using UnityEngine;

public class Exercicio11 : MonoBehaviour
{
    public float velocidadeinicial;
    public float aceleracao;
    public float tempo;

    void Start()
    {
       float velocidadeFinal = velocidadeinicial + aceleracao * tempo;

        print(velocidadeFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

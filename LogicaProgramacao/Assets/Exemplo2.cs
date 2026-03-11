using UnityEngine;

public class Exemplo2 : MonoBehaviour
{
    [SerializeField] private string funcionario;
    [SerializeField] private float tempoTrabalho;
    [SerializeField] private float valorHora;
    

    void Start()
    {
        print("O funcionário " + funcionario + " trabalhou por: " + tempoTrabalho + " horas");

        float pagamento = valorHora * tempoTrabalho;

        print(funcionario + " recebe " + valorHora + " reais por hora, então seu pagamento será " + pagamento + " Reais");
    }


    void Update()
    {
        
    }
}

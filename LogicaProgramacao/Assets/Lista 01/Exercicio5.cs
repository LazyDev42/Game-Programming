using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    [SerializeField] private int a;
    [SerializeField] private int b;

    void Start()
    {
        print((a % b));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

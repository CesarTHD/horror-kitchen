using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class Frutas : MonoBehaviour
{
    // Tempo de espera em segundos
    public float tempoDeEspera = 5000f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Função para adicionar força após o tempo de espera
    void AdicionarForcaComAtraso()
    {
        if (GetComponent<Rigidbody>().velocity.magnitude < 2.5f)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-5f, 0, 0));
        }
    }

    void Update()
    {
        InvokeRepeating(nameof(AdicionarForcaComAtraso), tempoDeEspera, tempoDeEspera);

    }
}

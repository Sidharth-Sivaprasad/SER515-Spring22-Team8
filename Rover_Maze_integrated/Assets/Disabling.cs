using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Manual"))
        {
            this.GetComponent<SampleAgentScript>().enabled = false;
            this.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            this.GetComponent<Buggy>().enabled = true;
        }

        if (Input.GetButtonDown("Auto"))
        {
            this.GetComponent<SampleAgentScript>().enabled = true;
            this.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
            this.GetComponent<Buggy>().enabled = false;
        }
    }
}

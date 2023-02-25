using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{

    [Header("Destruction Timer")]
    //After this time, the object will be destroyed
    public float timeToDestruction;
    
    // Start is called before the first frame update
    void Start()
    {
        //Execuute function based on time to destruction
        Invoke("DestroyObject", timeToDestruction);

    }

    //This function will destroy this object :( R.I.P
    void DestroyObject()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}


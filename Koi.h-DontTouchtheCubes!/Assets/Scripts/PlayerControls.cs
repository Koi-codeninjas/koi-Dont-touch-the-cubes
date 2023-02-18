using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{

    [Header("Rigidbody")]
    //Rigid body component
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        //variable rb equals to component rigidbody
        rb = GetComponent<Rigidbody>();
        //Game us at a normal pace
        Time.timeScale = 1f;
    }
    // Update is called once per frame
    void Update()
    {

    }

   

}

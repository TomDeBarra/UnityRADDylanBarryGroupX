using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InvisibleTrigger : MonoBehaviour
{

    void OnCollisionEnter(Collision collided)
    {
        if (collided.gameObject.tag == "Finish");

        

    }
    public GameObject parentobject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

}

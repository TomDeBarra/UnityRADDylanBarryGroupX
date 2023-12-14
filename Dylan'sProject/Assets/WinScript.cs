using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;
public class TestText : MonoBehaviour
{
        public Text test;
        public bool flag = false;
        public GameObject trigger;
    public class CallRepeater : MonoBehaviour
    {

        float _interval = 3f;

        float _time;
        private GameObject collisionCube;
        private Collision collision;

        private void OnCollisionEnter()
        {
            Camera.main.transform.position = new Vector3(0, 0, 1000);
        }

        // Use this for initialization 
        // Start is called before the first frame update
        void Start()
        {
            _time = 0f;
        }
        // Update is called once per frame
        void Update()
        {
            _time += Time.deltaTime;
            while (_time >= _interval)
            {
                OnCollisionEnter(collision);
                _time -= _interval;
            }
            void OnCollisionEnter(Collision collision)
            {
                Camera.main.transform.position = new Vector3(0, 0, 1000);
            }
            Collider[] victims = Physics.OverlapSphere(transform.position, 10);

            foreach (Collider victim in victims)
            {
                Camera.main.transform.position = new Vector3(0, 0, 1000);
            }
        }

    }
}


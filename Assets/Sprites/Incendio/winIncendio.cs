using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winIncendio : MonoBehaviour
{
    float time;
    GameObject[] items;
    public GameObject Principal;

    public GameObject ob1;
    public GameObject ob2;
    public GameObject ob3;

    // Start is called before the first frame update
    void Start()
    {
        time  = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
            time = time + 1.0f * Time.deltaTime;

            items = GameObject.FindGameObjectsWithTag("fuego");

            Debug.Log(items.Length);

            if (items.Length == 0 && time > 2){
                ob1.SetActive(true);
                ob2.SetActive(true);
                ob3.SetActive(true); 
                this.gameObject.SetActive(false);
                Principal.gameObject.SetActive(true);
                time = 0;
            }
    }
}

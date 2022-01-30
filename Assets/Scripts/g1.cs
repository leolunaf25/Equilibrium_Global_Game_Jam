using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g1 : MonoBehaviour
{
      GameObject[] npcEliminar1;  
      GameObject[] npcEliminar2;  
      GameObject[] npcEliminar3;

      public GameObject Volcan;
      public GameObject Principal;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        npcEliminar1 = GameObject.FindGameObjectsWithTag("npc");
        npcEliminar2 = GameObject.FindGameObjectsWithTag("npc2");
        npcEliminar3 = GameObject.FindGameObjectsWithTag("npc3");
    }

    public void Minijuego()
    {
        this.gameObject.SetActive(false);
        Volcan.gameObject.SetActive(true);
        Principal.gameObject.SetActive(false);        
    }

    public void Ignora()
    {
        for (int i = 0; i < npcEliminar1.Length * Random.Range(0.3f,1.0f); i++)
          {
            Destroy(npcEliminar1[i]);
          }

        for (int i = 0; i < npcEliminar2.Length * Random.Range(0.3f,1.0f); i++)
          {
            Destroy(npcEliminar2[i]);
          }

        for (int i = 0; i < npcEliminar3.Length * Random.Range(0.3f,1.0f); i++)
          {
            Destroy(npcEliminar3[i]);
          }
            
            this.gameObject.SetActive(false);
    }
}

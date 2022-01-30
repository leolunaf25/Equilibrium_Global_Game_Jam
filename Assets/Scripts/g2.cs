using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g2 : MonoBehaviour
{
      GameObject[] npcEliminar1;  
      GameObject[] npcEliminar2;  
      GameObject[] npcEliminar3;

      public GameObject Incendio;
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
        Incendio.gameObject.SetActive(true);
        Principal.gameObject.SetActive(false);
    }

    public void Ignora()
    {
        for (int i = 0; i < npcEliminar1.Length * Random.Range(0.3f,0.7f); i++)
          {
            Destroy(npcEliminar1[i]);
          }
           
        for (int i = 0; i < npcEliminar2.Length * Random.Range(0.2f,0.5f); i++)
          {
            Destroy(npcEliminar2[i]);
          }

          this.gameObject.SetActive(false);

    }


}

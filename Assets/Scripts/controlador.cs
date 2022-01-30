using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controlador : MonoBehaviour
{
    //public GameObject npcEliminar;
      GameObject[] npcEliminar1;  
      GameObject[] npcEliminar2;  
      GameObject[] npcEliminar3;
      //public GameObject modeloInicial;

      [Header("Contadores")]
      [SerializeField] Text contador1;
      [SerializeField] Text contador2;
      [SerializeField] Text contador3;

      private int cuentadef;
      private int cuenta1;
      private int cuenta2;
      private int cuenta3;

      public GameObject gameOver;
      public GameObject nivel;
  
      float time;

    // Start is called before the first frame update
    void Start()
    {
      time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {   
        npcEliminar1 = GameObject.FindGameObjectsWithTag("npc");
        npcEliminar2 = GameObject.FindGameObjectsWithTag("npc2");
        npcEliminar3 = GameObject.FindGameObjectsWithTag("npc3");

//ESTA OPCIÓN PERMITE EL SPAWN DE LAS DEMÁS CIUDADES
//        npcEliminar2 = GameObject.FindGameObjectsWithTag("poblacion2");

        int cuenta1 = npcEliminar1.Length;// + npcEliminar2.Length;
        int cuenta2 = npcEliminar2.Length;
        int cuenta3 = npcEliminar3.Length;
        contador1.text = string.Format("{000}", cuenta1);
        contador2.text = string.Format("{000}", cuenta2);
        contador3.text = string.Format("{000}", cuenta3);

        //npcEliminar = GameObject.FindWithTag("npc");
       

        time = time + 1.0f * Time.deltaTime;

        cuentadef = cuenta1 + cuenta2 + cuenta3;
        if (cuentadef >= 300)
        {
          Debug.Log("El mundo ha colapsado debido a la sobrepoblación");
          for (int i = 0; i < npcEliminar1.Length; i++)
          {
         //Aquí se requiere de un Delay para que no desaparezcan inmediatamente
            Destroy(npcEliminar1[i], 0.1f);
          }

          for (int i = 0; i < npcEliminar2.Length; i++)
          {
         //Aquí se requiere de un Delay para que no desaparezcan inmediatamente
            Destroy(npcEliminar2[i], 0.5f);
          }

          for (int i = 0; i < npcEliminar3.Length; i++)
          {
            Destroy(npcEliminar3[i], 1.0f);
          }

          gameOver.SetActive(true);
          nivel.SetActive(false);

        }

        if (cuentadef <= 0 && time > 2)
        {
          Debug.Log("La población se ha extinguido");
          gameOver.SetActive(true);
          nivel.SetActive(false);
        }
      
    }
/*
    public void Lluvia()
    {
      Debug.Log("SE HA ACTIVADO LA LLUVIA");

       if (npcEliminar1.Length!=0)
        {
          //Destroy(npcEliminar);        
          //Debug.Log(npcEliminar1.Length);
          for (int i = 0; i < 0.5 * npcEliminar1.Length; i++)
          {
            //Aquí se requiere de un Delay para que no desaparezcan inmediatamente
            Destroy(npcEliminar1[i]);
          }
        }
    }

public void Huracan()
    {
      Debug.Log("SE HA ACTIVADO UN DESASTRE");

       if (npcEliminar2.Length!=0)
        {
          //Destroy(npcEliminar);        
          //Debug.Log(npcEliminar2.Length);
          for (int i = 0; i < 0.3 * npcEliminar2.Length; i++)
          {
            //Aquí se requiere de un Delay para que no desaparezcan inmediatamente
            Destroy(npcEliminar2[i]);
          }
        }
    }

*/

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAwalk : MonoBehaviour
{
    NavMeshAgent nma;
    public Animator anim;

    private float timer;
    private float timeGuard = 2.0f;

    public Transform[] wayPoint;

    private int nextWayPoint;

    //[SerializeField] GameObject target;

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        nma = GetComponent<NavMeshAgent>();
        //nma.SetDestination(target.transform.position);
        
    }

    void Update()
    {  

        if(timer < timeGuard)
        {   
            Guardia();
        }

        if(timer >= timeGuard)
        {   
            Patrulla();
        }
    }

    void Guardia()
    {
        timer = timer + 1 * Time.deltaTime;
        anim.SetBool("walk",false);
    }

    void Patrulla()
    {
        anim.SetBool("walk",true);

        nma.SetDestination(wayPoint[nextWayPoint].transform.position);
        Vector3 difPos = wayPoint[nextWayPoint].transform.position - this.transform.position;
        if (Mathf.Abs(difPos.x) < 1.5f && Mathf.Abs(difPos.z) < 1.5f)
        {
            timer = 0;
            if ( nextWayPoint < wayPoint.Length -1)
            {
                nextWayPoint = Random.Range(0,5);
                //Debug.Log(nextWayPoint);
            }

            else if (nextWayPoint == wayPoint.Length -1) 
            {
                nextWayPoint = Random.Range(0,5);
                //Debug.Log(nextWayPoint);
            }
        }
    }

}

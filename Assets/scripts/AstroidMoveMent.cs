using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMoveMent : MonoBehaviour
{
    // Start is called before the first frame update

    private float Speed;
    private bool Dirictionleft;


    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        if (Dirictionleft == true)
        {
            transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position += new Vector3((-Speed * Time.deltaTime) , 0, 0);
        }

    }

    public void SetSpeed(float min, float max)
    {
        Speed = Random.Range(min, max);
    }

    public void SetDirection( bool directionleft)
    {

        Dirictionleft = directionleft;

    }
}

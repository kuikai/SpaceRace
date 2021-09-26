using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstairtAsteroid : MonoBehaviour
{

    public GameObject[] Astroid;
    private IEnumerator coroitineInstaietAstroids;

    public float min, max;



    public bool DirectionLeft;
    // Start is called before the first frame update
    void Start()
    {
        coroitineInstaietAstroids = GreatAstroids();
        
        StartCoroutine(GreatAstroids());
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RandomInstaiet()
    {
        
        int AstroidNumber = (int)Random.Range(0, Astroid.Length);

       GameObject astoid = Instantiate(Astroid[AstroidNumber], transform.position + new Vector3(0 ,Random.Range(-3,5),0), Quaternion.identity);

       astoid.GetComponent<AstroidMoveMent>().SetDirection(DirectionLeft);

        astoid.GetComponent<AstroidMoveMent>().SetSpeed(min,max);

    }

    private IEnumerator GreatAstroids()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0,2));

            RandomInstaiet();

        }
    }
}

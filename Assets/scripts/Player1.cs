using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;

    float diectionY;

    private Vector3 StartPos;

    public GameObject Explotion;

    private bool astoidHittingPlay;

    float screenHafeHigtInworuldUnits;

    public event System.Action OnAddpointToplayer; 

    void Start()
    {
        screenHafeHigtInworuldUnits = Camera.main.orthographicSize; 
        astoidHittingPlay = false;
        StartPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Movement();


        if(transform.position.y > screenHafeHigtInworuldUnits){

            OnAddpointToplayer?.Invoke();
            transform.position = new Vector2(transform.position.x,-screenHafeHigtInworuldUnits);
            
        }

        
        if(transform.position.y < -screenHafeHigtInworuldUnits){

            transform.position = new Vector2(transform.position.x,-screenHafeHigtInworuldUnits);
        }
       // var pos = transform.position;
       // pos.y = Mathf.Clamp(transform.position.y, -10 ,1f);
       // transform.position = pos;
    
    }

    public void Movement()
    {
        if (astoidHittingPlay == false)
        {
            float direction = Input.GetAxisRaw("Player1");

            float velocity = direction * speed;
           // transform.position += new Vector3(0, direction * Time.deltaTime, 0);
            transform.Translate(Vector2.up * velocity* Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(PlayerHitastoid());
    }
  
    IEnumerator PlayerHitastoid()
    {

        astoidHittingPlay = true;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<PolygonCollider2D>().enabled = false;
        Instantiate(Explotion,transform.position,Quaternion.identity);
        yield return new WaitForSeconds(2);

        transform.position = StartPos;
        astoidHittingPlay = false;
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<PolygonCollider2D>().enabled = true;

    }
}

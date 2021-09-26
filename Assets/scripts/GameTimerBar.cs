using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTimerBar : MonoBehaviour
{

    public event System.Action OnGameOver;
    private Slider slider;
    public int GameTime =2;   
    void Start()
    {
       slider = gameObject.GetComponent<Slider>();

       slider.maxValue = GameTime;
            
    
    }

    // Update is called once per frame
    void Update()
    {

        float time = GameTime -Time.timeSinceLevelLoad;

        slider.value = time;
        
        if(slider.value == 0){
           OnGameOver?.Invoke();
        }
    }

}


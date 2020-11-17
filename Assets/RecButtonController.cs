using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class RecButtonController : MonoBehaviour
{
    public float timer;
    private Color baseColor;
    private Color darkColor;
    public static bool pressed;
    // Start is called before the first frame update
    void Awake()
    {
        pressed = false;
        baseColor = this.GetComponent<Image>().color;
        darkColor = baseColor - new Color(0.2f, 0.2f, 0.2f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Logo of rec blinks when pressed
        if (pressed)
        {
            timer = timer + Time.deltaTime;
            if (timer % 1 > 0.5)
            {
                this.GetComponent<Image>().color = baseColor - new Color(0.2f, 0.2f, 0.2f, 0f);
            }
            else
            {
                this.GetComponent<Image>().color = baseColor;
            }
        }
        
    

}
}

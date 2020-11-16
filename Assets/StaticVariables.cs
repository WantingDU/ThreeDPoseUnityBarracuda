
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StaticVariables : MonoBehaviour
{
    // Start is called before the first frame update
    public static string VideoPath { get; set; }
    public static Text debugger;
    private void Awake()
    {
        if (GameObject.Find("Debugger"))
        debugger = GameObject.Find("Debugger").GetComponent<Text>();
    }
    public  void return2UI()
    {
        SceneManager.LoadScene(0);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    public Text killText;
    public float killCount;

    // Start is called before the first frame update
    void Start()
    {
        killCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        killText.text = "KILLS = " + killCount;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Animator cameraAnim;
    public float time = 1;

    public Animator title;
    public Animator play;

    bool isClicked = false;

    private void Start()
    {
        cameraAnim.SetBool("play", false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isClicked == false )
        {
            isClicked = true;
            StartCoroutine(setCam());
        }
    }

    IEnumerator setCam()
    {
        play.SetTrigger("trigger");
        title.SetTrigger("trigger");
        cameraAnim.SetBool("play", true);
        yield return new WaitForSeconds(time);
        Play();
    }

    public void Play()
    {
        SceneManager.LoadScene("CrazyTaxi");
    }
}

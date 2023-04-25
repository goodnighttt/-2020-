using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject option;
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            option.SetActive(true);
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ThirdPerson>().enabled = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player_C>().enabled = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
            Time.timeScale = 0f;
        }
    }

    public void Oncontinue()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ThirdPerson>().enabled = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player_C>().enabled = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
        Time.timeScale = 1f;
    }
    public void Onexit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}

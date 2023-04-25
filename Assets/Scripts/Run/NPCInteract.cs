using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NPCInteract : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI Dialogue;
    public GameObject TalkPlane;
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private PlayerMovement playerMovement;

    private bool isinteractable = false;
    private string[] Events;
    private int index;
    void Start()
    {
        index = 0;
        Events = new string[] { "嘿,你是新来的吧.欢迎你来到这片大陆,试着种地看看吧!等你收获到2000金币再回来找我!", "很好,你做的很不错.也许你注意到了,这座岛上有一些不是那么有好的史莱姆.....击杀他们可以获得必要的金币", "你想要一只小狗吗" };
        TalkPlane.SetActive(false);
    }

    public void SetIndex(int a)
    {
        index = a;
    }

    public void Interact()
    {
        Hide();
        TalkPlane.SetActive(true);
        Dialogue.text = Events[index];
        
        //index++;
        //Debug.Log("交互");
    }
    // Update is called once per frame
    private void Show()
    {
        containerGameObject.SetActive(true);
    }

    private void Hide()
    {
        containerGameObject.SetActive(false);

    }
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.GetInteractbleObject() != null)
        {
            //Debug.Log("交互");
            Show();


            //与NPC进行交互
            if (Input.GetKeyDown(KeyCode.E))
            {
                Interact();
                isinteractable = true;
            }

            if (Input.GetKeyDown(KeyCode.Y) && isinteractable == true)
            {
                //Debug.Log("商店");
                TalkPlane.SetActive(false);
                //Hide();
                //UIManager.Instance.ShowCreatePanel();
                //GameObject.Find("Slime_01").GetComponent<NPCInteract>().enabled = false;
                //GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ThirdPerson>().enabled = false;
                //GameObject.FindGameObjectWithTag("Player").GetComponent<Player_C>().enabled = false;
                //GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = false;


                //Time.timeScale = 0f;
                Hide();
                //GameObject.Find("Slime_01").GetComponent<NPCInteract>().enabled = false;
            }

            if (Input.GetKeyDown(KeyCode.N) && isinteractable == true)
            {
                TalkPlane.SetActive(false);
            }
        }
        else
        {
            Hide();
            TalkPlane.SetActive(false);

            //isinteractable = false;
        }




    }
}

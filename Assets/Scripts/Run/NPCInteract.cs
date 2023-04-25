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
        Events = new string[] { "��,���������İ�.��ӭ��������Ƭ��½,�����ֵؿ�����!�����ջ�2000����ٻ�������!", "�ܺ�,�����ĺܲ���.Ҳ����ע�⵽��,����������һЩ������ô�кõ�ʷ��ķ.....��ɱ���ǿ��Ի�ñ�Ҫ�Ľ��", "����ҪһֻС����" };
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
        //Debug.Log("����");
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
            //Debug.Log("����");
            Show();


            //��NPC���н���
            if (Input.GetKeyDown(KeyCode.E))
            {
                Interact();
                isinteractable = true;
            }

            if (Input.GetKeyDown(KeyCode.Y) && isinteractable == true)
            {
                //Debug.Log("�̵�");
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

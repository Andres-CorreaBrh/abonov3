using UnityEngine;
using UnityEngine.UI;
using static SimulationObject;
using System.Reflection;
using System.Runtime.InteropServices;
using TMPro;

public class DialogueViewer : MonoBehaviour
{
    [SerializeField] public Transform parentOfResponses;
    [SerializeField] public Button prefab_btnResponse;
    [SerializeField] public TextMeshProUGUI txtNodeDisplay;
    public SimulationController controller;

    public bool audioActivation = false;


    [DllImport("__Internal")]
    private static extern void openPage(string url);

    Animator anim;

    private void Awake()
    {
        controller.onEnteredNode += OnNodeEnteredDV;
        //controller.InitializeDialogue();
        SetNormalState();

        // Start the dialogue
        var curNode = controller.GetCurrentNode();
        anim = GetComponent<Animator>();
    }

    public void SetNormalState()
    {
        gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Vector4(0f, 0.2438478f, 0.5f, 0.7803922f);
    }

    public void WrongAnswer()
    {
        gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Vector4(1f, 0f, 0f, 0.7803922f);
        SoundManager.PlaySound("wrongAnswer");
    }

    public void OpenDialogue()
    {
        anim.SetBool("open", true);
    }

    public void CloseDialogue()
    {
        anim.SetBool("close", true);
    }


    public static void KillAllChildren(UnityEngine.Transform parent)
    {
        UnityEngine.Assertions.Assert.IsNotNull(parent);
        for (int childIndex = parent.childCount - 1; childIndex >= 0; childIndex--)
        {
            UnityEngine.Object.DestroyImmediate(parent.GetChild(childIndex).gameObject);
        }
    }

    public async void OnNodeSelected(int indexChosen)
    {
        //Debug.Log("Chose: " + indexChosen);
        MethodInfo taskObject = null;
        Node curNode = controller.GetCurrentNode();

        controller.ChooseResponse(indexChosen);

        foreach (var action in controller.GetCurrentNode().simulatorActions)
        {
            //print("Executing ... "+action.actionName+" - "+action.actionParams);
            GameObject objectF =  GameObject.Find(action.object2Action);
            taskObject = await objectF.GetComponent<ObjectController>().MethodAccess(action.actionName, action.actionParams);

            if (controller.GetCurrentNode().tags.Contains("end"))
            {
                controller.ChooseResponse(0);
            }
        }
    }

    private void OnNodeEnteredDV(Node newNode)
    {
        //Debug.Log("DLVIEWER - Entering node: " + newNode.title);
        txtNodeDisplay.text = newNode.text.Trim();

        //Debug.Log("TEXTO "+txtNodeDisplay.text);
        if(!gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color.Equals(new Vector4(1f, 1f, 1f, 0.7803922f)))
        {
            SetNormalState();
        }

        KillAllChildren(parentOfResponses);
        
        if (newNode.tags.Contains("end"))
        {
            gameObject.GetComponent<Animator>().SetTrigger("close");
            //RadioController.ColgarLlamada(false);
            audioActivation=false;
        }
        else
        {
            for (int i = newNode.responses.Count - 1; i >= 0; i--)
            {
                if(newNode.tags.Contains("dialogue"))
                {
                    int currentChoiceIndex = i;
                    var response = newNode.responses[i];
                    var responceButton = Instantiate(prefab_btnResponse, parentOfResponses);
                    responceButton.GetComponentInChildren<TextMeshProUGUI>().text = response.displayText.Trim();
                    responceButton.onClick.AddListener(delegate { OnNodeSelected(currentChoiceIndex); });
                }
            }
        }
    }
}
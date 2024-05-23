using UnityEngine;
using DialogueEditor;

public class convi : MonoBehaviour
{
    [SerializeField] private NPCConversation myConvesation;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown((KeyCode.E)))
            {
                ConversationManager.Instance.StartConversation(myConvesation);
            }
        }
    }
}

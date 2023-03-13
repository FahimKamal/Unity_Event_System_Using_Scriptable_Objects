using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BotMessageBox : MonoBehaviour
{
    [FormerlySerializedAs("EventWithInt")] [FormerlySerializedAs("intEvent")] [SerializeField] private IntEvent eventWithInt;
    [SerializeField] private Text messageBox;

    private void OnEnable()
    {
        eventWithInt.OnEventRaised += OnEventRaised;
    }
    private void OnDisable()
    {
        eventWithInt.OnEventRaised -= OnEventRaised;
    }

    private void OnEventRaised(int id)
    {
        messageBox.text = "Player is collided with Tree id: " + id;
        StartCoroutine(ResetMessagebox());
    }

    private IEnumerator ResetMessagebox()
    {
        yield return new WaitForSeconds(3.3f);
        messageBox.text = "Message Box";
    }
}

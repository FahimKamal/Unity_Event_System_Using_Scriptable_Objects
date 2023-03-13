using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BotMessageBox : MonoBehaviour
{
    [FormerlySerializedAs("EventWithInt")] [FormerlySerializedAs("intEvent")] [SerializeField] private IntEvent eventWithInt;
    [SerializeField] private DictEvent _dictEvent;
    [SerializeField] private Text messageBox;

    private void OnEnable()
    {
        eventWithInt.OnEventRaised += OnEventRaised;
        if (_dictEvent != null)
        {
            _dictEvent.OnEventRaised += DamageTaken;
        }
        else
        {
            throw new System.Exception("No Reference set yet");
        }
    }

    private void DamageTaken(Dictionary<string, int> arg0)
    {
        messageBox.text += "\nDamage taken: " + arg0["Damage"];
        StartCoroutine(ResetMessagebox());
    }

    private void OnDisable()
    {
        eventWithInt.OnEventRaised -= OnEventRaised;
        if (_dictEvent != null)
        {
            _dictEvent.OnEventRaised -= DamageTaken;
        }
        else
        {
            throw new System.Exception("No Reference set yet");
        }
    }

    private void OnEventRaised(int id)
    {
        messageBox.text += "\nPlayer is collided with Tree id: " + id;
        StartCoroutine(ResetMessagebox());
    }

    private IEnumerator ResetMessagebox()
    {
        yield return new WaitForSeconds(3.3f);
        messageBox.text = "Message Box";
    }
}

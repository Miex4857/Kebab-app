using UnityEngine;
using TMPro;
public class Add : MonoBehaviour
{
    public int Value;

    public void ChangeValue()
    {
        MathManager.Instance.ChangeValue(Value);
    }
}

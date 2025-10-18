using UnityEngine;

public class ChangeMenu : MonoBehaviour
{
    public GameObject menu;
    public void OnClick()
    {
        MenuManager.instance.ChangeMenu(menu);
    }
}

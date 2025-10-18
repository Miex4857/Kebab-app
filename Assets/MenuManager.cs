using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private GameObject _currentMenu;
    public static MenuManager instance;
    public GameObject StartMenu;

    private void Awake()
    {
        if (instance == null)

        {
            instance = this;
        }
        else 
        { 
            Destroy(gameObject);
        }

        if (StartMenu != null) 
        {
          ChangeMenu(StartMenu);  
        }
    }

    public void ChangeMenu(GameObject menu)
    {
        if (_currentMenu != null)
        {
            _currentMenu.SetActive(false);
        }    

        menu.SetActive(true);
        _currentMenu = menu;
    }

}

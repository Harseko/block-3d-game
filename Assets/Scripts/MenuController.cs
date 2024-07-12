using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] public GameObject mainMenu;
    [SerializeField] public GameObject selectLevel;

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        selectLevel.SetActive(false);
    }

    public void ShowSelectLevel()
    {
        mainMenu.SetActive(false);
        selectLevel.SetActive(true);
    }
}

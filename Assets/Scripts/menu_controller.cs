using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_controller : MonoBehaviour
{
    public GameObject setting_panel;
    public GameObject main_menu;
    public GameObject episode_Selection;

    public void openSettingPanel()
    {
        if(setting_panel != null)
        {
            setting_panel.SetActive(true);
            main_menu.SetActive(false);
        }
    }

    public void closeSettingPanel()
    {
        if(main_menu != null)
        {
            setting_panel.SetActive(false);
            main_menu.SetActive(true);
        }
    }

    public void openLevelEpisodeSelection()
    {
        if (main_menu != null)
        {
            main_menu.SetActive(false);
            setting_panel.SetActive(false);
            episode_Selection.SetActive(true);
        }
    }

    public void cancel()
    {
        episode_Selection.SetActive(false);
        main_menu.SetActive(true);
        setting_panel.SetActive(false);
    }
}

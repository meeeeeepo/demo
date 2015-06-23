﻿using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scenes.MapLevelAssets.Scripts
{
    /// <summary> Controller for editor main menu. </summary>
    public class EditorMenuController : MonoBehaviour
    {
        public GameObject MainMenuContainer;
        public GameObject SubMenuContainer;

        #region Main container

        public Button AddButton;
        public Button DeleteButton;
        public Button EditButton;

        #endregion

        #region Sub container

        public Button BackButton;
        public Button BuildingButton;
        public Button RoadButton;
        public Button TreeButton;
        public Button BarrierButton;

        #endregion

        // Use this for initialization
        void Start () {
	
        }
	
        // Update is called once per frame
        void Update () {
	
        }

        public void ShowSubMenu()
        {
            MainMenuContainer.SetActive(false);
            SubMenuContainer.SetActive(true);
        }

        public void ShowMainMenu()
        {
            MainMenuContainer.SetActive(true);
            SubMenuContainer.SetActive(false);
        }
    }
}

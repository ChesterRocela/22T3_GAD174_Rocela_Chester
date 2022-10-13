using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private GameObject ResumePanel;
        [SerializeField] private GameObject creditsPanel;
        [SerializeField] private GameObject MainMenuPanel;

        public void MainMenu()
        {
            Debug.Log("MainMenu button Activated");

            MainMenuPanel.SetActive(true);
            ResumePanel.SetActive(false);
            creditsPanel.SetActive(false);

        }
        public void Backbuttonclick()
        {
            Debug.Log("Back Button Activated!");

            ResumePanel.SetActive(true);
            creditsPanel.SetActive(false);
            MainMenuPanel.SetActive(false);
        }

        public void CreditsButtonClick()
        {
            Debug.Log("Credits Button Activated!");

            ResumePanel.SetActive(false);
            creditsPanel.SetActive(true);
            MainMenuPanel.SetActive(false);
        }

        public void QuitbuttonClick()
        {
            Debug.Log("Game is now Quitting");

            Application.Quit();
        }
    }
}

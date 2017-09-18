using UnityEngine;

public class PauseMenuButton : BaseButton
{
    public override void OnCursorEnter()
    {
        base.OnCursorEnter();

        PauseMenuManager.m_pauseMenuManager.SelectedButtonIndex = m_iParentListIndex;
        PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = false;
        PauseMenuManager.m_pauseMenuManager.SelectedButton = PauseMenuManager.m_pauseMenuManager.ActivePanelButtons[m_iParentListIndex];
        PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = true;
    }

    public override void OnClick(string a_strParameter)
    {
        base.OnClick(a_strParameter);

        switch (a_strParameter)
        {
            // Main panel start.
            case "MainPanelContinue":
                {
                    PauseMenuManager.m_pauseMenuManager.ActivePanelButtons = PauseMenuManager.m_pauseMenuManager.MainPanelButtons;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = false;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton = PauseMenuManager.m_pauseMenuManager.ActivePanelButtons[0];
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = true;
                    PauseMenuManager.m_pauseMenuManager.m_mainPanel.SetActive(true);
                    PauseMenuManager.m_pauseMenuManager.m_optionsPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_quitToMainMenuPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_quitToDesktopPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.ResetSelectedButtonIndex();
                    GameManager.m_gameManager.ContinueGame();
                    break;
                }

            case "MainPanelOptions":
                {
                    PauseMenuManager.m_pauseMenuManager.ActivePanelButtons = PauseMenuManager.m_pauseMenuManager.OptionsPanelbuttons;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = false;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton = PauseMenuManager.m_pauseMenuManager.ActivePanelButtons[0];
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = true;
                    PauseMenuManager.m_pauseMenuManager.m_mainPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_optionsPanel.SetActive(true);
                    PauseMenuManager.m_pauseMenuManager.m_quitToMainMenuPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_quitToDesktopPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.ResetSelectedButtonIndex();
                    break;
                }

            case "MainPanelQuitToMainMenu":
                {
                    PauseMenuManager.m_pauseMenuManager.ActivePanelButtons = PauseMenuManager.m_pauseMenuManager.QuitToMainMenuPanelButtons;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = false;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton = PauseMenuManager.m_pauseMenuManager.ActivePanelButtons[0];
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = true;
                    PauseMenuManager.m_pauseMenuManager.m_mainPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_optionsPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_quitToMainMenuPanel.SetActive(true);
                    PauseMenuManager.m_pauseMenuManager.m_quitToDesktopPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.ResetSelectedButtonIndex();
                    break;
                }

            case "MainPanelQuitToDesktop":
                {
                    PauseMenuManager.m_pauseMenuManager.ActivePanelButtons = PauseMenuManager.m_pauseMenuManager.QuitToDesktopPanelButtons;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = false;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton = PauseMenuManager.m_pauseMenuManager.ActivePanelButtons[0];
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = true;
                    PauseMenuManager.m_pauseMenuManager.m_mainPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_optionsPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_quitToMainMenuPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_quitToDesktopPanel.SetActive(true);
                    PauseMenuManager.m_pauseMenuManager.ResetSelectedButtonIndex();
                    break;
                }
            // Main panel end.

            // Options panel start
            case "OptionsPanelBack":
                {
                    PauseMenuManager.m_pauseMenuManager.ActivePanelButtons = PauseMenuManager.m_pauseMenuManager.MainPanelButtons;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = false;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton = PauseMenuManager.m_pauseMenuManager.ActivePanelButtons[0];
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = true;
                    PauseMenuManager.m_pauseMenuManager.m_mainPanel.SetActive(true);
                    PauseMenuManager.m_pauseMenuManager.m_optionsPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_quitToMainMenuPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_quitToDesktopPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.ResetSelectedButtonIndex();
                    break;
                }
            // Options panel end.

            // Quit to main menu panel start.
            case "QuitToMainMenuYes":
                {
                    GameManager.m_gameManager.LoadMainMenu();
                    break;
                }

            case "QuitToMainMenuNo":
                {
                    PauseMenuManager.m_pauseMenuManager.ActivePanelButtons = PauseMenuManager.m_pauseMenuManager.MainPanelButtons;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = false;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton = PauseMenuManager.m_pauseMenuManager.ActivePanelButtons[0];
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = true;
                    PauseMenuManager.m_pauseMenuManager.m_mainPanel.SetActive(true);
                    PauseMenuManager.m_pauseMenuManager.m_optionsPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_quitToMainMenuPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_quitToDesktopPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.ResetSelectedButtonIndex();
                    break;
                }
            // Quit to main menu panel end.

            // Quit to desktop panel start.
            case "QuitToDesktopYes":
                {
                    GameManager.m_gameManager.QuitToDesktop();
                    break;
                }

            case "QuitToDesktopNo":
                {
                    PauseMenuManager.m_pauseMenuManager.ActivePanelButtons = PauseMenuManager.m_pauseMenuManager.MainPanelButtons;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = false;
                    PauseMenuManager.m_pauseMenuManager.SelectedButton = PauseMenuManager.m_pauseMenuManager.ActivePanelButtons[0];
                    PauseMenuManager.m_pauseMenuManager.SelectedButton.IsMousedOver = true;
                    PauseMenuManager.m_pauseMenuManager.m_mainPanel.SetActive(true);
                    PauseMenuManager.m_pauseMenuManager.m_optionsPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_quitToMainMenuPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.m_quitToDesktopPanel.SetActive(false);
                    PauseMenuManager.m_pauseMenuManager.ResetSelectedButtonIndex();
                    break;
                }
            // Quit to desktop panel end.

            default:
                {
                    Debug.Log("Case for " + a_strParameter + "could not be found.");
                    break;
                }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public interface IGridSpace
{
    void SetGameControllerReference(GameController controller);
    void SetSpace();
}

public class GridSpace : MonoBehaviour, IGridSpace
{
    public Button button;
    public TMP_Text buttonText;

    private GameController gameController;

    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }

    public void SetSpace()
    {
        buttonText.text = gameController.GetPlayerSide();
        button.interactable = false;
        gameController.EndTurn();
    }
}
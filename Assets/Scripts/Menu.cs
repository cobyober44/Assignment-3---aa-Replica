using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public InputField playerName;
    public Text nameText;
    public static string myName = "You";

    public static float rotatorSpeed = 100f;
    public Text rotatorSpeedText;
    public Slider RotatorSpeedSlider;

    public static float pinSpeed = 50f;
    public Text pinSpeedText;
    public Slider PinSpeedSlider;

    public Dropdown ColorDropdown;
    public Text ColorText;
    public GameObject Rotator;
    public static int rotatorColor = 0;
    private int colorChange;


    public void pinSlider()
    {
        pinSpeedText.text = PinSpeedSlider.value.ToString();
        pinSpeed = PinSpeedSlider.value;
    }

    public void rotatorSlider()
    {
        rotatorSpeedText.text = RotatorSpeedSlider.value.ToString();
        rotatorSpeed = RotatorSpeedSlider.value;
    }

    private int resetLives = 5;

    public void StartGame()
    {
        SceneManager.LoadScene("MainLevel");
        GameManager.playerLivesPass = resetLives;
    }

    public void InputName()
    {
        myName = playerName.text.ToString();
        nameText.text = myName.ToUpper();
    }

    public void ChooseColor()
    {
        switch (ColorDropdown.value)
        {
            case 1:
                ColorText.text = ColorDropdown.options[1].text;
                colorChange = 1;
                rotatorColor = colorChange;
                break;
            case 2:
                ColorText.text = ColorDropdown.options[2].text;
                colorChange = 2;
                rotatorColor = colorChange;
                break;
            case 3:
                ColorText.text = ColorDropdown.options[3].text;
                colorChange = 3;
                rotatorColor = colorChange;
                break;
            default:
                ColorText.text = ColorDropdown.options[0].text;
                colorChange = 0;
                rotatorColor = colorChange;
                break;
        }
    }
}

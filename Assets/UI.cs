using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    #region singleton
    public static UI instance;

    private void Awake() {
        if(instance == null){
            instance = this;
        }
    }
    #endregion

    private Clickable clicked;
    [SerializeField] private Text title;
    [SerializeField] private Text desc;

    private void Start() {
        SetText("...", "...");
    }
    public void Click(Clickable newClicked){
        if(clicked != null){
            clicked.Deselect();
        }

        clicked = newClicked;
        SetText(clicked.title, clicked.desc);
    }
    private void SetText(string titleStr, string descStr){
        title.text = titleStr;
        string[] split = descStr.Split('#');

        string description = "";
        foreach(string para in split){
            description += para + "\n" + "\n";
        }

        desc.text = description;
    }
}

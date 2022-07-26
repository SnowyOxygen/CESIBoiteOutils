using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    private Animator animator;
    private UI ui;
    public bool selected = false;

    public string title;
    [TextArea(1, 6)] public string desc;
    private void Start() {
        animator = GetComponent<Animator>();
        ui = UI.instance;
    }
    private void OnMouseEnter() {
        if(!selected){
            animator.SetBool("hover", true);
        }
    }
    private void OnMouseExit() {
        animator.SetBool("hover", false);
    }
    private void OnMouseDown() {
        Select();
    }
    private void Select(){
        selected = true;
        animator.SetBool("hover", false);
        transform.localScale = new Vector3(1.4f, 1.4f, 1f);
        ui.Click(this);
    }
    public void Deselect(){
        transform.localScale = Vector3.one;
        selected = false;
    }
}

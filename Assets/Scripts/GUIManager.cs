using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour {
    public Button topButton;
    public Button bottomButton;
    public Button leftButton;
    public Button rightButton;

    void Start() { }

    private void Update()
    {
    }

    private void FixedUpdate()
    {
        foreach (var touch in Input.touches)
        {
            switch (touch.phase)
            {
                case TouchPhase.Began: break;
                case TouchPhase.Moved: break;
                case TouchPhase.Canceled: break;
                case TouchPhase.Ended: break;
                default: break;
            }

            var x = Camera.main.ScreenToWorldPoint((touch.position));
            Debug.Log(x);
            RaycastHit2D hit = Physics2D.Raycast(x, Vector2.zero);
            Debug.Log(hit);

            //Debug.Log(hit.collider.gameObject);
            //if (hit.collider.gameObject == topButton)
            //{
            //    Debug.Log("Touched topButton");
            //}
            //if (hit.collider.gameObject == bottomButton)
            //{
            //    Debug.Log("Touched bottomButton");
            //}
            //if (hit.collider.gameObject == leftButton)
            //{
            //    Debug.Log("Touched leftButton");
            //}
            //if (hit.collider.gameObject == rightButton)
            //{
            //    Debug.Log("Touched rightButton");
            //}


            //Ray ray = Camera.main.ScreenPointToRay(touch.position);
            //RaycastHit hit;
            //if (Physics.Raycast(ray, out hit, 100))
            //{
            //    Debug.Log("Hit" + hit);
            //    if (hit.collider.gameObject == topButton)
            //    {
            //        Debug.Log("Touched topButton");
            //    }
            //    if (hit.collider.gameObject == bottomButton)
            //    {
            //        Debug.Log("Touched bottomButton");
            //    }
            //    if (hit.collider.gameObject == leftButton)
            //    {
            //        Debug.Log("Touched leftButton");
            //    }
            //    if (hit.collider.gameObject == rightButton)
            //    {
            //        Debug.Log("Touched rightButton");
            //    }
            //}
            }
        }

    void TaskOnTopClick()
    {

    }

    void TaskOnBottomClick() {

    }

    void TaskOnLeftClick() {

    }

    void TaskOnRightClick() {

    }
}

public class InputManager : MonoBehaviour {

    private int VerticalAxis = 0;
    private int HorizontalAxis = 0;

    public static InputManager Instance {
        get;
        private set;
    }

    public void TopClick() {
        VerticalAxis = 1;
    }

    public void BottomClick() {
        VerticalAxis = -1;
    }

    public void VerticalAxisReset()
    {
        VerticalAxis = 0;
    }

    public void LeftClick() {

        HorizontalAxis = 1;
    }

    public void RightClick() {
        HorizontalAxis = -1;
    }

    public void HorizontalAxisReset()
    {
        HorizontalAxis = 0;
    }
}
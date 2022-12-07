using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SwipeScreen : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public float number = 10f;
    Vector3 screenLocation;
    public float easing = 0.1f;

    public RectTransform screenPos;
    private Vector2 initialPos;
    private Vector2 finalPos;

    // LIMITS
    public int totalPages = 1;
    public int currentPage = 1;

    // Start is called before the first frame update
    void Start()
    {
        screenLocation = transform.position;
        screenPos = GetComponent<RectTransform>();

        initialPos = new Vector2(400,-711);
        finalPos = new Vector2(-6000, -711);
    }
    void Update()
    {
    }


    public void OnDrag(PointerEventData data)
    {
        float difference = data.pressPosition.x - data.position.x; ;       
        transform.position = screenLocation - new Vector3(difference, 0, 0);
    }

    public void OnEndDrag(PointerEventData data)
    {
        //screenLocation = transform.position;
        float percentage = (data.pressPosition.x - data.position.x)/Screen.width;
        if (Mathf.Abs(percentage) >= number)
        {
            Vector3 newLocation = screenLocation;
            if (percentage > 0 && currentPage < totalPages)
            {
                currentPage++;
                newLocation += new Vector3(-Screen.width,0,0);
            }
            else if (percentage < 0 && currentPage > 1)
            {
                currentPage--;
                newLocation += new Vector3(Screen.width, 0, 0);
            }

            StartCoroutine(SmoothMove(transform.position, newLocation, easing));
            screenLocation = newLocation;
        }
        else
        {
            StartCoroutine(SmoothMove(transform.position, screenLocation, easing));
        }
    }

    IEnumerator SmoothMove(Vector3 startPos, Vector3 endPos, float sec) // QUEDA LIMITAR EL MOVIMIENTO EN LA 1A Y LA ÚLTIMA IMAGEN
    {      
        float t = 0f;
        
        while (t <= 1.0f)
        {
            t += Time.deltaTime / sec;
            transform.position = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0f,1f,t));
            //yield return new WaitForSeconds(0.001f);
            yield return null;
        }
              
        yield return null;
    } 
}

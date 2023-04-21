using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeightMeasurement : MonoBehaviour
{
    public Transform rayOrigin1, rayOrigin2;
    public Transform CentralTarget;
    private Vector3 rayVec1, rayVec2;
    public float HeightFloat;
    public LayerMask mask; 

    private float step1, step2;

    public SkinnedMeshRenderer objectToMeassure;
    public MeshCollider skinnedCollider;

    public Animator anim;

    public TextMeshProUGUI heightCM;

    public TMP_InputField TMPheightInput;

    public bool animatePressed;

    public float heightInput;

    public GameObject playerParent;

    //public float measurementVal;
    public float scaleVal;
    void Update()
    {
        RayArray();
        rayDistances();
        float.TryParse(TMPheightInput.text, out heightInput);
        HeightRemap();
        displayMeasurement();
    }

    private void LateUpdate()
    {
        BakeSkinnedMesh();
        rescaleCollidertoMesh();
    }

    public void HeightRemap()
    {
        float measurementVal = Mathf.InverseLerp(148f, 208f, heightInput);
        scaleVal = Mathf.Lerp(-0.1685f, 0.1685f, measurementVal);

        playerParent.transform.localScale = new Vector3(1, 1 + scaleVal, 1);
    }

    public void rescaleCollidertoMesh()
    {
        playerParent.GetComponentInChildren<MeshCollider>().sharedMesh = objectToMeassure.sharedMesh;
        Mesh bakedmesh = new Mesh();
        objectToMeassure.BakeMesh(bakedmesh);
        skinnedCollider.sharedMesh = bakedmesh;
    }

    public void RayArray()
    {
        RaycastHit rayHit1;
        if (Physics.Raycast(rayOrigin1.position, (CentralTarget.position - rayOrigin1.position), out rayHit1, 200f, mask))
        {
            Debug.DrawRay(rayOrigin1.position, (CentralTarget.position - rayOrigin1.position), Color.red, 200f);
            rayVec1 = rayHit1.point;
        }

        RaycastHit rayHit2;
        if (Physics.Raycast(rayOrigin2.position, (CentralTarget.position - rayOrigin2.position), out rayHit2, 200f))
        {
            Debug.DrawRay(rayOrigin2.position, (CentralTarget.position - rayOrigin2.position), Color.red, 200f);
            rayVec2 = rayHit2.point;
        }
    }

    public void rayDistances()
    {
        RaycastHit oneTwo;
        Physics.Raycast(rayVec1, (rayVec2 - rayVec1), out oneTwo);

        step1 = Vector3.Distance(rayVec1, rayVec2);

        HeightFloat = (step1 + step2) * 100;


    }

    public void BakeSkinnedMesh()
    {
        Mesh bakedmesh = new Mesh();
        objectToMeassure.BakeMesh(bakedmesh);
        skinnedCollider.sharedMesh = bakedmesh;
    }

    public void displayMeasurement()
    {
        if (!animatePressed)
        {
            int heightInt = (int)HeightFloat;

            heightCM.text = "Height: " + heightInt + "cm";
        }
    }

    public void animateButton(Button animateButton)
    {

        if (!animatePressed)
        {
            animatePressed = true;
            anim.SetBool("animBool", true);
        }
        else if (animatePressed)
        {
            anim.SetBool("animBool", false);
            animatePressed = false;
        }
    }
}

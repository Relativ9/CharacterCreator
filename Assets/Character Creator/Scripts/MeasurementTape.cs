using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MeasurementTape : MonoBehaviour
{

    public Transform rayOrigin1, rayOrigin2, rayOrigin3, rayOrigin4, rayOrigin5, rayOrigin6, rayOrigin7, rayOrigin8;
    public Transform CentralTarget;
    private Vector3 rayVec1, rayVec2, rayVec3, rayVec4, rayVec5, rayVec6, rayVec7, rayVec8;
    public float waistCircumference;

    public bool animatePressed;

    private float step1, step2, step3, step4, step5, step6, step7, step8;

    public SkinnedMeshRenderer objectToMeassure;
    public MeshCollider skinnedCollider;

    public Animator anim;

    public TextMeshProUGUI waistCM;

    public float scaleVal;

    public GameObject playerParent;

    public float waistInput;

    public TMP_InputField TMPwaistInput;


    void Update()
    {


        //waistInput = float.Parse(TMPwaistInput.text);
    }

    private void LateUpdate()
    {
        BakeSkinnedMesh();
        rayDistances();
        displayMeasurement();
        RayArray();
    }

    public void RayArray()
    {
        RaycastHit rayHit1;
        if (Physics.Raycast(rayOrigin1.position, (CentralTarget.position - rayOrigin1.position), out rayHit1, 20f))
        {
            Debug.DrawRay(rayOrigin1.position, (CentralTarget.position - rayOrigin1.position), Color.red, 20f);
            rayVec1 = rayHit1.point;
        }

        RaycastHit rayHit2;
        if (Physics.Raycast(rayOrigin2.position, (CentralTarget.position - rayOrigin2.position), out rayHit2, 20f))
        {
            Debug.DrawRay(rayOrigin2.position, (CentralTarget.position - rayOrigin2.position), Color.red, 20f);
            rayVec2 = rayHit2.point;
        }

        RaycastHit rayHit3;
        if (Physics.Raycast(rayOrigin3.position, (CentralTarget.position - rayOrigin3.position), out rayHit3, 20f))
        {
            Debug.DrawRay(rayOrigin3.position, (CentralTarget.position - rayOrigin3.position), Color.red, 20f);
            rayVec3 = rayHit3.point;
        }

        RaycastHit rayHit4;
        if (Physics.Raycast(rayOrigin4.position, (CentralTarget.position - rayOrigin4.position), out rayHit4, 20f))
        {
            Debug.DrawRay(rayOrigin4.position, (CentralTarget.position - rayOrigin4.position), Color.red, 20f);
            rayVec4 = rayHit4.point;
        }

        RaycastHit rayHit5;
        if (Physics.Raycast(rayOrigin5.position, (CentralTarget.position - rayOrigin5.position), out rayHit5, 20f))
        {
            Debug.DrawRay(rayOrigin5.position, (CentralTarget.position - rayOrigin5.position), Color.red, 20f);
            rayVec5 = rayHit5.point;
        }

        RaycastHit rayHit6;
        if (Physics.Raycast(rayOrigin6.position, (CentralTarget.position - rayOrigin6.position), out rayHit6, 20f))
        {
            Debug.DrawRay(rayOrigin6.position, (CentralTarget.position - rayOrigin6.position), Color.red, 20f);
            rayVec6 = rayHit6.point;
        }

        RaycastHit rayHit7;
        if (Physics.Raycast(rayOrigin7.position, (CentralTarget.position - rayOrigin7.position), out rayHit7, 20f))
        {
            Debug.DrawRay(rayOrigin7.position, (CentralTarget.position - rayOrigin7.position), Color.red, 20f);
            rayVec7 = rayHit7.point;
        }

        RaycastHit rayHit8;
        if (Physics.Raycast(rayOrigin8.position, (CentralTarget.position - rayOrigin8.position), out rayHit8, 20f))
        {
            Debug.DrawRay(rayOrigin8.position, (CentralTarget.position - rayOrigin8.position), Color.red, 20f);
            rayVec8 = rayHit8.point;
        }
    }

    public void rayDistances()
    {
        RaycastHit oneTwo;
        Physics.Raycast(rayVec1, (rayVec2 - rayVec1), out oneTwo);

        RaycastHit twoThree;
        Physics.Raycast(rayVec2, (rayVec3 - rayVec2), out twoThree);

        RaycastHit threeFour;
        Physics.Raycast(rayVec3, (rayVec4 - rayVec3), out threeFour);

        RaycastHit fourFive;
        Physics.Raycast(rayVec4, (rayVec5 - rayVec4), out fourFive);

        RaycastHit fiveSix;
        Physics.Raycast(rayVec5, (rayVec6 - rayVec5), out fiveSix);

        RaycastHit sixSeven;
        Physics.Raycast(rayVec6, (rayVec7 - rayVec6), out sixSeven);

        RaycastHit sevenEight;
        Physics.Raycast(rayVec7, (rayVec8 - rayVec7), out sevenEight);

        RaycastHit eightOne;
        Physics.Raycast(rayVec8, (rayVec1 - rayVec8), out eightOne);

        step1 = Vector3.Distance(rayVec1, rayVec2);
        step2 = Vector3.Distance(rayVec2, rayVec3);
        step3 = Vector3.Distance(rayVec3, rayVec4);
        step4 = Vector3.Distance(rayVec4, rayVec5);
        step5 = Vector3.Distance(rayVec5, rayVec6);
        step6 = Vector3.Distance(rayVec6, rayVec7);
        step7 = Vector3.Distance(rayVec7, rayVec8);
        step8 = Vector3.Distance(rayVec8, rayVec1);

        waistCircumference = (step1 + step2 + step3 + step4 + step5 + step6 + step7 + step8) * 100;


    }

    public void BakeSkinnedMesh()
    {
        Mesh bakedmesh = new Mesh();
        objectToMeassure.BakeMesh(bakedmesh);
        skinnedCollider.sharedMesh = bakedmesh;
    }

    public void displayMeasurement()
    {
        if(!animatePressed)
        {
            int waistInt = (int)waistCircumference;

            waistCM.text = "Waist: " + waistInt + "cm";
        }
    }

    public void animateButton(Button animateButton)
    {

        if (!animatePressed)
        {
            animatePressed = true;
            anim.SetBool("animBool", true);
        } else if (animatePressed)
        {
            anim.SetBool("animBool", false);
            animatePressed = false;
        }
    }
}

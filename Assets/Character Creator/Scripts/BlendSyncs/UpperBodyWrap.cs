using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpperBodyWrap : MonoBehaviour
{

    public CharCustomization charCust;
    public List<Slider> sliderNames = new List<Slider>();
    private Slider relevantSlider;

    public SkinnedMeshRenderer upperBody;
    public SkinnedMeshRenderer baseMesh;

    private void Start()
    {
        upperBody = this.gameObject.GetComponent<SkinnedMeshRenderer>();
        charCust = FindObjectOfType<CharCustomization>();
    }

    void LateUpdate()
    {
            for (int i = 0; i < sliderNames.Count; i++)
            {
                if (sliderNames[i].name == "Body_BodyFat")
                {
                    relevantSlider = sliderNames[i];
                    relevantSlider.onValueChanged.AddListener(delegate { WrapBodyFat(); });
                }

                if (sliderNames[i].name == "Body_Muscle")
                {
                    relevantSlider = sliderNames[i];
                    relevantSlider.onValueChanged.AddListener(delegate { WrapMuscle(); });
                }

                if (sliderNames[i].name == "Body_Belly")
                {
                    relevantSlider = sliderNames[i];
                    relevantSlider.onValueChanged.AddListener(delegate { WrapBelly(); });
                }

                if (sliderNames[i].name == "Body_Chest")
                {
                    relevantSlider = sliderNames[i];
                    relevantSlider.onValueChanged.AddListener(delegate { WrapChestSize(); });
                }

                if (sliderNames[i].name == "Body_Breasts")
                {
                    relevantSlider = sliderNames[i];
                    relevantSlider.onValueChanged.AddListener(delegate { WrapBreasts(); });
                }

                if (sliderNames[i].name == "Body_Shoulders")
                {
                    relevantSlider = sliderNames[i];
                    relevantSlider.onValueChanged.AddListener(delegate { WrapShoulders(); });
                }

                if (sliderNames[i].name == "Body_Bellyflabs")
                {
                    relevantSlider = sliderNames[i];
                    relevantSlider.onValueChanged.AddListener(delegate { WrapBellyFlabs(); });
                }

                if (sliderNames[i].name == null)
                {
                    relevantSlider = sliderNames[0];
                }
        }
    }

    public void WrapBodyFat()
    {

            upperBody.SetBlendShapeWeight(upperBody.sharedMesh.GetBlendShapeIndex("UpperBody_BodyFat Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Base_Bodyfat Max")));
            upperBody.SetBlendShapeWeight(upperBody.sharedMesh.GetBlendShapeIndex("UpperBody_BodyFat Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Base_Bodyfat Min")));
    }

    public void WrapMuscle()
    {
        upperBody.SetBlendShapeWeight(upperBody.sharedMesh.GetBlendShapeIndex("UpperBody_Muscles Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Base_Muscle Max")));
    }

    public void WrapShoulders()
    {
        upperBody.SetBlendShapeWeight(upperBody.sharedMesh.GetBlendShapeIndex("UpperBody_Shoulders Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Base_Shoulders Max")));
        upperBody.SetBlendShapeWeight(upperBody.sharedMesh.GetBlendShapeIndex("UpperBody_Shoulders Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Base_Shoulders Min")));
    }

    public void WrapBellyFlabs()
    {
        upperBody.SetBlendShapeWeight(upperBody.sharedMesh.GetBlendShapeIndex("UpperBody_BellyFlabs Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Base_BellyFlabs Max")));
    }

    public void WrapBreasts()
    {
        upperBody.SetBlendShapeWeight(upperBody.sharedMesh.GetBlendShapeIndex("UpperBody_Breasts Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Base_Breasts Max")));
    }

    public void WrapChestSize()
    {
        upperBody.SetBlendShapeWeight(upperBody.sharedMesh.GetBlendShapeIndex("UpperBody_ChestSize Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Base_ChestSize Max")));
        upperBody.SetBlendShapeWeight(upperBody.sharedMesh.GetBlendShapeIndex("UpperBody_ChestSize Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Base_ChestSize Min")));
    }

    public void WrapBelly()
    {
        upperBody.SetBlendShapeWeight(upperBody.sharedMesh.GetBlendShapeIndex("UpperBody_Belly Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Base_Belly Max")));
        upperBody.SetBlendShapeWeight(upperBody.sharedMesh.GetBlendShapeIndex("UpperBody_Belly Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Base_Belly Min")));
    }
}

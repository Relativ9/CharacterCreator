using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeRightSkinWrap : MonoBehaviour
{
    public SkinnedMeshRenderer rightEye;
    public SkinnedMeshRenderer baseMesh;
    public CharCustomization charCust;

    public List<Slider> sliderNames = new List<Slider>();
    private Slider relevantSlider;

    // Start is called before the first frame update
    void Start()
    {
        rightEye = this.gameObject.GetComponent<SkinnedMeshRenderer>();
        charCust = FindObjectOfType<CharCustomization>();

    }

    // Update is called once per frame

    void LateUpdate()
    {

        for (int i = 0; i < sliderNames.Count; i++)
        {
            if (sliderNames[i].name == "Cheek_Depth")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapCheekDepth(); });
            }

            if (sliderNames[i].name == "Eyes_Depth")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WarpEyesDepth(); });
            }

            if (sliderNames[i].name == "Eyes_Height")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WarpEyesHeight(); });
            }

            if (sliderNames[i].name == "Eyes_Rotated")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WarpEyesRotated(); });
            }

            if (sliderNames[i].name == "Eyes_Width")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WarpEyesWidth(); });
            }

            if (sliderNames[i].name == "Neck_Height")
            {
                relevantSlider = sliderNames[i];
                relevantSlider.onValueChanged.AddListener(delegate { WrapNeckHeight(); });
            }


            if (sliderNames[i].name == null)
            {
                relevantSlider = sliderNames[0];
            }
        }
    }

    public void WrapCheekDepth()
    {
        rightEye.SetBlendShapeWeight(rightEye.sharedMesh.GetBlendShapeIndex("RightEyeWrap_CheekDepth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Cheek_Depth Max")));
        rightEye.SetBlendShapeWeight(rightEye.sharedMesh.GetBlendShapeIndex("RightEyeWrap_CheekDepth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Cheek_Depth Min")));

    }
    public void WarpEyesDepth()
    {
        rightEye.SetBlendShapeWeight(rightEye.sharedMesh.GetBlendShapeIndex("RightEyeWrap_EyeDepth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Depth Max")));
        rightEye.SetBlendShapeWeight(rightEye.sharedMesh.GetBlendShapeIndex("RightEyeWrap_EyeDepth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Depth Min")));
    }

    public void WarpEyesHeight()
    {
        rightEye.SetBlendShapeWeight(rightEye.sharedMesh.GetBlendShapeIndex("RightEyeWrap_EyeHeight Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Height Max")));
        rightEye.SetBlendShapeWeight(rightEye.sharedMesh.GetBlendShapeIndex("RightEyeWrap_EyeHeight Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Height Min")));
    }

    public void WarpEyesRotated()
    {
        rightEye.SetBlendShapeWeight(rightEye.sharedMesh.GetBlendShapeIndex("RightEyeWrap_EyeRotation Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Rotated Max")));
        rightEye.SetBlendShapeWeight(rightEye.sharedMesh.GetBlendShapeIndex("RightEyeWrap_EyeRotation Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Rotated Min")));
    }

    public void WarpEyesWidth()
    {
        rightEye.SetBlendShapeWeight(rightEye.sharedMesh.GetBlendShapeIndex("RightEyeWrap_EyeWidth Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Wide Max")));
        rightEye.SetBlendShapeWeight(rightEye.sharedMesh.GetBlendShapeIndex("RightEyeWrap_EyeWidth Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Eyes_Wide Min")));
    }

    public void WrapNeckHeight()
    {
        rightEye.SetBlendShapeWeight(rightEye.sharedMesh.GetBlendShapeIndex("RightEyeWrap_NeckHeight Max"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Neck_Height Max")));
        rightEye.SetBlendShapeWeight(rightEye.sharedMesh.GetBlendShapeIndex("RightEyeWrap_NeckHeight Min"), baseMesh.GetBlendShapeWeight(baseMesh.sharedMesh.GetBlendShapeIndex("Neck_Height Min")));
    }
}

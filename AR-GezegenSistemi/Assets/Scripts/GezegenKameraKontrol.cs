using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GezegenKameraKontrol : MonoBehaviour
{
    private Animator marsAnimasyon;
    private Animator marsgeriAnimasyon;
    private Animator venusAnimasyon;
    private Animator venusgeriAnimasyon;
    private Animator dunyaAnimasyon;
    private Animator dunyageriAnimasyon;
    private Animator merkurAnimasyon;
    private Animator merkurgeriAnimasyon;
    private Animator jupiterAnimasyon;
    private Animator jupitergeriAnimasyon;
    private Animator saturnAnimasyon;
    private Animator saturngeriAnimasyon;
    private Animator uranusAnimasyon;
    private Animator uranusgeriAnimasyon;
    private Animator neptunAnimasyon;
    private Animator neptungeriAnimasyon;
    private Animator gunesAnimasyon;
    private Animator gunesgeriAnimasyon;
    private Animator AyAnimasyon;

    public GameObject kamera;

    private void Start()
    {
        AyAnimasyon = kamera.GetComponent<Animator>();
        marsAnimasyon = kamera.GetComponent<Animator>();
        marsgeriAnimasyon = kamera.GetComponent<Animator>();
        venusAnimasyon = kamera.GetComponent<Animator>();
        venusgeriAnimasyon = kamera.GetComponent<Animator>();
        dunyaAnimasyon = kamera.GetComponent<Animator>();
        dunyageriAnimasyon = kamera.GetComponent<Animator>();
        merkurAnimasyon = kamera.GetComponent<Animator>();
        merkurgeriAnimasyon = kamera.GetComponent<Animator>();
        jupiterAnimasyon = kamera.GetComponent<Animator>();
        jupitergeriAnimasyon = kamera.GetComponent<Animator>();
        saturnAnimasyon = kamera.GetComponent<Animator>();
        saturngeriAnimasyon = kamera.GetComponent<Animator>();
        uranusAnimasyon = kamera.GetComponent<Animator>();
        uranusgeriAnimasyon = kamera.GetComponent<Animator>();
        neptunAnimasyon = kamera.GetComponent<Animator>();
        neptungeriAnimasyon = kamera.GetComponent<Animator>();
        gunesAnimasyon = kamera.GetComponent<Animator>();
        gunesgeriAnimasyon = kamera.GetComponent<Animator>();

    }

    public void Ay()
    {
        AyAnimasyon.Play("ay");
    }
    public void Marsileri()
    {
        marsAnimasyon.Play("mars");
    }
    public void Marsgeri()
    {
        marsgeriAnimasyon.Play("marsgeri");
    }
    public void Venusileri()
    {
        venusAnimasyon.Play("venus");
    }
    public void Venusgeri()
    {
        venusgeriAnimasyon.Play("venusgeri");
    }
    public void Dunyaileri()
    {
        dunyaAnimasyon.Play("dunya");
    }
    public void Dunyageri()
    {
        dunyageriAnimasyon.Play("dunyageri");
    }
    public void merkurileri()
    {
        merkurAnimasyon.Play("merkur");
    }
    public void merkurgeri()
    {
        merkurgeriAnimasyon.Play("merkurgeri");
    }
    public void jupiterileri()
    {
        jupiterAnimasyon.Play("jupiter");
    }
    public void jupitergeri()
    {
        jupitergeriAnimasyon.Play("jupitergeri");
    }
    public void satürnileri()
    {
        saturnAnimasyon.Play("satürn");
    }
    public void satürgeri()
    {
        saturngeriAnimasyon.Play("satürngeri");
    }
    public void uranüsileri()
    {
        uranusAnimasyon.Play("uranüs");
    }
    public void uranüsgeri()
    {
        uranusgeriAnimasyon.Play("uranüsgeri");
    }
    public void neptunileri()
    {
        neptunAnimasyon.Play("neptun");
    }
    public void neptungeri()
    {
        neptungeriAnimasyon.Play("neptungeri");
    }
    public void gunesileri()
    {
        gunesAnimasyon.Play("gunes");
    }
    public void gunesgeri()
    {
        gunesgeriAnimasyon.Play("gunesgeri");
    }






}

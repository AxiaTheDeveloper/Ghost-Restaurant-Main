using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private string nama;
    [SerializeField] private string tempat;
    private int koinDarah = 0;
    private int famePoint = 0;
    private int hargaKerakTelorAwal = 1;
    private int hargaKerakTelorAkhir;

    [SerializeField]private TextMeshProUGUI NilaiHarga, NilaiKoin, NilaiFP;
    [SerializeField]private TextMeshProUGUI Nama, hargaT, koinT, FPT;

    [SerializeField]private GameObject pegangan1,pegangan2,dropdown;

    
    // Start is called before the first frame update
    void Start()
    {
        pegangan1.gameObject.SetActive(true);
        pegangan2.gameObject.SetActive(false);
        dropdown.gameObject.SetActive(false);

        NilaiHarga.text = hargaKerakTelorAkhir.ToString();
        NilaiKoin.text = koinDarah.ToString();
        NilaiFP.text = famePoint.ToString();
        Nama.text = nama.ToString();
        hargaT.text = hargaKerakTelorAkhir.ToString();
        koinT.text = koinDarah.ToString();
        FPT.text = famePoint.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hargakeraktelor " + hargaKerakTelorAkhir);
        // Debug.Log(koinDarah);
        NilaiHarga.text = hargaKerakTelorAkhir.ToString();
        NilaiKoin.text = koinDarah.ToString();
        NilaiFP.text = famePoint.ToString();
        Nama.text = nama.ToString();
        hargaT.text = hargaKerakTelorAkhir.ToString();
        koinT.text = koinDarah.ToString();
        FPT.text = famePoint.ToString();
    }

    public void dropdownn(){
        Debug.Log("Clicked!!");
        pegangan1.gameObject.SetActive(false);
        dropdown.gameObject.SetActive(true);
        pegangan2.gameObject.SetActive(true);
    }

    public void tarikatas(){
        pegangan1.gameObject.SetActive(true);
        dropdown.gameObject.SetActive(false);
        pegangan2.gameObject.SetActive(false);
    }


    public int getKoin(){ //kalo org mo upgrade cek ini
        return koinDarah;
    }
    public void changeKoin(int koin){ //masukkin + - kalo mo pake
        koinDarah += koin;
    }
    



    public int getFP(){ //kalo org mo upgrade cek ini
        return famePoint;
    }
    public void changeFP(int poin){ //masukkin + - kalo mo pake
        famePoint += poin;
    }

    //Kalo player ga punya uang cukup utk upgrade
    public void notEnough(){
        //Ntr ada Canvas d sini yg blg not enough begitu.
    }
    public void sudahMaxUpgrade(){
        //Ntr ada Canvas d sini yg blg not enough begitu.
    }





    public int getHarga(){ //Kalo org mo beli kan cek ini
        return hargaKerakTelorAkhir;
    }
    public void changeHarga(int hargaKT){ //masukkin + - kalo mo pake
        hargaKerakTelorAkhir = hargaKerakTelorAwal + hargaKT;
    }
}

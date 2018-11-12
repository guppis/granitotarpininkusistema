namespace GranitoTarpininkuSistema
{
  internal class supildytiAtaskaita
  {
    private int apmokamaDienu;
    private int apmokamaNaktu;
    private string deklarantas;
    private int visoDienu;
    private int visoNaktu;

    public supildytiAtaskaita(string d, int vN, int vD, int aD, int aN)
    {
      deklarantas = d;
      visoNaktu = vN;
      visoDienu = vD;
      apmokamaDienu = aD;
      apmokamaNaktu = aN;
    }
  }
}
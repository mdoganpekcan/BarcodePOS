//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarkodluSatis
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urun
    {
        public int UrunId { get; set; }
        public string UrunBarkod { get; set; }
        public string UrunAdi { get; set; }
        public string UrunAciklama { get; set; }
        public string Urungrup { get; set; }
        public Nullable<double> UrunAlisFiyat { get; set; }
        public Nullable<double> UrunSatisFiyat { get; set; }
        public Nullable<int> UrunKDVOrani { get; set; }
        public Nullable<double> UrunKDVTutari { get; set; }
        public string UrunBirim { get; set; }
        public Nullable<double> UrunMiktar { get; set; }
        public Nullable<System.DateTime> UrunEklemeTarih { get; set; }
        public string Kullanici { get; set; }
        public Nullable<int> Onay { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi2.ViewModel
{
    public class OgrenciModel
    {

        public string ogrId { get; set; }
        public string ogrNo { get; set; }
        public string ogrAdsoyad { get; set; }
        public Nullable<int> ogrDogTarih { get; set; }
    }
}
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // PUBLİC - BU CLASSA DİĞER KATMANLARDA ULAŞABİLSİN DEMEKTİR.İNTERNAL - SADECE ENTİTİES ERİŞEBİLİR DEMEK YANİ DEFAULT U O DUR.
    public class Product:IEntity 
    {
        public int ProductId { get; set; }
        public int CatogoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssetsAPI.Model
{
    public class Book : LibraryAsset
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string DeweyIndex { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssetsAPI.Model
{
    public abstract class LibraryAsset
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Cost { get; set; }
        public string ImageUrl { get; set; }
        public int NumberOfCopies { get; set; }
        public int StatusId { get; set; }
        //public LibraryBranch Location { get; set; }
        public Status Status { get; set; }
    }
}

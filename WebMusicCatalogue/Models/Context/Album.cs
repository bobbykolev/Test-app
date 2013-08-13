//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMusicCatalogue.Models.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Album
    {
        public Album()
        {
            this.Songs = new HashSet<Song>();
            this.Genres = new HashSet<Genre>();
        }
    
        public int AlbumID { get; set; }
        public int ArtistID { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> ProducerID { get; set; }
        public string AlbumName { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }
}
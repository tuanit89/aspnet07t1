using System;

namespace Model.Entity
{
    [Serializable]
    public class Post
    {
       public int PostId { get; set; }
       public int UserId { get; set; }
       public string PostName { get; set; }
       public string Source { get; set; }
       public string YoutubeSrc { get; set; }
       public string PicSrc { get; set; }
       public DateTime TimeAdded { get; set; }
       public bool Active { get; set; }
       public bool FavoriteClick { get; set; }
       public int PostView { get; set; }
       public int UnfavoriteClick { get; set; }
       public bool PostType { get; set; }
    }
}

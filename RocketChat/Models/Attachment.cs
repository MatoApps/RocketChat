using System;
using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Attachment
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("title_link")]
        public string TitleLink { get; set; }

        [JsonProperty("title_link_download")]
        public bool? TitleLinkDownloadable { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("author_icon")]
        public string AuthorIcon { get; set; }

        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("ts")]
        public DateTime Timestamp { get; set; }

        protected bool Equals(Attachment other)
        {
            return string.Equals(Title, other.Title) && string.Equals(TitleLink, other.TitleLink) && TitleLinkDownloadable == other.TitleLinkDownloadable
                   && string.Equals(Text, other.Text) && string.Equals(ImageUrl, other.ImageUrl) && string.Equals(AuthorName, other.AuthorName)
                   && string.Equals(AuthorIcon, other.AuthorIcon) && string.Equals(ThumbUrl, other.ThumbUrl) && string.Equals(Color, other.Color)
                   && Timestamp.Equals(other.Timestamp);
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Attachment)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Title != null ? Title.GetHashCode() : 0;
                hashCode = hashCode * 397 ^ (TitleLink != null ? TitleLink.GetHashCode() : 0);
                hashCode = hashCode * 397 ^ TitleLinkDownloadable.GetHashCode();
                hashCode = hashCode * 397 ^ (Text != null ? Text.GetHashCode() : 0);
                hashCode = hashCode * 397 ^ (ImageUrl != null ? ImageUrl.GetHashCode() : 0);
                hashCode = hashCode * 397 ^ (AuthorName != null ? AuthorName.GetHashCode() : 0);
                hashCode = hashCode * 397 ^ (AuthorIcon != null ? AuthorIcon.GetHashCode() : 0);
                hashCode = hashCode * 397 ^ (ThumbUrl != null ? ThumbUrl.GetHashCode() : 0);
                hashCode = hashCode * 397 ^ (Color != null ? Color.GetHashCode() : 0);
                hashCode = hashCode * 397 ^ Timestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
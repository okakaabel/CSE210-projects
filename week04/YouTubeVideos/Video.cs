using System.Collections.Generic;

namespace YouTubeVideos
{
    class Video(string title, string author, int length)
    {
        private string _title = title;
        private string _author = author;
        private int _length = length;
        private List<Comment> _comments = new List<Comment>();

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public int GetLength()
        {
            return _length;
        }

        public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }
    }
}
